using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace PlaylistSyncer
{
    public partial class MainForm : Form
    {
        //private playlistSyncer playlistSyncer;
        private bool wplExists;
        private bool zplExists;

        public MainForm()
        {
            InitializeComponent();
            syncButton.BackColor = Color.ForestGreen;
            //Load Settings
            PlaylistSyncer.LoadSettings(this);

            zplExists = PlaylistSyncer.CheckExtensionExists(ZPLPathTextBox.Text, ".zpl");
            wplExists = PlaylistSyncer.CheckExtensionExists(WPLPathTextBox.Text, ".wpl");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ZPLPlaylistBrowse_Click(object sender, EventArgs e)
        {
            DialogResult result = zPLLocationDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                string ZPLLocation = zPLLocationDialog.SelectedPath;
                //check for .zpl files
                zplExists = PlaylistSyncer.CheckExtensionExists(ZPLLocation, ".zpl");
                if (zplExists) ZPLPathTextBox.Text = ZPLLocation;
            }
            else
            {
            }
        }

        private void WMPPlaylistBrowse_Click(object sender, EventArgs e)
        {
            DialogResult result = wPLLocationDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                string WPLLocation = wPLLocationDialog.SelectedPath;
                //check for .WPL files
                wplExists = PlaylistSyncer.CheckExtensionExists(WPLLocation,".wpl");
                if (wplExists) WPLPathTextBox.Text = WPLLocation;
            }
            else
            {
            }
        }

        private void syncButton_Click(object sender, EventArgs e)
        {
            PlaylistSyncer.SaveSettings(this);
            if (zplExists && wplExists)
            {
                var syncStyle = syncStyleGroup.Controls.OfType<RadioButton>().Single(x => x.Checked);
                PlaylistSyncer.SyncPlaylists(syncStyle, ZPLPathTextBox.Text,WPLPathTextBox.Text);                
            }
            else
            {
                MessageBox.Show("Unable to Sync - files not found in directories");
            }
        }

        private void helpButton_Click(object sender, EventArgs e)
        {
            var helpForm = new HelpForm();
            helpForm.Show();
        }
    }
}
