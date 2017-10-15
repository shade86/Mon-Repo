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
using Mon_Repo.Dal;
using System.Security.Cryptography;
using Mon_Repo;

namespace Mon_Repo
{
    /// <summary>
    /// Interaction logic for LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        public List<UserDbModel> Users { get; }
        AdminWindow aw = new AdminWindow();
        SingUpWindow sw = new SingUpWindow();
        public LoginViewModel ViewModel;
        DataManager manager = new DataManager();
        public string password { get; set; }
        public LoginWindow()
        {
            InitializeComponent();
            this.PreviewKeyDown += new KeyEventHandler(HandleEsc);
            WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;
            ViewModel = new LoginViewModel();
            DataContext = ViewModel;
        }
        private void LoginClick(object sender, RoutedEventArgs e)
        {
            ViewModel.password = PasswordTextBox.Password;
            if (ViewModel.Login())
                Close();
            else
                MessageBox.Show("Hibás felhasználónév vagy jelszó!");
        }
        private void LoginWindowClosing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (!ViewModel.Login())
                e.Cancel = true;
        }
        private void ExitClick(object sender, RoutedEventArgs e)
        {
            MessageBoxResult _questionResult = MessageBox.Show("Biztosan kilép a programból?", "Kilépés", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (_questionResult == MessageBoxResult.Yes)
                {
                System.Windows.Application.Current.Shutdown();
                }
                    else return;
        }
        private void PasswordTextboxClick(object sender, RoutedEventArgs e)
        {
            PasswordTextBox.Password = "";
        }
        private void PasswordTextBoxLostFocus(object sender, RoutedEventArgs e)
        {
            if (PasswordTextBox.Password == "")
            PasswordTextBox.Password = "Jelszó";
        }
        private void HandleEsc(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Escape)
            {
                MessageBoxResult _questionResult = MessageBox.Show("Biztosan kilép a programból?", "Kilépés", MessageBoxButton.YesNo, MessageBoxImage.Question);
                if (_questionResult == MessageBoxResult.Yes)
                {
                    System.Windows.Application.Current.Shutdown();
                }
                    else return;
            }
        }
        private void NewUserClick(object sender, RoutedEventArgs e)
        {
            sw.ShowDialog();
            DataContext = new SignUpViewModel();
        }
        private void AdminClick(object sender, MouseButtonEventArgs e)
            //HIDDEN OBJECT CLICK
        {
            aw.ShowDialog();
        }
        private void Drag(object sender, MouseButtonEventArgs e)
        {
        if (e.ChangedButton == MouseButton.Left)
        DragMove();
        }
    }
}
