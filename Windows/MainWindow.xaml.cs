using System;
using System.Windows;


namespace WpfEDSS
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Classes.ClassManager.frameMain = FrameMainWindow;
            FrameMainWindow.Navigate(new Pages.Greetings());

            ButtonProcesses.IsEnabled = false;
            ButtonClients.IsEnabled = false;
            ButtonWorkers.IsEnabled = false;
            ButtonLogOut.IsEnabled = false;
            lblAccount.IsEnabled = false;

            ButtonProcesses.Visibility = Visibility.Hidden;
            ButtonClients.Visibility = Visibility.Hidden;
            ButtonWorkers.Visibility = Visibility.Hidden;
            ButtonLogOut.Visibility = Visibility.Hidden;
            lblAccount.Visibility = Visibility.Hidden;
        }


        private void ButtonProcesses_Click(object sender, RoutedEventArgs e)
        {
            Classes.ClassManager.frameMain.Navigate(new Pages.HomePage());
        }

        private void ButtonClients_Click(object sender, RoutedEventArgs e)
        {
            Classes.ClassManager.frameMain.Navigate(new Pages.ClientsPage());
        }

        private void ButtonWorkers_Click(object sender, RoutedEventArgs e)
        {
            Classes.ClassManager.frameMain.Navigate(new Pages.WorkersPage());
        }

        private void ButtonLogOut_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Forms.Application.Restart();
            Environment.Exit(0);
        }
    }
}
