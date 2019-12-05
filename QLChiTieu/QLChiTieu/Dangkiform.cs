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
    public partial class Dangkiform : Form
    {
        DatabaseManager bussiness;
        public Dangkiform()
        {
            InitializeComponent();
            this.btnCancel.Click += btnCancel_Click;
            this.btnSave.Click += btnSave_Click;
            bussiness = new DatabaseManager();
            
        }

        void btnSave_Click(object sender, EventArgs e)
        {
            string tk = txtTaikhoan.Text;
            string pass = txtmatkhau.Text;
            string repass = txtRematkhau.Text;
            string a = "";  
            if (pass == repass && pass != a && tk != a && repass !=a)
            {
                MessageBox.Show("Dang ky thanh cong");
                this.bussiness.DangKy(tk, pass);
                this.Close();
            }
            else  
            {
                MessageBox.Show("Dang nhap lai") ;
            }
            
        }

        void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }
    }
}
