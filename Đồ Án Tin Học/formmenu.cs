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
    public partial class formmenu : Form
    {
        public formmenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            formđatphong a= new formđatphong();
            a.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.ShowDialog();
        }

        private void formmenu_Load(object sender, EventArgs e)
        {

        }

        private void formmenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            formhoadon a = new formhoadon();
            a.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            khachhang a = new khachhang();
            a.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            formthongke a = new formthongke();
            a.ShowDialog();
        }
    }
}
