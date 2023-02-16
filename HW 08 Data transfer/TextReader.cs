using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW_08_Data_transfer
{
    public partial class TextReader : Form
    {
        public TextReader()
        {
            InitializeComponent();
            buttonReadFile.Enabled = false;
        }

        private void buttonOpentxt_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            ofd.FilterIndex = 1;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                StreamReader reader = File.OpenText(ofd.FileName);
                textBox1.Text = reader.ReadToEnd();
                reader.Close();
            }
            buttonReadFile.Enabled = true;
        }

        private void buttonReadFile_Click(object sender, EventArgs e)
        {
            ReadFile read = new ReadFile(textBox1.Text);
            read.DataSent += DataSend;
            read.Show();
        }
        private void DataSend(string str)
        {
            this.textBox1.Text = str;
        }
    }
}
