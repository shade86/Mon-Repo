using System;
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
        public ObservableCollection<User>Users { get; set; }
        public ObservableCollection<Product> Products { get; set; }
        public ObservableCollection<Purchase> Purchases { get; set; }
        public Product SelectedProduct { get; set; }
        public Product CartSelectedProduct { get; set; }
        public User AuthenticatedUser { get; set; }
        public int _sumcart { get; set; }

        

        public void SumCart()
        {
            sum = 0;
            foreach (var item in AuthenticatedUser.ProductList)
            {
                sum += (item.Price * item.Quantity);
            }
            _sumcart = sum;
        }

        public MainViewModel()
        {
            
            Products = new ObservableCollection<Product>();
            //DB szerkesztés
            // var ctx = new Context();
            var manager = new DataManager();
            foreach (var product in manager.GetProductList())
            {
                Products.Add(new Product(product));
            }


            Users = new ObservableCollection<User>();
            foreach (var user in manager.GetUserList())
            {
                Users.Add(new User(user));
            }


            //TODO purchases
            /*Purchases = new ObservableCollection<Purchase>();
            foreach (var purchase in manager.GetPurchasesOfUser())
            {
                Purchases.Add(new Purchase(purchase));
            }*/
        }
       

        public void Delete()
        {
            var manager = new DataManager();
            if (SelectedProduct == null)
            {
                MessageBox.Show("Nincs termék kiválasztva!");
                return;
            }
            else
            {
                manager.DeleteProduct(SelectedProduct.Name, SelectedProduct.Price);
                Products.Remove(SelectedProduct);
                MessageBox.Show("Termék törölve!");
            }
            
        }
        public void AddToProducts(string productname, int productprice, int productquantity)
        {
            Products.Add(new Product
            {
                Name = productname,
                Quantity = productquantity,
                Price = productprice
            });
        }


        public void Purchase()
        {
            var manager = new DataManager();
            foreach (var product in AuthenticatedUser.ProductList)
            {
                manager.Buy(product.Name, product.Quantity, product.Price, AuthenticatedUser.Username);
               
            }
            AuthenticatedUser.ProductList.Clear();
        }

        public int sum = 0;

        public string AddCart()
        {
            if (SelectedProduct.Price > AuthenticatedUser.Money)
                return "Nincs elég pénz";
            if (SelectedProduct.Quantity == 0)
                return "Nincs elég termék";
            var product = FindProduct(SelectedProduct.Name);
            if (product == null)
            {
                AuthenticatedUser.ProductList.Add(new Product
                {
                    Name = SelectedProduct.Name,
                    Price = SelectedProduct.Price,
                    Quantity = 1
                });
                AuthenticatedUser.Money -= SelectedProduct.Price;
                sum = sum + SelectedProduct.Price;
            }
            else
            {
                product.Quantity++;
                AuthenticatedUser.Money -= SelectedProduct.Price;
                sum = sum + SelectedProduct.Price;
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
                    item2.Quantity += item.Quantity;
            }
                AuthenticatedUser.ProductList.Clear();
            AuthenticatedUser.Money += sum;
            sum = 0;
            }
        public void ClearCartPurchase()
        {
            foreach (var item in AuthenticatedUser.ProductList)
                foreach (var item2 in Products)
                {
                    if (item.Name == item2.Name)
                        item2.Quantity++;
                }
            AuthenticatedUser.ProductList.Clear();
            sum = 0;
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


    
