using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Diagnostics;
using System.Linq;
using System.Windows.Controls;
using System.Windows.Forms;
using WpfEDSS.Classes;

namespace WpfEDSS.Pages
{
    /// <summary>
    /// Логика взаимодействия для HomePage.xaml
    /// </summary>
    public partial class HomePage : Page
    {
        readonly UIManager UIManager = new UIManager();
        Classes.AppContext db;
        public HomePage()
        {
            InitializeComponent();
            UIManager.Enable();
            db = new Classes.AppContext();

            List<Classes.Process> Processes = db.Processes.ToList();

            listOfProcesses.ItemsSource = Processes;
        }

        private void btnEditProcess_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            // Получаем выбранный процесс из списка процессов
            Classes.Process selectedProcess = (sender as System.Windows.Controls.Button).DataContext as Classes.Process;
            // Создаем экземпляр страницы редактирования процессов и передаем данные выбранного процесса
            ProcessEdit editProcessPage = new ProcessEdit(selectedProcess);
            // Открываем страницу редактирования процессов
            NavigationService.Navigate(editProcessPage);
        }

        private void SearchBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            textBlockSearch.Visibility = SearchBox.Text.Length == 0 ? System.Windows.Visibility.Visible : System.Windows.Visibility.Hidden;
            db = new Classes.AppContext();

            string searchText = (sender as System.Windows.Controls.TextBox).Text.ToLower();
            List<Classes.Process> filteredProcesss = db.Processes.Where(u => u.id_comment.ToLower().Contains(searchText) || u.id_process.ToString().ToLower().Contains(searchText)).ToList();

            if (listOfProcesses != null) // проверка на null
            {
                listOfProcesses.ItemsSource = filteredProcesss;
            }
            if (SearchBox.Text.Length == 0)
            {
                db = new Classes.AppContext();
                List<Classes.Process> Processes = db.Processes.ToList();
                listOfProcesses.ItemsSource = Processes;
            }
        }

        private void btnProcessAddNew_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            Classes.ClassManager.frameMain.Navigate(new Pages.ProcessEdit());
        }
    }
}
