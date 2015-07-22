using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PlaylistSyncer;

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
            if (zplExists && wplExists) //should be based on setttings
            {
                MessageBox.Show ("They're both there!");
            }
            else
            {
                MessageBox.Show("Unable to Sync - files not found in directories");
            }
        }
    }
}
