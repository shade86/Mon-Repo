using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mon_Repo.Dal;

namespace Mon_Repo
{
    public class Purchase: BaseModel
    {
        public string Timestamp { get; set; }
        public int SumPrice { get; set; }
        public int SumCount { get; set; }
    }
}
