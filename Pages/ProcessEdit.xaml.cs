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
    /// Логика взаимодействия для ProcessEdit.xaml
    /// </summary>
    public partial class ProcessEdit : Page
    {
        

        
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

        private void BtnProcessAdd_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnProcessDel_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnProcessEdit_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
