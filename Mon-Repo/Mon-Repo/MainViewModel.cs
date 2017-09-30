using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mon_Repo.Dal;

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
            AuthenticatedUser.Money -= SelectedProduct.Price;
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
        public void RemoveCart()
        {
            if (CartSelectedProduct != null)
                CartSelectedProduct.Quantity --; 
            {
                if (CartSelectedProduct != null)
                    foreach (var item in Products)
                {
                    if (item.Name == CartSelectedProduct.Name)
                    {
                        item.Quantity++;
                        AuthenticatedUser.Money += item.Price;
                    }
                }
            }
        }
    }
}


    
