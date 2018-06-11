using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.DirectoryServices.AccountManagement;
using Microsoft.Win32;
using FilterSaver.Properties;
using static System.Windows.Forms.Control;
using System.Security.Principal;

namespace FilterSaver.Writer
{
    public class Writer
    {
        public Writer() { }
        private string NewFilter = string.Empty;

        public bool WriteSavedFiltersToDisk(ControlCollection cc)
        {
            bool bRet = false;

            ListBox lb = (ListBox)cc["lbSavedBongoFilters"];

            string folder = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            folder = GetUserAppDataLocalRoamingFolder(UserPrincipal.Current.Sid.ToString());

            int FilterCount = lb.Items.Count;
            int ItemWriteCounter = 0;
            if (!Directory.Exists(folder))
                Directory.CreateDirectory(folder);
            StreamWriter sw = new StreamWriter(folder + @"savedFilters.txt");
            if (NewFilter != string.Empty) {
                lb.Items.Add(NewFilter);
                FilterCount++;
            }
            foreach (var car in lb.Items)
            {
                System.Diagnostics.Debug.Write(car.ToString() + "\n");
                sw.WriteLine(car.ToString());
                sw.Flush();
                ItemWriteCounter++;
            }
            if (ItemWriteCounter == FilterCount)
            {
                bRet = true;
            }
            sw.Close();
            return bRet;
        }

        public bool WriteSavedFiltersToDisk(string newFilter) {
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
