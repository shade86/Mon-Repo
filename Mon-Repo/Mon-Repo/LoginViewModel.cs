using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using Mon_Repo.Dal;
using System.Windows;
using System.Security.Cryptography;

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
        public static string GetMd5Hash(MD5 md5Hash, string input)
        {
            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));
            StringBuilder sBuilder = new StringBuilder();
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }
            return sBuilder.ToString();
        }
    }

}

