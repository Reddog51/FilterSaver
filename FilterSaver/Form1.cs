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
            Writer.Writer writer = new Writer.Writer();
            writer.WriteSavedFiltersToDisk(ActiveForm.Controls);
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
            Writer.Writer writer = new Writer.Writer();
            string incomingString = tbAddFilter.Text;
            if (incomingString == String.Empty) {
                lbSavedBongoFilters.Focus();
                return;
            }
            List<string> temp = lbSavedBongoFilters.Items.Cast<string>().ToList();
            temp.Add(incomingString);
            writer.WriteSavedFiltersToDisk(ActiveControl.Parent.Controls);
            lbSavedBongoFilters.DataSource = temp;
        }
    }
}
