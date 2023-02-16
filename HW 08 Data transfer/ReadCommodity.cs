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
    public partial class ReadCommodity : Form
    {
       public Commodity? commodity=null;
        public ReadCommodity(Commodity? _commodity)
        {
            InitializeComponent();
            textBox1.Text = _commodity.name;
            textBox2.Text = Convert.ToString( _commodity.price);
            textBox3.Text = _commodity.characteristic;
            textBox4.Text = _commodity.description;
            this.commodity = _commodity;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text!="" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "")
            {
                commodity=new Commodity(textBox1.Text,textBox3.Text,textBox4.Text,Convert.ToInt32(textBox2.Text));
            }
            else
            {
                MessageBox.Show("Text is null =(");
            }
        }
    }
}
