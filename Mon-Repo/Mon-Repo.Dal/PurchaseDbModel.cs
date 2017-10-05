using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mon_Repo.Dal
{
    public class PurchaseDbModel
    {
        [Key]
        public int PurchaseId { get; set; }
        public UserDbModel User { get; set; }
        public DateTime Timestamp { get; set; }
        public ICollection<ProductDbModel> Products { get; set; }
    }
}
