using System;
using System.Collections.Generic;
using System.Diagnostics;
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
using Process = WpfEDSS.Classes.Process;

namespace WpfEDSS.Pages
{
    /// <summary>
    /// Логика взаимодействия для ProcessEdit.xaml
    /// </summary>
    public partial class ProcessEdit : Page
    {

        Classes.AppContext db;

        public ProcessEdit(Process selectedProcess)
        {
            InitializeComponent();

            // Заполняем элементы управления данными выбранного процесса
            idTextBox.Text = selectedProcess.id_process.ToString();
            idCommentTextBox.Text = selectedProcess.id_comment.ToString();
            idQrCodeTextBox.Text = selectedProcess.id_qr_code.ToString();
            idUserTextBox.Text = selectedProcess.id_user.ToString();
            idReportTextBox.Text = selectedProcess.id_report.ToString();
            idClientTextBox.Text = selectedProcess.id_client.ToString();
            


        }
        public ProcessEdit()
        {
            InitializeComponent();
        }

        private void BtnProcessAdd_Click(object sender, RoutedEventArgs e)
        {

            // Создаем новый объект класса Process
            if (idCommentTextBox.Text.Length == 0 || idQrCodeTextBox.Text.Length == 0 || idUserTextBox.Text.Length == 0 || idReportTextBox.Text.Length == 0 || idClientTextBox.Text.Length == 0)
            {
                Classes.Process newProcess = new Classes.Process()
                {

                    id_comment = 0,
                    id_qr_code = 0,
                    id_user = 0,
                    id_report = 0,
                    id_client = 0,
                };
                // Добавляем новый процесс в DbSet Processes в AppContext
                db = new Classes.AppContext();
                db.Processes.Add(newProcess);
                db.SaveChanges();
            }
            else {
                Classes.Process newProcess = new Classes.Process()
                {

                    id_comment = int.Parse(idCommentTextBox.Text),
                    id_qr_code = int.Parse(idQrCodeTextBox.Text),
                    id_user = int.Parse(idUserTextBox.Text),
                    id_report = int.Parse(idReportTextBox.Text),
                    id_client = int.Parse(idClientTextBox.Text),
                };
                // Добавляем новый процесс в DbSet Processes в AppContext
                db = new Classes.AppContext();
                db.Processes.Add(newProcess);
                db.SaveChanges();
            }
            Classes.ClassManager.frameMain.Navigate(new Pages.HomePage());

        }

        private void BtnProcessDel_Click(object sender, RoutedEventArgs e)
        {
            // Получаем выбранный процесс
            Process process = new Process
            {
                id_process = int.Parse(idTextBox.Text),
                id_comment = int.Parse(idCommentTextBox.Text),
                id_qr_code = int.Parse(idQrCodeTextBox.Text),
                id_user = int.Parse(idUserTextBox.Text),
                id_report = int.Parse(idReportTextBox.Text),
                id_client = int.Parse(idClientTextBox.Text)
            };

            // Удаляем процесс из базы данных
            using (Classes.AppContext db = new Classes.AppContext())
            {
                db.DeleteProcess(process);
            }

            // Возвращаемся на предыдущую страницу
            Classes.ClassManager.frameMain.Navigate(new Pages.HomePage());
        }

        private void BtnProcessEdit_Click(object sender, RoutedEventArgs e)
        {
            int processId = int.Parse(idTextBox.Text);

            // Находим объект Process в базе данных по его идентификатору
            using (Classes.AppContext db = new Classes.AppContext())
            {
                Process process = db.Processes.FirstOrDefault(p => p.id_process == processId);

                // Обновляем свойства объекта Process
                process.id_comment = int.Parse(idCommentTextBox.Text);
                process.id_qr_code = int.Parse(idQrCodeTextBox.Text);
                process.id_user = int.Parse(idUserTextBox.Text);
                process.id_report = int.Parse(idReportTextBox.Text);
                process.id_client = int.Parse(idClientTextBox.Text);

                // Сохраняем изменения в базе данных
                db.SaveChanges();
            }


            // Возвращаемся на предыдущую страницу
            Classes.ClassManager.frameMain.Navigate(new Pages.HomePage());
        }
    }
}
