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
        public string LoginName { get; set; }
        public string LoginPassword { get; set; }
        public User AuthenticatedUser { get; private set; }

        public bool Login()
        {
            var manager = new DataManager();
            var user = manager.GetUser(LoginName, LoginPassword);
            if (user == null)
            {
                return false;
            }
            AuthenticatedUser = new User(user);
            return true;
        }
        public bool Register()
        {
            var manager = new DataManager();
            var user = manager.GetUser(LoginName, LoginPassword);
            if (user == null)
                return false;
            AuthenticatedUser = new User(user);
            MessageBox.Show("Sikeres regisztráció");
            return true;
        }
    }

}

