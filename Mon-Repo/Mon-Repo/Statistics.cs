using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mon_Repo
{
    public static class Statistics
    {
       
        public static int SumSpent(IEnumerable<Product> products)
        {
            return products.Sum(x => x.Price * x.Quantity);
        }
       
    }
}
