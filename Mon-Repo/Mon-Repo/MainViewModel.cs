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
        public MainViewModel()
        {
            Products = new ObservableCollection<Product>
            {
            new Product { Name = "Kenyér", Price = 10 },
            new Product { Name = "Tej", Price = 20 }
            };
        }
    }
}
