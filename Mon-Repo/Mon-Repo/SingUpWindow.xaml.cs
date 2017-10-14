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

namespace Mon_Repo
{
    /// <summary>
    /// Interaction logic for SingUpWindow.xaml
    /// </summary>
    public partial class SingUpWindow : Window
        
    {
        SignUpViewModel sw = new SignUpViewModel();
        DataManager manager = new DataManager();
        public SingUpWindow()
        {
            DataContext = sw;
            InitializeComponent();
        }

        private void SignUpClick(object sender, RoutedEventArgs e)
        {
            string password1 = SignUpPassword1.Password;
            string password2 = SignUpPassword2.Password;
            sw.Reg(password1, password2);
            Close();
            MainWindow mw = new MainWindow();
            mw.ShowDialog();
        }
    }
}
