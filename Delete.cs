using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace LibraryManagementSystem
{
    public partial class Delete : Form
    {
        public Delete()
        {
            InitializeComponent();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            string Title = TitleDText.Text;

            string Dquery = "DELETE FROM books WHERE Title = @Title";

            using (MySqlConnection con = new DbConnection().GetConnection())
            {
                con.Open();
                using (MySqlCommand cmd = new MySqlCommand(Dquery, con))
                {
                    cmd.Parameters.AddWithValue("@Title", Title);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Book deleted successfully!");
                }
            }
        }

        private void DeleteAllButton_Click(object sender, EventArgs e)
        {
            string DAquery = "truncate table books";

            using (MySqlConnection con = new DbConnection().GetConnection())
            {
                con.Open();
                using (MySqlCommand cmd = new MySqlCommand(DAquery, con))
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("All books deleted successfully!");
                }
            }
        }
    }
}
