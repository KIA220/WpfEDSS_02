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
    /// Логика взаимодействия для WorkerEdit.xaml
    /// </summary>
    public partial class WorkerEdit : Page
    {
        Classes.AppContext db;
        public WorkerEdit(User selectedProcess)
        {
            InitializeComponent();
            // Заполняем элементы управления данными выбранного сотрудника
            idWorkerIdBox.Text = selectedProcess.id_user.ToString();
            idRoleBox.Text = selectedProcess.id_jobtitle.ToString();
            idFIOBox.Text = selectedProcess.fio_user.ToString();
            idTelBox.Text = selectedProcess.tel_user.ToString();
        }
        public WorkerEdit()
        {
            InitializeComponent();
        }
        private void BtnWorkerDel_Click(object sender, RoutedEventArgs e)
        {
            // Получаем выбранного пользователя
            User user = new User
            {
                id_user = int.Parse(idWorkerIdBox.Text),
                id_jobtitle = idRoleBox.Text,
                fio_user = idFIOBox.Text,
                tel_user = idTelBox.Text,
            };

            // Удаляем пользователя из базы данных
            using (Classes.AppContext db = new Classes.AppContext())
            {
                db.DeleteUser(user);
            }

            // Возвращаемся на предыдущую страницу
            Classes.ClassManager.frameMain.Navigate(new Pages.WorkersPage());
        }

        private void BtnWorkerEdit_Click(object sender, RoutedEventArgs e)
        {
            int userId = int.Parse(idWorkerIdBox.Text);

            // Находим объект User в базе данных по его идентификатору
            using (Classes.AppContext db = new Classes.AppContext())
            {
                User user = db.Users.FirstOrDefault(p => p.id_user == userId);

                // Обновляем свойства объекта User
                user.id_jobtitle = idRoleBox.Text;
                user.fio_user = idFIOBox.Text;
                user.tel_user = idTelBox.Text;

                // Сохраняем изменения в базе данных
                db.SaveChanges();
            }
            // Возвращаемся на предыдущую страницу
            Classes.ClassManager.frameMain.Navigate(new Pages.WorkersPage());
        }

        private void BtnWorkerAdd_Click(object sender, RoutedEventArgs e)
        {
            // Создаем новый объект класса User
            if (idRoleBox.Text.Length == 0 || idFIOBox.Text.Length == 0 || idTelBox.Text.Length == 0)
            {
                Classes.User newUser = new Classes.User()
                {
                    id_jobtitle = "0",
                    fio_user = "0",
                    tel_user = "0",
                };
                // Добавляем нового пользователя в DbSet Users в AppContext
                db = new Classes.AppContext();
                db.Users.Add(newUser);
                db.SaveChanges();
            }
            else
            {
                Classes.User newUser = new Classes.User()
                {
                    id_jobtitle = idRoleBox.Text,
                    fio_user = idFIOBox.Text,
                    tel_user = idTelBox.Text,
                };
                // Добавляем нового пользователя в DbSet Users в AppContext
                db = new Classes.AppContext();
                db.Users.Add(newUser);
                db.SaveChanges();
            }
            Classes.ClassManager.frameMain.Navigate(new Pages.WorkersPage());
        }
    }
}
