﻿using System;
using System.Linq;
using System.IO;
using System.Windows.Forms;
using System.Configuration;

namespace PlaylistSyncer
{
    static class PlaylistSyncer
    {
        private const string _wpl = ".wpl";
        private const string _zpl = ".zpl";        

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

        public static void LoadSettings(MainForm mainForm)
        {
            var zplPath = ConfigurationManager.AppSettings["ZPLPath"];
            var wplPath = ConfigurationManager.AppSettings["WPLPath"];

            var reflectNew = Convert.ToBoolean(ConfigurationManager.AppSettings["ReflectNew"]);
            var deleteMissing = Convert.ToBoolean(ConfigurationManager.AppSettings["DeleteMissing"]);

            mainForm.ZPLPathTextBox.Text = zplPath;
            mainForm.WPLPathTextBox.Text = wplPath;

            mainForm.reflectNewCheckbox.Checked = reflectNew;
            mainForm.deleteMissingCheckbox.Checked = deleteMissing;
        }

        public static void BuildDialogs(MainForm mainForm)
        {
            mainForm.zPLLocationDialog.RootFolder = Environment.SpecialFolder.MyComputer;
            mainForm.zPLLocationDialog.SelectedPath = mainForm.ZPLPathTextBox.Text;
            mainForm.wPLLocationDialog.RootFolder = Environment.SpecialFolder.MyComputer;
            mainForm.wPLLocationDialog.SelectedPath = mainForm.WPLPathTextBox.Text;
        }

        public static void SaveSettings(MainForm mainForm)
        {
            var configFile = ConfigurationManager.OpenExeConfiguration(Application.ExecutablePath);
            var settings = configFile.AppSettings.Settings;

            settings["ZPLPath"].Value = mainForm.ZPLPathTextBox.Text;
            settings["WPLPath"].Value = mainForm.WPLPathTextBox.Text;

            settings["ReflectNew"].Value = mainForm.reflectNewCheckbox.Checked.ToString();
            settings["DeleteMissing"].Value = mainForm.deleteMissingCheckbox.Checked.ToString();

            configFile.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection(configFile.AppSettings.SectionInformation.Name); //Probably Unnecessary
        }

        public static bool CheckExtensionExists(string filePath, string extension)
        {
            bool PlaylistsExist = Directory.Exists(filePath) && Directory.GetFiles(filePath, ("*" + extension)).Any();
            if (!PlaylistsExist) MessageBox.Show("No Playlists with the extension '" + extension +  "' found in this directory. Please Choose a new directory.");
            return PlaylistsExist;
        }

        public static void SyncPlaylists(SyncStyle syncStyle, string zunePlaylistPath, string wplPlaylistPath)
        {
            var zunePlaylists = Directory.GetFiles(zunePlaylistPath, ("*" + _zpl)).Select(x => new FileInfo(x));
            var wplPlaylists = Directory.GetFiles(wplPlaylistPath, ("*" + _wpl)).Select(x => new FileInfo(x));
            //Todo: Check vs Playlist Schema

            var playlistQuery = from zunePlaylist in zunePlaylists
                                let zuneFileName = zunePlaylist.Name.Substring(0, zunePlaylist.Name.IndexOf(_zpl))
                            join wplPlaylist in wplPlaylists
                                on zuneFileName equals wplPlaylist.Name.Substring(0, wplPlaylist.Name.IndexOf(_wpl))
                            into temp
                            from subWplPlaylist in temp.DefaultIfEmpty()
                            select new
                            {
                                fileName = zuneFileName,
                                zuneModifiedTime = (DateTime?)zunePlaylist.LastWriteTime,
                                wplModifiedTime = (subWplPlaylist == null ? (DateTime?)null : subWplPlaylist.LastWriteTime)
                            };

            var playlists = playlistQuery.ToList();

            var excludedWpls = wplPlaylists
                   .Where(x => 
                        !playlists.Select(y => y.fileName).ToList().Contains(x.Name))
                   .Select(x => new
                    {
                        fileName = x.Name.Substring(0, x.Name.IndexOf(_wpl)),
                        zuneModifiedTime = (DateTime?)null,
                        wplModifiedTime = (DateTime?)x.LastWriteTime
                    }).ToList();

            var allPlaylists = playlists.Union(excludedWpls);

            foreach (var playlist in allPlaylists)
            {
                var zuneModifiedLast = playlist.zuneModifiedTime > playlist.wplModifiedTime;
                if (syncStyle == SyncStyle.FromZune
                    || (syncStyle == SyncStyle.FromOther && zuneModifiedLast))
                {
                    //write a new .zpl file in wpl directory
                    var fileToCopyPath = Path.Combine(zunePlaylistPath, playlist.fileName + _zpl);
                    var newZplFile = Path.Combine(wplPlaylistPath, playlist.fileName + _zpl);
                    File.Copy(fileToCopyPath, newZplFile,true);
                }
                else
                {
                    //write new .wpl file in zune directory
                    var fileToCopyPath = Path.Combine(wplPlaylistPath, playlist.fileName + _wpl);
                    var newWplFile = Path.Combine(zunePlaylistPath, playlist.fileName + _wpl);
                    File.Copy(playlist.fileName, newWplFile, true);
                }
            }

        }
    }
}
