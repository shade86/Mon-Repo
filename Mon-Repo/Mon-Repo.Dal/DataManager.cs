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
        }
        public void DeleteProduct(string productname, int productprice)
        {
            foreach (var product in _ctx.ProductList)
            {
                if (productname == product.Name && productprice == product.Price)
                {
                    _ctx.ProductList.Remove(product);
                }
            }
            _ctx.SaveChanges();
        }
        public void Buy(string productname, int productquantity, int productprice, string username)
        {
            int Sumprice = 0;
            foreach (var product in _ctx.ProductList)
            {
                if (productname == product.Name && productprice == product.Price)
                {
                    product.Quantity -= productquantity;
                    Sumprice = Sumprice + (productprice * productquantity);
                }
            }
            foreach (var user in _ctx.Users)
            {
                if (username == user.Username)
                    user.Money = user.Money - Sumprice;
            }
            _ctx.SaveChanges();
        }
        public void Register(string username, string password)
        {
            if (_ctx.Users.Any(x => x.Username == username))
            {
                MessageBox.Show("A felhasználónév már létezik");
                return;
            }
            else
                _ctx.Users.Add(new UserDbModel
                {
                    Username = username,
                    Password = password,
                    Money = 10000
                });
            _ctx.SaveChanges();
            MessageBox.Show("Sikeres regisztráció");
        }
        public bool AddProductDb(string productname, int productquantity, int productprice)
        {
            _ctx.ProductList.Add(new ProductDbModel
            {
                Name = productname,
                Quantity = productquantity,
                Price = productprice
            });
            _ctx.SaveChanges();
            return true;
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

        public IEnumerable<UserDbModel> GetUserList()
        {
            return _ctx.Users.OrderBy(x => x.Username);
        }
        public UserDbModel GetUser(string username, string password)
        {
            try
            {
                return _ctx.Users.SingleOrDefault(x => x.Username == username && x.Password == password);
            }
            catch (InvalidOperationException)
            {
                return null;
            }
        }
        public ProductDbModel GetProducts(string productname, int productquantity, int productprice)
        {
            try
            {
                return _ctx.ProductList.SingleOrDefault(x => x.Name == productname && x.Quantity == productquantity && x.Price == productprice);
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