using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mon_Repo.Dal;

namespace Mon_Repo
{
    public class Product : BaseModel
    {
        public Product(ProductDbModel dbModel)
        {
            Name = dbModel.Name;
            Price = dbModel.Price;
            Quantity = dbModel.Quantity;
        }
        public Product()
        {

        }

        string _name;
        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
                OnPropertyChange();
            }
        }
        int _price;
        public int Price
        {
            get { return _price; }
            set
            {
                _price = value;
                OnPropertyChange();
            }
        }

        int _quantity;
      
        public int Quantity
        {
            get { return _quantity; }
            set
            {
                _quantity = value;
                OnPropertyChange();
            }
        }
    }
}
