using System;
using System.Windows;

namespace Terminplaner.Appointment
{
    /// <summary>
    /// Interaction logic for NewAppointmentWindow.xaml
    /// </summary>
    public partial class AppointmentWindow : Window
    {
        public AppointmentWindow()
        {
            InitializeComponent();
            init();
        }

        public void init()
        {
            appointmentFromDatePicker.SelectedDate = DateTime.Now;
            appointmentToDatePicker.SelectedDate = DateTime.Now;
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void CreateButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
