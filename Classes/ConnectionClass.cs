using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Windows;

namespace Terminplaner.Classes
{
    class ConnectionClass
    {
        private MySqlConnection connection;
        string host = "localhost";
        string database = "pdbsj2o876";
        string username = "root";
        string password;

        public ConnectionClass()
        {
            Initialize();
        }

        private void Initialize()
        {
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
                    default:
                        MessageBox.Show("An error occured.");
                        break;
                }
                return false;
            }
        }

        public void InsertAppointment(Pages.Appointment appointment)
        {
            OpenConnection();
            MySqlCommand command = new MySqlCommand();
            command.CommandText = "INSERT INTO appointments VALUES(?id, ?title,?state,?priority,?category,?fromDate,?toDate)";
            command.Parameters.AddWithValue("?id", command.LastInsertedId);
            command.Parameters.AddWithValue("?title", appointment.Title);
            command.Parameters.AddWithValue("?state", appointment.State);
            command.Parameters.AddWithValue("?priority", appointment.Priority);
            command.Parameters.AddWithValue("?category", appointment.Category);
            command.Parameters.AddWithValue("?fromDate", appointment.FromDate);
            command.Parameters.AddWithValue("?toDate", appointment.ToDate);
            command.Connection = GetConnection();
            
            command.ExecuteNonQuery();
        }

        public List<Pages.Appointment> GetAppointments()
        {
            List<Pages.Appointment> appointments = new List<Pages.Appointment>();
            try
            {
                OpenConnection();
                MySqlDataReader reader = null;
                string selectCmd = "SELECT * FROM  appointments";

                MySqlCommand command = new MySqlCommand(selectCmd, GetConnection());
                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    appointments.Add(new Pages.Appointment() { Title = (string)reader["title"], FromDate = (DateTime)reader["fromDate"], ToDate = (DateTime)reader["toDate"], Category = (string)reader["category"], Priority = (int)reader["priority"], State = (int)reader["state"] });
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }

            return appointments;
        }

        public MySqlConnection GetConnection()
        {
            return connection;
        }

    }

    
}
