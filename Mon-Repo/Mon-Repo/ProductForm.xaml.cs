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
    /// Interaction logic for ProductForm.xaml
    /// </summary>
    public partial class ProductForm : Window
    {
        public ProductForm()
        {
            InitializeComponent();
        }

        private void SaveProductClick(object sender, RoutedEventArgs e)
        {
            if (((ProductFormViewModel)DataContext).Validate())
                Close();
            else
                MessageBox.Show("Hiba! Ár > 0, megnevezés > 4!");
        }
    }
}
