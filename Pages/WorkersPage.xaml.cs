﻿using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
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
            if (Role.CheckRole() == 2)
            {
                System.Windows.MessageBox.Show("Гость не может этого делать!");
            }
            else
            {
                // Получаем выбранного сотрудника из списка сотрудников
                Classes.User selectedUser = (sender as System.Windows.Controls.Button).DataContext as Classes.User;
                if (Role.CheckRole() == 0)
                {
                    // Создаем экземпляр страницы редактирования сотрудников и передаем данные выбранного сотрудника
                    WorkerEdit editUserPage = new WorkerEdit(selectedUser);
                    // Открываем страницу редактирования процессов
                    NavigationService.Navigate(editUserPage);
                }
                else if (selectedUser.id_jobtitle.ToString() == UserSessionStats.account)
                {
                    // Создаем экземпляр страницы редактирования сотрудников и передаем данные выбранного сотрудника
                    WorkerEdit editUserPage = new WorkerEdit(selectedUser);
                    // Открываем страницу редактирования процессов
                    NavigationService.Navigate(editUserPage);
                }
                else
                {
                    System.Windows.MessageBox.Show("Допускается изменение только своего аккаунта!");
                }
            }
        }

        

        private void SearchBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            textBlockSearch.Visibility = SearchBox.Text.Length == 0 ? Visibility.Visible : Visibility.Hidden;
            db = new Classes.AppContext();

            string searchText = (sender as TextBox).Text.ToLower();
            List<User> filteredUsers = db.Users.Where(u => u.fio_user.ToLower().Contains(searchText)).ToList();

            if (listOfWorkers != null) // проверка на null
            {
                listOfWorkers.ItemsSource = filteredUsers;
            }
            if (SearchBox.Text.Length == 0) {
                db = new Classes.AppContext();
                List<Classes.User> Users = db.Users.ToList();
                listOfWorkers.ItemsSource = Users;
            }
        }

        private void btnUserAddNew_Click(object sender, RoutedEventArgs e)
        {
            if (Role.CheckRole() == 2)
            {
                System.Windows.MessageBox.Show("Гость не может этого делать!");
            }
            else
            {
                Classes.ClassManager.frameMain.Navigate(new Pages.WorkerEdit());
            }
        }
    }
}
