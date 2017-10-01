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
        public List<Purchase>Purchases { get; set; }
        public PurchasesViewModel(User user)
        {
            AuthenticatedUser = user;
            Purchases = new List<Purchase>();
            Context context = new Context();
            context.Purchases.ForEach(x => Purchases.Add(new Purchase
            {
                Timestamp = x.Timestamp.ToString("f") , 
                SumPrice = x.Products.Sum(y => y.Price * y.Quantity),
                SumCount = x.Products.Sum(y => y.Quantity)

            }));
        }
    }
}
