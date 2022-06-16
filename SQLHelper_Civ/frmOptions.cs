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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using static SQLHelper_Civ.Globals.Globals;

namespace SQLHelper_Civ
{
    public partial class frmOptions : Form
    {
        public frmOptions(List<string> languages)
        {
            InitializeComponent();
            chkReferenceSuggest.Checked = Properties.Settings.Default.ReferenceSuggest;
            chkColumnAppend.Checked = Properties.Settings.Default.ColumnSuggest;
            chkReferenceForced.Checked = Properties.Settings.Default.ReferenceForce;
            chkCrossDatabase.Checked = Properties.Settings.Default.CrossContext;

            List<string> languageOptions = new List<string>() { Globals.Globals.All, Properties.Settings.Default.DefaultLanguage };
            languageOptions.AddRange(languages);
            languageOptions = languageOptions.Distinct().ToList();
            cbLanguageSelector.Items.AddRange(languageOptions.ToArray());
            cbLanguageSelector.Text = Properties.Settings.Default.DefaultLanguage;

            switch ((InsertTypes)Properties.Settings.Default.InsertMethod)
            {
                case InsertTypes.Insert:
                default:
                    rdoInsert.Checked = true;
                    break;
                case InsertTypes.InsertOrIgnore:
                    rdoIgnore.Checked = true;
                    break;
                case InsertTypes.InsertOrReplace:
                    rdoReplace.Checked = true;
                    break;
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.ReferenceSuggest = chkReferenceSuggest.Checked;
            Properties.Settings.Default.ColumnSuggest = chkColumnAppend.Checked;
            Properties.Settings.Default.ReferenceForce = chkReferenceForced.Checked;
            Properties.Settings.Default.CrossContext = chkCrossDatabase.Checked;
            Properties.Settings.Default.DefaultLanguage = cbLanguageSelector.Text;

            if (rdoInsert.Checked)
                Properties.Settings.Default.InsertMethod = (int)InsertTypes.Insert;
            else if (rdoIgnore.Checked)
                Properties.Settings.Default.InsertMethod = (int)InsertTypes.InsertOrIgnore;
            else if (rdoReplace.Checked)
                Properties.Settings.Default.InsertMethod = (int)InsertTypes.InsertOrReplace;

            Properties.Settings.Default.Save();

            this.Close();
        }

        private void LinkAbout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            using (frmAbout about = new frmAbout())
            {
                about.ShowDialog();
            }
        }
    }
}
