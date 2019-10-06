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
using System.Windows.Shapes;

namespace Client_Wpf
{
    /// <summary>
    /// Логика взаимодействия для ManagerConfirmWindow.xaml
    /// </summary>
    public partial class ManagerConfirmWindow : Window
    {
        public ManagerConfirmWindow()
        {
            InitializeComponent();
        }

        private void Accept_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = true;
        }

        public string Login
        {
            get { return tbLogin.Text; }
        }
        
        public string Password
        {
            get { return tbPassword.Text; }
        }
    }
}
