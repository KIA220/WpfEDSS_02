using QRCoder;
using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using Process = WpfEDSS.Classes.Process;
using System.Drawing.Imaging;
using System.Drawing;
using System.IO;
using System.Windows.Media.Imaging;

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

            string id_process = idTextBox.Text;
            string comment = idCommentTextBox.Text;
            string qrCodeId = idQrCodeTextBox.Text;
            string id_user = idUserTextBox.Text;
            string id_report = idReportTextBox.Text;
            string id_client = idClientTextBox.Text;

            // Проверяем наличие файла QR-кода и отображаем его, если он существует
            string fileName = $"QRCode{id_process}{qrCodeId}{id_report}.png";
            string path = AppDomain.CurrentDomain.BaseDirectory + "/QRCodes/" + fileName;
            if (File.Exists(path))
            {
                BitmapImage bmp = new BitmapImage();
                bmp.BeginInit();
                bmp.UriSource = new Uri(path);
                bmp.EndInit();
                qrCodeImage.Source = bmp;
            }

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

                    id_comment = "0",
                    id_qr_code = 0,
                    id_user = "0",
                    id_report = 0,
                    id_client = "0",
                };
                // Добавляем новый процесс в DbSet Processes в AppContext
                db = new Classes.AppContext();
                db.Processes.Add(newProcess);
                db.SaveChanges();
            }
            else {
                Classes.Process newProcess = new Classes.Process()
                {

                    id_comment = idCommentTextBox.Text,
                    id_qr_code = int.Parse(idQrCodeTextBox.Text),
                    id_user = idUserTextBox.Text,
                    id_report = int.Parse(idReportTextBox.Text),
                    id_client = idClientTextBox.Text,
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
                id_comment = idCommentTextBox.Text,
                id_qr_code = int.Parse(idQrCodeTextBox.Text),
                id_user = idUserTextBox.Text,
                id_report = int.Parse(idReportTextBox.Text),
                id_client = idClientTextBox.Text,
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
                process.id_comment = idCommentTextBox.Text;
                process.id_qr_code = int.Parse(idQrCodeTextBox.Text);
                process.id_user = idUserTextBox.Text;
                process.id_report = int.Parse(idReportTextBox.Text);
                process.id_client = idClientTextBox.Text;

                // Сохраняем изменения в базе данных
                db.SaveChanges();
            }


            // Возвращаемся на предыдущую страницу
            Classes.ClassManager.frameMain.Navigate(new Pages.HomePage());
        }

        private void BtnQR_Generate_Click(object sender, RoutedEventArgs e)
        {
            GenerateQRCode();
        }
        private void GenerateQRCode()
        {
            // Получаем значения из текстбоксов
            string id_process = idTextBox.Text;
            string comment = idCommentTextBox.Text;
            string qrCodeId = idQrCodeTextBox.Text;
            string id_user = idUserTextBox.Text;
            string id_report = idReportTextBox.Text;
            string id_client = idClientTextBox.Text;

            // Формируем строку для QR-кода
            
            string qrText = $"ID Process:\t{id_process}\nComment:\t{comment}\nQR Code ID:\t{qrCodeId}\nID User:\t{id_user}\nID Report:\t{id_report}\n";

            // Создаем объект QRCodeGenerator и генерируем QR-код
            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            var qrCodeData = new QRCodeGenerator().CreateQrCode(qrText, QRCodeGenerator.ECCLevel.Q, forceUtf8: true);
            QRCode qrCode = new QRCode(qrCodeData);

            // Создаем изображение
            Bitmap qrImage = qrCode.GetGraphic(20);

            // Формируем имя файла
            string fileName = $"QRCode{id_process}{qrCodeId}{id_report}.png";

            // Сохраняем изображение в файл
            string path = AppDomain.CurrentDomain.BaseDirectory + "/QRCodes/" + fileName;
            string dir = @"QRCodes";

            if (!Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
            }
            // Проверяем наличие файла
            if (File.Exists(path))
            {
                System.Windows.MessageBox.Show("Такой файл уже существует!");
            }
            else {
                qrImage.Save(path, ImageFormat.Png);
                System.Diagnostics.Process.Start("explorer.exe", "/root," + System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "QRCodes"));
            }
        }
    }
}
