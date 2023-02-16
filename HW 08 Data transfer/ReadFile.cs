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
    public delegate void DataSentHalder(string str);
    public partial class ReadFile : Form
    {
        public event DataSentHalder DataSent;
        public ReadFile(string Text)
        {
            InitializeComponent();
            textBoxRead.Text = Text;
        }

        private void buttonRead_Click(object sender, EventArgs e)
        {
            this.DataSent(textBoxRead.Text);
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
