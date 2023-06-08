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
        readonly UIManager UIManager = new UIManager();
        Classes.AppContext db;
        public LoginPage()
        {
            InitializeComponent();

            db = new Classes.AppContext();
            UserSessionStats.status = 1; //regularuser for default
        }
        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            db = new Classes.AppContext();

            string id_jobtitle = loginTextBox.Text.Trim();
            string fio_user = passwordBox.Password.Trim();

            Classes.User authUser = null;
            using (Classes.AppContext db = new Classes.AppContext())
            {
                authUser = db.Users.Where(b => b.id_jobtitle == id_jobtitle && b.fio_user == fio_user).FirstOrDefault();
            }
            if (authUser != null)
            {
                if (id_jobtitle == "admin") { 
                    UserSessionStats.status = 0; //become admin
                    
                    
                }
                UserSessionStats.account = id_jobtitle;
                UIManager.LabelAccountUpdate();
                Classes.ClassManager.frameMain.Navigate(new Pages.HomePage());
            }
            else
            {
                UserSessionStats.status = 1; //deadmin
                System.Windows.MessageBox.Show("Что-то введено не корректно!");
            }
        }
        
    }
}
