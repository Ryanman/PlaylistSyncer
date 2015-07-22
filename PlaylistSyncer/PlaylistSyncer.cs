using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlaylistSyncer
{
    static class PlaylistSyncer
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }

        public static bool CheckExtensionExists(string filePath, string extension)
        {

            bool PlaylistsExist = Directory.GetFiles(filePath, ("*" + extension)).Length != 0;
            if (!PlaylistsExist) MessageBox.Show("No Windows Media Playlists Found. Please Choose a new directory.");
            return PlaylistsExist;
        }
    }
}
