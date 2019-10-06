using Client_Wpf.ServiceReference1;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Resources;
using System.Windows.Shapes;

namespace Client_Wpf
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        #region Values

        ContractClient client;
        ServiceUser clientUser;

        DtoGood[] goods;
        DtoUser[] users;

        DtoUser user;

        public ObservableCollection<DtoGood> curOrderList;
        List<PreviousOrder> prevOrderList;

        int count = 1;
        string bCount = "";
        int curentItem;

        int terminalNum = 1;
        string terminalName;
        bool isConnected = false;

        #endregion

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            terminalName = $"TRM{terminalNum}";
            TermName.Text = terminalName;
            TermConnection.Text = "Offline";
            TermUser.Text = "User not logged on";

            ConnectToService();

            if (isConnected == true)
            {
                goods = client.GetGoods();
                users = client.GetUsers();

                curOrderList = new ObservableCollection<DtoGood>();
                CurrentOrder.ItemsSource = curOrderList;

                prevOrderList = new List<PreviousOrder>();
                PrevOrdersItem.ItemsSource = prevOrderList.Select(p => p.List).FirstOrDefault();
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


        #region Menu buttons

        private void MainButton_Click(object sender, RoutedEventArgs e)
        {
            MainMenu.ItemsSource = null;
            var main = goods.Where(g => g.Category_Id == 2 || g.Category_Id == 3 || g.Category_Id == 4 || g.Category_Id == 5 || g.Category_Id == 13);
            List<Button> mainBtns = new List<Button>();
            foreach (var n in main)
            {
                mainBtns.Add(CreateButton(n));
            }
            MainMenu.ItemsSource = mainBtns;
        }

        private void DrinkButton_Click(object sender, RoutedEventArgs e)
        {
            MainMenu.ItemsSource = null;
            var main = goods.Where(g => g.Category_Id == 1);
            List<Button> mainBtns = new List<Button>();
            foreach (var n in main)
            {
                mainBtns.Add(CreateButton(n));
            }
            MainMenu.ItemsSource = mainBtns;
        }

        private void PotatoButton_Click(object sender, RoutedEventArgs e)
        {
            MainMenu.ItemsSource = null;
            var main = goods.Where(g => g.Category_Id == 6);
            List<Button> mainBtns = new List<Button>();
            foreach (var n in main)
            {
                mainBtns.Add(CreateButton(n));
            }
            MainMenu.ItemsSource = mainBtns;
        }

        private void HotDrinkButton_Click(object sender, RoutedEventArgs e)
        {
            MainMenu.ItemsSource = null;
            var main = goods.Where(g => g.Category_Id == 8);
            List<Button> mainBtns = new List<Button>();
            foreach (var n in main)
            {
                mainBtns.Add(CreateButton(n));
            }
            MainMenu.ItemsSource = mainBtns;
        }

        private void DessertButton_Click(object sender, RoutedEventArgs e)
        {
            MainMenu.ItemsSource = null;
            var main = goods.Where(g => g.Category_Id == 9);
            List<Button> mainBtns = new List<Button>();
            foreach (var n in main)
            {
                mainBtns.Add(CreateButton(n));
            }
            MainMenu.ItemsSource = mainBtns;
        }

        private void IceCreamButton_Click(object sender, RoutedEventArgs e)
        {
            MainMenu.ItemsSource = null;
            var main = goods.Where(g => g.Category_Id == 10);
            List<Button> mainBtns = new List<Button>();
            foreach (var n in main)
            {
                mainBtns.Add(CreateButton(n));
            }
            MainMenu.ItemsSource = mainBtns;
        }

        private void SaladButton_Click(object sender, RoutedEventArgs e)
        {
            MainMenu.ItemsSource = null;
            var main = goods.Where(g => g.Category_Id == 7);
            List<Button> mainBtns = new List<Button>();
            foreach (var n in main)
            {
                mainBtns.Add(CreateButton(n));
            }
            MainMenu.ItemsSource = mainBtns;
        }

        private void SauceButton_Click(object sender, RoutedEventArgs e)
        {
            MainMenu.ItemsSource = null;
            var main = goods.Where(g => g.Category_Id == 11 || g.Category_Id == 12);
            List<Button> mainBtns = new List<Button>();
            foreach (var n in main)
            {
                mainBtns.Add(CreateButton(n));
            }
            MainMenu.ItemsSource = mainBtns;
        }

        #endregion

        #region Side bar buttons

        private void Promo_Click(object sender, RoutedEventArgs e)
        {
            if (CurrentOrder.SelectedItem != null)
            {
                if (ManagerConfirm())
                {
                    curOrderList.Where(o => o == (CurrentOrder.SelectedItem as DtoGood)).FirstOrDefault().Price = 0;

                    CurrentOrder.SelectedItem = null;
                    CurrentOrder.SelectedIndex = 0;
                    OptionalButtons.ItemsSource = null;

                    CurrentOrder.ItemsSource = null;
                    CurrentOrder.ItemsSource = curOrderList;


                    CalculatePrice();
                }
                else
                {
                    MessageBox.Show("Авторизация не пройдена");
                }
            }
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            if (CurrentOrder.SelectedItem != null)
            {
                curOrderList.Remove(CurrentOrder.SelectedItem as DtoGood);
                CurrentOrder.SelectedItem = null;
                CurrentOrder.SelectedIndex = 0;
                OptionalButtons.ItemsSource = null;
                CalculatePrice();
            }
        }

        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            count = 1;
            bCount = "";
            tCount.Text = bCount;
            CurrentOrder.SelectedItem = null;
            CurrentOrder.SelectedIndex = 0;
        }

        private void MenuCrew_Click(object sender, RoutedEventArgs e)
        {
            MainMenu.ItemsSource = null;
            List<Button> mainBtns = new List<Button>();

            Button btn = new Button();
            btn.HorizontalAlignment = HorizontalAlignment.Stretch;
            btn.VerticalAlignment = VerticalAlignment.Stretch;
            btn.Margin = new Thickness(3);
            btn.BorderThickness = new Thickness(0);

            Grid grid = new Grid();
            grid.VerticalAlignment = VerticalAlignment.Center;
            grid.HorizontalAlignment = HorizontalAlignment.Center;

            TextBlock tb = new TextBlock();
            tb.Text = "Block terminal";
            tb.Foreground = Brushes.White;
            tb.TextWrapping = TextWrapping.Wrap;
            tb.FontSize = 15;
            tb.TextAlignment = TextAlignment.Center;
            tb.VerticalAlignment = VerticalAlignment.Center;
            tb.FontWeight = FontWeights.Bold;
            tb.Effect = new DropShadowEffect { ShadowDepth = 0, Color = Colors.Black, Opacity = 1, BlurRadius = 10 };

            grid.Children.Add(tb);

            btn.Content = grid;

            btn.Click += BlockTerminal;

            Style style = this.FindResource("GoodBtnsStyle") as Style;
            btn.Style = style;

            mainBtns.Add(btn);

            MainMenu.ItemsSource = mainBtns;
        }

        private void MenuManage_Click(object sender, RoutedEventArgs e)
        {
            MainMenu.ItemsSource = null;
            List<Button> mainBtns = new List<Button>();

            Button btn = new Button();
            btn.HorizontalAlignment = HorizontalAlignment.Stretch;
            btn.VerticalAlignment = VerticalAlignment.Stretch;
            btn.Margin = new Thickness(3);
            btn.BorderThickness = new Thickness(0);

            Grid grid = new Grid();
            grid.VerticalAlignment = VerticalAlignment.Center;
            grid.HorizontalAlignment = HorizontalAlignment.Center;

            TextBlock tb = new TextBlock();
            tb.Text = "Login user";
            tb.Foreground = Brushes.White;
            tb.TextWrapping = TextWrapping.Wrap;
            tb.FontSize = 15;
            tb.TextAlignment = TextAlignment.Center;
            tb.VerticalAlignment = VerticalAlignment.Center;
            tb.FontWeight = FontWeights.Bold;
            tb.Effect = new DropShadowEffect { ShadowDepth = 0, Color = Colors.Black, Opacity = 1, BlurRadius = 10 };

            grid.Children.Add(tb);
            btn.Content = grid;
            btn.Click += LogIn;

            Button btn2 = new Button();
            btn2.HorizontalAlignment = HorizontalAlignment.Stretch;
            btn2.VerticalAlignment = VerticalAlignment.Stretch;
            btn2.Margin = new Thickness(3);
            btn2.BorderThickness = new Thickness(0);

            Grid grid2 = new Grid();
            grid2.VerticalAlignment = VerticalAlignment.Center;
            grid2.HorizontalAlignment = HorizontalAlignment.Center;

            TextBlock tb2 = new TextBlock();
            tb2.Text = "Logoff user";
            tb2.Foreground = Brushes.White;
            tb2.TextWrapping = TextWrapping.Wrap;
            tb2.FontSize = 15;
            tb2.TextAlignment = TextAlignment.Center;
            tb2.VerticalAlignment = VerticalAlignment.Center;
            tb2.FontWeight = FontWeights.Bold;
            tb2.Effect = new DropShadowEffect { ShadowDepth = 0, Color = Colors.Black, Opacity = 1, BlurRadius = 10 };

            grid2.Children.Add(tb2);
            btn2.Content = grid2;
            btn2.Click += LogOff;

            Style style = this.FindResource("GoodBtnsStyle") as Style;
            btn.Style = style;
            btn2.Style = style;

            mainBtns.Add(btn);
            mainBtns.Add(btn2);

            MainMenu.ItemsSource = mainBtns;
        }

        private void Outside_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if(client.TestConnection() == true)
                {
                    if (curOrderList.Count != 0)
                    {
                        DtoGood[] list = curOrderList.ToArray();
                        client.SendOrder(list, user, terminalNum);
                        prevOrderList.Add(new PreviousOrder() { Type = "Out", List = curOrderList.ToList() });
                        curOrderList.Clear();
                        curentItem = prevOrderList.Count();
                        countOfPrevOrd.Text = prevOrderList.Count().ToString();
                        PrevOrdersItem.ItemsSource = prevOrderList.Select(s => s.List).LastOrDefault();
                        TypeOrder.Text = prevOrderList.Select(s => s.Type).LastOrDefault();
                        numOfPrevOrd.Text = curentItem.ToString();
                        OptionalButtons.ItemsSource = null;
                    }
                }
            }
            catch
            {
                TermConnection.Text = "Offline";
                ConnectToService();
            }
        }

        private void Inside_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (client.TestConnection() == true)
                {
                    if (curOrderList.Count != 0)
                    {
                        DtoGood[] list = curOrderList.ToArray();
                        client.SendOrder(list, user, 1);
                        prevOrderList.Add(new PreviousOrder() { Type = "In", List = curOrderList.ToList() });
                        curOrderList.Clear();
                        curentItem = prevOrderList.Count();
                        countOfPrevOrd.Text = curentItem.ToString();
                        PrevOrdersItem.ItemsSource = prevOrderList.Select(s => s.List).LastOrDefault();
                        TypeOrder.Text = prevOrderList.Select(s => s.Type).LastOrDefault();
                        numOfPrevOrd.Text = curentItem.ToString();
                        OptionalButtons.ItemsSource = null;
                    }
                }
            }
            catch
            {
                TermConnection.Text = "Offline";
                ConnectToService();
            }
        }

        #endregion

        #region Functions

        private void ConnectToService()
        {
            try
            {
                client = new ContractClient();
                clientUser = client.ClientConnect(terminalName);
                isConnected = true;
                TermConnection.Text = "Online";
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
                            clientUser = client.ClientConnect(terminalName);
                            cancel = true;
                            isConnected = true;
                            TermConnection.Text = "Online";
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

        private bool ManagerConfirm()
        {
            bool isConfirmed = false;
            ManagerConfirmWindow confirmWindow = new ManagerConfirmWindow();
            if (confirmWindow.ShowDialog() == true)
            {
                foreach (var n in users.Where(u => u.Role_Id == 2))
                {
                    if (n.Login == confirmWindow.Login && n.Password == confirmWindow.Password)
                    {
                        isConfirmed = true;
                        return true;
                    }
                }
                if (isConfirmed == false)
                {
                    MessageBox.Show("Неверный логин или пароль");
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Авторизация не пройдена");
            }
            return false;
        }

        private Button CreateButton(DtoGood good)
        {
            Button btn = new Button();

            btn.Background = Brushes.LightGray;

            btn.Margin = new Thickness(3);
            btn.BorderThickness = new Thickness(0);

            Style style = this.FindResource("GoodBtnsStyle") as Style;
            btn.Style = style;

            btn.ToolTip = good.Price;

            Grid grid = new Grid();
            grid.VerticalAlignment = VerticalAlignment.Center;
            grid.HorizontalAlignment = HorizontalAlignment.Center;


            var str = $"Images/{good.Image}.png";
            Image img = new Image();
            img.Source = new BitmapImage(new Uri(str, UriKind.Relative));
            img.HorizontalAlignment = HorizontalAlignment.Stretch;
            img.VerticalAlignment = VerticalAlignment.Stretch;

            grid.Children.Add(img);

            TextBlock tb = new TextBlock();
            tb.Text = good.Name;
            tb.Foreground = Brushes.White;
            tb.TextWrapping = TextWrapping.Wrap;
            tb.FontSize = 15;
            tb.TextAlignment = TextAlignment.Center;
            tb.VerticalAlignment = VerticalAlignment.Center;
            tb.FontWeight = FontWeights.Bold;
            tb.Effect = new DropShadowEffect { ShadowDepth = 0, Color = Colors.Black, Opacity = 1, BlurRadius = 10 };

            grid.Children.Add(tb);

            btn.Content = grid;

            btn.Click += (s, e) => SendOrder(good);

            return btn;
        }

        private void SendOrder(DtoGood good)
        {
            try
            {
                if(client.TestConnection() == true)
                {
                    if (user != null)
                    {
                        DtoGood orderGood = new DtoGood()
                        {
                            Id = good.Id,
                            Name = good.Name,
                            Image = good.Image,
                            Price = good.Price,
                            Category_Id = good.Category_Id
                        };

                        ServiceMessage newMessage = new ServiceMessage()
                        {
                            Date = DateTime.Now,
                            Message = orderGood,
                            User = clientUser
                        };

                        while (count > 0)
                        {
                            client.SendNewMessage(newMessage);
                            curOrderList.Add(orderGood);
                            count--;
                        }
                        CurrentOrder.SelectedIndex = CurrentOrder.Items.Count - 1;
                        count = 1;
                        bCount = "";
                        tCount.Text = bCount;
                        CalculatePrice();
                    }
                    else
                    {
                        MessageBox.Show("User not logged on!", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                }
            }
            catch
            {
                TermConnection.Text = "Offline";
                ConnectToService();
            }
        }

        private void CalculatePrice()
        {
            decimal price = 0;
            foreach (var n in curOrderList)
            {
                price += n.Price;
            }
            CurrentOrderPrice.Text = price.ToString();

        }

        private void BCount_Click(object sender, RoutedEventArgs e)
        {
            Button b = sender as Button;
            bCount += b.Content;
            count = Convert.ToInt32(bCount);
            tCount.Text = bCount;
        }

        private void LogIn(object sender, RoutedEventArgs e)
        {
            if(user == null)
            {
                if (ManagerConfirm())
                {
                    bool isLoggedOn = false;
                    LoginWindow logWindow = new LoginWindow();
                    if (logWindow.ShowDialog() == true)
                    {
                        foreach (var n in users)
                        {
                            if (n.Login == logWindow.Login)
                            {
                                user = n;
                                TermUser.Text = $"User: {user.Name}";
                                MessageBox.Show("Авторизация пройдена");
                                isLoggedOn = true;
                                break;
                            }
                        }
                        if (isLoggedOn == false)
                        {
                            MessageBox.Show("Неверный логин");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Авторизация не пройдена");
                    }
                }
            }
            else
            {
                MessageBox.Show("Пользователь авторизован!", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void LogOff(object sender, RoutedEventArgs e)
        {
            if (ManagerConfirm())
            {
                if (MessageBox.Show("LogOut?", "Question", MessageBoxButton.YesNo, MessageBoxImage.Warning) == MessageBoxResult.Yes)
                {
                    user = null;
                    TermUser.Text = "User not logged on";
                }
            }
        }

        private void BlockTerminal(object sender, RoutedEventArgs e)
        {
            BlockWindow.Visibility = Visibility.Visible;
        }

        private void BlockWindow_Click(object sender, RoutedEventArgs e)
        {
            if (ManagerConfirm())
            {
                BlockWindow.Visibility = Visibility.Hidden;
            }
        }

        private void CurrentOrder_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (CurrentOrder.SelectedItem != null)
            {
                var good = CurrentOrder.SelectedItem as DtoGood;
                if (good.Category_Id == 6)
                {
                    OptionalButtons.ItemsSource = null;
                    var main = goods.Where(g => g.Category_Id == 11);
                    List<Button> mainBtns = new List<Button>();
                    foreach (var n in main)
                    {
                        mainBtns.Add(CreateButton(n));
                    }
                    OptionalButtons.ItemsSource = mainBtns;
                }
                else if (good.Category_Id == 7)
                {
                    OptionalButtons.ItemsSource = null;
                    var main = goods.Where(g => g.Category_Id == 12);
                    List<Button> mainBtns = new List<Button>();
                    foreach (var n in main)
                    {
                        mainBtns.Add(CreateButton(n));
                    }
                    OptionalButtons.ItemsSource = mainBtns;
                }
                else if (good.Category_Id == 8)
                {
                    OptionalButtons.ItemsSource = null;
                    var main = goods.Where(g => g.Category_Id == 9);
                    List<Button> mainBtns = new List<Button>();
                    foreach (var n in main)
                    {
                        mainBtns.Add(CreateButton(n));
                    }
                    OptionalButtons.ItemsSource = mainBtns;
                }
                else if (good.Category_Id == 13)
                {
                    OptionalButtons.ItemsSource = null;
                    var main = goods.Where(g => g.Category_Id == 11);
                    List<Button> mainBtns = new List<Button>();
                    foreach (var n in main)
                    {
                        mainBtns.Add(CreateButton(n));
                    }
                    OptionalButtons.ItemsSource = mainBtns;
                }
                else
                {
                    OptionalButtons.ItemsSource = null;
                }
            }

        }

        #endregion

        #region Past orders list functons

        private void bNextOrder_Click(object sender, RoutedEventArgs e)
        {
            if(curentItem < prevOrderList.Count())
            {
                curentItem++;
                var n = curentItem;
                numOfPrevOrd.Text = curentItem.ToString();
                PrevOrdersItem.ItemsSource = prevOrderList[--n].List;
                TypeOrder.Text = prevOrderList[n].Type;
            }
        }

        private void bPrevOrder_Click(object sender, RoutedEventArgs e)
        {
            if (curentItem > 1)
            {
                curentItem--;
                var n = curentItem;
                numOfPrevOrd.Text = curentItem.ToString();
                PrevOrdersItem.ItemsSource = prevOrderList[--n].List;
                TypeOrder.Text = prevOrderList[n].Type;
            }
        }

        private void ButtonServiced_Click(object sender, RoutedEventArgs e)
        {
            if(prevOrderList.Count != 0)
            {
                var n = curentItem;
                n--;
                prevOrderList.RemoveAt(n);
                if (n == 0)
                {
                    if (prevOrderList.Count == 0)
                    {
                        PrevOrdersItem.ItemsSource = null;
                        curentItem = 0;
                        numOfPrevOrd.Text = curentItem.ToString();
                        TypeOrder.Text = "";
                    }
                    else
                    {
                        PrevOrdersItem.ItemsSource = prevOrderList[0].List;
                        curentItem = 1;
                        numOfPrevOrd.Text = curentItem.ToString();
                        TypeOrder.Text = prevOrderList[0].Type;
                    }
                }
                else
                {
                    PrevOrdersItem.ItemsSource = prevOrderList[--n].List;
                    TypeOrder.Text = prevOrderList[n].Type;
                    curentItem = ++n;
                    numOfPrevOrd.Text = curentItem.ToString();
                }
                countOfPrevOrd.Text = prevOrderList.Count().ToString();
            }
        }

        #endregion

    }
}
