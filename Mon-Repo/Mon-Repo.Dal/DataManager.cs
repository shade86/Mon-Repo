using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mon_Repo.Dal
{
    public class DataManager
    {
        readonly Context _ctx; //csak a Dalon belül létezik, kifelé DateManagereken keresztül kommunikál, közvetít. Elfedi az adatbázist.
        public DataManager()
        {
            _ctx = new Context();   //Ha a username asdf nem létezik az adatbázisban akkor létrehozza azt. WPFApp4hez is hozzá kell adni a nugetet, és appconfigba name beírni
            if (!_ctx.Users.Any(x => x.Username == "asdf"))
            {
                _ctx.Users.Add(new UserDbModel
                {
                    Username = "asdf",
                    Password = "asdf",
                    Money = 1000
                }
                    );
                _ctx.SaveChanges();
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