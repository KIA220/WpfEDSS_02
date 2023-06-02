using System.Windows;
using System.Windows.Controls;


namespace WpfEDSS.Pages
{
    /// <summary>
    /// Логика взаимодействия для Greetings.xaml
    /// </summary>
    public partial class Greetings : Page
    {
        public Greetings()
        {
            InitializeComponent();
        }
        private void BtnGreetingsHelp_Click(object sender, RoutedEventArgs e)
        {
            Classes.ClassManager.frameMain.Navigate(new Pages.Help());
        }
        private void BtnGreetingsForward_Click(object sender, RoutedEventArgs e)
        {
            Classes.ClassManager.frameMain.Navigate(new Pages.LoginPage());
        }
    }
}
