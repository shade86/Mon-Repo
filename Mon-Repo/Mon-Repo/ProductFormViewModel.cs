using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mon_Repo.Dal;

namespace Mon_Repo
{
    public class ProductFormViewModel : BaseModel
    {
        public string productname { get; set; }
        public int productquantity { get; set; }
        public int productprice { get; set; }
        public Product Product { get; set; }


        public ProductFormViewModel(Product Product)
        {
            this.Product = Product;
        }

        public bool AddProduct()
        {
            var vm = new MainViewModel();
            var manager = new DataManager();
            if (Validate())
            {
                if  (manager.AddProductDb(Product.Name, Product.Price, Product.Quantity))
                {
                    vm.Products.Add(Product);
                    return true;
                }
                    
                return false;

            }
            else return false;
        }
        public bool Validate()
        {
            return Product.Name != null &&
                Product.Name.Length > 0 &&
                Product.Price > -1 &&
                Product.Quantity > 0;
        }


        public bool IsEdit { get; set; }

        public bool OnWindowClosing()
        {
            return
           IsEdit == true
                &&
                Validate() != true;
        }
    }
}
