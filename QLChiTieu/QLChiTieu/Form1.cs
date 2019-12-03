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
    public partial class Form1 : Form
    {
        DatabaseManager Business;
        public Form1()
        {
            Business = new DatabaseManager();
            InitializeComponent();
            this.btnDK.Click += btnDK_Click;
            this.btnDN.Click += btnDN_Click;
        }

        void btnDN_Click(object sender, EventArgs e)
        {
            if (Business.IsValidLogin(txt_account.Text, txt_Pass.Text))
            {
                MessageBox.Show("Dang nhap thanh cong");
            }
            else
            {
                MessageBox.Show("Dang nhap that bai");
            }
        }

        void btnDK_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
