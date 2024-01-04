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
using System.Runtime.Serialization.Formatters;
using System.Runtime.Serialization.Formatters.Binary;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Xml.Linq;
using System.Diagnostics;
using System.DirectoryServices;
using System.Data.Linq;

namespace Đồ_Án_Tin_Học
{
 
    public partial class formthongke : Form
    {
        Dictionary<string,hoadon> ds = new Dictionary<string,hoadon>();
        public formthongke()
        {
            InitializeComponent();
        }

        private void dgvds_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void formthongke_Load(object sender, EventArgs e)
        {
            
            try
            {
                FileStream f = new FileStream("thongke.dat", FileMode.Open);
                BinaryFormatter bf = new BinaryFormatter();
                ds = bf.Deserialize(f) as Dictionary<string, hoadon>;
                hienthi();
                f.Close();
            }
            catch
            {
                ds = new Dictionary<string,hoadon>();
            }
        }
        private void hienthi()
        {
            List<hoadon> dsSorted = ds.Values.OrderBy(x => x.Mahd).ToList();
            dgvds.DataSource = dsSorted;
            
        }

        private void btnthongke_Click(object sender, EventArgs e)
        {
            int tong = 0;
           for(int i=0;i<dgvds.Rows.Count;i++)
            {
                DateTime m_ngaydi =Convert.ToDateTime( dgvds.Rows[i].Cells[6].Value.ToString());
                if(dtpngaydi.Value <= m_ngaydi &&dtpngayden.Value >= m_ngaydi)
                {
                   
                    tong += int.Parse(dgvds.Rows[i].Cells[2].Value.ToString());
                }

            }
           txttongtien.Text = tong.ToString();
        }

        hoadon a = new hoadon();
        private void btnxoa_Click(object sender, EventArgs e)
        {
            ds.Remove(a.Mahd);
            dgvds.DataSource = ds.Values.ToList() ;
            FileStream f = new FileStream("thongke.dat", FileMode.Create);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(f, ds);
            f.Close();
        }

        private void dgvds_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            a = (hoadon)dgvds.Rows[e.RowIndex].DataBoundItem;


        }

        private void btnreport_Click(object sender, EventArgs e)
        {
            if(dgvds.Rows.Count > 0)
            {
                SaveFileDialog save = new SaveFileDialog();
                save.Filter = "PDF (*.pdf)|*.pdf";
                save.FileName = "Result.pdf";
                bool x = false;
                if(File.Exists(save.FileName))
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

                       
                        PdfPTable pTable = new PdfPTable(dgvds.Columns.Count);
                        pTable.DefaultCell.Padding = 2;
                        pTable.WidthPercentage = 100;
                        pTable.HorizontalAlignment = Element.ALIGN_LEFT;
                        BaseFont bf = BaseFont.CreateFont("c:/windows/fonts/arial.ttf", BaseFont.IDENTITY_H, BaseFont.EMBEDDED);
                        iTextSharp.text.Font font = new iTextSharp.text.Font(bf, 8, iTextSharp.text.Font.NORMAL);
                        foreach (DataGridViewColumn col in dgvds.Columns)
                        {
                            PdfPCell pCell = new PdfPCell(new Phrase(col.HeaderText,font));
                            pTable.AddCell(pCell);
                        }
                        foreach(DataGridViewRow viewRow in dgvds.Rows)
                        {
                            foreach(DataGridViewCell cell in viewRow.Cells)
                            {
                                PdfPCell pCell = new PdfPCell(new Phrase(cell.Value.ToString(), font));
                                pTable.AddCell(pCell);
                            }
                        }
                        //Table.AddCell("Tên Khách Hàng:");
                        //foreach (KeyValuePair<string, khang> i in ds)
                        //{

                        //    if (i.Value.Makh == row.Cells[1].Value.ToString())
                        //    {
                        //        table.AddCell(i.Value.Name1);
                        //        note = i.Value.Note;
                        //        break;
                        //    }
                        //}
                        using (FileStream a = new FileStream(save.FileName, FileMode.Create))
                        {
                            
                            Document document = new Document(PageSize.A4,8f,16f,16f,8f);
                            PdfWriter.GetInstance(document, a);
                            document.Open();
                            document.AddTitle("Report");
                            document.Add(pTable);
                            document.Close();
                            a.Close();
                        }
                        MessageBox.Show("Thành Công");
                        Process.Start(save.FileName);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("error" +ex.Message);
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
