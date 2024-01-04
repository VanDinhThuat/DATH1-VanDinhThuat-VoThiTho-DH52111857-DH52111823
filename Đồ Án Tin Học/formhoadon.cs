using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using iTextSharp.text.pdf;
using iTextSharp;
using iTextSharp.text;
using System.Diagnostics;

namespace Đồ_Án_Tin_Học
{
    public partial class formhoadon : Form
    {
        Dictionary<string, hoadon> listhoadon = new Dictionary<string, hoadon>();
        Dictionary<string, hoadon> thongke = new Dictionary<string, hoadon>();
        public formhoadon()
        {
            InitializeComponent();
        }
        hoadon a = new hoadon();
        private void formhoadon_Load(object sender, EventArgs e)
        {
            try
            {
                FileStream f = new FileStream("hoadon.dat", FileMode.Open);
                BinaryFormatter bf = new BinaryFormatter();
                listhoadon = bf.Deserialize(f) as Dictionary<string, hoadon>;
                f.Close();
                hienthi();
            }
            catch
            {
                listhoadon = new Dictionary<string, hoadon>();
            }


        }
        private void hienthi()
        {
            dgvds.DataSource = listhoadon.Values.ToList();
        }

        private void dgvds_CellClick(object sender, DataGridViewCellEventArgs e)
        {


            a = (hoadon)dgvds.Rows[e.RowIndex].DataBoundItem;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (a != null)
            {
                listhoadon.Remove(a.Mahd);
                FileStream h = new FileStream("hoadon.dat", FileMode.Create);
                BinaryFormatter b = new BinaryFormatter();
                b.Serialize(h, listhoadon);
                h.Close();
                dgvds.DataSource = listhoadon.Values.ToList();
            }
        }

        private void btnthanhtoan_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream f = new FileStream("thongke.dat", FileMode.Open);
                BinaryFormatter bf = new BinaryFormatter();
                thongke = bf.Deserialize(f) as Dictionary<string, hoadon>;
                f.Close();
            }
            catch
            {
                thongke = new Dictionary<string, hoadon>();
            }
            if (a != null)
            {
                string uniqueID = "HD00" + "1";
                int index = 1;

                while (thongke.ContainsKey(uniqueID))
                {
                    index++;
                    uniqueID = "HD00" + index.ToString();
                }
                hoadon b = new hoadon();
                b.Makh = a.Makh;
                b.Mahd = uniqueID;
                b.Maphong = a.Maphong;
                b.Ngayden = a.Ngayden;
                b.Ngaydi = a.Ngaydi;
                b.Total = a.Total;
                b.TinhTrang = "Đã Thanh Toán";
                thongke.Add(b.Mahd, b);

            }
            listhoadon.Remove(a.Mahd);
            dgvds.DataSource = listhoadon.Values.ToList();
            FileStream d = new FileStream("hoadon.dat", FileMode.Create);
            BinaryFormatter p = new BinaryFormatter();
            p.Serialize(d, listhoadon);
            d.Close();

            FileStream h = new FileStream("thongke.dat", FileMode.Create);
            BinaryFormatter c = new BinaryFormatter();
            c.Serialize(h, thongke);
            h.Close();

            MessageBox.Show("Thanh Toán Thành Công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }
        private string note { set; get; } = "";
        private void button2_Click(object sender, EventArgs e)
        {
            Dictionary<string, khang> ds = new Dictionary<string, khang>();
            FileStream c = new FileStream("khang.dat", FileMode.Open);
            BinaryFormatter d = new BinaryFormatter();
            ds = d.Deserialize(c) as Dictionary<string, khang>;
            c.Close();

            if (dgvds.Rows.Count > 0)
            {
                SaveFileDialog save = new SaveFileDialog();
                save.Filter = "PDF (*.pdf)|*.pdf";
                save.FileName = "Bill.pdf";
                bool x = false;
                if (File.Exists(save.FileName))
                {
                    try
                    {
                        File.Delete(save.FileName);
                    }
                    catch
                    {
                        x = true;
                        MessageBox.Show("Không thể chuyển");
                    }
                }
                if (!x)
                {
                    try
                    {
                       
                        Document document = new Document(PageSize.A4);
                        PdfWriter writer = PdfWriter.GetInstance(document, new FileStream(save.FileName, FileMode.Create));
                        document.Open();
                        document.AddTitle("Hóa Đơn");
                        PdfPTable table = new PdfPTable(2);
                        PdfPCell headerCell = new PdfPCell(new Phrase("Hóa Đơn Khách Hàng"));
                        headerCell.Colspan = 2;
                        headerCell.HorizontalAlignment = Element.ALIGN_CENTER;
                        foreach (DataGridViewRow row in dgvds.SelectedRows)
                        {
                            

                            table.AddCell(headerCell);
                            table.AddCell("Mã Hóa Đơn:");
                            table.AddCell(row.Cells[0].Value.ToString());
                            table.AddCell("Tên Khách Hàng:");
                            foreach (KeyValuePair<string, khang> i in ds)
                            {

                                if (i.Value.Makh == row.Cells[1].Value.ToString())
                                {
                                    table.AddCell(i.Value.Name1);
                                    note = i.Value.Note;
                                    break;
                                }
                            }
                            table.AddCell("Mã Phòng");
                            table.AddCell(row.Cells[3].Value.ToString());
                            table.AddCell("Ngày Đến");
                            table.AddCell(row.Cells[5].Value.ToString());
                            table.AddCell("Ngày Đi");
                            table.AddCell(row.Cells[6].Value.ToString());
                            table.AddCell("Căn Cước Công Dân:");
                            foreach (KeyValuePair<string,khang> i in ds)
                            {
                                
                                if(i.Value.Makh == row.Cells[1].Value.ToString())
                                {
                                    table.AddCell(i.Value.Cccd);
                                    note = i.Value.Note;
                                    break;
                                }
                            }
                            table.AddCell("Ghi Chú");
                            table.AddCell(note);
                            table.AddCell("Tổng Giá Tiền:");
                            table.AddCell(row.Cells[2].Value.ToString());
                        }
                        
                        document.Add(table);

                        
                        document.Close();

                        Process.Start(save.FileName);

                        MessageBox.Show("Thành Công");
                    }
                    catch (Exception ex)
                    {
                        
                        MessageBox.Show("error" + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("error");
            }
        }
    }
}

