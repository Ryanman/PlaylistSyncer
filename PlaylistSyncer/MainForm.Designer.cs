namespace PlaylistSyncer
{
    partial class MainForm
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
            this.ZPLPlaylistBrowse = new System.Windows.Forms.Button();
            this.WMPPlaylistBrowse = new System.Windows.Forms.Button();
            this.ZPLPathTextBox = new System.Windows.Forms.TextBox();
            this.WPLPathTextBox = new System.Windows.Forms.TextBox();
            this.zPLLocationDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.wPLLocationDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.syncButton = new System.Windows.Forms.Button();
            this.wplLabel = new System.Windows.Forms.Label();
            this.zPLLabel = new System.Windows.Forms.Label();
            this.addtlOptionsGroup = new System.Windows.Forms.GroupBox();
            this.reflectNewCheckbox = new System.Windows.Forms.CheckBox();
            this.deleteMissingCheckbox = new System.Windows.Forms.CheckBox();
            this.syncStyleGroup = new System.Windows.Forms.GroupBox();
            this.fromZuneRadio = new System.Windows.Forms.RadioButton();
            this.fromOtherRadio = new System.Windows.Forms.RadioButton();
            this.latestRadio = new System.Windows.Forms.RadioButton();
            this.helpButton = new System.Windows.Forms.Button();
            this.addtlOptionsGroup.SuspendLayout();
            this.syncStyleGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // ZPLPlaylistBrowse
            // 
            this.ZPLPlaylistBrowse.Location = new System.Drawing.Point(8, 61);
            this.ZPLPlaylistBrowse.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ZPLPlaylistBrowse.Name = "ZPLPlaylistBrowse";
            this.ZPLPlaylistBrowse.Size = new System.Drawing.Size(56, 20);
            this.ZPLPlaylistBrowse.TabIndex = 0;
            this.ZPLPlaylistBrowse.Text = "Browse...";
            this.ZPLPlaylistBrowse.UseVisualStyleBackColor = true;
            this.ZPLPlaylistBrowse.Click += new System.EventHandler(this.ZPLPlaylistBrowse_Click);
            // 
            // WMPPlaylistBrowse
            // 
            this.WMPPlaylistBrowse.Location = new System.Drawing.Point(308, 61);
            this.WMPPlaylistBrowse.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.WMPPlaylistBrowse.Name = "WMPPlaylistBrowse";
            this.WMPPlaylistBrowse.Size = new System.Drawing.Size(56, 20);
            this.WMPPlaylistBrowse.TabIndex = 1;
            this.WMPPlaylistBrowse.Text = "Browse...";
            this.WMPPlaylistBrowse.UseVisualStyleBackColor = true;
            this.WMPPlaylistBrowse.Click += new System.EventHandler(this.WMPPlaylistBrowse_Click);
            // 
            // ZPLPathTextBox
            // 
            this.ZPLPathTextBox.Location = new System.Drawing.Point(10, 38);
            this.ZPLPathTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ZPLPathTextBox.Name = "ZPLPathTextBox";
            this.ZPLPathTextBox.Size = new System.Drawing.Size(264, 20);
            this.ZPLPathTextBox.TabIndex = 2;
            // 
            // WPLPathTextBox
            // 
            this.WPLPathTextBox.Location = new System.Drawing.Point(308, 38);
            this.WPLPathTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.WPLPathTextBox.Name = "WPLPathTextBox";
            this.WPLPathTextBox.Size = new System.Drawing.Size(264, 20);
            this.WPLPathTextBox.TabIndex = 3;
            // 
            // zPLLocationDialog
            // 
            this.zPLLocationDialog.Description = "Location of Zune Playlists";
            this.zPLLocationDialog.RootFolder = System.Environment.SpecialFolder.MyMusic;
            this.zPLLocationDialog.SelectedPath = global::PlaylistSyncer.Properties.Settings.Default.ZPLPath;
            // 
            // wPLLocationDialog
            // 
            this.wPLLocationDialog.Description = "Location of Windows Playlists";
            this.wPLLocationDialog.RootFolder = System.Environment.SpecialFolder.MyMusic;
            this.wPLLocationDialog.SelectedPath = global::PlaylistSyncer.Properties.Settings.Default.WPLPath;
            // 
            // syncButton
            // 
            this.syncButton.Location = new System.Drawing.Point(435, 130);
            this.syncButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.syncButton.Name = "syncButton";
            this.syncButton.Size = new System.Drawing.Size(112, 122);
            this.syncButton.TabIndex = 4;
            this.syncButton.Text = "Sync!";
            this.syncButton.UseVisualStyleBackColor = true;
            this.syncButton.Click += new System.EventHandler(this.syncButton_Click);
            // 
            // wplLabel
            // 
            this.wplLabel.AutoSize = true;
            this.wplLabel.Location = new System.Drawing.Point(308, 20);
            this.wplLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.wplLabel.Name = "wplLabel";
            this.wplLabel.Size = new System.Drawing.Size(111, 13);
            this.wplLabel.TabIndex = 5;
            this.wplLabel.Text = "Location of WPL Files";
            // 
            // zPLLabel
            // 
            this.zPLLabel.AutoSize = true;
            this.zPLLabel.Location = new System.Drawing.Point(8, 20);
            this.zPLLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.zPLLabel.Name = "zPLLabel";
            this.zPLLabel.Size = new System.Drawing.Size(112, 13);
            this.zPLLabel.TabIndex = 6;
            this.zPLLabel.Text = "Location of Zune Files";
            // 
            // addtlOptionsGroup
            // 
            this.addtlOptionsGroup.Controls.Add(this.reflectNewCheckbox);
            this.addtlOptionsGroup.Controls.Add(this.deleteMissingCheckbox);
            this.addtlOptionsGroup.Location = new System.Drawing.Point(214, 130);
            this.addtlOptionsGroup.Margin = new System.Windows.Forms.Padding(2);
            this.addtlOptionsGroup.Name = "addtlOptionsGroup";
            this.addtlOptionsGroup.Padding = new System.Windows.Forms.Padding(2);
            this.addtlOptionsGroup.Size = new System.Drawing.Size(150, 167);
            this.addtlOptionsGroup.TabIndex = 10;
            this.addtlOptionsGroup.TabStop = false;
            this.addtlOptionsGroup.Text = "Additional Options";
            // 
            // reflectNewCheckbox
            // 
            this.reflectNewCheckbox.AutoSize = true;
            this.reflectNewCheckbox.Location = new System.Drawing.Point(11, 44);
            this.reflectNewCheckbox.Margin = new System.Windows.Forms.Padding(2);
            this.reflectNewCheckbox.Name = "reflectNewCheckbox";
            this.reflectNewCheckbox.Size = new System.Drawing.Size(85, 17);
            this.reflectNewCheckbox.TabIndex = 5;
            this.reflectNewCheckbox.Text = "Reflect New";
            this.reflectNewCheckbox.UseVisualStyleBackColor = true;
            // 
            // deleteMissingCheckbox
            // 
            this.deleteMissingCheckbox.AutoSize = true;
            this.deleteMissingCheckbox.Checked = true;
            this.deleteMissingCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.deleteMissingCheckbox.Location = new System.Drawing.Point(11, 84);
            this.deleteMissingCheckbox.Margin = new System.Windows.Forms.Padding(2);
            this.deleteMissingCheckbox.Name = "deleteMissingCheckbox";
            this.deleteMissingCheckbox.Size = new System.Drawing.Size(95, 17);
            this.deleteMissingCheckbox.TabIndex = 6;
            this.deleteMissingCheckbox.Text = "Delete Missing";
            this.deleteMissingCheckbox.UseVisualStyleBackColor = true;
            // 
            // syncStyleGroup
            // 
            this.syncStyleGroup.Controls.Add(this.fromZuneRadio);
            this.syncStyleGroup.Controls.Add(this.fromOtherRadio);
            this.syncStyleGroup.Controls.Add(this.latestRadio);
            this.syncStyleGroup.Location = new System.Drawing.Point(11, 130);
            this.syncStyleGroup.Margin = new System.Windows.Forms.Padding(2);
            this.syncStyleGroup.Name = "syncStyleGroup";
            this.syncStyleGroup.Padding = new System.Windows.Forms.Padding(2);
            this.syncStyleGroup.Size = new System.Drawing.Size(150, 167);
            this.syncStyleGroup.TabIndex = 9;
            this.syncStyleGroup.TabStop = false;
            this.syncStyleGroup.Text = "Sync Style";
            // 
            // fromZuneRadio
            // 
            this.fromZuneRadio.AutoSize = true;
            this.fromZuneRadio.Checked = true;
            this.fromZuneRadio.Location = new System.Drawing.Point(14, 44);
            this.fromZuneRadio.Margin = new System.Windows.Forms.Padding(2);
            this.fromZuneRadio.Name = "fromZuneRadio";
            this.fromZuneRadio.Size = new System.Drawing.Size(91, 17);
            this.fromZuneRadio.TabIndex = 1;
            this.fromZuneRadio.TabStop = true;
            this.fromZuneRadio.Text = "Zune -> Other";
            this.fromZuneRadio.UseVisualStyleBackColor = true;
            // 
            // fromOtherRadio
            // 
            this.fromOtherRadio.AutoSize = true;
            this.fromOtherRadio.Location = new System.Drawing.Point(14, 84);
            this.fromOtherRadio.Margin = new System.Windows.Forms.Padding(2);
            this.fromOtherRadio.Name = "fromOtherRadio";
            this.fromOtherRadio.Size = new System.Drawing.Size(91, 17);
            this.fromOtherRadio.TabIndex = 2;
            this.fromOtherRadio.Text = "Other -> Zune";
            this.fromOtherRadio.UseVisualStyleBackColor = true;
            // 
            // latestRadio
            // 
            this.latestRadio.AutoSize = true;
            this.latestRadio.Location = new System.Drawing.Point(14, 125);
            this.latestRadio.Margin = new System.Windows.Forms.Padding(2);
            this.latestRadio.Name = "latestRadio";
            this.latestRadio.Size = new System.Drawing.Size(83, 17);
            this.latestRadio.TabIndex = 3;
            this.latestRadio.Text = "Latest Mirror";
            this.latestRadio.UseVisualStyleBackColor = true;
            // 
            // helpButton
            // 
            this.helpButton.Location = new System.Drawing.Point(472, 329);
            this.helpButton.Margin = new System.Windows.Forms.Padding(2);
            this.helpButton.Name = "helpButton";
            this.helpButton.Size = new System.Drawing.Size(75, 28);
            this.helpButton.TabIndex = 11;
            this.helpButton.Text = "Help";
            this.helpButton.UseVisualStyleBackColor = true;
            this.helpButton.Click += new System.EventHandler(this.helpButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 368);
            this.Controls.Add(this.helpButton);
            this.Controls.Add(this.syncStyleGroup);
            this.Controls.Add(this.addtlOptionsGroup);
            this.Controls.Add(this.zPLLabel);
            this.Controls.Add(this.wplLabel);
            this.Controls.Add(this.syncButton);
            this.Controls.Add(this.WPLPathTextBox);
            this.Controls.Add(this.ZPLPathTextBox);
            this.Controls.Add(this.WMPPlaylistBrowse);
            this.Controls.Add(this.ZPLPlaylistBrowse);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MainForm";
            this.Text = "PlaylistSyncer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.addtlOptionsGroup.ResumeLayout(false);
            this.addtlOptionsGroup.PerformLayout();
            this.syncStyleGroup.ResumeLayout(false);
            this.syncStyleGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ZPLPlaylistBrowse;
        private System.Windows.Forms.Button WMPPlaylistBrowse;
        public System.Windows.Forms.TextBox ZPLPathTextBox;
        public System.Windows.Forms.TextBox WPLPathTextBox;
        private System.Windows.Forms.FolderBrowserDialog zPLLocationDialog;
        private System.Windows.Forms.FolderBrowserDialog wPLLocationDialog;
        private System.Windows.Forms.Button syncButton;
        private System.Windows.Forms.Label wplLabel;
        private System.Windows.Forms.Label zPLLabel;
        private System.Windows.Forms.GroupBox addtlOptionsGroup;
        public System.Windows.Forms.CheckBox reflectNewCheckbox;
        public System.Windows.Forms.CheckBox deleteMissingCheckbox;
        private System.Windows.Forms.GroupBox syncStyleGroup;
        private System.Windows.Forms.RadioButton fromZuneRadio;
        private System.Windows.Forms.RadioButton fromOtherRadio;
        private System.Windows.Forms.RadioButton latestRadio;
        private System.Windows.Forms.Button helpButton;
    }
}

