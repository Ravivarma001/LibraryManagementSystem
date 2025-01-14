using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace LibraryManagementSystem
{
    internal class DbConnection
    {
        private MySqlConnection con;

        public DbConnection()
        {
            con = new MySqlConnection("server=127.0.0.1;uid=root;pwd=root;database=lib");

        }
        
        public MySqlConnection GetConnection()
        {
            return con;
        }
    }
}
