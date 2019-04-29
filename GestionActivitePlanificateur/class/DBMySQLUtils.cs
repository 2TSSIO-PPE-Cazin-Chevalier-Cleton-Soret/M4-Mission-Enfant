using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Tutorial.SqlConn
{
    class DBMySQLUtils
    {

        public static MySqlConnection GetDBConnection(string host, int port, string database, string username, string password)
        {
            // Connection String.
            String connString = "Server=" + host + ";Database=" + database + ";port=" + port + ";user id=" + username + ";password=" + password;

            MySqlConnection conn = new MySqlConnection(connString);

            return conn;
        }

        public static MySqlConnection GetDBConnection(string host, string database, string username, string password)
        {
            // Connection String.
            String connString = "Server=" + host + ";database=" + database +  ";user id=" + username + ";password=" + password;

            MySqlConnection conn = new MySqlConnection(connString);

            return conn;
        }

    }
}