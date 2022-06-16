// Copyright (C) 2022 Brandon Hook
// 
// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.
// 
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
// 
// You should have received a copy of the GNU General Public License
// along with this program.  If not, see <http://www.gnu.org/licenses/>.

using SQLHelper_Civ.Extensions_Helpers;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Core;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Test.ORM;
using static SQLHelper_Civ.Extensions_Helpers.Classes;
using static SQLHelper_Civ.Globals.Globals;

namespace SQLHelper_Civ
{
    public partial class SQLHelper : Form
    {
        BaseDBContext _ActiveDB;
        BaseDBContext ActiveDB
        {
            get { return _ActiveDB; }
            set
            {
                if (value == null)
                    btnAdd.Enabled = btnDelete.Enabled = btnFindReferences.Enabled = false;
                else
                {
                    btnAdd.Enabled = btnDelete.Enabled = btnFindReferences.Enabled = (ActiveTable != null);
                    _ActiveDB = value;
                }
            }
        }
        ConfigurationDB Configuration;
        LocalizationDB Localization;
        GameplayDB GamePlay;

        TablePropertyHolder _ActiveTable;
        TablePropertyHolder ActiveTable
        {
            get { return _ActiveTable; }
            set
            {
                if (value == null)
                    btnAdd.Enabled = btnDelete.Enabled = btnFindReferences.Enabled = false;
                else
                {
                    btnAdd.Enabled = btnDelete.Enabled = btnFindReferences.Enabled = (ActiveDB != null);
                    _ActiveTable = value;
                }
            }
        }

        BindingList<object> FilteredList = new BindingList<object>();

        /// <summary>
        /// Represents a cache of loaded values for populating the SuggestAppend of local Table. Speeds up the process a tiny bit.
        /// </summary>
        Dictionary<string, List<object>> ActiveSuggestions = new Dictionary<string, List<object>>();

        Dictionary<BaseDBContext, List<TablePropertyHolder>> CachedProperties = new Dictionary<BaseDBContext, List<TablePropertyHolder>>();
        List<Tuple<DataGridViewCell, string>> InvalidCells = new List<Tuple<DataGridViewCell, string>>();

        public SQLHelper(GameplayDB gameplay, LocalizationDB local, ConfigurationDB configuration)
        {
            InitializeComponent();
            GamePlay = gameplay;
            Localization = local;
            Configuration = configuration;

            CachedProperties.Add(GamePlay, new List<TablePropertyHolder>());
            CachedProperties.Add(Localization, new List<TablePropertyHolder>());
            CachedProperties.Add(Configuration, new List<TablePropertyHolder>());
            scMainSplitter.Panel2Collapsed = true;


        }

        private void CbDBSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbDBSelector.SelectedIndex != -1)
            {
                if (cbDBSelector.Text.ToLower() == "configuration")
                    ActiveDB = Configuration;
                else if (cbDBSelector.Text.ToLower() == "localization")
                    ActiveDB = Localization;
                else if (cbDBSelector.Text.ToLower() == "gameplay")
                    ActiveDB = GamePlay;

                var tableNames = ActiveDB.TableNames.Select(u => u.Name).ToList();
                cbTableSelector.DataSource = tableNames;
                cbTableSelector.AutoCompleteCustomSource = new AutoCompleteStringCollection();
                cbTableSelector.AutoCompleteCustomSource.AddRange(tableNames.ToArray());
            }
        }

        private void CbTableSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbTableSelector.SelectedIndex != -1)
            {
                //foreach(TablePropertyHolder itemToReset in CachedProperties[ActiveDB])
                //{
                //    itemToReset.LoadedItems = null;
                //}
                LoadTable(cbTableSelector.Text, true);
            }
        }

        private void LoadTable(string tableName, bool loadIntoScreen = true, BaseDBContext overrideContext = null)
        {
            if (overrideContext == null)
                overrideContext = ActiveDB;

            if (loadIntoScreen)
            {
                ActiveSuggestions.Clear();

                //Disable these events to prevent multiple calls.
                dgvBaseSource.CellValidating -= DgvBaseSource_CellValidating;
                dgvBaseSource.RowsAdded -= SetRowNumbers;
                dgvBaseSource.RowsRemoved -= SetRowNumbers;
            }

            TablePropertyHolder tableToSelect = null;
            List<ForeignKeyHolder> fkAccessor = null;
            bool cacheNeedsUpdated = false;
            var tableInfo = overrideContext.TableNames.FirstOrDefault(u => u.Name == tableName);
            if (!CachedProperties[overrideContext].Select(u => u.Table).Contains(tableInfo))
            {
                tableToSelect = new TablePropertyHolder();
                tableToSelect.Context = overrideContext;
                tableToSelect.Table = tableInfo;
                CachedProperties[overrideContext].Add(tableToSelect);
                var allForeignKeys = Helpers.GetForeignKeys(overrideContext, tableToSelect.UnderlyingType);
                fkAccessor = allForeignKeys.ForeignKeys;
                //tableToSelect.InverseForeignKeys = Helpers.GetInverseForeignKeys(overrideContext, tableToSelect.UnderlyingType, fkAccessor);
                tableToSelect.InverseForeignKeys = allForeignKeys.InverseForeignKeys;
                cacheNeedsUpdated = true;
            }
            else
                tableToSelect = CachedProperties[overrideContext].FirstOrDefault(u => u.Table == tableInfo);

            if (loadIntoScreen)
            {
                ActiveTable = tableToSelect;

                dgvBaseSource.AutoGenerateColumns = false;
                dgvBaseSource.Columns.Clear();
            }

            if (tableToSelect.LoadedItems == null)
            {
                if (tableToSelect.UnderlyingType != typeof(Test.ORM.Localization.LocalizedText))
                    tableToSelect.LoadedItems = ((IEnumerable)overrideContext.GetPropertyValue(tableName)).OfType<object>().ToBindingList();
                else
                {
                    string language = Properties.Settings.Default.DefaultLanguage;
                    tableToSelect.LoadedItems = Localization.LocalizedText.Where(u => (language == Globals.Globals.All) ? true : u.Language == language).ToList().OfType<object>().ToBindingList();
                }
            }

            foreach (var prop in tableToSelect.UnderlyingType.GetProperties())
            {
                string pkFkTag = string.Empty;
                if (prop.IsPropertyPrimaryKey())
                {
                    if (cacheNeedsUpdated)
                        tableToSelect.PrimaryKeys.Add(prop);

                    pkFkTag = "PK";
                }

                if (cacheNeedsUpdated)
                {
                    var hasFK = fkAccessor.Where(u => u.LocalPropertyName == prop.Name);
                    foreach (var fk in hasFK)
                    {
                        ForeignKeyMapper mapper = new ForeignKeyMapper();
                        mapper.LocalProperty = prop;
                        mapper.LocalTable = tableToSelect;

                        mapper.ReferenceContextName = fk.ReferenceContextName;
                        mapper.ReferenceTableName = fk.ReferenceTableName;
                        mapper.ReferencePropertyName = fk.ReferencePropertyName;
                        mapper.LocalPropertyAccessorName = fk.LocalPropertyAccessorName;

                        tableToSelect.ForeignKeys.Add(mapper);
                        LoadForeignKeysIn(prop.Name);
                    }
                }
                bool isFKProp = tableToSelect.ForeignKeys.Any(u => u.LocalProperty == prop);

                if (isFKProp)
                    pkFkTag = string.IsNullOrEmpty(pkFkTag) ? "FK" : $"{pkFkTag}, FK";

                if (prop.IsPropertyRequired() || prop.IsPropertyPrimaryKey())
                {
                    if (cacheNeedsUpdated)
                        tableToSelect.RequiredItems.Add(prop);

                    //Primary Keys are required, so no point in putting label.
                    if (!pkFkTag.Contains("PK"))
                        pkFkTag = string.IsNullOrEmpty(pkFkTag) ? "R" : $"{pkFkTag}, R";
                }

                if (loadIntoScreen)
                {
                    dgvBaseSource.DataSource = null;

                    bool nullablePrimitive = Helpers.FindUnderylingNullableType(prop.PropertyType)?.IsPrimitive ?? false;
                    if (prop.PropertyType == typeof(string) || prop.PropertyType.IsPrimitive || nullablePrimitive)
                    {
                        string displayName = string.IsNullOrEmpty(pkFkTag) ? string.Empty : $" ({pkFkTag})";

                        int colIndex;

                        if (isFKProp && (Properties.Settings.Default.ReferenceSuggest || Properties.Settings.Default.ReferenceForce))
                        {
                            DataGridViewComboBoxColumn fkCol = new DataGridViewComboBoxColumn();
                            List<object> items = new List<object>();
                            foreach (var fkMapperProp in tableToSelect.ForeignKeys.Where(u => u.LocalProperty == prop))
                            {
                                var fkProp = fkMapperProp.ReferencedTable;

                                if (fkProp == null || !fkProp.ForeignKeys.Any() || fkProp.LoadedItems == null)
                                {
                                    LoadForeignKeysIn(prop.Name);
                                    fkProp = fkMapperProp.ReferencedTable;
                                }

                                if (fkProp.UnderlyingType != typeof(Test.ORM.Localization.LocalizedText))
                                    items.AddRange(fkProp.LoadedItems.Select(u => u.GetPropertyValue(fkMapperProp.ReferencePropertyName)).Where(u => u != null).Distinct().ToList());
                                else
                                {
                                    string language = Properties.Settings.Default.DefaultLanguage;
                                    items.AddRange(Localization.LocalizedText.Where(u => (language == Globals.Globals.All) ? true : u.Language == language).ToList().Select(u => u.GetPropertyValue(fkMapperProp.ReferencePropertyName)).Where(u => u != null).Distinct().ToList());
                                }
                            }
                            items.AddRange(tableToSelect.LoadedItems.Select(u => u.GetPropertyValue(prop.Name)).Where(u => u != null).Distinct().ToList());
                            items = items.Distinct().ToList();
                            items.Sort();
                            fkCol.Items.Add(string.Empty);
                            fkCol.Items.AddRange(items.ToArray());
                            fkCol.Name = prop.Name;
                            fkCol.HeaderText = prop.Name + displayName;
                            if (Properties.Settings.Default.ReferenceSuggest)
                                fkCol.DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing;
                            colIndex = dgvBaseSource.Columns.Add(fkCol);
                        }
                        else if (prop.PropertyType == typeof(bool)/* || prop.PropertyType == typeof(bool?)*/)
                        {
                            DataGridViewComboBoxColumn fkCol = new DataGridViewComboBoxColumn();
                            if (prop.PropertyType == typeof(bool?))
                                fkCol.Items.Add(string.Empty);
                            fkCol.Items.Add(true);
                            fkCol.Items.Add(false);
                            fkCol.Name = prop.Name;
                            fkCol.HeaderText = prop.Name + displayName;
                            colIndex = dgvBaseSource.Columns.Add(fkCol);
                        }
                        else
                        {
                            colIndex = dgvBaseSource.Columns.Add(prop.Name, prop.Name + displayName);
                        }

                        dgvBaseSource.Columns[colIndex].DataPropertyName = prop.Name;
                        dgvBaseSource.Columns[colIndex].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                        dgvBaseSource.Columns[colIndex].MinimumWidth = 100;
                    }
                }
            }

            if (loadIntoScreen)
            {
                dgvBaseSource.DataSource = tableToSelect.LoadedItems;
                dgvBaseSource.CellValidating += DgvBaseSource_CellValidating;
                InvalidCells.Clear();
                LoadReferencesToComboBoxes();
                SetRowNumbers(null, null);
                dgvBaseSource.RowsAdded += SetRowNumbers;
                dgvBaseSource.RowsRemoved += SetRowNumbers;
            }
        }

        private void SetRowNumbers(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvBaseSource.Rows)
            {
                row.HeaderCell.Value = (row.Index + 1).ToString();
            }
        }

        private void DgvBaseSource_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (ActiveTable != null && ActiveTable.UnderlyingType != null)
            {
                var instance = Activator.CreateInstance(ActiveTable.UnderlyingType);
                ActiveDB.Set(ActiveTable.UnderlyingType).Add(instance);
                ActiveTable.LoadedItems.Add(instance);

                foreach (var requiredItem in ActiveTable.RequiredItems)
                {
                    dgvBaseSource.CurrentCell = dgvBaseSource.Rows[dgvBaseSource.Rows.Count - 1].Cells[requiredItem.Name];
                }
                dgvBaseSource.CurrentCell = dgvBaseSource.Rows[dgvBaseSource.Rows.Count - 1].Cells[0];
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            List<string> dbLog = new List<string>();
            try
            {
                dbLog = ActiveDB.SaveChanges();
            }
            #region Exception Logging
            catch (DbEntityValidationException ex)
            {
                StringBuilder exceptionLog = new StringBuilder();
                exceptionLog.AppendLine("The program has enountered an error when attempting to save - Validation.");
                if (ex.Message.ToLower().Contains("validation"))
                {
                    foreach (var exMessage in ex.EntityValidationErrors)
                    {
                        exceptionLog.AppendLine("\t" + exMessage.Entry.Entity.GetType().Name);
                        exceptionLog.AppendLine("\tCurrent: " + exMessage.Entry.CurrentValues);
                        if (exMessage.Entry.State != EntityState.Added)
                            exceptionLog.AppendLine("\tOriginal: " + exMessage.Entry.OriginalValues);
                        foreach (var validationError in exMessage.ValidationErrors)
                        {
                            exceptionLog.AppendLine("\t\tMessage: " + validationError.ErrorMessage);
                            exceptionLog.AppendLine("\t\tName" + validationError.PropertyName);
                            exceptionLog.AppendLine();
                        }
                        exceptionLog.AppendLine();
                    }
                }

                using (var form = new frmOutputSQL(new List<StringBuilder>() { exceptionLog }))
                {
                    form.ShowDialog();
                }
            }
            catch (DataException ex)
            {
                StringBuilder exceptionLog = new StringBuilder();
                int failCount = 0;
                var activeException = ex.InnerException;
                while (activeException != null && activeException.Message.ToLower().Contains("inner exception") && failCount++ < 40)
                {
                    activeException = activeException.InnerException;
                }

                exceptionLog.AppendLine($"The program has enountered an error when attempting to save. - {ex.GetType()}");
                exceptionLog.AppendLine("\t" + activeException.Message);
                if (ex is UpdateException)
                {
                    foreach (var exObject in (ex as UpdateException).StateEntries)
                    {
                        exceptionLog.AppendLine("\t\t" + exObject.Entity.GetType().Name);
                        exceptionLog.AppendLine("\t\tCurrent: " + exObject.CurrentValues);
                        exceptionLog.AppendLine("\t\tOriginal: " + exObject.OriginalValues);
                    }
                }
                else if (ex is DbUpdateException)
                {
                    foreach (var exObject in (ex as DbUpdateException).Entries)
                    {
                        exceptionLog.AppendLine("\t\t" + exObject.Entity.GetType().Name);
                        exceptionLog.AppendLine("\t\tCurrent: " + exObject.CurrentValues);
                        exceptionLog.AppendLine("\t\tOriginal: " + exObject.OriginalValues);
                    }
                }

                using (var form = new frmOutputSQL(new List<StringBuilder>() { exceptionLog }))
                {
                    form.ShowDialog();
                }
            }
            #endregion Exception Logging

            if (dbLog.Any())
            {
                //We want to reverse the list to help with the parsing. Easier to replace "@123" before "@1". 
                dbLog.Reverse();

                List<StringBuilder> transactions = new List<StringBuilder>();
                bool inTransaction = false;
                List<Tuple<string, string>> replaceList = new List<Tuple<string, string>>();
                foreach (var line in dbLog)
                {
                    //Beginning of Transaction
                    if (inTransaction && (line.ToLower().StartsWith("update") || line.ToLower().StartsWith("insert") || line.ToLower().StartsWith("delete")))
                    {
                        string localLine = line;
                        if (line.ToLower().StartsWith("insert") && Properties.Settings.Default.InsertMethod != (int)InsertTypes.Insert)
                        {
                            switch ((InsertTypes)Properties.Settings.Default.InsertMethod)
                            {
                                case InsertTypes.InsertOrIgnore:
                                    localLine = line.ReplaceFirst("INSERT", "INSERT OR IGNORE");
                                    break;
                                case InsertTypes.InsertOrReplace:
                                default:
                                    localLine = line.ReplaceFirst("INSERT", "INSERT OR REPLACE");
                                    break;
                            }
                        }

                        StringBuilder transaction = new StringBuilder();
                        transaction.Append(localLine);

                        foreach (var toReplace in replaceList)
                        {
                            transaction.Replace(toReplace.Item1, toReplace.Item2);
                        }

                        transactions.Add(transaction);
                        inTransaction = false;
                    }
                    //Items to replace out in the transactions
                    else if (line.ToLower().StartsWith("-- @"))
                    {
                        if (!inTransaction)
                        {
                            inTransaction = true;
                            replaceList.Clear();
                        }

                        string variable = line.Substring(line.IndexOf('@'), line.IndexOf(':') - line.IndexOf('@'));
                        string value = line.Substring(line.IndexOf('\''), line.LastIndexOf('\'') - line.IndexOf('\'') + 1);
                        if (value == "\'False\'")
                            value = "\'0\'";
                        else if (value == "\'True\'")
                            value = "\'1\'";
                        var tupleItem = Tuple.Create(variable, value);
                        replaceList.Add(tupleItem);
                    }
                }

                //Reverse back as order actually will matter.
                transactions.Reverse();

                var dialog = new frmOutputSQL(transactions);
                dialog.Show();
                dialog = null;

                foreach (var t in CachedProperties)
                {
                    foreach (var b in t.Value)
                    {
                        b.LoadedItems = null;
                    }
                }

                CbTableSelector_SelectedIndexChanged(null, null);
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            foreach (var row in dgvBaseSource.SelectedRows)
            {
                var instance = row.DataBoundItem;
                ActiveDB.Set(ActiveTable.UnderlyingType).Remove(instance);
                ActiveTable.LoadedItems.Remove(instance);
                InvalidCells.RemoveAll(u => u.Item1.RowIndex == row.Index);
            }
            ValidateChanged();
        }

        private void DgvBaseSource_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (Properties.Settings.Default.ColumnSuggest || Properties.Settings.Default.ReferenceSuggest)
            {
                if (e.Control is TextBox && Properties.Settings.Default.ColumnSuggest)
                {
                    List<object> appendObjects = new List<object>();
                    string headerName = (dgvBaseSource.Columns[dgvBaseSource.CurrentCell.ColumnIndex].Name);
                    if (!ActiveSuggestions.TryGetValue(headerName, out appendObjects) || !appendObjects.Any())
                    {
                        appendObjects = new List<object>();
                        //If it is a PK (and it is the only one), then we don't suggest, as that would be getting in the way since it is required unique. 

                        if (ActiveTable.PrimaryKeys.Count > 1 || ActiveTable.PrimaryKeys.FirstOrDefault()?.Name != headerName)
                        {
                            var list = ActiveTable.LoadedItems.Select(u => u.GetPropertyValue(headerName)).Where(u => u != null);
                            appendObjects.AddRange(list);
                        }
                        //if (chkReferenceSuggest.Checked)
                        //{
                        //LoadForeignKeysIn(headerName);

                        //Come back to optimize this. Shouldn't be adding all PK, jus the PK is associates to. Although, most FK don't have a composite PK scenario, so low priority. -Z
                        //foreach (var fk in ActiveTable.Mapper.Where(u => u.LocalProperty.Name == headerName))
                        //{
                        //    foreach (var pkInFK in fk.ReferencedTable.PrimaryKeys)
                        //    {
                        //        appendObjects.AddRange(fk.ReferencedTable.LoadedItems.Select(u => u.GetPropertyValue(pkInFK.Name)).Where(u => u != null));
                        //    }
                        //}
                        //}

                        appendObjects.Distinct();
                        appendObjects.Sort();
                        if (ActiveSuggestions.ContainsKey(headerName))
                            ActiveSuggestions[headerName].AddRange(appendObjects);
                        else
                            ActiveSuggestions.Add(headerName, appendObjects);
                    }
                    var item = e.Control as TextBox;
                    item.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                    item.AutoCompleteSource = AutoCompleteSource.CustomSource;
                    item.AutoCompleteCustomSource = new AutoCompleteStringCollection();
                    item.AutoCompleteCustomSource.AddRange(appendObjects.Select(u => u.ToString()).ToArray());
                }
                else if (e.Control is ComboBox && Properties.Settings.Default.ReferenceSuggest)
                {
                    var item = e.Control as ComboBox;

                    item.DropDownStyle = ComboBoxStyle.DropDown;
                    item.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                }
            }
        }

        private void LoadForeignKeysIn(string prop)
        {
            foreach (var fkMapped in ActiveTable.ForeignKeys.Where(u => u.LocalProperty.Name == prop))
            {
                BaseDBContext overrideContext = ActiveDB;
                if (fkMapped.ReferenceContextName == Globals.Globals.LocalizationName)
                    overrideContext = Localization;
                else if (fkMapped.ReferenceContextName == Globals.Globals.GameplayName)
                    overrideContext = GamePlay;
                else if (fkMapped.ReferenceContextName == Globals.Globals.ConfigurationName)
                    overrideContext = Configuration;

                LoadTable(fkMapped.ReferenceTableName, false, overrideContext);

                if (fkMapped.ReferencedTable == null)
                {
                    fkMapped.ReferencedTable = CachedProperties[overrideContext].FirstOrDefault(u => u.Table.Name == fkMapped.ReferenceTableName);

                    if (string.IsNullOrEmpty(fkMapped.ReferencePropertyName))
                        fkMapped.ReferencePropertyName = fkMapped.ReferencedTable.PrimaryKeys.FirstOrDefault().Name;
                }
            }
        }

        private void DgvBaseSource_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                var col = dgvBaseSource.Columns[e.ColumnIndex];
                string cellValue = dgvBaseSource[e.ColumnIndex, e.RowIndex].EditedFormattedValue?.ToString();
                if (ActiveTable.RequiredItems.Select(u => u.Name).Contains(col.Name))
                {
                    string requiredText = $"{col.Name} is required.{Environment.NewLine}";
                    var storedInvalid = Tuple.Create(dgvBaseSource[e.ColumnIndex, e.RowIndex], requiredText);
                    if (string.IsNullOrEmpty(cellValue) && !InvalidCells.Contains(storedInvalid))
                    {
                        InvalidCells.Add(storedInvalid);
                        dgvBaseSource.Rows[e.RowIndex].ErrorText += requiredText;
                    }
                    else if (InvalidCells.Contains(storedInvalid))
                    {
                        InvalidCells.Remove(storedInvalid);
                        dgvBaseSource.Rows[e.RowIndex].ErrorText = dgvBaseSource.Rows[e.RowIndex].ErrorText.Replace(requiredText, string.Empty);
                    }
                }

                if (ActiveTable.PrimaryKeys.Select(u => u.Name).Contains(col.Name) && ActiveTable.PrimaryKeys.Count == 1)
                {
                    string uniqueText = $"{col.Name} must be unique.{Environment.NewLine}";
                    var storedInvalid = Tuple.Create(dgvBaseSource[e.ColumnIndex, e.RowIndex], uniqueText);

                    if (dgvBaseSource.Rows.OfType<DataGridViewRow>().Where(u => u != dgvBaseSource.Rows[e.RowIndex]).Select(d => d.Cells[col.Index].EditedFormattedValue?.ToString()).Contains(cellValue) && !InvalidCells.Contains(storedInvalid))
                    {
                        InvalidCells.Add(storedInvalid);
                        dgvBaseSource.Rows[e.RowIndex].ErrorText += uniqueText;
                    }
                    else if (InvalidCells.Contains(storedInvalid))
                    {
                        InvalidCells.Remove(storedInvalid);
                        dgvBaseSource.Rows[e.RowIndex].ErrorText.Replace(uniqueText, string.Empty);
                    }
                }
                ValidateChanged();
            }
        }

        private void ValidateChanged()
        {
            btnSave.Enabled = cbDBSelector.Enabled = cbTableSelector.Enabled = btnFindReferences.Enabled = !InvalidCells.Any();
            if (!btnSave.Enabled)
            {
                int one = 1;
            }
        }

        private void BtnOptions_Click(object sender, EventArgs e)
        {
            using (var options = new frmOptions(Localization.LocalizedText.Select(u => u.Language).ToList()))
            {
                options.ShowDialog();
            }

            ActiveSuggestions.Clear();
            CbTableSelector_SelectedIndexChanged(null, null);
        }

        private void DgvBaseSource_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
            var col = dgvBaseSource.Columns[e.ColumnIndex] as DataGridViewComboBoxColumn;
            if (col != null)
            {
                var objValue = dgvBaseSource[e.ColumnIndex, e.RowIndex].Value;
                if (objValue != null && !col.Items.Contains(objValue))
                {
                    col.Items.Add(dgvBaseSource[e.ColumnIndex, e.RowIndex].Value);
                }
            }
        }

        private void DgvBaseSource_EndEditRedoFilter(object sender, ColumnFilterClickedEventArg e)
        {
            FilteredList.Clear();
            foreach (var loadedItem in ActiveTable.LoadedItems)
            {
                bool add = true;
                foreach (DataGridViewColumn item in dgvBaseSource.Columns)
                {
                    DataGridFilterHeader filterHeader = item.HeaderCell as DataGridFilterHeader;

                    if (!string.IsNullOrEmpty(filterHeader.HeldBox.Text))
                    {
                        var heldValue = loadedItem.GetPropertyValue(item.Name);
                        if (heldValue != null)
                        {
                            if (!heldValue.ToString().ToLower().Contains(filterHeader.HeldBox.Text.ToLower()))
                            {
                                add = false;
                                break;
                            }
                        }
                        else
                        {
                            add = false;
                            break;
                        }
                    }
                }

                if (add)
                    FilteredList.Add(loadedItem);
            }

            dgvBaseSource.CellValidating -= DgvBaseSource_CellValidating;
            dgvBaseSource.DataSource = FilteredList;
            dgvBaseSource.CellValidating += DgvBaseSource_CellValidating;
            InvalidCells.Clear();
        }

        private void BtnFindReferences_Click(object sender, EventArgs e)
        {
            scMainSplitter.Panel2Collapsed = !btnFindReferences.Checked;
            LoadReferencesToComboBoxes();
        }

        private void LoadReferencesToComboBoxes()
        {
            cbReferencedFrom.SelectedIndex = cbReferences.SelectedIndex = -1;

            if (!scMainSplitter.Panel2Collapsed)
            {

                cbReferences.DataSource = null;
                cbReferences.DisplayMember = "Display";
                var references = ActiveTable.ForeignKeys.Where(u => Helpers.ContextSwitcher(ActiveDB) == u.ReferenceContextName).Select(u => new { Display = $"{u.ReferenceTableName} - {u.LocalProperty.Name}", FieldName = u.LocalPropertyAccessorName, TableName = u.ReferenceTableName }).Distinct().OrderBy(u => u.Display).ToList();
                if (references.Any(u => !string.IsNullOrEmpty(u.Display)))
                    cbReferences.DataSource = (references);
                else
                {
                    var none = new { Display = Globals.Globals.None, Value = Globals.Globals.None };

                    cbReferences.DataSource = (new[] { none }.ToList());
                    cbReferences.SelectedIndex = 0;
                }

                cbReferencedFrom.DataSource = null;
                cbReferencedFrom.DisplayMember = "Display";
                var referencedFrom = ActiveTable.InverseForeignKeys.Select(u => new { Display = (!string.IsNullOrEmpty(u.InversePropertyName)) ? $"{u.ReferencedFromTableName} - {u.InversePropertyName}" : u.ReferencedFromTableName, FieldName = u.LocalPropertyAccessorName, TableName = u.ReferencedFromTableName }).Distinct().OrderBy(u => u.Display).ToList();
                if (referencedFrom.Any(u => !string.IsNullOrEmpty(u.Display)))
                    cbReferencedFrom.DataSource = (referencedFrom);
                else
                {
                    var none = new { Display = Globals.Globals.None, Value = Globals.Globals.None };

                    cbReferencedFrom.DataSource = (new[] { none }.ToList());
                    cbReferencedFrom.SelectedIndex = 0;
                }
            }
        }

        private void CbReferencing_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox caller = sender as ComboBox;
            DataGridWithFilter callersDatagrid = (caller == cbReferencedFrom) ? dgvReferencedFrom : dgvReferences;
            if (!scMainSplitter.Panel2Collapsed)
            {
                DataGridViewRow selectedRow = dgvBaseSource.SelectedRows?.FirstOrDefault();

                if (caller.SelectedIndex != -1 && caller.Text.ToString() != Globals.Globals.None && selectedRow != null)
                {
                    dynamic value = caller.SelectedValue;
                    //ActiveDB.Entry(selectedRow.DataBoundItem).Collection(cbReferencedFrom.SelectedValue.ToString()).Load();
                    Type table = ActiveDB.TableNames.FirstOrDefault(u => u.Name == value.TableName).PropertyType.GetGenericArguments().Single();
                    BindingList<object> dataToPopulate = null;
                    var property = selectedRow.DataBoundItem.GetPropertyValue((string)value.FieldName);
                    if (property != null && property.GetType().IsGenericType == true)
                        dataToPopulate = ((IEnumerable)property).OfType<object>().ToBindingList();
                    else if (property != null)
                    {
                        dataToPopulate = new BindingList<object>();
                        dataToPopulate.Add(property);
                    }
                    PopulateGridColumns(callersDatagrid, table, dataToPopulate);
                }
                else
                {
                    callersDatagrid.Columns.Clear();
                    callersDatagrid.DataSource = null;
                }
            }
        }

        private void PopulateGridColumns(DataGridWithFilter dgvToPopulate, Type table, BindingList<object> dataToPopulate)
        {
            dgvToPopulate.AutoGenerateColumns = false;
            dgvToPopulate.Columns.Clear();
            dgvToPopulate.DataSource = null;

            foreach (var prop in table.GetProperties())
            {
                bool nullablePrimitive = Helpers.FindUnderylingNullableType(prop.PropertyType)?.IsPrimitive ?? false;
                if (prop.PropertyType == typeof(string) || prop.PropertyType.IsPrimitive || nullablePrimitive)
                {
                    int colIndex = dgvToPopulate.Columns.Add(prop.Name, prop.Name);

                    dgvToPopulate.Columns[colIndex].DataPropertyName = prop.Name;
                    dgvToPopulate.Columns[colIndex].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    dgvToPopulate.Columns[colIndex].MinimumWidth = 100;
                }
            }

            dgvToPopulate.DataSource = dataToPopulate;
        }

        private void DgvBaseSource_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (!scMainSplitter.Panel2Collapsed)
            {
                CbReferencing_SelectedIndexChanged(cbReferencedFrom, null);

                var foundItem = cbReferences.Items.OfType<dynamic>().FirstOrDefault(u => u.Display.Contains($"- {dgvBaseSource.Columns[e.ColumnIndex].Name}"));
                //cbReferences.FindStringExact($"- {dgvBaseSource.Columns[e.ColumnIndex].Name}");
                if (foundItem != null)
                    cbReferences.SelectedItem = foundItem;
                else
                    CbReferencing_SelectedIndexChanged(cbReferences, null);
            }
        }

        private void SQLHelper_Load(object sender, EventArgs e)
        {

        }
    }
}
