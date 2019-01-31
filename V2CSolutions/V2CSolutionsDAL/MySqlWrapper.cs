using System;
using System.Collections.Generic;
using System.Text;
using MySQL2ObjWrapper;
using MySql.Data.MySqlClient;

namespace V2CSolutionsDAL
{
   public class MySqlWrapper
    {
       MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;

        public MySqlWrapper()
        {
            server = "localhost";
            database = "v2c";
            uid = "root";
            password = "lk@12345";
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" +
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

            connection = new MySqlConnection(connectionString);
        }
      
    }
}
