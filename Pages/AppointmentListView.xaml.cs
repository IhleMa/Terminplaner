using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using Terminplaner.Classes;

namespace Terminplaner.Pages
{
    /// <summary>
    /// Interaction logic for Appointments.xaml
    /// </summary>
    public partial class AppointmentListView : Page
    {
        public AppointmentListView()
        {
            InitializeComponent();
            init();
        }

        public void init()
        {
            ConnectionClass connection = new ConnectionClass();
            appointmentList.ItemsSource = connection.GetAppointments();
        }
    }

    public class Appointment
    {
        public string Title { get; set; }

        public DateTime FromDate { get; set; }

        public DateTime ToDate { get; set; }

        public string Category { get; set; }

        public int Priority { get; set; }

        public int State { get; set; }


        public string GetFromDateAsString {
            get { return FromDate.ToString("dd.MM.yyyy"); }
        }
        public string GetToDateAsString {
            get { return ToDate.ToString("dd.MM.yyyy"); }
        }

    }
}
