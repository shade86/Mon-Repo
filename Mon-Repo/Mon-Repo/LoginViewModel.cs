using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using Mon_Repo.Dal;
using System.Windows;

namespace Mon_Repo
{
    public class LoginViewModel : BaseModel
    {
        //public ObservableCollection<User> Users { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public User AuthenticatedUser { get; private set; }

        public bool Login()
        {
            var manager = new DataManager();
            var user = manager.GetUser(username, password);
            if (user == null)
            {
                return false;
            }
            AuthenticatedUser = new User(user);
            return true;
        }
    }

}

