using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLChiTieu
{
    class DatabaseManager
    {
        public bool IsValidLogin(string taiKhoan, string matKhau)
        {
            DataManagerMoneyEntities db = new DataManagerMoneyEntities();
            List<TaiKhoan> listTK = db.TaiKhoans.ToList();
            TaiKhoan temp = new TaiKhoan();
            temp.taiKhoan1 = taiKhoan;
            temp.matKhau = matKhau;
            bool isValid = false;
            for (int i = 0; i < listTK.Count; i++)
            {
                if (listTK[i].taiKhoan1 == temp.taiKhoan1 &&
                    listTK[i].matKhau == temp.matKhau)
                {
                    isValid = true;
                }
            }
            return isValid;
        }
    }
}
