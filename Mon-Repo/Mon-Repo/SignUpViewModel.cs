using Mon_Repo.Dal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Mon_Repo
{
    public class SignUpViewModel:BaseModel
    {
        public string username { get; set; }
        public string password { get; set; }

        public bool SignUpValidate()
        {
            return username != null &&
                username.Length > 0;    
        }
        public void Reg(string password1, string password2)
        {
            if (password1 != password2)
            { MessageBox.Show("A megadott jelszavak nem egyeznek"); }
            else{
                if (SignUpValidate())
                {
                    password = password1;
                    var manager = new DataManager();
                    manager.Register(username, password);
                }
                else
                    MessageBox.Show("Nem megfelelő formátum!");
            }
        }
    }
}
