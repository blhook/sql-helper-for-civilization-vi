namespace SQLHelper_Civ
{
    partial class frmFindReferences
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFindReferences));
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnSave = new System.Windows.Forms.Button();
            this.lblTabel = new System.Windows.Forms.Label();
            this.cbTableSelector = new System.Windows.Forms.ComboBox();
            this.dgvBaseSource = new SQLHelper_Civ.Extensions_Helpers.DataGridWithFilter();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBaseSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(553, 12);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(93, 29);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // lblTabel
            // 
            this.lblTabel.AutoSize = true;
            this.lblTabel.Location = new System.Drawing.Point(12, 20);
            this.lblTabel.Name = "lblTabel";
            this.lblTabel.Size = new System.Drawing.Size(34, 13);
            this.lblTabel.TabIndex = 9;
            this.lblTabel.Text = "Table";
            // 
            // cbTableSelector
            // 
            this.cbTableSelector.AllowDrop = true;
            this.cbTableSelector.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbTableSelector.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cbTableSelector.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbTableSelector.FormattingEnabled = true;
            this.cbTableSelector.Location = new System.Drawing.Point(71, 17);
            this.cbTableSelector.MaxDropDownItems = 3;
            this.cbTableSelector.Name = "cbTableSelector";
            this.cbTableSelector.Size = new System.Drawing.Size(241, 21);
            this.cbTableSelector.TabIndex = 8;
            this.cbTableSelector.SelectedIndexChanged += new System.EventHandler(this.CbTableSelector_SelectedIndexChanged);
            // 
            // dgvBaseSource
            // 
            this.dgvBaseSource.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvBaseSource.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvBaseSource.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvBaseSource.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBaseSource.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvBaseSource.Location = new System.Drawing.Point(12, 55);
            this.dgvBaseSource.Name = "dgvBaseSource";
            this.dgvBaseSource.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvBaseSource.RowHeadersWidth = 55;
            this.dgvBaseSource.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvBaseSource.Size = new System.Drawing.Size(634, 333);
            this.dgvBaseSource.TabIndex = 1;
            this.dgvBaseSource.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.DgvBaseSource_CellFormatting);
            // 
            // frmFindReferences
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 400);
            this.Controls.Add(this.lblTabel);
            this.Controls.Add(this.cbTableSelector);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dgvBaseSource);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(551, 204);
            this.Name = "frmFindReferences";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Options";
            ((System.ComponentModel.ISupportInitialize)(this.dgvBaseSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolTip toolTip1;
        private Extensions_Helpers.DataGridWithFilter dgvBaseSource;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblTabel;
        private System.Windows.Forms.ComboBox cbTableSelector;
    }
}