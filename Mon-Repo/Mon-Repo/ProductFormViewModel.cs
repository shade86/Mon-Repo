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
                Product.Name.Length > 4 &&
                Product.Price > 0;
        }
    }
}
