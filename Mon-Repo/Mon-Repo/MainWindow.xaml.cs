using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
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
        const string FileName = @"C:\1\Users.txt";
        public MainWindow()
        {

            InitializeComponent();
        }

        private void PasswordKeyDown(object sender, KeyEventArgs e)
        {
            if (Keyboard.GetKeyStates(Key.CapsLock) == KeyStates.Toggled)
            {
                ToolTip CapsSign = new ToolTip();
                CapsSign.Content = "A Caps Lock be van kapcsolva!";
                CapsSign.Placement = PlacementMode.Bottom;
                CapsSign.PlacementTarget = sender as UIElement;
              
              
                PasswordBox.ToolTip = CapsSign;
                CapsSign.IsOpen = true;
            }
            else
            {
               
                    PasswordBox.ToolTip = null;
            }
        }

        private void SignInClick(object sender, RoutedEventArgs e)
        {
            // BELÉPÉS USERNAME CHECK, egyelőre nem működik rendesen
            StringCollection UserSearch = new StringCollection();
            UserSearch.Add(UserTextBox.Text);


            StreamReader FileReader = new StreamReader(FileName);
            string FileContents;
            FileContents = FileReader.ReadToEnd();
            FileReader.Close();
            foreach (string s in UserSearch)
            {
                if (FileContents.Contains(s))
                    MessageBox.Show("Sikeres belépés");
                var signin = new ProductList();
                Close();
                signin.ShowDialog();
            }
            
        

                  
        }
    }
}