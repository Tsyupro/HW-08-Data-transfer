namespace HW_08_Data_transfer
{
    public partial class SearchForm : Form
    {
        public SearchForm()
        {
            InitializeComponent();
        }

        private void searching_Click(object sender, EventArgs e)
        {
            SearchingForm searchingForm = new SearchingForm();
            searchingForm.dataSent += DataSend;
            searchingForm.Show();
        }
        private void DataSend(List <string> values)
        {
            if(listView1!= null)
            {
                listView1.Items.Clear();
            }
            for (int i = 0; i < values.Count; i++)
            {
                listView1.Items.Add(values[i]);
            }
        }
    }
}
