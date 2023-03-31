using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLHT.DAL
{
    class DAL_Login
    {
        public bool Login(string username, string password)
        {
            using (var context = new QLHTEntities())
            {
                NguoiDung NguoiDung = context.NguoiDungs.Where(x => x.TenDangNhap == username && x.MatKhau == password).FirstOrDefault();
                return NguoiDung != null ? true : false;
            }
        }
    }
}
