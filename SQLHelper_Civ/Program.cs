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
using System.Linq;
using System.Windows.Forms;
using Test.ORM;

namespace SQLHelper_Civ
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            bool validToRun = true;
            GameplayDB gp = null;
            LocalizationDB localization = null;
            ConfigurationDB config = null;
            do
            {
                validToRun = true;
                using (frmDatabaseSelector selector = new frmDatabaseSelector())
                {
                    selector.ShowDialog();
                    validToRun = selector.NoErrors;
                    if (selector.ForceClose)
                    {
                        Application.Exit();
                        break;
                    }
                }

                try
                {
                    gp = new GameplayDB();
                    gp.AiScoutUses.FirstOrDefault();
                    localization = new LocalizationDB();
                    localization.AudioLanguages.FirstOrDefault();
                    config = new ConfigurationDB();
                    config.DuplicateLeaders.FirstOrDefault();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("The selected databases failed to open." + Environment.NewLine + ex.ToString(), "Open Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    validToRun = false;
                    gp?.Dispose();
                    localization?.Dispose();
                    config?.Dispose();
                }
            } while (!validToRun);

            using (SQLHelper mainForm = new SQLHelper(gp, localization, config))
            {
                mainForm.ShowDialog();
            }
        }
    }
}
