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
        public MainWindow()
        {
            InitializeComponent();
            initialize();
        }

        private void initialize()
        {
            //ConnectionClass connection = new ConnectionClass();
            //MessageBox.Show(connection.OpenConnection().ToString());

            initFrame();
        }

        private void initFrame()
        {
            Main.Content = new MonthView();
        }
    }
}
