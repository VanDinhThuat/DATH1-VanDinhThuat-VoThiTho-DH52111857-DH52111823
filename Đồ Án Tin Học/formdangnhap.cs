using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Đồ_Án_Tin_Học
{
    public partial class formdangnhap : Form
    {
        public formdangnhap()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btndangnhap_Click(object sender, EventArgs e)
        {
            if(txttk.Text == "admin" && txtmk.Text == "admin")
            {
                formmenu a = new formmenu();
                a.Show();
                this.Hide();
            }
            else
            {
                lbl.Text = "tài khoản hoặc mật khẩu sai";
            }
            
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Nhấn Ok để thoát","Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
            {
                Close();
            }
        }

        private void formdangnhap_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
