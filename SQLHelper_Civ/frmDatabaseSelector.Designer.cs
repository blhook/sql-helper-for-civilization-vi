namespace SQLHelper_Civ
{
    partial class frmDatabaseSelector
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDatabaseSelector));
            this.lblLocalization = new System.Windows.Forms.Label();
            this.lblGameplay = new System.Windows.Forms.Label();
            this.lblConfiguration = new System.Windows.Forms.Label();
            this.chkSave = new System.Windows.Forms.CheckBox();
            this.txtLocalizationPath = new System.Windows.Forms.TextBox();
            this.txtGameplayPath = new System.Windows.Forms.TextBox();
            this.txtConfigurationPath = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnLocalizationSearch = new System.Windows.Forms.Button();
            this.btnGameplaySearch = new System.Windows.Forms.Button();
            this.btnConfigurationSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblLocalization
            // 
            this.lblLocalization.AutoSize = true;
            this.lblLocalization.Location = new System.Drawing.Point(8, 21);
            this.lblLocalization.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLocalization.Name = "lblLocalization";
            this.lblLocalization.Size = new System.Drawing.Size(63, 13);
            this.lblLocalization.TabIndex = 0;
            this.lblLocalization.Text = "Localization";
            // 
            // lblGameplay
            // 
            this.lblGameplay.AutoSize = true;
            this.lblGameplay.Location = new System.Drawing.Point(8, 42);
            this.lblGameplay.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGameplay.Name = "lblGameplay";
            this.lblGameplay.Size = new System.Drawing.Size(54, 13);
            this.lblGameplay.TabIndex = 1;
            this.lblGameplay.Text = "Gameplay";
            // 
            // lblConfiguration
            // 
            this.lblConfiguration.AutoSize = true;
            this.lblConfiguration.Location = new System.Drawing.Point(8, 63);
            this.lblConfiguration.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblConfiguration.Name = "lblConfiguration";
            this.lblConfiguration.Size = new System.Drawing.Size(69, 13);
            this.lblConfiguration.TabIndex = 2;
            this.lblConfiguration.Text = "Configuration";
            // 
            // chkSave
            // 
            this.chkSave.AutoSize = true;
            this.chkSave.Checked = true;
            this.chkSave.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkSave.Location = new System.Drawing.Point(11, 97);
            this.chkSave.Margin = new System.Windows.Forms.Padding(2);
            this.chkSave.Name = "chkSave";
            this.chkSave.Size = new System.Drawing.Size(144, 17);
            this.chkSave.TabIndex = 3;
            this.chkSave.Text = "Save Database Location";
            this.chkSave.UseVisualStyleBackColor = true;
            this.chkSave.Visible = false;
            // 
            // txtLocalizationPath
            // 
            this.txtLocalizationPath.Location = new System.Drawing.Point(81, 19);
            this.txtLocalizationPath.Margin = new System.Windows.Forms.Padding(2);
            this.txtLocalizationPath.Name = "txtLocalizationPath";
            this.txtLocalizationPath.Size = new System.Drawing.Size(207, 20);
            this.txtLocalizationPath.TabIndex = 4;
            this.txtLocalizationPath.TextChanged += new System.EventHandler(this.ValidationTextChanged);
            // 
            // txtGameplayPath
            // 
            this.txtGameplayPath.Location = new System.Drawing.Point(81, 40);
            this.txtGameplayPath.Margin = new System.Windows.Forms.Padding(2);
            this.txtGameplayPath.Name = "txtGameplayPath";
            this.txtGameplayPath.Size = new System.Drawing.Size(207, 20);
            this.txtGameplayPath.TabIndex = 5;
            this.txtGameplayPath.TextChanged += new System.EventHandler(this.ValidationTextChanged);
            // 
            // txtConfigurationPath
            // 
            this.txtConfigurationPath.Location = new System.Drawing.Point(81, 61);
            this.txtConfigurationPath.Margin = new System.Windows.Forms.Padding(2);
            this.txtConfigurationPath.Name = "txtConfigurationPath";
            this.txtConfigurationPath.Size = new System.Drawing.Size(207, 20);
            this.txtConfigurationPath.TabIndex = 6;
            this.txtConfigurationPath.TextChanged += new System.EventHandler(this.ValidationTextChanged);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(354, 9);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(93, 29);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            // 
            // btnLocalizationSearch
            // 
            this.btnLocalizationSearch.Image = global::SQLHelper_Civ.Properties.Resources.FindinFiles_16x;
            this.btnLocalizationSearch.Location = new System.Drawing.Point(304, 18);
            this.btnLocalizationSearch.Margin = new System.Windows.Forms.Padding(2);
            this.btnLocalizationSearch.Name = "btnLocalizationSearch";
            this.btnLocalizationSearch.Size = new System.Drawing.Size(20, 20);
            this.btnLocalizationSearch.TabIndex = 8;
            this.btnLocalizationSearch.UseVisualStyleBackColor = true;
            this.btnLocalizationSearch.Click += new System.EventHandler(this.BtnChangeFileLocation);
            // 
            // btnGameplaySearch
            // 
            this.btnGameplaySearch.Image = global::SQLHelper_Civ.Properties.Resources.FindinFiles_16x;
            this.btnGameplaySearch.Location = new System.Drawing.Point(304, 42);
            this.btnGameplaySearch.Margin = new System.Windows.Forms.Padding(2);
            this.btnGameplaySearch.Name = "btnGameplaySearch";
            this.btnGameplaySearch.Size = new System.Drawing.Size(20, 20);
            this.btnGameplaySearch.TabIndex = 9;
            this.btnGameplaySearch.UseVisualStyleBackColor = true;
            this.btnGameplaySearch.Click += new System.EventHandler(this.BtnChangeFileLocation);
            // 
            // btnConfigurationSearch
            // 
            this.btnConfigurationSearch.Image = global::SQLHelper_Civ.Properties.Resources.FindinFiles_16x;
            this.btnConfigurationSearch.Location = new System.Drawing.Point(304, 66);
            this.btnConfigurationSearch.Margin = new System.Windows.Forms.Padding(2);
            this.btnConfigurationSearch.Name = "btnConfigurationSearch";
            this.btnConfigurationSearch.Size = new System.Drawing.Size(20, 20);
            this.btnConfigurationSearch.TabIndex = 10;
            this.btnConfigurationSearch.UseVisualStyleBackColor = true;
            this.btnConfigurationSearch.Click += new System.EventHandler(this.BtnChangeFileLocation);
            // 
            // frmDatabaseSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 121);
            this.Controls.Add(this.btnConfigurationSearch);
            this.Controls.Add(this.btnGameplaySearch);
            this.Controls.Add(this.btnLocalizationSearch);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtConfigurationPath);
            this.Controls.Add(this.txtGameplayPath);
            this.Controls.Add(this.txtLocalizationPath);
            this.Controls.Add(this.chkSave);
            this.Controls.Add(this.lblConfiguration);
            this.Controls.Add(this.lblGameplay);
            this.Controls.Add(this.lblLocalization);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(472, 160);
            this.MinimumSize = new System.Drawing.Size(472, 160);
            this.Name = "frmDatabaseSelector";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmDatabaseSelector";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmDatabaseSelector_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLocalization;
        private System.Windows.Forms.Label lblGameplay;
        private System.Windows.Forms.Label lblConfiguration;
        private System.Windows.Forms.CheckBox chkSave;
        private System.Windows.Forms.TextBox txtLocalizationPath;
        private System.Windows.Forms.TextBox txtGameplayPath;
        private System.Windows.Forms.TextBox txtConfigurationPath;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btnConfigurationSearch;
        private System.Windows.Forms.Button btnGameplaySearch;
        private System.Windows.Forms.Button btnLocalizationSearch;
    }
}