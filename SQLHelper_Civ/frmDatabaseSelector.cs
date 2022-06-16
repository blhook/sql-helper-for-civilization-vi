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
using System.IO;
using System.Windows.Forms;

namespace SQLHelper_Civ
{
    public partial class frmDatabaseSelector : Form
    {
        public bool NoErrors => (string.IsNullOrEmpty(errorProvider1.GetError(txtConfigurationPath)) && string.IsNullOrEmpty(errorProvider1.GetError(txtGameplayPath)) && string.IsNullOrEmpty(errorProvider1.GetError(txtLocalizationPath)));

        public bool ForceClose = false;

        public frmDatabaseSelector()
        {
            InitializeComponent();

            txtConfigurationPath.Text = Path.Combine(Properties.Settings.Default.ConfigurationPath);
            txtGameplayPath.Text = Path.Combine(Properties.Settings.Default.GameplayPath);
            txtLocalizationPath.Text = Path.Combine(Properties.Settings.Default.LocalizationPath);
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.ConfigurationPath = Path.Combine(txtConfigurationPath.Text);
            Properties.Settings.Default.GameplayPath = Path.Combine(txtGameplayPath.Text);
            Properties.Settings.Default.LocalizationPath = Path.Combine(txtLocalizationPath.Text);

            Properties.Settings.Default.Save();

            this.Close();
        }

        private void BtnChangeFileLocation(object sender, EventArgs e)
        {
            string path = string.Empty;
            if (sender == btnConfigurationSearch)
                path = Path.Combine(txtConfigurationPath.Text);
            else if (sender == btnGameplaySearch)
                path = Path.Combine(txtGameplayPath.Text);
            else if (sender == btnLocalizationSearch)
                path = Path.Combine(txtLocalizationPath.Text);

            DialogResult response;
            using (var fileDialog = new OpenFileDialog())
            {
                fileDialog.CheckPathExists = true;
                fileDialog.Multiselect = false;
                fileDialog.InitialDirectory = Path.GetDirectoryName(path);
                fileDialog.Title = "SQL File Selector";

                response = fileDialog.ShowDialog();
                path = fileDialog.FileName ?? string.Empty;
            }

            if (response == DialogResult.OK)
            {
                if (sender == btnConfigurationSearch)
                    txtConfigurationPath.Text = Path.Combine(path);
                else if (sender == btnGameplaySearch)
                    txtGameplayPath.Text = Path.Combine(path);
                else if (sender == btnLocalizationSearch)
                    txtLocalizationPath.Text = Path.Combine(path);
            }
        }

        void ValidationTextChanged(object sender, EventArgs e)
        {
            if (IsSqliteDatabase((sender as TextBox).Text))
                errorProvider1.SetError(sender as TextBox, "");
            else
                errorProvider1.SetError(sender as TextBox, "The selected file does not exist or is not a properly formatted SQLite Database.");

            btnSave.Enabled = NoErrors;
        }

        private void FrmDatabaseSelector_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!File.Exists(Properties.Settings.Default.ConfigurationPath) ||
            !File.Exists(Properties.Settings.Default.GameplayPath) ||
            !File.Exists(Properties.Settings.Default.LocalizationPath))
            {
                var response = MessageBox.Show("The form is attempted to be close when there are still errors in the saved selection. Please retry and save properly.", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                if (response == DialogResult.Retry)
                    e.Cancel = true;
                else
                {
                    this.FormClosing -= FrmDatabaseSelector_FormClosing;
                    ForceClose = true;
                    Application.Exit();
                }
            }
        }

        //Source: https://www.blakepell.com/2014-01-13-vbnet-csharp-function-to-efficiently-check-if-a-file-is-a-sqlite-database
        /// <summary>
        /// Does a quick check on a file to see if a valid SQLite header exists.  This does not further check the validity
        /// of the database.  If the file does not exist, false will be returned.
        /// </summary>
        /// <param name="filename"></param>
        /// <returns></returns>
        /// <remarks></remarks>
        public bool IsSqliteDatabase(string filename)
        {
            if (!System.IO.File.Exists(filename))
                return false;

            // FileShare.ReadWrite allows to the file to be read even if it's locked by another process such as something
            // that has an active connection to the database.
            using (FileStream fs = new FileStream(filename, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
            {
                byte[] bytes = new byte[16];
                int x = fs.Read(bytes, 0, 16);
                fs.Close();
                string text = System.Text.ASCIIEncoding.ASCII.GetString(bytes);
                return text.Contains("SQLite format");
            }
        }
    }
}
