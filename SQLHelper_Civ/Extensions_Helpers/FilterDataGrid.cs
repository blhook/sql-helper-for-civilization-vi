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
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace SQLHelper_Civ.Extensions_Helpers
{
    //Source: https://stackoverflow.com/a/4243942 Much respect and appreciation for this author. It has been modified quite a bit, but very useful design.
    public class DataGridWithFilter : DataGridView
    {
        [Category("Appearance")]
        [Description("Display/Suppress the Filter Header")]
        [Browsable(true), EditorBrowsable(EditorBrowsableState.Always), DefaultValue(true)]
        public bool ShowFilter { get; set; } = true;

        public event EventHandler<ColumnFilterClickedEventArg> EndEditRedoFilter;

        new public List<DataGridViewRow> SelectedRows
        {
            get
            {
                List<DataGridViewRow> rowsToReturn = new List<DataGridViewRow>();
                if (this.GetCellCount(DataGridViewElementStates.Selected) > 0)
                {
                    rowsToReturn.AddRange(this.SelectedCells.OfType<DataGridViewCell>().DistinctBy(u => u.RowIndex).Where(u => u.RowIndex != -1).Select(u => this.Rows[u.RowIndex]));
                }
                return rowsToReturn;
            }
        }

        protected override void OnColumnAdded(DataGridViewColumnEventArgs e)
        {
            if (ShowFilter)
            {
                var header = new DataGridFilterHeader();
                header.Value = e.Column.HeaderCell.Value;
                if (header.HeldBox == null)
                {
                    // filter button
                    TextBox innerCtrl = new TextBox();
                    innerCtrl.Size = new System.Drawing.Size(100, 30);
                    header.HeldBox = innerCtrl;
                    innerCtrl.Tag = header;
                    header.HeldBox.LostFocus += HeldBox_Leave;
                }

                header.FilterButtonClicked += new EventHandler<ColumnFilterClickedEventArg>(header_FilterButtonClicked);
                e.Column.HeaderCell = header;
            }
            base.OnColumnAdded(e);
        }

        void header_FilterButtonClicked(object sender, ColumnFilterClickedEventArg e)
        {
            DataGridFilterHeader header = sender as DataGridFilterHeader;

            var popup = new ToolStripDropDown();
            popup.AutoSize = false;
            popup.Margin = Padding.Empty;
            popup.Padding = Padding.Empty;
            ToolStripControlHost host = new ToolStripControlHost(header.HeldBox);
            host.Margin = Padding.Empty;
            host.Padding = Padding.Empty;
            host.AutoSize = false;
            host.Size = header.HeldBox.Size;
            popup.Size = header.HeldBox.Size;
            popup.Items.Add(host);

            // show the popup
            popup.Show(this, e.ButtonRectangle.X, e.ButtonRectangle.Bottom);
        }

        private void HeldBox_Leave(object sender, EventArgs e)
        {
            this.EndEditRedoFilter?.Invoke(this, new ColumnFilterClickedEventArg(((TextBox)sender).Tag as DataGridFilterHeader, new Rectangle()));
        }
    }

    public class DataGridFilterHeader : DataGridViewColumnHeaderCell
    {
        public TextBox HeldBox;
        PushButtonState currentState = PushButtonState.Normal;
        Point cellLocation;
        Rectangle buttonRect;

        public event EventHandler<ColumnFilterClickedEventArg> FilterButtonClicked;

        protected override void Paint(Graphics graphics,
                                      Rectangle clipBounds,
                                      Rectangle cellBounds,
                                      int rowIndex,
                                      DataGridViewElementStates dataGridViewElementState,
                                      object value,
                                      object formattedValue,
                                      string errorText,
                                      DataGridViewCellStyle cellStyle,
                                      DataGridViewAdvancedBorderStyle advancedBorderStyle,
                                      DataGridViewPaintParts paintParts)
        {
            base.Paint(graphics, clipBounds,
                       cellBounds, rowIndex,
                       dataGridViewElementState, value,
                       formattedValue, errorText,
                       cellStyle, advancedBorderStyle, paintParts);

            int width = 20; // 20 px
            buttonRect = new Rectangle(cellBounds.X + cellBounds.Width - width, cellBounds.Y, width, cellBounds.Height);

            cellLocation = cellBounds.Location;
            // to set image/ or some other properties to the filter button look at DrawButton overloads
            ButtonRenderer.DrawButton(graphics,
                                      buttonRect,
                                      string.IsNullOrEmpty(this.HeldBox?.Text) ? Properties.Resources.Filter : Properties.Resources.FilterWithCheck,
                                      buttonRect,
                                      false,
                                      currentState);
        }

        protected override void OnMouseDown(DataGridViewCellMouseEventArgs e)
        {
            if (this.IsMouseOverButton(e.Location))
                currentState = PushButtonState.Pressed;
            base.OnMouseDown(e);
        }
        protected override void OnMouseUp(DataGridViewCellMouseEventArgs e)
        {
            if (this.IsMouseOverButton(e.Location))
            {
                currentState = PushButtonState.Normal;
                this.OnFilterButtonClicked();
            }
            base.OnMouseUp(e);
        }
        private bool IsMouseOverButton(Point e)
        {
            Point p = new Point(e.X + cellLocation.X, e.Y + cellLocation.Y);
            if (p.X >= buttonRect.X && p.X <= buttonRect.X + buttonRect.Width &&
                p.Y >= buttonRect.Y && p.Y <= buttonRect.Y + buttonRect.Height)
            {
                return true;
            }
            return false;
        }
        protected virtual void OnFilterButtonClicked()
        {
            this.FilterButtonClicked?.Invoke(this, new ColumnFilterClickedEventArg(this, this.buttonRect));
        }
    }

    public class ColumnFilterClickedEventArg : EventArgs
    {
        public DataGridFilterHeader ColumnHeader { get; private set; }
        public Rectangle ButtonRectangle { get; private set; }
        public ColumnFilterClickedEventArg(DataGridFilterHeader colIndex, Rectangle btnRect)
        {
            this.ColumnHeader = colIndex;
            this.ButtonRectangle = btnRect;
        }
    }
}
