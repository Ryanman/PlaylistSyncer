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
            this.SuspendLayout();
            // 
            // ZPLPlaylistBrowse
            // 
            this.ZPLPlaylistBrowse.Location = new System.Drawing.Point(10, 75);
            this.ZPLPlaylistBrowse.Name = "ZPLPlaylistBrowse";
            this.ZPLPlaylistBrowse.Size = new System.Drawing.Size(75, 25);
            this.ZPLPlaylistBrowse.TabIndex = 0;
            this.ZPLPlaylistBrowse.Text = "Browse...";
            this.ZPLPlaylistBrowse.UseVisualStyleBackColor = true;
            this.ZPLPlaylistBrowse.Click += new System.EventHandler(this.ZPLPlaylistBrowse_Click);
            // 
            // WMPPlaylistBrowse
            // 
            this.WMPPlaylistBrowse.Location = new System.Drawing.Point(410, 75);
            this.WMPPlaylistBrowse.Name = "WMPPlaylistBrowse";
            this.WMPPlaylistBrowse.Size = new System.Drawing.Size(75, 25);
            this.WMPPlaylistBrowse.TabIndex = 1;
            this.WMPPlaylistBrowse.Text = "Browse...";
            this.WMPPlaylistBrowse.UseVisualStyleBackColor = true;
            this.WMPPlaylistBrowse.Click += new System.EventHandler(this.WMPPlaylistBrowse_Click);
            // 
            // ZPLPathTextBox
            // 
            this.ZPLPathTextBox.Location = new System.Drawing.Point(13, 47);
            this.ZPLPathTextBox.Name = "ZPLPathTextBox";
            this.ZPLPathTextBox.Size = new System.Drawing.Size(350, 22);
            this.ZPLPathTextBox.TabIndex = 2;
            // 
            // WPLPathTextBox
            // 
            this.WPLPathTextBox.Location = new System.Drawing.Point(410, 47);
            this.WPLPathTextBox.Name = "WPLPathTextBox";
            this.WPLPathTextBox.Size = new System.Drawing.Size(350, 22);
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
            this.syncButton.Location = new System.Drawing.Point(600, 275);
            this.syncButton.Name = "syncButton";
            this.syncButton.Size = new System.Drawing.Size(150, 150);
            this.syncButton.TabIndex = 4;
            this.syncButton.Text = "Sync!";
            this.syncButton.UseVisualStyleBackColor = true;
            this.syncButton.Click += new System.EventHandler(this.syncButton_Click);
            // 
            // wplLabel
            // 
            this.wplLabel.AutoSize = true;
            this.wplLabel.Location = new System.Drawing.Point(410, 24);
            this.wplLabel.Name = "wplLabel";
            this.wplLabel.Size = new System.Drawing.Size(145, 17);
            this.wplLabel.TabIndex = 5;
            this.wplLabel.Text = "Location of WPL Files";
            // 
            // zPLLabel
            // 
            this.zPLLabel.AutoSize = true;
            this.zPLLabel.Location = new System.Drawing.Point(10, 24);
            this.zPLLabel.Name = "zPLLabel";
            this.zPLLabel.Size = new System.Drawing.Size(148, 17);
            this.zPLLabel.TabIndex = 6;
            this.zPLLabel.Text = "Location of Zune Files";
            // 
            // playlistSyncerMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 453);
            this.Controls.Add(this.zPLLabel);
            this.Controls.Add(this.wplLabel);
            this.Controls.Add(this.syncButton);
            this.Controls.Add(this.WPLPathTextBox);
            this.Controls.Add(this.ZPLPathTextBox);
            this.Controls.Add(this.WMPPlaylistBrowse);
            this.Controls.Add(this.ZPLPlaylistBrowse);
            this.Name = "playlistSyncerMainForm";
            this.Text = "PlaylistSyncer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ZPLPlaylistBrowse;
        private System.Windows.Forms.Button WMPPlaylistBrowse;
        private System.Windows.Forms.TextBox ZPLPathTextBox;
        private System.Windows.Forms.TextBox WPLPathTextBox;
        private System.Windows.Forms.FolderBrowserDialog zPLLocationDialog;
        private System.Windows.Forms.FolderBrowserDialog wPLLocationDialog;
        private System.Windows.Forms.Button syncButton;
        private System.Windows.Forms.Label wplLabel;
        private System.Windows.Forms.Label zPLLabel;
    }
}

