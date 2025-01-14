namespace LibraryManagementSystem
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            Add add = new Add();
            add.Show();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            Delete del = new Delete();
            del.Show();
        }

        private void View_Click(object sender, EventArgs e)
        {
            View view = new View();
            view.Show();
        }
    }
}
