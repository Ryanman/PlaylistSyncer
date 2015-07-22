namespace PlaylistSyncer
{
    partial class SettingsForm
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
            this.fromZuneRadio = new System.Windows.Forms.RadioButton();
            this.fromOtherRadio = new System.Windows.Forms.RadioButton();
            this.latestRadio = new System.Windows.Forms.RadioButton();
            this.reflectNewCheckbox = new System.Windows.Forms.CheckBox();
            this.deleteMissingCheckbox = new System.Windows.Forms.CheckBox();
            this.helpButton = new System.Windows.Forms.Button();
            this.syncStyleGroup = new System.Windows.Forms.GroupBox();
            this.addtlOptionsGroup = new System.Windows.Forms.GroupBox();
            this.syncStyleGroup.SuspendLayout();
            this.addtlOptionsGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // fromZuneRadio
            // 
            this.fromZuneRadio.AutoSize = true;
            this.fromZuneRadio.Checked = true;
            this.fromZuneRadio.Location = new System.Drawing.Point(19, 54);
            this.fromZuneRadio.Name = "fromZuneRadio";
            this.fromZuneRadio.Size = new System.Drawing.Size(119, 21);
            this.fromZuneRadio.TabIndex = 1;
            this.fromZuneRadio.TabStop = true;
            this.fromZuneRadio.Text = "Zune -> Other";
            this.fromZuneRadio.UseVisualStyleBackColor = true;
            // 
            // fromOtherRadio
            // 
            this.fromOtherRadio.AutoSize = true;
            this.fromOtherRadio.Location = new System.Drawing.Point(19, 104);
            this.fromOtherRadio.Name = "fromOtherRadio";
            this.fromOtherRadio.Size = new System.Drawing.Size(119, 21);
            this.fromOtherRadio.TabIndex = 2;
            this.fromOtherRadio.Text = "Other -> Zune";
            this.fromOtherRadio.UseVisualStyleBackColor = true;
            // 
            // latestRadio
            // 
            this.latestRadio.AutoSize = true;
            this.latestRadio.Location = new System.Drawing.Point(19, 154);
            this.latestRadio.Name = "latestRadio";
            this.latestRadio.Size = new System.Drawing.Size(109, 21);
            this.latestRadio.TabIndex = 3;
            this.latestRadio.Text = "Latest Mirror";
            this.latestRadio.UseVisualStyleBackColor = true;
            // 
            // reflectNewCheckbox
            // 
            this.reflectNewCheckbox.AutoSize = true;
            this.reflectNewCheckbox.Location = new System.Drawing.Point(15, 54);
            this.reflectNewCheckbox.Name = "reflectNewCheckbox";
            this.reflectNewCheckbox.Size = new System.Drawing.Size(105, 21);
            this.reflectNewCheckbox.TabIndex = 5;
            this.reflectNewCheckbox.Text = "Reflect New";
            this.reflectNewCheckbox.UseVisualStyleBackColor = true;
            // 
            // deleteMissingCheckbox
            // 
            this.deleteMissingCheckbox.AutoSize = true;
            this.deleteMissingCheckbox.Checked = true;
            this.deleteMissingCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.deleteMissingCheckbox.Location = new System.Drawing.Point(15, 103);
            this.deleteMissingCheckbox.Name = "deleteMissingCheckbox";
            this.deleteMissingCheckbox.Size = new System.Drawing.Size(122, 21);
            this.deleteMissingCheckbox.TabIndex = 6;
            this.deleteMissingCheckbox.Text = "Delete Missing";
            this.deleteMissingCheckbox.UseVisualStyleBackColor = true;
            // 
            // helpButton
            // 
            this.helpButton.Location = new System.Drawing.Point(12, 256);
            this.helpButton.Name = "helpButton";
            this.helpButton.Size = new System.Drawing.Size(100, 35);
            this.helpButton.TabIndex = 7;
            this.helpButton.Text = "Help";
            this.helpButton.UseVisualStyleBackColor = true;
            // 
            // syncStyleGroup
            // 
            this.syncStyleGroup.Controls.Add(this.fromZuneRadio);
            this.syncStyleGroup.Controls.Add(this.fromOtherRadio);
            this.syncStyleGroup.Controls.Add(this.latestRadio);
            this.syncStyleGroup.Location = new System.Drawing.Point(12, 12);
            this.syncStyleGroup.Name = "syncStyleGroup";
            this.syncStyleGroup.Size = new System.Drawing.Size(200, 205);
            this.syncStyleGroup.TabIndex = 8;
            this.syncStyleGroup.TabStop = false;
            this.syncStyleGroup.Text = "Sync Style";
            // 
            // addtlOptionsGroup
            // 
            this.addtlOptionsGroup.Controls.Add(this.reflectNewCheckbox);
            this.addtlOptionsGroup.Controls.Add(this.deleteMissingCheckbox);
            this.addtlOptionsGroup.Location = new System.Drawing.Point(218, 12);
            this.addtlOptionsGroup.Name = "addtlOptionsGroup";
            this.addtlOptionsGroup.Size = new System.Drawing.Size(200, 205);
            this.addtlOptionsGroup.TabIndex = 9;
            this.addtlOptionsGroup.TabStop = false;
            this.addtlOptionsGroup.Text = "Additional Options";
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 303);
            this.Controls.Add(this.addtlOptionsGroup);
            this.Controls.Add(this.syncStyleGroup);
            this.Controls.Add(this.helpButton);
            this.Name = "SettingsForm";
            this.Text = "SettingsForm";
            this.syncStyleGroup.ResumeLayout(false);
            this.syncStyleGroup.PerformLayout();
            this.addtlOptionsGroup.ResumeLayout(false);
            this.addtlOptionsGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton fromZuneRadio;
        private System.Windows.Forms.RadioButton fromOtherRadio;
        private System.Windows.Forms.RadioButton latestRadio;
        private System.Windows.Forms.CheckBox reflectNewCheckbox;
        private System.Windows.Forms.CheckBox deleteMissingCheckbox;
        private System.Windows.Forms.Button helpButton;
        private System.Windows.Forms.GroupBox syncStyleGroup;
        private System.Windows.Forms.GroupBox addtlOptionsGroup;
    }
}