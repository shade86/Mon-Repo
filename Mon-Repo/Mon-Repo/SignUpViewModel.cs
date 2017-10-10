using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mon_Repo
{
    public class SignUpViewModel:BaseModel
    {
        public string username { get; set; }
        public bool SignUpValidate()
        {

            return username != null &&
                username.Length > 0;
                
                
        }
    }
}
