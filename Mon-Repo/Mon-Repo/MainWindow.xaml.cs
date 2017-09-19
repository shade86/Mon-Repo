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
        MainViewModel _vm = new MainViewModel();
        public MainWindow()
        {
            InitializeComponent();
            //  DataContext = new MainViewModel();
            // var lvm = new LoginViewModel();
            LoginWindow lw = new LoginWindow();
          /*  {
               DataContext = lvm
            };*/
            lw.ShowDialog();
            _vm.AuthenticatedUser = ((LoginViewModel)lw.DataContext).AuthenticatedUser;
            DataContext = _vm;
        }

        void NewProductClick(object sender, RoutedEventArgs e)
        {
            var vm = new ProductFormViewModel
            {
                Product = new Product()
            };
            var form = new ProductForm()
            {
                DataContext = vm
            };
            form.ShowDialog();
            if (vm.Validate())
                ((MainViewModel)DataContext).Products.Add(vm.Product);
        }

        private void EditProductClick(object sender, RoutedEventArgs e)
        {
            var SelectedProduct = ((MainViewModel)DataContext).SelectedProduct;
            if (SelectedProduct == null)
            {
                return;
            }
            var vm = new ProductFormViewModel

            {
                IsEdit = true,
                Product = ((MainViewModel)DataContext).SelectedProduct
            };
            var form = new ProductForm()
            {
                DataContext = vm
            };
            form.ShowDialog();

        }

        private void DeleteProductClick(object sender, RoutedEventArgs e)
        {
            var SelectedProduct = ((MainViewModel)DataContext).SelectedProduct;
            if (SelectedProduct == null)
            {
                return;
            }
            var vm = new ProductFormViewModel

            {

                Product = ((MainViewModel)DataContext).SelectedProduct
            };
            ((MainViewModel)DataContext).Products.Remove(vm.Product);
        }
    }
}
