using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FilterSaver.Writer;
using FilterSaver.Reader;

namespace FilterSaver
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Reader.Reader reader = new Reader.Reader();
            lbSavedBongoFilters.Visible = reader.GetFilterSaverState();
            string FilterType = "bongos";
            reader.LoadSavedFilters(FilterType, lbSavedBongoFilters);
        }

        private void btnLoadFilter_Click(object sender, EventArgs e)
        {
            int whichItem = lbSavedBongoFilters.SelectedIndex;
            MessageBox.Show(whichItem.ToString() + " : " + lbSavedBongoFilters.SelectedItem);
        }

        private void btnAddFilter_Click(object sender, EventArgs e)
        {
            var dropper = tbAddFilter.Visible ? tbAddFilter.Visible = false : tbAddFilter.Visible = true;
            Button b = (Button)sender;
            Writer.Writer writer = new Writer.Writer();
            string incomingString = tbAddFilter.Text;
            if (incomingString == String.Empty)
            {
                //lbSavedBongoFilters.Focus();
                tbAddFilter.Focus();
                
                if (b.Text == "&Add Filter")
                {
                    b.Text = "&Save Filter";
                }
                return;
            }
            else
            {
                b.Text = "&Add Filter";
            }
            List<string> temp = lbSavedBongoFilters.Items.Cast<string>().ToList();
            temp.Add(incomingString);
            writer.WriteNewFiltersToDisk(incomingString);
            writer.WriteSavedFiltersToDisk(ActiveControl.Parent.Controls);
            lbSavedBongoFilters.DataSource = temp;
            tbAddFilter.Text = string.Empty;
        }

        private void btnDeleteFilter_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("are you sure?");
            if (dr.ToString() == "ok")
            {
                throw new NotImplementedException("get Id, Get datasource as list, delete from list, rebind list to datasource");
            }
            else {
                return;
            }
        }
    }
}
