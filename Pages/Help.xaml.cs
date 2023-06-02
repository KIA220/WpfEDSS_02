using System.Windows.Controls;


namespace WpfEDSS.Pages
{
    /// <summary>
    /// Логика взаимодействия для Help.xaml
    /// </summary>
    public partial class Help : Page
    {
        public Help()
        {
            InitializeComponent();
        }

        private void BtnHelpBack_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            Classes.ClassManager.frameMain.Navigate(new Pages.Greetings());
        }
    }
}
