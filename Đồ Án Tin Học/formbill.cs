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
    public partial class formbill : Form
    {
        public formbill()
        {
            InitializeComponent();
        }
        
        private void Formhoadon_Load(object sender, EventArgs e)
        {
            lbl0.Text = khachhang.KH1;
            lbl1.Text = khachhang.Ten;
            lbl2.Text = khachhang.CCCD;
            lbl3.Text = khachhang.Phone;
            lbl4.Text = khachhang.GT;
            lbl5.Text = khachhang.maphong;
            lbl6.Text = khachhang.loaiPhong;
            lbl7.Text = khachhang.ngayden.Date.ToShortDateString();
            lbl8.Text = khachhang.ngaydi.Date.ToShortDateString();
            lbl9.Text = khachhang.ThanhTien;
           
            
        }
        Dictionary<string,hoadon> ds = new Dictionary<string,hoadon>();
        private void btnXacnhan_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream f = new FileStream("hoadon.dat", FileMode.Open);
                BinaryFormatter bf = new BinaryFormatter();
                ds = bf.Deserialize(f) as Dictionary<string, hoadon>;
                f.Close();
            }
            catch
            {
                ds = new Dictionary<string, hoadon>();
            }
            hoadon a = new hoadon();
            string uniqueID ="HD00" + "1";
            int index = 1;

            while (ds.ContainsKey(uniqueID))
            {
                index++;
                uniqueID = "HD00" + index.ToString();
            }
            a.Makh = lbl0.Text;
            a.Mahd = uniqueID;
            a.Maphong = lbl5.Text;
            a.Total = double.Parse(khachhang.ThanhTien);
            a.TinhTrang = "Chưa Thanh Toán";
            a.Ngayden = khachhang.ngayden;
            a.Ngaydi = khachhang.ngaydi;
            ds.Add(a.Mahd,a);
            FileStream h = new FileStream("hoadon.dat", FileMode.Create);
            BinaryFormatter b = new BinaryFormatter();
            b.Serialize(h,ds);
            h.Close();
            MessageBox.Show("Tạo Hóa Đơn Thành Công");
            this.Hide();
        }
    }
}
