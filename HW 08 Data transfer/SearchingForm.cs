using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HW_08_Data_transfer
{
    public partial class SearchingForm : Form
    {
        public delegate void DataSentHalder(List<string> values);
        public List<string> listfiels = new List<string>();
        public event DataSentHalder dataSent;
        public SearchingForm()
        {
            InitializeComponent();
        }
        

        private void openPatch_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog dlg = new FolderBrowserDialog() { Description = "Select you Patch" })
            {
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    textBoxPatchPapka.Text = dlg.SelectedPath;
                }
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            if (textBoxType.Text == "" || textBoxPatchPapka.Text=="")
            {
                MessageBox.Show("The field is empty");
                return;
            }
            foreach (string item in Directory.GetFileSystemEntries(textBoxPatchPapka.Text,textBoxType.Text))
            {
                FileInfo file = new FileInfo(item);
                listfiels.Add(file.Name);
            }
            this.dataSent(listfiels);
            listfiels.Clear();
        }
    }
}
