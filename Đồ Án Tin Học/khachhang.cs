using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
namespace Đồ_Án_Tin_Học
{
    public partial class khachhang : Form
    {
        Dictionary<string, dskh> KH = new Dictionary<string, dskh>();
        string ma;
        public khachhang()
        {
            InitializeComponent();
        }
        Dictionary<string, khang> ds = new Dictionary<string, khang>();

        private void khachhang_Load(object sender, EventArgs e)
        {
            cb.SelectedItem = "Theo Mã KH";
            try
            {
                FileStream f = new FileStream("khachhang1.dat", FileMode.Open);
                BinaryFormatter bf = new BinaryFormatter();
                KH = bf.Deserialize(f) as Dictionary<string, dskh>;
                f.Close();
            }
            catch
            {
                KH = new Dictionary<string, dskh>();
            }
            try
            {
                FileStream c = new FileStream("khang.dat", FileMode.Open);
                BinaryFormatter d = new BinaryFormatter();
                ds = d.Deserialize(c) as Dictionary<string, khang>;
                c.Close();
            }
            catch
            {
                ds = new Dictionary<string, khang>();
            }

            ds = ds.OrderBy(kvp => kvp.Key).ToDictionary(kvp => kvp.Key, kvp => kvp.Value);
            dgvkh.DataSource = ds.Values.ToList();

        }

        private void dgvkh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if (e.RowIndex == -1) return;
            ma = dgvkh.Rows[e.RowIndex].Cells[0].Value.ToString();
           
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            ds.Remove(ma);
            dgvkh.DataSource = ds.Values.ToList();
            FileStream f = new FileStream("khang.dat", FileMode.Create);
            BinaryFormatter sw = new BinaryFormatter();
            sw.Serialize(f, ds);
            f.Close();
        }

        private void search()
        {
            Dictionary<string,khang> ds1 = new Dictionary<string, khang>();
            string ma = txttimkiem.Text.ToLower();
            foreach (KeyValuePair<string,khang> a in ds) {
                if(cb.SelectedItem==null)
                {
                    MessageBox.Show("vui lòng chọn tìm kiếm");
                    return;
                }

                if (cb.SelectedItem.ToString() == "Theo Mã KH")
                {
                    if (a.Value.Makh.ToLower().Contains(ma))
                    {
                        ds1.Add(a.Key, a.Value);
                    }
                }
                if (cb.SelectedItem.ToString() == "Theo CCCD")
                {
                    if (a.Value.Cccd.ToLower().Contains(ma))
                    {
                        ds1.Add(a.Key, a.Value);
                    }
                }
            }

            dgvkh.DataSource = ds1.Values.ToList();
            if (txttimkiem.Text == string.Empty)
            {
                dgvkh.DataSource = ds.Values.ToList();
                return;
            }

        }

        private void cb_TextChanged(object sender, EventArgs e)
        {
            search();
            
        }

        private void sort(object sender, EventArgs e)
        {
            search();
        }
        private void ktt()
        {
            
            try
            {
                FileStream f = new FileStream("khang.dat", FileMode.Open);
                BinaryFormatter bf = new BinaryFormatter();
                ds = bf.Deserialize(f) as Dictionary<string, khang>;
                f.Close();
                dgvkh.DataSource = ds.Values.ToList();

            }
            catch (Exception)
            {
                //MessageBox.Show("không thể đọc file", "thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                ds = new Dictionary<string, khang>();
            }
           
            for (int i = 0; i < dgvkh.RowCount ; i++)
            {
                string maphong = dgvkh.Rows[i].Cells[4].Value.ToString();
        
                string loaiphong = dgvkh.Rows[i].Cells[5].Value.ToString();
                DateTime m_Ngaydi = Convert.ToDateTime(dgvkh.Rows[i].Cells[7].Value);
                DateTime m_Ngayden = Convert.ToDateTime(dgvkh.Rows[i].Cells[6].Value);

                if (formđatphong.ngayden.Date >= m_Ngayden.Date && formđatphong.ngayden.Date <= m_Ngaydi.Date ||
                   formđatphong.ngaydi.Date >= m_Ngayden.Date && formđatphong.ngaydi.Date <= m_Ngaydi.Date ||
                   formđatphong.ngaydi.Date <= m_Ngayden.Date && formđatphong.ngayden.Date >= m_Ngaydi.Date)
                {

                    if (maphong == "P01" && loaiphong == "Vip")
                    {
                        Form1.P01 = "Đầy";
                    }
                    if (maphong == "P02" && loaiphong == "Vip")
                    {
                        Form1.P02 = true;
                    }
                    if (maphong == "P03" && loaiphong == "Vip")
                    {
                        Form1.P03 = true;
                    }
                    if (maphong == "P04" && loaiphong == "Vip")
                    {
                        Form1.P04 = true;
                    }
                    if (maphong == "P05" && loaiphong == "Vip")
                    {
                        Form1.P05 = true;
                    }
                    if (maphong == "P01" && loaiphong == "Thường")
                    {
                        Form1.P06 = true;
                    }
                    if (maphong == "P02" && loaiphong == "Thường")
                    {
                        Form1.P07 = true;
                    }
                    if (maphong == "P03" && loaiphong == "Thường")
                    {
                        Form1.P08 = true;
                    }
                    if (maphong == "P04" && loaiphong == "Thường")
                    {
                        Form1.P09 = true;
                    }
                    if (maphong == "P05" && loaiphong == "Thường")
                    {
                        Form1.P10 = true;
                    }

                }

            }
        }
        public void kt1()
        {
            ktt();
        }
        public static string KH1 { get;  set; } = "";

        public static string Ten { get; set; } = "";
        public static string CCCD { get; set; } = "";
        public static string Phone { get; set; } = "";
        public static DateTime ngaydi { get; set; } = DateTime.Now;
        public static DateTime ngayden { get; set; } = DateTime.Now;
        public static string GT { get; set; } = "";
        public static string maphong { get; set; } = " ";
        public static string loaiPhong { set; get; } = " ";

        public static string ThanhTien { set; get; } = "";
        
        private void dgvkh_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            

            maphong = "";
            loaiPhong = "";
            ThanhTien = "";
            foreach (DataGridViewRow row in dgvkh.SelectedRows)
            {
                
                string ma = row.Cells[0].Value.ToString();
                khang kh = ds[ma];
                //lưu dữ liệu để chuyển qua form 2
                KH1 = kh.Makh;
                Ten = kh.Name1;
                CCCD = kh.Cccd;
                maphong = kh.Maphong;
                loaiPhong = kh.Loaiphong;
                ngaydi = kh.Ngaydi.Date;
                ngayden = kh.Ngayden.Date;
                ThanhTien = kh.Gia;
                foreach(KeyValuePair<string,dskh> a in KH)
                {
                    if(a.Key == kh.Makh)
                    {
                        GT = a.Value.m_GT;
                        Phone = a.Value.Phone;
                    }
                   
                }
                
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
           if(dgvkh.SelectedRows.Count == 0)
            {
                MessageBox.Show("Bạn phải chọn khách hàng cần tạo hóa đơn");
                return;
            }
            formbill a = new formbill();
            a.ShowDialog();
        }

        private void dgvkh_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
