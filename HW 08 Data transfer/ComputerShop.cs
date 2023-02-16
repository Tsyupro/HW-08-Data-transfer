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
    public partial class ComputerShop : Form
    {
        public ComputerShop()
        {
            InitializeComponent();
            listBoxShop.Items.Add(new Commodity("Acer Aspire 7", "A715-42G-R3EZ", "MD Ryzen 5 5500U / RAM 16 ГБ / SSD 512 ГБ / nVidia GeForce GTX 1650", 30999));
            listBoxShop.Items.Add(new Commodity("ASUS TUF Gaming", "FX506LHB-HN324", "Intel Core i5-10300H / RAM 16 ГБ / SSD 512 ГБ / nVidia GeForce GTX 1650", 33999));
            listBoxShop.Items.Add(new Commodity("Lenovo IdeaPad Gaming 3", "15IHU6 (82K101FJRA)", "Intel Core i5-11320H / RAM 8 ГБ / SSD 256 ГБ / nVidia GeForce GTX 1650", 29999));
            buttonReadItem.Enabled = false;
        }

        private void Price_Click(object sender, EventArgs e)
        {
            int price = 0;
            foreach(Commodity item in listBoxShop.Items)
            {
                price += item.price;
            }
            MessageBox.Show($" Suma : {price}");
        }

        private void priceElement_Click(object sender, EventArgs e)
        {
            if (listBoxShop.SelectedItem != null)
            {
                Commodity? item = listBoxShop.SelectedItem as Commodity;
                MessageBox.Show($"Ціна: {item.price} UAH");
            }
            else
            {
                MessageBox.Show("Who Element bro?");
            }

        }

        private void addItem_Click(object sender, EventArgs e)
        {
            
            if (listBoxShop.SelectedItem != null)
            {
                listBoxMyElement.Items.Add(listBoxShop.SelectedItem as Commodity);
            }
            else
            {
                MessageBox.Show("Who Element bro?");
            }
        }

        private void InfoItem_Click(object sender, EventArgs e)
        {
            if (listBoxShop.SelectedItem != null)
            {
                Commodity? item = listBoxShop.SelectedItem as Commodity;
                MessageBox.Show(item.InfoCommodity());
            }
            else{
                MessageBox.Show("Who Element bro?");
            }
        }

        private void buttonPassword_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                if (textBox1.Text == "123")
                {
                    buttonReadItem.Enabled = true;
                }
                else{
                    MessageBox.Show("No Valid Password!");
                }
            }
            else
            {
                MessageBox.Show("Text is Null!");
            }
        }

        private void buttonReadItem_Click(object sender, EventArgs e)
        {
            if(listBoxShop.SelectedItem != null)
            {
                ReadCommodity read = new ReadCommodity(listBoxShop.SelectedItem as Commodity);
                read.ShowDialog();               
                int index = listBoxShop.SelectedIndex;
                listBoxShop.Items.Remove(index);
                listBoxShop.Items.Insert(index,read.commodity);
            }

        }
    }
}
