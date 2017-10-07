using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Mon_Repo.Dal
{
    public class DataManager
    {
        readonly Context _ctx; 
        public DataManager()
        {
            
            _ctx = new Context();   
           /* if (!_ctx.Users.Any(x => x.Username == "asdf"))
            {
                _ctx.Users.Add(new UserDbModel
                {
                    Username = "asdf",
                    Password = "asdf",
                    Money = 1000
                }
                    );
                _ctx.SaveChanges();
            }*/
     
        }
        //public bool Register(string username, string password)
        //{
        //    if (_ctx.Users.Any(x => x.Username == username))
        //        return false;
        //    else
        //    {
        //        _ctx.Users.Add(new UserDbModel
        //        {
        //            Username = username,
        //            Password = password,
        //            Money = 1000
        //        });
        //        _ctx.SaveChanges();
        //    }   return true;
        //}
        public void Register(string username, string password)
        {
            if (!_ctx.Users.Any(x => x.Username == username))
		//throw new ArgumentException(nameof(username));

            _ctx.Users.Add(new UserDbModel
                    {
                      Username = username,
                      Password = password,
                      Money = 1000
                     });

            _ctx.SaveChanges();
        }
        public void DbShow()
        {
            foreach (var item in _ctx.Users)
            {
                MessageBox.Show(item.Username);
            }
        }
        public IEnumerable<ProductDbModel> GetProductList()
        {
            return _ctx.ProductList.OrderBy(x => x.Name);
        }

        public UserDbModel GetUser(string username, string password)
        {
            try
            {
                return _ctx.Users.SingleOrDefault(x => x.Username == username && x.Password == password); //singleordefault: csak egy érték felel meg a kritériumoknak 

            }
            catch (InvalidOperationException)
            {

                return null;
            }
        }
        public IEnumerable<PurchaseDbModel> GetPurchasesOfUser(string username)
        {
            return _ctx.Purchases.Where(x => x.User.Username == username);
        }
    }
}