namespace SQLHelper_Civ
{
    partial class SQLHelper
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SQLHelper));
            this.cbDBSelector = new System.Windows.Forms.ComboBox();
            this.cbTableSelector = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblDatabase = new System.Windows.Forms.Label();
            this.lblTabel = new System.Windows.Forms.Label();
            this.btnOptions = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.scMainSplitter = new System.Windows.Forms.SplitContainer();
            this.dgvBaseSource = new SQLHelper_Civ.Extensions_Helpers.DataGridWithFilter();
            this.btnFindReferences = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pnlReferencedFrom = new System.Windows.Forms.Panel();
            this.dgvReferencedFrom = new SQLHelper_Civ.Extensions_Helpers.DataGridWithFilter();
            this.lblReferencedFrom = new System.Windows.Forms.Label();
            this.cbReferencedFrom = new System.Windows.Forms.ComboBox();
            this.pnelReferencedBy = new System.Windows.Forms.Panel();
            this.dgvReferences = new SQLHelper_Civ.Extensions_Helpers.DataGridWithFilter();
            this.lblReferences = new System.Windows.Forms.Label();
            this.cbReferences = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.scMainSplitter)).BeginInit();
            this.scMainSplitter.Panel1.SuspendLayout();
            this.scMainSplitter.Panel2.SuspendLayout();
            this.scMainSplitter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBaseSource)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.pnlReferencedFrom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReferencedFrom)).BeginInit();
            this.pnelReferencedBy.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReferences)).BeginInit();
            this.SuspendLayout();
            // 
            // cbDBSelector
            // 
            this.cbDBSelector.AllowDrop = true;
            this.cbDBSelector.AutoCompleteCustomSource.AddRange(new string[] {
            "GamePlay",
            "Configuration",
            "Localization"});
            this.cbDBSelector.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbDBSelector.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cbDBSelector.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbDBSelector.FormattingEnabled = true;
            this.cbDBSelector.Items.AddRange(new object[] {
            "GamePlay",
            "Configuration",
            "Localization"});
            this.cbDBSelector.Location = new System.Drawing.Point(83, 12);
            this.cbDBSelector.MaxDropDownItems = 3;
            this.cbDBSelector.Name = "cbDBSelector";
            this.cbDBSelector.Size = new System.Drawing.Size(136, 21);
            this.cbDBSelector.TabIndex = 1;
            this.cbDBSelector.SelectedIndexChanged += new System.EventHandler(this.CbDBSelector_SelectedIndexChanged);
            // 
            // cbTableSelector
            // 
            this.cbTableSelector.AllowDrop = true;
            this.cbTableSelector.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbTableSelector.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cbTableSelector.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbTableSelector.FormattingEnabled = true;
            this.cbTableSelector.Location = new System.Drawing.Point(83, 39);
            this.cbTableSelector.MaxDropDownItems = 3;
            this.cbTableSelector.Name = "cbTableSelector";
            this.cbTableSelector.Size = new System.Drawing.Size(241, 21);
            this.cbTableSelector.TabIndex = 2;
            this.cbTableSelector.SelectedIndexChanged += new System.EventHandler(this.CbTableSelector_SelectedIndexChanged);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(693, 12);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(93, 29);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Generate SQL";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // lblDatabase
            // 
            this.lblDatabase.AutoSize = true;
            this.lblDatabase.Location = new System.Drawing.Point(24, 15);
            this.lblDatabase.Name = "lblDatabase";
            this.lblDatabase.Size = new System.Drawing.Size(53, 13);
            this.lblDatabase.TabIndex = 6;
            this.lblDatabase.Text = "Database";
            // 
            // lblTabel
            // 
            this.lblTabel.AutoSize = true;
            this.lblTabel.Location = new System.Drawing.Point(24, 42);
            this.lblTabel.Name = "lblTabel";
            this.lblTabel.Size = new System.Drawing.Size(34, 13);
            this.lblTabel.TabIndex = 7;
            this.lblTabel.Text = "Table";
            // 
            // btnOptions
            // 
            this.btnOptions.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOptions.Location = new System.Drawing.Point(693, 47);
            this.btnOptions.Name = "btnOptions";
            this.btnOptions.Size = new System.Drawing.Size(93, 29);
            this.btnOptions.TabIndex = 8;
            this.btnOptions.Text = "Options";
            this.btnOptions.UseVisualStyleBackColor = true;
            this.btnOptions.Click += new System.EventHandler(this.BtnOptions_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Enabled = false;
            this.btnDelete.Image = global::SQLHelper_Civ.Properties.Resources.RemoveRow_16x;
            this.btnDelete.Location = new System.Drawing.Point(9, 75);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(28, 29);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Enabled = false;
            this.btnAdd.Image = global::SQLHelper_Civ.Properties.Resources.AddRow_16x;
            this.btnAdd.Location = new System.Drawing.Point(9, 40);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(28, 29);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // scMainSplitter
            // 
            this.scMainSplitter.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.scMainSplitter.Location = new System.Drawing.Point(0, 81);
            this.scMainSplitter.Margin = new System.Windows.Forms.Padding(2);
            this.scMainSplitter.Name = "scMainSplitter";
            this.scMainSplitter.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // scMainSplitter.Panel1
            // 
            this.scMainSplitter.Panel1.Controls.Add(this.dgvBaseSource);
            this.scMainSplitter.Panel1.Controls.Add(this.btnFindReferences);
            this.scMainSplitter.Panel1.Controls.Add(this.btnAdd);
            this.scMainSplitter.Panel1.Controls.Add(this.btnDelete);
            // 
            // scMainSplitter.Panel2
            // 
            this.scMainSplitter.Panel2.Controls.Add(this.tableLayoutPanel1);
            this.scMainSplitter.Size = new System.Drawing.Size(787, 519);
            this.scMainSplitter.SplitterDistance = 350;
            this.scMainSplitter.SplitterWidth = 3;
            this.scMainSplitter.TabIndex = 10;
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
            this.dgvBaseSource.Location = new System.Drawing.Point(42, 5);
            this.dgvBaseSource.Name = "dgvBaseSource";
            this.dgvBaseSource.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvBaseSource.RowHeadersWidth = 55;
            this.dgvBaseSource.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvBaseSource.Size = new System.Drawing.Size(739, 331);
            this.dgvBaseSource.TabIndex = 0;
            this.dgvBaseSource.EndEditRedoFilter += new System.EventHandler<SQLHelper_Civ.Extensions_Helpers.ColumnFilterClickedEventArg>(this.DgvBaseSource_EndEditRedoFilter);
            this.dgvBaseSource.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvBaseSource_CellEnter);
            this.dgvBaseSource.CellLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvBaseSource_CellLeave);
            this.dgvBaseSource.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.DgvBaseSource_CellValidating);
            this.dgvBaseSource.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.DgvBaseSource_DataError);
            this.dgvBaseSource.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.DgvBaseSource_EditingControlShowing);
            this.dgvBaseSource.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.SetRowNumbers);
            this.dgvBaseSource.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.SetRowNumbers);
            this.dgvBaseSource.Sorted += new System.EventHandler(this.SetRowNumbers);
            // 
            // btnFindReferences
            // 
            this.btnFindReferences.Appearance = System.Windows.Forms.Appearance.Button;
            this.btnFindReferences.Enabled = false;
            this.btnFindReferences.Image = global::SQLHelper_Civ.Properties.Resources.SearchMember_16x;
            this.btnFindReferences.Location = new System.Drawing.Point(9, 5);
            this.btnFindReferences.Name = "btnFindReferences";
            this.btnFindReferences.Size = new System.Drawing.Size(28, 29);
            this.btnFindReferences.TabIndex = 11;
            this.btnFindReferences.UseVisualStyleBackColor = true;
            this.btnFindReferences.Click += new System.EventHandler(this.BtnFindReferences_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.pnlReferencedFrom, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.pnelReferencedBy, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(787, 166);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // pnlReferencedFrom
            // 
            this.pnlReferencedFrom.Controls.Add(this.dgvReferencedFrom);
            this.pnlReferencedFrom.Controls.Add(this.lblReferencedFrom);
            this.pnlReferencedFrom.Controls.Add(this.cbReferencedFrom);
            this.pnlReferencedFrom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlReferencedFrom.Location = new System.Drawing.Point(3, 3);
            this.pnlReferencedFrom.Name = "pnlReferencedFrom";
            this.pnlReferencedFrom.Size = new System.Drawing.Size(387, 160);
            this.pnlReferencedFrom.TabIndex = 1;
            // 
            // dgvReferencedFrom
            // 
            this.dgvReferencedFrom.AllowUserToAddRows = false;
            this.dgvReferencedFrom.AllowUserToDeleteRows = false;
            this.dgvReferencedFrom.AllowUserToResizeRows = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvReferencedFrom.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvReferencedFrom.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvReferencedFrom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReferencedFrom.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvReferencedFrom.Location = new System.Drawing.Point(3, 30);
            this.dgvReferencedFrom.Name = "dgvReferencedFrom";
            this.dgvReferencedFrom.ReadOnly = true;
            this.dgvReferencedFrom.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvReferencedFrom.RowHeadersVisible = false;
            this.dgvReferencedFrom.RowHeadersWidth = 55;
            this.dgvReferencedFrom.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReferencedFrom.ShowFilter = false;
            this.dgvReferencedFrom.ShowRowErrors = false;
            this.dgvReferencedFrom.Size = new System.Drawing.Size(381, 126);
            this.dgvReferencedFrom.TabIndex = 13;
            // 
            // lblReferencedFrom
            // 
            this.lblReferencedFrom.AutoSize = true;
            this.lblReferencedFrom.Location = new System.Drawing.Point(9, 6);
            this.lblReferencedFrom.Name = "lblReferencedFrom";
            this.lblReferencedFrom.Size = new System.Drawing.Size(89, 13);
            this.lblReferencedFrom.TabIndex = 9;
            this.lblReferencedFrom.Text = "Referenced From";
            // 
            // cbReferencedFrom
            // 
            this.cbReferencedFrom.AllowDrop = true;
            this.cbReferencedFrom.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cbReferencedFrom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbReferencedFrom.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbReferencedFrom.FormattingEnabled = true;
            this.cbReferencedFrom.Location = new System.Drawing.Point(104, 3);
            this.cbReferencedFrom.MaxDropDownItems = 3;
            this.cbReferencedFrom.Name = "cbReferencedFrom";
            this.cbReferencedFrom.Size = new System.Drawing.Size(282, 21);
            this.cbReferencedFrom.TabIndex = 8;
            this.cbReferencedFrom.SelectedIndexChanged += new System.EventHandler(this.CbReferencing_SelectedIndexChanged);
            // 
            // pnelReferencedBy
            // 
            this.pnelReferencedBy.Controls.Add(this.dgvReferences);
            this.pnelReferencedBy.Controls.Add(this.lblReferences);
            this.pnelReferencedBy.Controls.Add(this.cbReferences);
            this.pnelReferencedBy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnelReferencedBy.Location = new System.Drawing.Point(396, 3);
            this.pnelReferencedBy.Name = "pnelReferencedBy";
            this.pnelReferencedBy.Size = new System.Drawing.Size(388, 160);
            this.pnelReferencedBy.TabIndex = 0;
            // 
            // dgvReferences
            // 
            this.dgvReferences.AllowUserToAddRows = false;
            this.dgvReferences.AllowUserToDeleteRows = false;
            this.dgvReferences.AllowUserToResizeRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvReferences.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvReferences.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvReferences.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReferences.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvReferences.Location = new System.Drawing.Point(3, 33);
            this.dgvReferences.Name = "dgvReferences";
            this.dgvReferences.ReadOnly = true;
            this.dgvReferences.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvReferences.RowHeadersVisible = false;
            this.dgvReferences.RowHeadersWidth = 55;
            this.dgvReferences.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReferences.ShowFilter = false;
            this.dgvReferences.ShowRowErrors = false;
            this.dgvReferences.Size = new System.Drawing.Size(382, 123);
            this.dgvReferences.TabIndex = 12;
            // 
            // lblReferences
            // 
            this.lblReferences.AutoSize = true;
            this.lblReferences.Location = new System.Drawing.Point(8, 9);
            this.lblReferences.Name = "lblReferences";
            this.lblReferences.Size = new System.Drawing.Size(62, 13);
            this.lblReferences.TabIndex = 11;
            this.lblReferences.Text = "References";
            // 
            // cbReferences
            // 
            this.cbReferences.AllowDrop = true;
            this.cbReferences.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cbReferences.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbReferences.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbReferences.FormattingEnabled = true;
            this.cbReferences.Location = new System.Drawing.Point(92, 6);
            this.cbReferences.MaxDropDownItems = 3;
            this.cbReferences.Name = "cbReferences";
            this.cbReferences.Size = new System.Drawing.Size(294, 21);
            this.cbReferences.TabIndex = 10;
            this.cbReferences.SelectedIndexChanged += new System.EventHandler(this.CbReferencing_SelectedIndexChanged);
            // 
            // SQLHelper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(802, 619);
            this.Controls.Add(this.btnOptions);
            this.Controls.Add(this.lblTabel);
            this.Controls.Add(this.lblDatabase);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cbTableSelector);
            this.Controls.Add(this.cbDBSelector);
            this.Controls.Add(this.scMainSplitter);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(818, 658);
            this.Name = "SQLHelper";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SQL Helper";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.SQLHelper_Load);
            this.scMainSplitter.Panel1.ResumeLayout(false);
            this.scMainSplitter.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scMainSplitter)).EndInit();
            this.scMainSplitter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBaseSource)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.pnlReferencedFrom.ResumeLayout(false);
            this.pnlReferencedFrom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReferencedFrom)).EndInit();
            this.pnelReferencedBy.ResumeLayout(false);
            this.pnelReferencedBy.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReferences)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Extensions_Helpers.DataGridWithFilter dgvBaseSource;
        private System.Windows.Forms.ComboBox cbDBSelector;
        private System.Windows.Forms.ComboBox cbTableSelector;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblDatabase;
        private System.Windows.Forms.Label lblTabel;
        private System.Windows.Forms.Button btnOptions;
        private System.Windows.Forms.SplitContainer scMainSplitter;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel pnlReferencedFrom;
        private System.Windows.Forms.Panel pnelReferencedBy;
        private Extensions_Helpers.DataGridWithFilter dgvReferencedFrom;
        private System.Windows.Forms.Label lblReferencedFrom;
        private System.Windows.Forms.ComboBox cbReferencedFrom;
        private Extensions_Helpers.DataGridWithFilter dgvReferences;
        private System.Windows.Forms.Label lblReferences;
        private System.Windows.Forms.ComboBox cbReferences;
        private System.Windows.Forms.CheckBox btnFindReferences;
    }
}

