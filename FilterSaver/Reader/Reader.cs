using System;
using System.Collections.Generic;
using System.Configuration;
using System.DirectoryServices.AccountManagement;
using System.IO;
using static System.Windows.Forms.Control;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FilterSaver.Properties;
using System.Windows.Forms;

using Microsoft.Win32;

namespace FilterSaver.Reader
{
    public class Reader
    {
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
            string FullPath = GetUserAppDataLocalRoamingFolder(localUP.Sid.ToString()) + @"savedFilters.txt";
            if (!File.Exists(FullPath))
            {
                throw new Exception("Would you like to save a filter, you don't have any saved yet.");
                //return SavedFilters;
            }
            StreamReader sr = new StreamReader(GetUserAppDataLocalRoamingFolder(localUP.Sid.ToString()) + @"\savedFilters.txt");
            
            string line = string.Empty;
            while ((line = sr.ReadLine()) != null)
            {
                SavedFilters.Add(line);
            }
            sr.Close();
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
