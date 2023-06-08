using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Forms;
using WpfEDSS.Classes;

namespace WpfEDSS.Pages
{
    /// <summary>
    /// Логика взаимодействия для LoginPage.xaml
    /// </summary>
    public partial class LoginPage : Page
    {
        int trycount = 0;
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
                UserSessionStats.status = authUser.user_role; //become role user
                trycount = 0;
                UserSessionStats.account = authUser.id_jobtitle;
                UIManager.LabelAccountUpdate();
                Classes.ClassManager.frameMain.Navigate(new Pages.HomePage());
            }
            else
            {
                trycount++;
                System.Windows.MessageBox.Show("Что-то введено не корректно!");
                if (trycount > 5)
                {
                    DialogResult dialogResult = (DialogResult)System.Windows.MessageBox.Show("Количество попыток превышено. Вы хотите войти как гость?", "Войти как гость", (MessageBoxButton)MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        UserSessionStats.status = 2; //guest log in
                        trycount = 0;
                        Classes.ClassManager.frameMain.Navigate(new Pages.HomePage());
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        trycount = 0;
                    }
                }
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            UserSessionStats.status = 2; //guest log in
            trycount = 0;
            Classes.ClassManager.frameMain.Navigate(new Pages.HomePage());
        }
    }
}
