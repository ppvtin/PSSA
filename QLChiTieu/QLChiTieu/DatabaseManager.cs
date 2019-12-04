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

        public void DangKy(string tk, string matKhau)
        {
            TaiKhoan temp = new TaiKhoan();
            temp.taiKhoan1 = tk;
            temp.matKhau = matKhau;
            DataManagerMoneyEntities db = new DataManagerMoneyEntities();
            db.TaiKhoans.Add(temp);
            db.SaveChanges();
            db.Dispose();
        }
    }
}
