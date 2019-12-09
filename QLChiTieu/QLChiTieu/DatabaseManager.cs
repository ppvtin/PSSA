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

        public ChiRa[] GetChiRa()
        {
            DataManagerMoneyEntities db = new DataManagerMoneyEntities();
            return db.ChiRas.ToArray();
        }

        public ThuVao[] GetThuVao()
        {
            DataManagerMoneyEntities db = new DataManagerMoneyEntities();
            return db.ThuVaos.ToArray();
        }
        public void SetChiRa(string taikhoan , string tenchi , float gia, int soluong, DateTime time)
        {
            ChiRa temp = new ChiRa();
            temp.TenTK = taikhoan;
            temp.TenChi = tenchi;
            temp.soluong = soluong ;
            temp.GiaTien = gia;
            temp.Time = time;

            DataManagerMoneyEntities db = new DataManagerMoneyEntities();
            db.ChiRas.Add(temp);
            db.SaveChanges();
            db.Dispose();
        }
        public void SetThuvao (string taikhoan , string tenthu , double gia , DateTime time)
        {
            ThuVao temp = new ThuVao();
            temp.TenTK = taikhoan;
            temp.TenThuVao = tenthu;
            temp.GiaTien = gia;
            temp.Time = time;
            DataManagerMoneyEntities db = new DataManagerMoneyEntities();
            db.ThuVaos.Add(temp);
            db.SaveChanges();
            db.Dispose(); 
        }

        public double GetTongTienChi()
        {
            DataManagerMoneyEntities db = new DataManagerMoneyEntities();
            return db.ChiRas.Select(item => item.GiaTien).Sum();
        }
        public double GetTongTienThu()
        {
            DataManagerMoneyEntities db = new DataManagerMoneyEntities();
            return db.ThuVaos.Select(item => item.GiaTien).Sum();
        }
        public void deleteThu(int Ma)
        {
            DataManagerMoneyEntities db = new DataManagerMoneyEntities();
            var data = db.ThuVaos.Find(Ma);
            db.ThuVaos.Remove(data);
            db.SaveChanges();
            db.Dispose();
        }
        public void deleteChi(int Ma)
        {
            DataManagerMoneyEntities db = new DataManagerMoneyEntities();
            var data = db.ChiRas.Find(Ma);
            db.ChiRas.Remove(data);
            db.SaveChanges();
            db.Dispose();
        }
    }
}
