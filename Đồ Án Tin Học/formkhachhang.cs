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
using System.Runtime.Serialization.Formatters;
using System.IO;

using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Remoting.Messaging;

namespace Đồ_Án_Tin_Học
{

    public partial class Form1 : Form
    {
        static Dictionary<string, dskh> DSKH = new Dictionary<string, dskh>();
        Dictionary<string, khang> ds = new Dictionary<string, khang>();
        public Form1()
        {
            InitializeComponent();
        }

        private void hienthi()
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = DSKH.Values.ToList();
            dgvdskh.DataSource = bs;
        }

        private void rdoVip_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoVip.Checked)
            {
                lbGia.Text = "500000";
            }
            else
            {
                lbGia.Text = "";
            }
        }

        private void rdoThuong_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoThuong.Checked)
            {
                lbGia.Text = "300000";
            }
            else
            {
                lbGia.Text = "";
            }
        }
        private void btnthem_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream f = new FileStream("khachhang1.dat", FileMode.Open);
                BinaryFormatter bf = new BinaryFormatter();
                DSKH = bf.Deserialize(f) as Dictionary<string, dskh>;
                f.Close();
                hienthi();
            }
            catch
            {
                DSKH = new Dictionary<string, dskh>();
            }
            try
            {

                FileStream v = new FileStream("khang.dat", FileMode.Open);
                BinaryFormatter d = new BinaryFormatter();
                ds = d.Deserialize(v) as Dictionary<string, khang>;
                v.Close();

                dskh kh = new dskh();

                kh.MaKH = txtMaKH.Text;
                kh.TenKH = txtTen.Text;
                foreach (dskh a in DSKH.Values)
                {
                    if (a.CCCD == txtcccd.Text)
                    {
                        {
                            MessageBox.Show("loi khach hang");
                            return;
                        }
                    }

                    kh.CCCD = txtcccd.Text;
                    kh.Phone = txtphone.Text;

                    if (rdnam.Checked == true)
                    {
                        kh.m_GT = "Nam";
                    }
                    else
                    {
                        kh.m_GT = "Nữ";
                    }

                    DSKH.Add(kh.MaKH, kh);
                    hienthi();
                    khang c = new khang();
                    string uniqueID = "1";
                    int index = 1;
                    while (ds.ContainsKey(uniqueID))
                    {
                        index++;
                        uniqueID = index.ToString();
                    }
                    c.ID1 = uniqueID;
                    c.Makh = kh.MaKH;
                    c.Name1 = kh.TenKH;
                    c.Maphong = formđatphong.MP;
                    c.Loaiphong = formđatphong.LP;
                    c.Cccd = kh.CCCD;
                    c.Ngayden = formđatphong.ngaydi;
                    c.Ngaydi = formđatphong.ngayden;
                    c.Note = formđatphong.ghichu;
                    int tong = 0;
                    TimeSpan ngay = dtpngaydi.Value - dtpngayden.Value;
                    tong = int.Parse(lbGia.Text) * ngay.Days;
                    lbthanhtoan.Text = tong.ToString();
                    c.Gia = lbthanhtoan.Text;
                    ds.Add(c.ID1, c);
                    FileStream h = new FileStream("khang.dat", FileMode.Create);
                    BinaryFormatter q = new BinaryFormatter();
                    q.Serialize(h, ds);
                    h.Close();
                }
            }
            catch
            {

            }
           
        }
        private void dgvDSKH(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            foreach (DataGridViewRow i in dgvdskh.SelectedRows)
            {

                if (e.RowIndex == -1) return;
                string mssv = i.Cells[0].Value.ToString();

                dskh kh = DSKH[mssv];
                txtMaKH.Text = kh.MaKH;
                txtTen.Text = kh.TenKH;
                txtcccd.Text = kh.CCCD;
                txtphone.Text = kh.Phone;
                if (kh.m_GT == "Nam")
                {
                    rdnam.Checked = true;
                }
                else
                {
                    rdnu.Checked = true;
                }

                if (formđatphong.LP == "Thường")
                {
                    rdoThuong.Checked = true;
                    lbGia.Text = "300000";
                }
                else
                {
                    rdoVip.Checked = true;
                    lbGia.Text = "500000";
                }
                
                int tong = 0;
                TimeSpan ngay = dtpngaydi.Value - dtpngayden.Value;
                tong = int.Parse(lbGia.Text) * ngay.Days;
                lbthanhtoan.Text = tong.ToString();
                lb1.Text = formđatphong.ghichu;
                break;
            }
            
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            
            if (MessageBox.Show("bạn có muốn xóa khách hàng này không?", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                foreach (DataGridViewRow r in dgvdskh.SelectedRows)
                {
                    string mskh = r.Cells[0].Value.ToString();
                    
                    if (DSKH.Remove(mskh) == true)
                        break;
                    
                }
            }
            hienthi();

            clear1();
            txtMaKH.Focus();
        }
        private void btnsua_Click(object sender, EventArgs e)
        {

            string mssv = txtMaKH.Text;
            dskh kh = DSKH[mssv];
            kh.CCCD = txtcccd.Text;
            kh.TenKH = txtTen.Text;
            kh.Phone = txtphone.Text;
            if (rdnam.Checked == true)
            {

                kh.m_GT = "Nam";
            }
            else
            {
                kh.m_GT = "Nữ";
            }

         
            hienthi();
        }
        private void clear1()
        {
            txtcccd.Clear();
            txtMaKH.Clear();
            txtTen.Clear();
            txtphone.Clear();
            txtMaKH.Focus();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            FileStream f = new FileStream("khachhang1.dat", FileMode.Create);
            BinaryFormatter sw = new BinaryFormatter();
            sw.Serialize(f, DSKH);
            f.Close();
            MessageBox.Show("ghi file thanh cong");
        }
        private void btnxemhoadon_Click(object sender, EventArgs e)
        {
            formbill a = new formbill();
            a.ShowDialog();

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            
            if (txtcccd.Text == string.Empty)
            {
                try
                {
                    FileStream f = new FileStream("khachhang1.dat", FileMode.Open);
                    BinaryFormatter bf = new BinaryFormatter();
                    DSKH = bf.Deserialize(f) as Dictionary<string, dskh>;
                    f.Close();
                    hienthi();
                }
                catch {
                    DSKH = new Dictionary<string, dskh>();
                }
            }
            lb1.Text = formđatphong.ghichu;
            txtMaKH.Text = "KH0" + (DSKH.Count + 1).ToString();
            try
            {
               
                cbMaPhong.Text = formđatphong.MP;
                if (formđatphong.LP == "Vip")
                {
                    rdoVip.Checked = true;
                }
                else
                {
                    rdoThuong.Checked = true;
                }
                txtcccd.Text = formđatphong.CCCD;
                dtpngayden.Value = formđatphong.ngaydi;
                dtpngaydi.Value = formđatphong.ngayden;
                lbGia.Text = formđatphong.giaphong;
                int tong = 0;
                TimeSpan ngay = dtpngaydi.Value - dtpngayden.Value;
                tong = int.Parse(lbGia.Text) * ngay.Days;
                lbthanhtoan.Text = tong.ToString();
            }
            catch
            {
                return;
            }
            try
            {
                FileStream f = new FileStream("khachhang1.dat", FileMode.Open);
                BinaryFormatter bf = new BinaryFormatter();
                DSKH = bf.Deserialize(f) as Dictionary<string, dskh>;
                f.Close();
                hienthi();

            }
            catch (Exception)
            {
                MessageBox.Show("không thể đọc file", "thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                DSKH = new Dictionary<string, dskh>();
            }
            if (dtpngaydi.Value < dtpngayden.Value)
            {
               
                MessageBox.Show("Ngày đi phải nhỏ ngày đến");
                return;

            }
         
        }
        public static string P01 { set; get; } = "Trống";
        public static bool P02 { set; get; } = false;
        public static bool P03 { set; get; } = false;
        public static bool P04 { set; get; } = false;
        public static bool P05 { set; get;} = false;
        public static bool P06 { set; get; } = false;
        public static bool P07 { set; get; } = false;
        public static bool P08 { set; get; } = false;
        public static bool P09 { set; get; } = false;
        public static bool P10 { set; get; } = false;
        
        private void luudanhsach()
        {
            bool check = false;
            try
            {
                FileStream f = new FileStream("khachhang1.dat", FileMode.Open);
                BinaryFormatter bf = new BinaryFormatter();
                DSKH = bf.Deserialize(f) as Dictionary<string, dskh>;
                f.Close();
                hienthi();

            }
            catch (Exception)
            {
                MessageBox.Show("không thể đọc file", "thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                DSKH = new Dictionary<string, dskh>();
            }
            FileStream v = new FileStream("khang.dat", FileMode.Open);
            BinaryFormatter d = new BinaryFormatter();
            ds = d.Deserialize(v) as Dictionary<string, khang>;
            v.Close();
            
            khang c = new khang();
            string uniqueID = "1";
            int index = 1;
            
            while (ds.ContainsKey(uniqueID))
            {
                index++;
                uniqueID = index.ToString();
            }
            
            
            foreach (KeyValuePair<string,dskh> kh in DSKH)
            {
                if (kh.Value.CCCD == formđatphong.CCCD)
                {

                   
                    c.ID1 = uniqueID;
                    c.Makh = kh.Value.MaKH;
                    c.Name1 = kh.Value.TenKH;
                    c.Maphong = formđatphong.MP;
                    c.Loaiphong = formđatphong.LP;
                    c.Ngayden = formđatphong.ngaydi;
                    c.Ngaydi = formđatphong.ngayden;
                    c.Cccd = kh.Value.CCCD;
                    c.Note = formđatphong.ghichu;
                    lbGia.Text = formđatphong.giaphong;
                    int tong = 0;
                    TimeSpan ngay = formđatphong.ngayden - formđatphong.ngaydi;
                    tong = int.Parse(lbGia.Text) * ngay.Days;
                    lbthanhtoan.Text = tong.ToString();
                    c.Gia = lbthanhtoan.Text;
                    ds.Add(c.ID1, c);
                    check = true;
                    FileStream k = new FileStream("khachhang1.dat", FileMode.Create);
                    BinaryFormatter sw = new BinaryFormatter();
                    sw.Serialize(k, DSKH);
                    k.Close();
                    MessageBox.Show("Đặt Phòng Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    
                } 
            }
            if (check == false)
            {
                formđatphong.check1 = true;
            }
            FileStream h = new FileStream("khang.dat", FileMode.Create);
            BinaryFormatter q = new BinaryFormatter();
            q.Serialize(h, ds);
            h.Close();
        }
        public void check()
        {
            luudanhsach();
        }
        private void btnxemhoadon_Click_1(object sender, EventArgs e)
        {
            formhoadon a = new formhoadon();
            a.ShowDialog();
        }
    }

}
