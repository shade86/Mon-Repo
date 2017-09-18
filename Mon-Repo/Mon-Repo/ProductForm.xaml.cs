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
                MessageBox.Show("Hiba: A termék neve legalább 4 karakter kell hogy legyen, mennyisége és az ára legalább 0!");
        }

        private void OnClosing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            e.Cancel = ((ProductFormViewModel)DataContext).OnWindowClosing();
            if ((((ProductFormViewModel)DataContext).OnWindowClosing() == true))
                MessageBox.Show("Hiba: A termék neve legalább 4 karakter kell hogy legyen, mennyisége és az ára legalább 0!");


        }
    }
}
