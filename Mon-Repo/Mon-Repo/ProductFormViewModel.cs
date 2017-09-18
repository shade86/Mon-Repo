using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mon_Repo
{
    public class ProductFormViewModel : BaseModel
    {
        public Product Product { get; set; }
        public bool Validate()
        {
            return Product.Name != null &&
                Product.Name.Length > 0 &&
                Product.Price > -1;
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
