namespace SQLHelper_Civ
{
    partial class frmOptions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOptions));
            this.btnSave = new System.Windows.Forms.Button();
            this.chkReferenceForced = new System.Windows.Forms.CheckBox();
            this.chkColumnAppend = new System.Windows.Forms.CheckBox();
            this.chkReferenceSuggest = new System.Windows.Forms.CheckBox();
            this.chkCrossDatabase = new System.Windows.Forms.CheckBox();
            this.cbLanguageSelector = new System.Windows.Forms.ComboBox();
            this.lblLanguage = new System.Windows.Forms.Label();
            this.linkAbout = new System.Windows.Forms.LinkLabel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.grpSaveOptions = new System.Windows.Forms.GroupBox();
            this.grpFilterOptions = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rdoInsert = new System.Windows.Forms.RadioButton();
            this.rdoIgnore = new System.Windows.Forms.RadioButton();
            this.rdoReplace = new System.Windows.Forms.RadioButton();
            this.grpSaveOptions.SuspendLayout();
            this.grpFilterOptions.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(441, 9);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(93, 29);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // chkReferenceForced
            // 
            this.chkReferenceForced.AutoSize = true;
            this.chkReferenceForced.Checked = true;
            this.chkReferenceForced.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkReferenceForced.Location = new System.Drawing.Point(16, 42);
            this.chkReferenceForced.Name = "chkReferenceForced";
            this.chkReferenceForced.Size = new System.Drawing.Size(131, 17);
            this.chkReferenceForced.TabIndex = 11;
            this.chkReferenceForced.Text = "Reference Adherence";
            this.toolTip1.SetToolTip(this.chkReferenceForced, "Forces the selection to be a value from the FK. As in, no typing own entries will" +
        " be allowed.\r\nIf you experience a lag between selecting comboboxes, turn this of" +
        "f for a speed increase.");
            this.chkReferenceForced.UseVisualStyleBackColor = true;
            // 
            // chkColumnAppend
            // 
            this.chkColumnAppend.AutoSize = true;
            this.chkColumnAppend.Checked = true;
            this.chkColumnAppend.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkColumnAppend.Location = new System.Drawing.Point(16, 19);
            this.chkColumnAppend.Name = "chkColumnAppend";
            this.chkColumnAppend.Size = new System.Drawing.Size(103, 17);
            this.chkColumnAppend.TabIndex = 10;
            this.chkColumnAppend.Text = "Column Suggest";
            this.toolTip1.SetToolTip(this.chkColumnAppend, "Enables suggestions based on other values in the column. Won\'t work if References" +
        " are Required, or there is only one PK in the table.\r\nTurn off to slightly impro" +
        "ve performance.");
            this.chkColumnAppend.UseVisualStyleBackColor = true;
            // 
            // chkReferenceSuggest
            // 
            this.chkReferenceSuggest.AutoSize = true;
            this.chkReferenceSuggest.Location = new System.Drawing.Point(16, 64);
            this.chkReferenceSuggest.Name = "chkReferenceSuggest";
            this.chkReferenceSuggest.Size = new System.Drawing.Size(118, 17);
            this.chkReferenceSuggest.TabIndex = 12;
            this.chkReferenceSuggest.Text = "Reference Suggest";
            this.toolTip1.SetToolTip(this.chkReferenceSuggest, "Suggests contents based on the values in the Foreign Fields.\r\nTurn off to improve" +
        " memory and performance.");
            this.chkReferenceSuggest.UseVisualStyleBackColor = true;
            // 
            // chkCrossDatabase
            // 
            this.chkCrossDatabase.AutoSize = true;
            this.chkCrossDatabase.Checked = true;
            this.chkCrossDatabase.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkCrossDatabase.Location = new System.Drawing.Point(16, 86);
            this.chkCrossDatabase.Name = "chkCrossDatabase";
            this.chkCrossDatabase.Size = new System.Drawing.Size(101, 17);
            this.chkCrossDatabase.TabIndex = 13;
            this.chkCrossDatabase.Text = "Cross Database";
            this.toolTip1.SetToolTip(this.chkCrossDatabase, resources.GetString("chkCrossDatabase.ToolTip"));
            this.chkCrossDatabase.UseVisualStyleBackColor = true;
            // 
            // cbLanguageSelector
            // 
            this.cbLanguageSelector.AllowDrop = true;
            this.cbLanguageSelector.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cbLanguageSelector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLanguageSelector.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbLanguageSelector.FormattingEnabled = true;
            this.cbLanguageSelector.Location = new System.Drawing.Point(110, 108);
            this.cbLanguageSelector.MaxDropDownItems = 3;
            this.cbLanguageSelector.Name = "cbLanguageSelector";
            this.cbLanguageSelector.Size = new System.Drawing.Size(89, 21);
            this.cbLanguageSelector.TabIndex = 14;
            this.toolTip1.SetToolTip(this.cbLanguageSelector, "Narrows the selection of the LocalizationText table by the language selected. Hig" +
        "hly suggested to keep limited to one language to keep performance reasonable.");
            // 
            // lblLanguage
            // 
            this.lblLanguage.AutoSize = true;
            this.lblLanguage.Location = new System.Drawing.Point(13, 110);
            this.lblLanguage.Name = "lblLanguage";
            this.lblLanguage.Size = new System.Drawing.Size(92, 13);
            this.lblLanguage.TabIndex = 15;
            this.lblLanguage.Text = "Default Language";
            // 
            // linkAbout
            // 
            this.linkAbout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.linkAbout.AutoSize = true;
            this.linkAbout.Location = new System.Drawing.Point(499, 163);
            this.linkAbout.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkAbout.Name = "linkAbout";
            this.linkAbout.Size = new System.Drawing.Size(35, 13);
            this.linkAbout.TabIndex = 17;
            this.linkAbout.TabStop = true;
            this.linkAbout.Text = "About";
            this.linkAbout.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkAbout_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(25, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Some changes may require a restart to be effective.";
            // 
            // grpSaveOptions
            // 
            this.grpSaveOptions.Controls.Add(this.panel1);
            this.grpSaveOptions.Location = new System.Drawing.Point(229, 12);
            this.grpSaveOptions.Name = "grpSaveOptions";
            this.grpSaveOptions.Size = new System.Drawing.Size(198, 136);
            this.grpSaveOptions.TabIndex = 19;
            this.grpSaveOptions.TabStop = false;
            this.grpSaveOptions.Text = "SQL Generation";
            // 
            // grpFilterOptions
            // 
            this.grpFilterOptions.Controls.Add(this.chkColumnAppend);
            this.grpFilterOptions.Controls.Add(this.chkReferenceForced);
            this.grpFilterOptions.Controls.Add(this.chkReferenceSuggest);
            this.grpFilterOptions.Controls.Add(this.chkCrossDatabase);
            this.grpFilterOptions.Controls.Add(this.lblLanguage);
            this.grpFilterOptions.Controls.Add(this.cbLanguageSelector);
            this.grpFilterOptions.Location = new System.Drawing.Point(12, 12);
            this.grpFilterOptions.Name = "grpFilterOptions";
            this.grpFilterOptions.Size = new System.Drawing.Size(211, 136);
            this.grpFilterOptions.TabIndex = 20;
            this.grpFilterOptions.TabStop = false;
            this.grpFilterOptions.Text = "Filter Options";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rdoReplace);
            this.panel1.Controls.Add(this.rdoIgnore);
            this.panel1.Controls.Add(this.rdoInsert);
            this.panel1.Location = new System.Drawing.Point(6, 19);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(149, 81);
            this.panel1.TabIndex = 0;
            // 
            // rdoInsert
            // 
            this.rdoInsert.AutoSize = true;
            this.rdoInsert.Checked = true;
            this.rdoInsert.Location = new System.Drawing.Point(3, 3);
            this.rdoInsert.Name = "rdoInsert";
            this.rdoInsert.Size = new System.Drawing.Size(65, 17);
            this.rdoInsert.TabIndex = 15;
            this.rdoInsert.TabStop = true;
            this.rdoInsert.Text = "INSERT";
            this.rdoInsert.UseVisualStyleBackColor = true;
            // 
            // rdoIgnore
            // 
            this.rdoIgnore.AutoSize = true;
            this.rdoIgnore.Location = new System.Drawing.Point(3, 26);
            this.rdoIgnore.Name = "rdoIgnore";
            this.rdoIgnore.Size = new System.Drawing.Size(129, 17);
            this.rdoIgnore.TabIndex = 16;
            this.rdoIgnore.Text = "INSERT OR IGNORE";
            this.rdoIgnore.UseVisualStyleBackColor = true;
            // 
            // rdoReplace
            // 
            this.rdoReplace.AutoSize = true;
            this.rdoReplace.Location = new System.Drawing.Point(3, 49);
            this.rdoReplace.Name = "rdoReplace";
            this.rdoReplace.Size = new System.Drawing.Size(136, 17);
            this.rdoReplace.TabIndex = 17;
            this.rdoReplace.Text = "INSERT OR REPLACE";
            this.rdoReplace.UseVisualStyleBackColor = true;
            // 
            // frmOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 185);
            this.Controls.Add(this.grpFilterOptions);
            this.Controls.Add(this.grpSaveOptions);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.linkAbout);
            this.Controls.Add(this.btnSave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(551, 204);
            this.Name = "frmOptions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Options";
            this.grpSaveOptions.ResumeLayout(false);
            this.grpFilterOptions.ResumeLayout(false);
            this.grpFilterOptions.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.CheckBox chkReferenceForced;
        private System.Windows.Forms.CheckBox chkColumnAppend;
        private System.Windows.Forms.CheckBox chkReferenceSuggest;
        private System.Windows.Forms.CheckBox chkCrossDatabase;
        private System.Windows.Forms.ComboBox cbLanguageSelector;
        private System.Windows.Forms.Label lblLanguage;
        private System.Windows.Forms.LinkLabel linkAbout;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpSaveOptions;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox grpFilterOptions;
        private System.Windows.Forms.RadioButton rdoInsert;
        private System.Windows.Forms.RadioButton rdoReplace;
        private System.Windows.Forms.RadioButton rdoIgnore;
    }
}