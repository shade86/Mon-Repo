﻿using Mon_Repo.Dal;
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
            WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;
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

        private void BuyProduct(object sender, MouseButtonEventArgs e)
        {
            if (_vm.SelectedProduct != null)
            {
                if (_vm.SelectedProduct.Price > _vm.AuthenticatedUser.Money)
                    MessageBox.Show("Nincs elég pénz!");
                else if (_vm.SelectedProduct.Quantity == 0)
                    MessageBox.Show("A termék elfogyott");
                else _vm.AddCart();
            }
        }

        private void CartDoubleClick(object sender, MouseButtonEventArgs e)
        {
            _vm.RemoveCart(); 
        }

        private void ClickUp(object sender, MouseButtonEventArgs e)
        {
            if (_vm.CartSelectedProduct != null && _vm.CartSelectedProduct.Quantity == 0)
                _vm.AuthenticatedUser.ProductList.Remove(_vm.CartSelectedProduct);
            return;
        }

        private void LogoutClick(object sender, MouseButtonEventArgs e)
        {
           MessageBoxResult _questionResult = MessageBox.Show("Biztosan kijelentkezik?", "Kijelentkezés", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (_questionResult == MessageBoxResult.Yes)
            {
                System.Diagnostics.Process.Start(Application.ResourceAssembly.Location);
                Application.Current.Shutdown();
            }
                else return;
        }

        private void PurchasesClick(object sender, RoutedEventArgs e)
        {
            var _pvm = new PurchasesViewModel(_vm.AuthenticatedUser);
            var pw = new PurchasedProducts() { DataContext = _pvm };
            pw.ShowDialog();
        }

        private void StatisticsClick(object sender, RoutedEventArgs e)
        {
            var user = _vm.AuthenticatedUser;
            MessageBox.Show($"Össz. költség: {Statistics.SumSpent(user.ProductList)}Ft");
        }

        private void PurchaseClick(object sender, RoutedEventArgs e)
        {
            foreach (var item in _vm.AuthenticatedUser.ProductList)
            {
                MessageBox.Show($"Megvásárolt termék(ek): \n Termék megnevezése: {item.Name}\n Termék ára: {item.Price}\n Megvásárolt darabszám: {item.Quantity}");
            }
            _vm.CleanCart(); 
        }
    }
}
