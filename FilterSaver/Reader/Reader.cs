using System;
using System.Collections.Generic;
using System.Configuration;
using System.DirectoryServices.AccountManagement;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FilterSaver.Properties;
using System.Windows.Forms;
using Newtonsoft.Json;

using Microsoft.Win32;

namespace FilterSaver.Reader
{
    public class Reader
    {

        // TODO write function and class to get paths to the correct folder.  code to get folders is growing
        // TODO need function to get necessar list boxes that are dealt with.
        // clean up the write.
        // currently writing but not reading the files as json.

        public Reader() { }

        public void LoadSavedFilters(string filterType, System.Windows.Forms.ListBox lb) {
            try
            {
                lb.DataSource = AddUserFilters("BongoFilter");
            }
            catch (Exception ex) {
                var response = MessageBox.Show(ex.Message,ex.Message,MessageBoxButtons.YesNoCancel);
                if (response.ToString() == "yes") {
                    System.Diagnostics.Debug.Write(response.ToString() + "\n");
                    lb.Focus();
                }
            }
            System.Diagnostics.Debug.Write("success\n");
        }

        private List<string> AddUserFilters(string FIlterType)
        {
            List<string> SavedFilters = new List<string>();
            UserPrincipal localUP = UserPrincipal.Current;
            string FullPath = GetUserAppDataLocalRoamingFolder(localUP.Sid.ToString()) + @"savedFilters.json";
            if (!File.Exists(FullPath))
            {
                throw new Exception("Would you like to save a filter, you don't have any saved yet.");
                //return SavedFilters;
            }
            StreamReader sr = new StreamReader(GetUserAppDataLocalRoamingFolder(localUP.Sid.ToString()) + @"\savedFilters.json");
            
            string line = string.Empty;
            string output = sr.ReadToEnd();
            SavedFilters = JsonConvert.DeserializeObject<List<string>>(output);
            
            SavedFilters.Sort();
            return SavedFilters;
        }

        private string GetUserAppDataLocalRoamingFolder(string sid)
        {
            string folder = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData); ;
            const string regKeyFolders = @"HKEY_USERS\<SID>\Software\Microsoft\Windows\CurrentVersion\Explorer\Shell Folders";
            const string regValueAppData = @"AppData";
            folder = Registry.GetValue(regKeyFolders.Replace("<SID>", sid), regValueAppData, null).ToString();
            folder = folder + @"\Inworks\";
            return folder;
        }

        public bool GetFilterSaverState()
        {
            string str = ConfigurationManager.AppSettings["visibleFilterSaver"];
            bool bpoot = Convert.ToBoolean(str);
            //return Convert.ToBoolean( ConfigurationManager.AppSettings["visibleFilterSaver GetFilterSaverState()"]);
            return bpoot;
        }
    }
}
