using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;

namespace Mon_Repo
{
    class LoginViewModel : BaseModel
    {
        public ObservableCollection<User> Users { get; set; }
        public string LoginName { get; set; }
        public string LoginPassword { get; set; }
        public User AuthenticatedUser { get; set; }
        public LoginViewModel()
        {

            Users = new ObservableCollection<User>
            {
                new User {Username = "asdf", Password = "1234", Money = 1000, ProductList= new ObservableCollection<Product>()},
                new User {Username = "Tomi", Password = "1234", Money = 200, ProductList= new ObservableCollection<Product>()}
            };
        }
        public bool Login()
        {
            foreach (var user in Users)
            {
                if (user.Username == LoginName && user.Password == LoginPassword)
                {

                    AuthenticatedUser = user;
                    return true;
                }
            }
            return false;
        }


    }

}

