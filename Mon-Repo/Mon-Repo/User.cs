using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mon_Repo.Dal;

namespace Mon_Repo
{
    public class User : BaseModel
    
 {
        public User(UserDbModel user)
        {
            Username = user.Username;
            Password = user.Password;
            Money = user.Money;
        }
        public ObservableCollection<Product>ProductList { get; set; }
   public string Password { get; set; }
        public string Username { get; set; }

        int _money;
        public int Money
        {
            get { return _money; }
            set
            {
                _money = value;
                OnPropertyChange();
            }
        }
    }
}
