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
        public bool Validate()
        {
            return productname != null &&
                productname.Length > 0 &&
                productprice > -1 &&
                productquantity > 0;
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
