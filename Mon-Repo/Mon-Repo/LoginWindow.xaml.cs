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

namespace Mon_Repo
{
    /// <summary>
    /// Interaction logic for LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
       public LoginViewModel ViewModel { get; }
        public LoginWindow()
        {
            InitializeComponent();
            ViewModel = new LoginViewModel();
            DataContext = ViewModel;
        }
        private void LoginClick(object sender, RoutedEventArgs e)
        {
            ViewModel.Password = PasswordTextBox.Password;
            if (ViewModel.Login())
                Close();
            else
                MessageBox.Show("HIBA");
        }
    }
}
