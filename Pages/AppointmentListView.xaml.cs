using System;
using System.Collections.Generic;
using System.Windows.Controls;

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
            List<Appointment> appointments = new List<Appointment>();

            //Schleife benötigt die alle Termine abgreift und hinzufügt (for each)

            appointments.Add(new Appointment() { Description = "Test", FromDate = DateTime.Now, ToDate = DateTime.Now, Type = 0, Priority = 0, Status = 0 }); //platzhalter

            appointmentList.ItemsSource = appointments;
        }
    }

    public class Appointment
    {
        public string Description { get; set; }

        public DateTime FromDate { get; set; }

        public DateTime ToDate { get; set; }

        public int Type { get; set; }

        public int Priority { get; set; }

        public int Status { get; set; }
    }
}
