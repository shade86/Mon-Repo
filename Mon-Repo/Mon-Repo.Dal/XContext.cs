using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mon_Repo.Dal
{
    public class XContext
    {
        public List<ProductDbModel> Products { get; } = new List<ProductDbModel>
        {
            new ProductDbModel{Name="Alma",Price=100,Quantity=40},
            new ProductDbModel{Name="Körte",Price=150,Quantity=20},
            new ProductDbModel{Name="Szilva",Price=130,Quantity=30},
            new ProductDbModel{Name="Barack",Price=180,Quantity=80}
        };
        public List<UserDbModel> Users { get; } = new List<UserDbModel>
        {
            new UserDbModel {Username="Tomi", Password="1234", Money=1000 }
        };
        public List<PurchaseDbModel>Purchases { get; }
        public XContext()
        {
            Purchases = new List<PurchaseDbModel>
            {
                new PurchaseDbModel
                {
                    User = Users[0],
                    Timestamp = DateTime.Now,
                    Products = new List<ProductDbModel>
                    {
                        Products[0]
                    }


                }
            };
        }
    }
}
