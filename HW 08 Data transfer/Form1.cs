namespace HW_08_Data_transfer
{
    public partial class StartProgram : Form
    {
        public StartProgram()
        {
            InitializeComponent();
        }

        private void search_Click(object sender, EventArgs e)
        {
            SearchForm searchForm = new SearchForm();
            searchForm.ShowDialog();
        }

        private void ComputerOpen_Click(object sender, EventArgs e)
        {
            ComputerShop shop = new ComputerShop();
            shop.ShowDialog();
        }
    }
}