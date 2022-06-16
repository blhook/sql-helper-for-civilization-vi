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
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using static SQLHelper_Civ.Extensions_Helpers.Classes;

namespace SQLHelper_Civ
{
    public partial class frmFindReferences : Form
    {
        TablePropertyHolder HeldTable;

        object HeldRow;

        List<PropertyInfo> Props = new List<PropertyInfo>();

        public frmFindReferences(object searchTable, object searchRow)
        {
            InitializeComponent();

            HeldTable = (TablePropertyHolder)searchTable;
            HeldRow = searchRow;

            Props.AddRange(HeldTable.UnderlyingType.GetProperties()
            .Where(p => p.PropertyType.IsGenericType
            && p.PropertyType.GetGenericTypeDefinition() == typeof(ICollection<>)).ToList());

            cbTableSelector.Items.AddRange(Props.Select(u => u.PropertyType.GetGenericArguments().Single().Name).ToArray());
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {

        }

        private void CbTableSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            PopulateGrid();
        }

        private void PopulateGrid()
        {
            dgvBaseSource.AutoGenerateColumns = false;
            dgvBaseSource.Columns.Clear();

            foreach (var prop in Props.FirstOrDefault(u => u.PropertyType.GetGenericArguments().Single().Name == cbTableSelector.Text).PropertyType.GetGenericArguments().Single().GetProperties())
            {
                int colIndex;
                dgvBaseSource.DataSource = null;

                bool nullablePrimitive = Helpers.FindUnderylingNullableType(prop.PropertyType)?.IsPrimitive ?? false;
                if (prop.PropertyType == typeof(string) || prop.PropertyType.IsPrimitive || nullablePrimitive)
                {
                    if (prop.PropertyType == typeof(bool)/* || prop.PropertyType == typeof(bool?)*/)
                    {
                        DataGridViewComboBoxColumn fkCol = new DataGridViewComboBoxColumn();
                        if (prop.PropertyType == typeof(bool?))
                            fkCol.Items.Add(string.Empty);
                        fkCol.Items.Add(true);
                        fkCol.Items.Add(false);
                        fkCol.Name = prop.Name;
                        fkCol.HeaderText = prop.Name;
                        colIndex = dgvBaseSource.Columns.Add(fkCol);
                    }
                    else
                    {
                        colIndex = dgvBaseSource.Columns.Add(prop.Name, prop.Name);
                    }

                    dgvBaseSource.Columns[colIndex].DataPropertyName = prop.Name;
                    dgvBaseSource.Columns[colIndex].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    dgvBaseSource.Columns[colIndex].MinimumWidth = 100;
                }
            }
            dgvBaseSource.DataSource = ((IEnumerable)HeldRow.GetPropertyValue(cbTableSelector.Text)).OfType<object>().ToBindingList();
        }

        private void DgvBaseSource_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            //DataGridView grid = (DataGridView)sender;
            //DataGridViewRow row = grid.Rows[e.RowIndex];
            //DataGridViewColumn col = grid.Columns[e.ColumnIndex];
            //if (row.DataBoundItem != null && col.DataPropertyName.Contains("."))
            //{
            //    string[] props = col.DataPropertyName.Split('.');
            //    PropertyInfo propInfo = row.DataBoundItem.GetType().GetProperty(props[0]);
            //    object val = propInfo.GetValue(row.DataBoundItem, null);
            //    for (int i = 1; i < props.Length; i++)
            //    {
            //        propInfo = val.GetType().GetProperty(props[i]);
            //        val = propInfo.GetValue(val, null);
            //    }
            //    e.Value = val;
            //}
        }
    }
}
