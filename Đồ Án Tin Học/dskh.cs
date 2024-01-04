using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Đồ_Án_Tin_Học
{
    [Serializable]
    class dskh
    {
      
        private string sMaKH;
        private string sTenKH;
        private string sCCCD;
        private string sPhone;
        private string GT;
        //private string MaPhong;
        //private string LoaiPhong;
        //private DateTime ngayden;
        //private DateTime ngaydi;
        //private string note;
       
        //public string Note
        //{
        //    get { return note; }
        //    set { note = value; }
        //}
        public string MaKH
        {
            get { return sMaKH; }
            set
            {
                sMaKH = value;
            }
        }
        public string TenKH { get { return sTenKH; } set { sTenKH = value; } }
        public string CCCD { get { return sCCCD; } set { sCCCD = value; } }
        public string Phone {  get { return sPhone; } set { sPhone = value; } }
        public string m_GT {  get { return GT; } set {  GT = value; } }
        //public string m_MaPhong { get { return MaPhong; } set { MaPhong = value; } }
        //public string m_LoaiPhong { get { return LoaiPhong; } set { LoaiPhong = value; } }
        //public DateTime Ngayden { get { return ngayden; } set {  ngayden = value; } }
        //public DateTime Ngaydi { get { return ngaydi; } set { ngaydi = value; } }
        public dskh()
        {
            MaKH = "";
            TenKH = "";
            CCCD = "";
            Phone = "";
            m_GT = "";
            //m_MaPhong = "";
            //m_LoaiPhong = "";
            //Ngayden = DateTime.Now;
            //Ngaydi = DateTime.Now;
            //note = "";
        }
    }
}

