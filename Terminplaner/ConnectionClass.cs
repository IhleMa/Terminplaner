﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Terminplaner
{
    class ConnectionClass
    {
        private MySqlConnection connection;
        string host = "sql7.freemysqlhosting.net";
        string database = "sql7258286";
        string username = "sql7258286";
        string password;

        public ConnectionClass()
        {
            Initialize();
        }

        private void Initialize()
        {
            host = "localhost";
            database = "testSchule";
            username = "root";
            password = "";
            string connectionString;
            connectionString = "SERVER=" + host + ";" + "DATABASE=" + database + ";" + "UID=" + username + ";" + "PASSWORD=" + password + ";";

            connection = new MySqlConnection(connectionString);

           
        }

        //open connection to database
        public bool OpenConnection()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                switch (ex.Number)
                {
                    case 0:
                        MessageBox.Show("Cannot connect to server.");
                        break;
                    case 1045:
                        MessageBox.Show("Wrong username or password.");
                        break;
                }
                return false;
            }
        }

        public void useStatement(string statement) {

            string stm = "SELECT VERSION()";
            MySqlCommand cmd = new MySqlCommand(stm, conn);
            string version = Convert.ToString(cmd.ExecuteScalar());
        }
    }
}
