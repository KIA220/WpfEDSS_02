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
        public ClientEdit(Client selectedProcess)
        {
            InitializeComponent();
            idClientIdBox.Text = selectedProcess.id_client.ToString();
            ClientFIOBox.Text = selectedProcess.fio_client.ToString();
            idTelBox.Text = selectedProcess.tel_client.ToString();
        }

        private void BtnClientAdd_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnClientEdit_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnClientDel_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
