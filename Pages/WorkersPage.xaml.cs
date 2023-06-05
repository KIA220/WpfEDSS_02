using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfEDSS.Classes;

namespace WpfEDSS.Pages
{
    /// <summary>
    /// Логика взаимодействия для WorkersPage.xaml
    /// </summary>
    public partial class WorkersPage : Page
    {
        readonly UIManager UIManager = new UIManager();
        Classes.AppContext db;
        public WorkersPage()
        {
            InitializeComponent();
            UIManager.Enable();
            db = new Classes.AppContext();

            List<Classes.User> Users = db.Users.ToList();

            listOfWorkers.ItemsSource = Users;
        }

        private void btnEditWorker_Click(object sender, RoutedEventArgs e)
        {
            // Получаем выбранного сотрудника из списка сотрудников
            Classes.User selectedUser = (sender as System.Windows.Controls.Button).DataContext as Classes.User;
            // Создаем экземпляр страницы редактирования сотрудников и передаем данные выбранного сотдрудника
            WorkerEdit editUserPage = new WorkerEdit(selectedUser);
            // Открываем страницу редактирования процессов
            NavigationService.Navigate(editUserPage);
        }
    }
}
