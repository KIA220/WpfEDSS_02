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

            List<Classes.Client> Clients = db.Clients.ToList();

            listOfClients.ItemsSource = Clients;
        }

        private void btnEditClient_Click(object sender, RoutedEventArgs e)
        {
            // Получаем выбранного клиента из списка клиентов
            Classes.Client selectedClient = (sender as System.Windows.Controls.Button).DataContext as Classes.Client;
            // Создаем экземпляр страницы редактирования сотрудников и передаем данные выбранного сотдрудника
            ClientEdit editClientPage = new ClientEdit(selectedClient);
            // Открываем страницу редактирования процессов
            NavigationService.Navigate(editClientPage);
        }
    }
}
