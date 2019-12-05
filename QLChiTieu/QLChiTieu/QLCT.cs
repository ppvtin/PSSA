using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLChiTieu
{
    public partial class QLCT : Form
    {
        DatabaseManager business;
        public QLCT(string taiKhoan)
        {
            InitializeComponent();
            txtTaiKhoan.Text = taiKhoan;
            business = new DatabaseManager();
            btnSaveChi.Click += btnSaveChi_Click;
            btnSavethu.Click += btnSavethu_Click;
        }

        void btnSavethu_Click(object sender, EventArgs e)
        {
            string taikhoan = txtTaiKhoan.Text;
            string tenThu = txtThu.Text;
            double gia = double.Parse(txtGiathu.Text);
            DateTime t = DateTime.Parse(ngaythangthu.Text);
            business.SetThuvao(taikhoan, tenThu,gia,t);
            this.OnLoad(null);
        }

        void btnSaveChi_Click(object sender, EventArgs e)
        {
            string taikhoan = txtTaiKhoan.Text;
            string tenChi = txtChi.Text;
            float gia = float.Parse(txtGiaChi.Text);
            int soluong = int.Parse(txtSoluong.Text);
            DateTime t = DateTime.Parse(ngaythangChi.Text);
            business.SetChiRa(taikhoan,tenChi,gia,soluong,t);
            this.OnLoad(null);

        }

        private void QLCT_Load(object sender, EventArgs e)
        {
            grdChi.DataSource = business.GetChiRa();
            grdChi.Columns["TaiKhoan"].Visible = false;
            grdThuvao.DataSource = business.GetThuVao();
            grdThuvao.Columns["TaiKhoan"].Visible = false;
            txtTongChi.Text = business.GetTongTienChi().ToString();
            txtTongThu.Text = business.GetTongTienThu().ToString();
           // txtTienDu.Text = 
        }

      

      

       

        
        
    }
}
