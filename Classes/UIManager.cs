using System;
using System.Collections.Generic;
using System.Windows;

namespace WpfEDSS.Classes
{

    public class UIManager
    {
        readonly MainWindow mainWindow = (MainWindow)Application.Current.MainWindow;

        public void Disable() {

            mainWindow.ButtonProcesses.IsEnabled = false;
            mainWindow.ButtonClients.IsEnabled = false;
            mainWindow.ButtonWorkers.IsEnabled = false;
            mainWindow.ButtonLogOut.IsEnabled = false;
            mainWindow.lblAccount.IsEnabled = false;

            mainWindow.ButtonProcesses.Visibility = Visibility.Hidden;
            mainWindow.ButtonClients.Visibility = Visibility.Hidden;
            mainWindow.ButtonWorkers.Visibility = Visibility.Hidden;
            mainWindow.ButtonLogOut.Visibility = Visibility.Hidden;
            mainWindow.lblAccount.Visibility = Visibility.Hidden;

        }
        public void Enable() {

            mainWindow.ButtonProcesses.IsEnabled = true;
            mainWindow.ButtonClients.IsEnabled = true;
            mainWindow.ButtonWorkers.IsEnabled = true;
            mainWindow.ButtonLogOut.IsEnabled = true;
            mainWindow.lblAccount.IsEnabled = true;

            mainWindow.ButtonProcesses.Visibility = Visibility.Visible;
            mainWindow.ButtonClients.Visibility = Visibility.Visible;
            mainWindow.ButtonWorkers.Visibility = Visibility.Visible;
            mainWindow.ButtonLogOut.Visibility = Visibility.Visible;
            mainWindow.lblAccount.Visibility = Visibility.Visible;

        }
        public void LabelAccountUpdate() {
            mainWindow.lblAccount.Content = "";
        }
    }
}
