using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mon_Repo
{
    public class Product
    {
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
    }
}
