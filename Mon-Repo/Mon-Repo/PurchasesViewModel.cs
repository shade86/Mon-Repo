using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mon_Repo.Dal;

namespace Mon_Repo
{
    public class PurchasesViewModel: BaseModel
    {
        public User AuthenticatedUser { get; set; }
        public List<Purchase>Purchases { get; }
        public PurchasesViewModel(User user)
        {
            var manager = new DataManager();
            //var ctx = new Context();
            Purchases = manager.GetPurchasesOfUser(user.Username)

                .Select(x => new Purchase
                {
                    //Felhasználási réteg, az adatbázis kiadja az adatot, utána már nincs vele kapcsolat
                    Timestamp = x.Timestamp.ToString("f"),
                    SumPrice = x.Products.Sum(y => y.Price * y.Quantity),
                    SumCount = x.Products.Sum(y => y.Quantity)
                }).ToList();
        }

    }
}
