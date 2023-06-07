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
    /// Логика взаимодействия для ClientsPage.xaml
    /// </summary>
    public partial class ClientsPage : Page
    {
        readonly UIManager UIManager = new UIManager();
        Classes.AppContext db;
        public ClientsPage()
        {
            InitializeComponent();
            UIManager.Enable();
            db = new Classes.AppContext();

            List<Client> Clients = db.Clients.ToList();

            listOfClients.ItemsSource = Clients;
        }

        private void btnEditClient_Click(object sender, RoutedEventArgs e)
        {
            // Получаем выбранного клиента из списка клиентов
            Client selectedClient = (sender as Button).DataContext as Client;
            // Создаем экземпляр страницы редактирования сотрудников и передаем данные выбранного сотдрудника
            ClientEdit editClientPage = new ClientEdit(selectedClient);
            // Открываем страницу редактирования процессов
            NavigationService.Navigate(editClientPage);
        }

        private void SearchBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            textBlockSearch.Visibility = SearchBox.Text.Length == 0 ? Visibility.Visible : Visibility.Hidden;
            db = new Classes.AppContext();

            string searchText = (sender as TextBox).Text.ToLower();
            List<Client> filteredClients = db.Clients.Where(u => u.fio_client.ToString().ToLower().Contains(searchText)).ToList();

            if (listOfClients != null) // проверка на null
            {
                listOfClients.ItemsSource = filteredClients;
            }
            if (SearchBox.Text.Length == 0)
            {
                db = new Classes.AppContext();
                List<Client> Clients = db.Clients.ToList();
                listOfClients.ItemsSource = Clients;
            }
        }

        private void btnClientAddNew_Click(object sender, RoutedEventArgs e)
        {
            Classes.ClassManager.frameMain.Navigate(new Pages.ClientEdit());
        }
    }
}
