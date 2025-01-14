using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public partial class View : Form
    {
        public View()
        {
            InitializeComponent();
        }

        private void ViewButton_Click(object sender, EventArgs e)
        {
            string Title = TitleVText.Text;
            string query = "SELECT * FROM books WHERE Title = @Title";
            using (MySql.Data.MySqlClient.MySqlConnection con = new DbConnection().GetConnection())
            {
                con.Open();
                using (MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@Title", Title);
                    using (MySql.Data.MySqlClient.MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string AuthorVText = reader["Author"].ToString();
                            MessageBox.Show($"Book Title : {Title} , Author : {AuthorVText}");
                        }
                        else
                        {
                            MessageBox.Show("Book not found!");
                        }
                    }
                }
            }
        }
    }
}
