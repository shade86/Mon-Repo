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
        LoginViewModel ViewModel = new LoginViewModel();
        public LoginWindow()
        {
            InitializeComponent();
            
            DataContext = ViewModel;
        }
        private void LoginClick(object sender, RoutedEventArgs e)
        {
            ViewModel.LoginPassword = PasswordTextBox.Password;
            if (ViewModel.Login())
                Close();
            else
                MessageBox.Show("HIBA");
        }

        private void LoginWindowClosing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (!ViewModel.Login())
                e.Cancel = true;
        }

        private void ExitClick(object sender, RoutedEventArgs e)
        {
            System.Windows.Application.Current.Shutdown();
        }
        //BUTTON Animáció
        private void ExitMouseEnter(object sender, MouseEventArgs e)
        {
     /*    myScaleTransform.ScaleX = 2;
            ExitButton.Content = "Quit";
            ExitButton.FontSize =12;
         myScaleTransform.ScaleY = 1;*/
        }

        //BUTTON Animáció
        private void ExitMouseLeave(object sender, MouseEventArgs e)
        {
      /*     myScaleTransform.ScaleX = 1;
           myScaleTransform.ScaleY = 1;*/
        }

        private void UserTextChange(object sender, RoutedEventArgs e)
        {
          //  UserNameTextBox.Text = { Binding LoginName}
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
    }
}
