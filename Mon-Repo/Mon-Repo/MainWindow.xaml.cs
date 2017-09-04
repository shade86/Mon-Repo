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

namespace Mon_Repo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void PasswordTextBoxClick(object sender, RoutedEventArgs e)
        {
            if (PasswordTextBox.Text == "Jelszó")
            PasswordTextBox.Text = "";
        }

        private void PasswordTextBoxUnclick(object sender, RoutedEventArgs e)
        {
            if (PasswordTextBox.Text == "")
                PasswordTextBox.Text = "Jelszó";
        }

        private void UserTextBoxClick(object sender, RoutedEventArgs e)
        {
            if (UserTextBox.Text == "Felhasználó")
            UserTextBox.Text = "";
        }

        private void UserTextBoxUnclick(object sender, RoutedEventArgs e)
        {
            if (UserTextBox.Text == "")
                UserTextBox.Text = "Felhasználó";
        }
    }
}
