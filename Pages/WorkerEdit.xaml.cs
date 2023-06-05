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
        public WorkerEdit(User selectedProcess)
        {
            InitializeComponent();
            // Заполняем элементы управления данными выбранного сотрудника
            idWorkerIdBox.Text = selectedProcess.id_user.ToString();
            idRoleBox.Text = selectedProcess.id_jobtitle.ToString();
            idFIOBox.Text = selectedProcess.fio_user.ToString();
            idTelBox.Text = selectedProcess.tel_user.ToString();
        }

        private void BtnWorkerDel_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnWorkerEdit_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnWorkerAdd_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
