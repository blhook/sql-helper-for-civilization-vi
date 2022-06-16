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
using System.Text;
using System.Windows.Forms;

namespace SQLHelper_Civ
{
    public partial class frmOutputSQL : Form
    {
        List<StringBuilder> HeldResults = new List<StringBuilder>();
        public frmOutputSQL(List<StringBuilder> dialogResults)
        {
            InitializeComponent();
            StringBuilder s = new StringBuilder();
            s.AppendLine("--Code Generated using Zugaikotsu's SQL Helper for Civilization VI");

            HeldResults.Add(s);
            HeldResults.AddRange(dialogResults);

            foreach (var sb in dialogResults)
            {
                s.AppendLine(sb.ToString());
            }

            rtbInformation.Text = s.ToString();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog save = new SaveFileDialog())
            {
                save.Filter = "SQL Format|*.sql|Text Format|*.txt";//"JPeg Image|*.jpg|Bitmap Image|*.bmp|Gif Image|*.gif";
                save.Title = "Save The Generated SQL to Disk";
                save.ShowDialog();

                if (save.FileName != "")
                {
                    using (System.IO.StreamWriter file = new System.IO.StreamWriter(save.FileName))
                    {
                        foreach (var sb in HeldResults)
                        {
                            file.WriteLine(sb.ToString());
                        }
                    }
                }
            }
        }
    }
}
