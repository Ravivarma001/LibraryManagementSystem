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
    public partial class Add : Form
    {
        public Add()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            string Title = TitleAText.Text;
            string Author = AuthorAText.Text;

            string query = "INSERT INTO books (Title, Author) VALUES (@Title, @Author)";
            using (MySqlConnection con = new DbConnection().GetConnection())
            {
                con.Open();
                using (MySqlCommand cmd = new MySqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@Title", Title);
                    cmd.Parameters.AddWithValue("@Author", Author);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Book added successfully!");
                }
            }
        }
    }
}
