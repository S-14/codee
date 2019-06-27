using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BOL;
using DAL1;

namespace BLL1
{
    public class Admin
    {
        public static bool ValidateAdmin(string Email,string Password)
        {
            return AdminDAL.ValidateAdmin(Email,Password);
        }
        public static bool RegisterAdmin(AdminBOL admin)
        {
            return AdminDAL.Register(admin);
        }
    }
}
