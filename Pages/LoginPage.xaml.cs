using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using WpfEDSS.Classes;

namespace WpfEDSS.Pages
{
    /// <summary>
    /// Логика взаимодействия для LoginPage.xaml
    /// </summary>
    public partial class LoginPage : Page
    {
        
        Classes.AppContext db;
        public LoginPage()
        {
            InitializeComponent();

            db = new Classes.AppContext();
        }
        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            string id_jobtitle = loginTextBox.Text.Trim();
            string FIO = passwordBox.Password.Trim();



            Classes.User authUser = null;
            using (Classes.AppContext db = new Classes.AppContext())
            {
                authUser = db.Users.Where(b => b.Id_jobtitle == id_jobtitle && b.Fio == FIO).FirstOrDefault();
            }
            if (authUser != null)
            {
                //System.Windows.MessageBox.Show("Все хорошо!");
                Classes.ClassManager.frameMain.Navigate(new Pages.HomePage());
            }
            else
            {
                System.Windows.MessageBox.Show("Что-то введено не корректно!");
            }
        }
        
    }
}
