using Kitchen_Fries.ServiceReference1;
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
using System.Windows.Threading;

namespace Kitchen_Fries
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ContractClient client;
        private ServiceUser clientUser;

        List<string> orders;

        int clientNum = 1;
        string clientName;
        bool isConnected = false;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            clientName = $"FRIES{clientNum}";
            ConnectionStatus.Text = "Offline";
            ClientName.Text = clientName;

            ConnectToService();

            orders = new List<string>();

            Orders.ItemsSource = orders;

            if (isConnected == true)
            {
                DispatcherTimer dispatcherTimer = new DispatcherTimer();
                dispatcherTimer.Tick += new EventHandler(dispatcherTimer_Tick);
                dispatcherTimer.Interval = new TimeSpan(0, 0, 1);
                dispatcherTimer.Start();
            }
            else
            {
                this.Close();
            }
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            try
            {
                if (client.TestConnection() == true)
                {
                    client.RemoveUser(clientUser);
                }
            }
            catch
            {

            }
        }

        #region Functions

        private void ConnectToService()
        {
            try
            {
                client = new ContractClient();
                clientUser = client.ClientConnect(clientName);
                isConnected = true;
                ConnectionStatus.Text = "Online";
            }
            catch
            {
                bool cancel = false;
                MessageBoxResult result = MessageBox.Show("Не удалось подключиться к серверу. Повторить попытку?", "Error", MessageBoxButton.YesNo, MessageBoxImage.Question);
                if (result == MessageBoxResult.Yes)
                {
                    while (cancel == false)
                    {
                        try
                        {
                            client = new ContractClient();
                            clientUser = client.ClientConnect(clientName);
                            cancel = true;
                            isConnected = true;
                            ConnectionStatus.Text = "Online";
                        }
                        catch
                        {
                            MessageBoxResult result2 = MessageBox.Show("Не удалось подключиться к серверу. Повторить попытку?", "Error", MessageBoxButton.YesNo, MessageBoxImage.Question);
                            if (result2 == MessageBoxResult.No)
                            {
                                cancel = true;
                            }
                        }
                    }
                }
                else
                {
                    this.Close();
                }
            }
        }

        private void dispatcherTimer_Tick(object sender, EventArgs e)
        {
            try
            {
                if (client.TestConnection() == true)
                {
                    ServiceMessage[] messages = client.GetNewMessages(clientUser);

                    if (messages != null)
                    {
                        foreach (var message in messages)
                        {
                            if (message.Message.Category_Id == 6)
                            {
                                orders.Add("\n" + "Terminal " + message.User.UserName + "(" + message.Date + "):\n" + message.Message.Name + "\n");
                            }
                        }
                        Orders.ItemsSource = null;
                        Orders.ItemsSource = orders;
                    }
                }
            }
            catch
            {
                ConnectionStatus.Text = "Offline";
                ConnectToService();
            }
        }

        private void ClearFirst_Click(object sender, RoutedEventArgs e)
        {
            orders.RemoveAt(0);
            Orders.ItemsSource = null;
            Orders.ItemsSource = orders;
        }

        private void ClearSelected_Click(object sender, RoutedEventArgs e)
        {
            orders.RemoveAt(Orders.SelectedIndex);
            Orders.ItemsSource = null;
            Orders.ItemsSource = orders;
        }

        #endregion
    }
}
