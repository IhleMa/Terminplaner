using Microsoft.VisualBasic;
using System;
using System.Windows;
using Terminplaner.Classes;
using Terminplaner.Pages;

namespace Terminplaner.MainWindow
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        static readonly DateTime now = DateTime.Now;
        string currentView;

        MonthView monthView = new MonthView(now);

        public MainWindow()
        {
            InitializeComponent();
            initialize();
        }

        private void initialize()
        {
            //ConnectionClass connection = new ConnectionClass();
            //MessageBox.Show(connection.OpenConnection().ToString());

            initControls();
            initFrame();
        }

        private void initControls()
        {
            currentDateTextBox.Text = DateAndTime.MonthName(now.Month) + " " + now.Year;
        }

        private void initFrame()
        {
            Main.Content = monthView;
            currentView = "Month";
        }

        private void PreviousDateButton_Click(object sender, RoutedEventArgs e)
        {
            switch (currentView)
            {
                case "Day":

                    break;

                case "Week":

                    break;

                case "Month":
                    currentDateTextBox.Text = monthView.showPreviousMonth();
                    break;

                case "Year":

                    break;

                default:
                    break;
            }
        }

        private void NextDateButton_Click(object sender, RoutedEventArgs e)
        {
            switch (currentView)
            {
                case "Day":

                    break;

                case "Week":

                    break;

                case "Month":
                    currentDateTextBox.Text = monthView.showNextMonth();
                    break;

                case "Year":

                    break;

                default:
                    break;
            }
        }
    }
}
