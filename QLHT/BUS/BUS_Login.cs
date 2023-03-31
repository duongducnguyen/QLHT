using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLHT.DAL;
namespace QLHT.BUS
{
    class BUS_Login
    {
        public bool Login(string username, string password)
        {
            DAL_Login DAL_Login = new DAL_Login();
            return DAL_Login.Login(username, password);
        }
    }
}
