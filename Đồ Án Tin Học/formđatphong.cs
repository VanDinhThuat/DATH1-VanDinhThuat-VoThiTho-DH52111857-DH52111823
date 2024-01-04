using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Đồ_Án_Tin_Học
{
    public partial class formđatphong : Form
    {
        private List<danhsachphong> list = new List<danhsachphong>();
        public formđatphong()
        {
            InitializeComponent();
        }

        private void formđatphong_Load(object sender, EventArgs e)
        {
           
        }
        private void hienthi(List<danhsachphong> a)
        {
            dgvdsphong.DataSource = a.ToList();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        

        private void rdofull_CheckedChanged(object sender, EventArgs e)
        {
            dgvdsphong.DataSource = new List<danhsachphong>();
            hienthi(list);
        }


        List<danhsachphong> listday = new List<danhsachphong>();
        private void rdoday_CheckedChanged(object sender, EventArgs e)
        {
            dgvdsphong.DataSource = new List<danhsachphong>();
            List<danhsachphong> listday = new List<danhsachphong>();
            foreach (danhsachphong a in list)
            {
                if (a.Tinhtrang == "Đầy")
                {
                    listday.Add(a);
                }
            }
            hienthi(listday);
        }
        private void rdotrong_CheckedChanged(object sender, EventArgs e)
        {
            dgvdsphong.DataSource = new List<danhsachphong>();
            List<danhsachphong> listtrong = new List<danhsachphong>();
            foreach (danhsachphong a in list)
            {
                if (a.Tinhtrang == "Trống")
                {
                    listtrong.Add(a);
                }
            }
            hienthi(listtrong);
        }

        private void dgvdsphong_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            foreach(DataGridViewRow r in dgvdsphong.SelectedRows)
            {
              
            }
        }
        public static DateTime ngaydi { get; set; } = DateTime.Now;

            
        public static DateTime ngayden { get; set; } = DateTime.Now;
        private void btntimkiem_Click(object sender, EventArgs e)
        {
            if (dtptungay.Value.Date > dtpdenngay.Value.Date)
            {
                MessageBox.Show("Không Hợp Lệ! Ngày tới phải bé hơn ngày đi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            ngaydi = dtptungay.Value.Date;
            ngayden = dtpdenngay.Value.Date;

            btnDatPhong.Hide();
            list = new List<danhsachphong>();
            danhsachphong a;
            khachhang b = new khachhang();
            b.kt1();

            a = new danhsachphong() { ID = "1", Maphong = "P01", Tinhtrang = Form1.P01, Loaiphong = "Vip" };
            list.Add(a);
            a = new danhsachphong() { ID = "2", Maphong = "P01", Tinhtrang = Form1.P06 == true ? "Đầy" : "Trống", Loaiphong = "Thường" };
            list.Add(a);
            a = new danhsachphong() { ID = "3", Maphong = "P02", Tinhtrang = Form1.P02 == true ? "Đầy" : "Trống", Loaiphong = "Vip" };
            list.Add(a);
            a = new danhsachphong() { ID = "4", Maphong = "P02", Tinhtrang = Form1.P07 == true ? "Đầy" : "Trống", Loaiphong = "Thường" };
            list.Add(a);
            a = new danhsachphong() { ID = "5", Maphong = "P03", Tinhtrang = Form1.P03 == true ? "Đầy" : "Trống", Loaiphong = "Vip" };
            list.Add(a);
            a = new danhsachphong() { ID = "6", Maphong = "P03", Tinhtrang = Form1.P08 == true ? "Đầy" : "Trống", Loaiphong = "Thường" };
            list.Add(a);
            a = new danhsachphong() { ID = "7", Maphong = "P04", Tinhtrang = Form1.P04 == true ? "Đầy" : "Trống", Loaiphong = "Vip" };
            list.Add(a);
            a = new danhsachphong() { ID = "8", Maphong = "P04", Tinhtrang = Form1.P09 == true ? "Đầy" : "Trống", Loaiphong = "Thường" };
            list.Add(a);
            a = new danhsachphong() { ID = "9", Maphong = "P05", Tinhtrang = Form1.P05 == true ? "Đầy" : "Trống", Loaiphong = "Vip" };
            list.Add(a);
            a = new danhsachphong() { ID = "10", Maphong = "P05", Tinhtrang = Form1.P10 == true ? "Đầy" : "Trống", Loaiphong = "Thường" };
            rdofull.Checked = true;
            list.Add(a);
            hienthi(list);
            btnDatPhong.Show();
        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            txtcancuoc.Text = String.Empty;
            txtghichu.Text = string.Empty;
            txtcancuoc.Focus();
        }
        public static string LP { get; set; } = "";
        public static string MP { get; set; } = "";
        public static string CCCD { get; set; } = "";
        public static bool check1 { get; set; } = false;
        public static string giaphong { get; set; } = "";
        public static string ghichu { set; get; } = "";
        private void btnDatPhong_Click(object sender, EventArgs e)
        {
            check1 = false;
            errorProvider1.Clear();
            CCCD = txtcancuoc.Text;
            ghichu = txtghichu.Text;
            foreach(DataGridViewRow i in dgvdsphong.SelectedRows)
            {
                LP = i.Cells[3].Value.ToString();
                MP = i.Cells[2].Value.ToString();
                if (i.Cells[1].Value.ToString() == "Đầy")
                {
                    MessageBox.Show("Phòng đã có người đặt", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (LP == "Vip")
                {
                    giaphong = "500000";
                }
                else
                {
                    giaphong = "300000";
                }
            }
            if (dgvdsphong.SelectedRows.Count == 0)
            {
                MessageBox.Show("Bạn phải click chọn phòng để đặt", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning); ;
                return;
            }
            {

            }
            if (txtcancuoc.Text == String.Empty)
            {
                errorProvider1.SetError(txtcancuoc, "không được để trống");
                return;
            }
            Form1 a = new Form1();
          
            a.check();
            if(check1)
            {
                
                a.Show();
            }
        }
    }
  
}
