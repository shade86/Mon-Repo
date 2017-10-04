﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mon_Repo.Dal;
using System.Windows;
using System.Windows.Data;

namespace Mon_Repo
{
    public class MainViewModel : BaseModel
    {
        public ObservableCollection<Product> Products { get; set; }
        public Product SelectedProduct { get; set; }
        public Product CartSelectedProduct { get; set; }
        public User AuthenticatedUser { get; set; }
        public MainViewModel()
        {
            Products = new ObservableCollection<Product>();
            var ctx = new Context();
            foreach (var product in ctx.Products)
            {
                Products.Add(new Product(product));
            }
        }
        public string AddCart()
        {
            if (SelectedProduct.Price > AuthenticatedUser.Money)
                return "Nincs elég pénz";
            if (SelectedProduct.Quantity == 0)
                return "Nincs elég termék";
            var product = FindProduct(SelectedProduct.Name);
            if (product == null)
                AuthenticatedUser.ProductList.Add(new Product
                {
                    Name = SelectedProduct.Name,
                    Price = SelectedProduct.Price,
                    Quantity = 1
                });
            else
            {
                product.Quantity++;
            }
            SelectedProduct.Quantity--;
            return null;
        }

        Product FindProduct(string name)
        {
            foreach (var product in AuthenticatedUser.ProductList)
                if (product.Name == name)
                    return product;
            return null;
        }
        public string RemoveCart()
        {
           if (CartSelectedProduct == null)
            { return null; }
            var product = FindProduct(CartSelectedProduct.Name);
            if (SelectedProduct == null)
            {
                Products.Add(new Product
                {
                    Name = product.Name, Price = product.Price, Quantity = 1});
                }
            if (product != null)
                {
                product.Quantity--;
                foreach (var item in Products)
                    {
                    if (item.Name == product.Name)
                        {
                            item.Quantity++;
                        }
                    }
                }
            return null;
        }

        public void PurchaseFromCart()
        {
            if (AuthenticatedUser.Money > Statistics.SumSpent(AuthenticatedUser.ProductList))

                foreach (var item in AuthenticatedUser.ProductList)
                {
                    if (item.Name != null)
                    {
                        AuthenticatedUser.PurchasedProductsList.Add(new Product
                        {
                            Name = item.Name,
                            Price = item.Price,
                            Quantity = item.Quantity,
                            BuyDate = item.BuyDate

                        });
                    }
                }
            else{
                MessageBox.Show($"Nincs elég pénz a művelet végrehajtásához!");
                return;
            }
            
           
            AuthenticatedUser.Money -= Statistics.SumSpent(AuthenticatedUser.ProductList);
            AuthenticatedUser.ProductList.Clear();
        }
        public void ClearCart()
            {
            foreach (var item in AuthenticatedUser.ProductList)
                foreach (var item2 in Products)
                { 
                if (item.Name == item2.Name)
                    item2.Quantity++;
            }
                AuthenticatedUser.ProductList.Clear();
            }
        public void ListOrderABC()
        {
            var list = Products.Cast<Product>().OrderBy(item => item.Name).ToList();
            Products.Clear();
            foreach (Product product in list)
            {
                Products.Add(product);
            }
        }
        public void ListOrderPriceAsc()
        {
            var list = Products.Cast<Product>().OrderBy(item => item.Price).ToList();
            Products.Clear();
            foreach (Product product in list)
            {
                Products.Add(product);
            }
        }
        public void ListOrderPriceDesc()
        {
            var list = Products.Cast<Product>().OrderByDescending(item => item.Price).ToList();
            Products.Clear();
            foreach (Product product in list)
            {
                Products.Add(product);
            }
        }
        public void ListOrderQuantityAsc()
        {
            var list = Products.Cast<Product>().OrderBy(item => item.Quantity).ToList();
            Products.Clear();
            foreach (Product product in list)
            {
                Products.Add(product);
            }
        }
        public void ListOrderQuantityDesc()
        {
            var list = Products.Cast<Product>().OrderByDescending(item => item.Quantity).ToList();
            Products.Clear();
            foreach (Product product in list)
            {
                Products.Add(product);
            }
        }




        public void CartListOrderABC()
        {
            var list = AuthenticatedUser.ProductList.Cast<Product>().OrderBy(item => item.Name).ToList();
            AuthenticatedUser.ProductList.Clear();
            foreach (Product product in list)
            {
                AuthenticatedUser.ProductList.Add(product);
            }
        }
        public void CartListOrderPriceAsc()
        {
            var list = AuthenticatedUser.ProductList.Cast<Product>().OrderBy(item => item.Price).ToList();
            AuthenticatedUser.ProductList.Clear();
            foreach (Product product in list)
            {
                AuthenticatedUser.ProductList.Add(product);
            }
        }
        public void CartListOrderPriceDesc()
        {
            var list = AuthenticatedUser.ProductList.Cast<Product>().OrderByDescending(item => item.Price).ToList();
            AuthenticatedUser.ProductList.Clear();
            foreach (Product product in list)
            {
                AuthenticatedUser.ProductList.Add(product);
            }
        }
        public void CartListOrderQuantityAsc()
        {
            var list = AuthenticatedUser.ProductList.Cast<Product>().OrderBy(item => item.Quantity).ToList();
            AuthenticatedUser.ProductList.Clear();
            foreach (Product product in list)
            {
                AuthenticatedUser.ProductList.Add(product);
            }
        }
        public void CartListOrderQuantityDesc()
        {
            var list = AuthenticatedUser.ProductList.Cast<Product>().OrderByDescending(item => item.Quantity).ToList();
            AuthenticatedUser.ProductList.Clear();
            foreach (Product product in list)
            {
                AuthenticatedUser.ProductList.Add(product);
            }
        }

    }
}


    
