using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using Mon_Repo.Dal;

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
            var ctx = new Context();
            foreach (var user in ctx.Users)
                if (user.Username == LoginName &&
                    user.Password == LoginPassword)
            {
                    AuthenticatedUser = new User(user);
                    return true;
            }
            return false;
        }
    }
}

