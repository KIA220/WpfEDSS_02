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
    }
}
