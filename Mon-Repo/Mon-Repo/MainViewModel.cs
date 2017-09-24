using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            Products = new ObservableCollection<Product>
            {
            new Product { Name = "Kenyér", Price = 10, Quantity = 10 },
            new Product { Name = "Tej", Price = 20, Quantity = 100 }
            };
        }
        public void AddCart()
        {
            SelectedProduct.Quantity -= 1;
            foreach (var item in AuthenticatedUser.ProductList)
            {
                if (SelectedProduct.Name == item.Name)
                {
                    item.Quantity++;
                    AuthenticatedUser.Money -= item.Price;
                    return;

                }
            }
            AuthenticatedUser.ProductList.Add(new Product { Name = SelectedProduct.Name, Price = SelectedProduct.Price, Quantity = 1 });
            AuthenticatedUser.Money -= SelectedProduct.Price;
        }
        public void RemoveCart()
        {
            CartSelectedProduct.Quantity --; 
            {
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
