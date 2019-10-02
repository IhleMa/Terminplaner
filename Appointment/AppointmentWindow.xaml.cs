using System;
using System.Windows;
using Terminplaner.Classes;

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
            CreateNewEntry();
            Close();
        }

        void CreateNewEntry()
        {

            Pages.Appointment appointment = new Pages.Appointment();

            appointment.Title = titleTextBox.Text;
            appointment.Category = appointmentCategoryComboBox.SelectedValue.ToString();
            appointment.FromDate = (DateTime)appointmentFromDatePicker.SelectedDate;
            appointment.ToDate = (DateTime)appointmentToDatePicker.SelectedDate;
            appointment.Priority = (int)appointmentPriorityComboBox.SelectedIndex;
            appointment.State = (int)appointmentStatusComboBox.SelectedIndex;


            ConnectionClass connection = new ConnectionClass();
            connection.InsertAppointment(appointment);
        }
    }
}
