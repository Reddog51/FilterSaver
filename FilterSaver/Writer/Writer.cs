using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.DirectoryServices.AccountManagement;
using Microsoft.Win32;
using FilterSaver.Properties;
using static System.Windows.Forms.Control;
using System.Security.Principal;
using Newtonsoft.Json;

namespace FilterSaver.Writer
{
    public class Writer
    {
        public Writer() { }
        private string NewFilter = string.Empty;

        public bool WriteSavedFiltersToDisk(GroupBox gb)
        {
            string SavedFilterNames = "savedFilters.Json";
            bool bRet = false;
            ControlCollection cc1 = gb.Parent.Controls;
            var qq = cc1["lbSavedBongoFilters"];
            ListBox lb = (ListBox)cc1["lbSavedBongoFilters"];

            List<string> FilterNames = (List<string>)lb.DataSource;
            string folder = GetUserAppDataLocalRoamingFolder(UserPrincipal.Current.Sid.ToString());
            SavedFilterNames = folder + SavedFilterNames;
            int FilterCount = lb.Items.Count;
            int ItemWriteCounter = 0;

            List<SavedFilter> lFiltersToSave = new List<SavedFilter>();
            TextBox tbaddfilter = (TextBox)cc1["tbaddfilter"];
            SavedFilter fName = new SavedFilter { name = tbaddfilter.Text, value = "List" };
            FilterNames.Add(tbaddfilter.Text);
            lb.DataSource = FilterNames;
            lFiltersToSave.Add(fName);
            System.Windows.Forms.Control.ControlCollection cc = gb.Controls;
            foreach (Control c in cc)
            {
                Type type = c.GetType();
                System.Diagnostics.Debug.Write("inside for each control in the group");
                switch (type.Name.ToLower())
                {

                    case "textbox":
                        SavedFilter sf = new SavedFilter { name = c.Name, value = c.Text };
                        lFiltersToSave.Add(sf);
                        break;
                    case "combobox":
                        ComboBox tempCB = (ComboBox)c;
                        sf = new SavedFilter { name = tempCB.Name, value = tempCB.SelectedIndex };
                        lFiltersToSave.Add(sf);
                        break;
                    case "label":
                        break;
                };
            }
            if (!Directory.Exists(folder))
                Directory.CreateDirectory(folder);

            //write new filter to disk
            StreamWriter sw = new StreamWriter(folder + tbaddfilter.Text + ".json");
            string output = JsonConvert.SerializeObject(lFiltersToSave);
            sw.Write(output);
            sw.Close();
            sw = new StreamWriter(SavedFilterNames);
            output = JsonConvert.SerializeObject(FilterNames);
            sw.Write(output);
            sw.Close();
            return bRet;
        }

        public bool WriteNewFiltersToDisk(string newFilter)
        {
            NewFilter = newFilter;
            return true;
        }

        private static string GetUserAppDataLocalRoamingFolder(string sid)
        {
            string folder;
            const string regKeyFolders = @"HKEY_USERS\<SID>\Software\Microsoft\Windows\CurrentVersion\Explorer\Shell Folders";
            const string regValueAppData = @"AppData";
            folder = Registry.GetValue(regKeyFolders.Replace("<SID>", sid), regValueAppData, null).ToString();
            folder = folder + @"\Inworks\";
            return folder;
        }
    }

    public class SavedFilter
    {
        public string name { get; set; }
        public object value { get; set; }
    }
}
/*
string folder = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);

// Combine the base folder with your specific folder....
string specificFolder = Path.Combine(folder, "YourSpecificFolder");

// CreateDirectory will check if folder exists and, if not, create it.
// If folder exists then CreateDirectory will do nothing.
Directory.CreateDirectory(specificFolder);
In the last pass is not clear where you have the file to copy.
However, supposing that you have a file called

string file = @"C:\program files\myapp\file.txt";
File.Copy(file, Path.Combine(specificFolder, Path.GetFileName(file));
*/
