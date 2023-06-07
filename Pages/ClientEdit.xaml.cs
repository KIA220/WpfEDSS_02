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
    /// Логика взаимодействия для ClientEdit.xaml
    /// </summary>
    public partial class ClientEdit : Page
    {
        Classes.AppContext db;
        public ClientEdit(Client selectedProcess)
        {
            InitializeComponent();
            idClientIdBox.Text = selectedProcess.id_client.ToString();
            ClientFIOBox.Text = selectedProcess.fio_client.ToString();
            idTelBox.Text = selectedProcess.tel_client.ToString();
        }
        public ClientEdit()
        {
            InitializeComponent();
        }

        private void BtnClientAdd_Click(object sender, RoutedEventArgs e)
        {
            // Создаем новый объект класса Client
            if (ClientFIOBox.Text.Length == 0 || idTelBox.Text.Length == 0)
            {
                Classes.Client newClient = new Classes.Client()
                {
                    fio_client = "0",
                    tel_client = "0",
                };
                // Добавляем нового клиента в DbSet Clients в AppContext
                db = new Classes.AppContext();
                db.Clients.Add(newClient);
                db.SaveChanges();
            }
            else
            {
                Classes.Client newClient = new Classes.Client()
                {
                    fio_client = ClientFIOBox.Text,
                    tel_client = idTelBox.Text,
                };
                // Добавляем нового клиента в DbSet Clients в AppContext
                db = new Classes.AppContext();
                db.Clients.Add(newClient);
                db.SaveChanges();
            }
            Classes.ClassManager.frameMain.Navigate(new Pages.ClientsPage());
        }

        private void BtnClientEdit_Click(object sender, RoutedEventArgs e)
        {
            int clientId = int.Parse(idClientIdBox.Text);

            // Находим объект Client в базе данных по его идентификатору
            using (Classes.AppContext db = new Classes.AppContext())
            {
                Client client = db.Clients.FirstOrDefault(p => p.id_client == clientId);

                // Обновляем свойства объекта Client
                client.fio_client = ClientFIOBox.Text;
                client.tel_client = idTelBox.Text;

                // Сохраняем изменения в базе данных
                db.SaveChanges();
            }
            // Возвращаемся на предыдущую страницу
            Classes.ClassManager.frameMain.Navigate(new Pages.ClientsPage());
        }

        private void BtnClientDel_Click(object sender, RoutedEventArgs e)
        {
            // Получаем выбранного клиента
            Client client = new Client
            {
                id_client = int.Parse(idClientIdBox.Text),
                fio_client = ClientFIOBox.Text,
                tel_client = idTelBox.Text,
            };

            // Удаляем клиента из базы данных
            using (Classes.AppContext db = new Classes.AppContext())
            {
                db.DeleteClient(client);
            }

            // Возвращаемся на предыдущую страницу
            Classes.ClassManager.frameMain.Navigate(new Pages.ClientsPage());
        }
    }
}
