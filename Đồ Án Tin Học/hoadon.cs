using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Đồ_Án_Tin_Học
{
    [Serializable]
    internal class hoadon
    {
        private string mahd;
        private string makh;
        private double total;
        private string maphong;
        private string tinhtrang;
        private string id;
        private DateTime ngayden;
        private DateTime ngaydi;
        public string Mahd
        {
            get { return mahd; } set { mahd = value; }
        }
        public string Makh
        {
            get { return makh; }
            set { makh = value; }
        }
        public double Total
        {
            get { return total; }
            set { total = value; }
        }
        public string Maphong
        {
            get { return maphong; }
            set { maphong = value; }
        }
        public string TinhTrang
        {
            get { return tinhtrang; }
            set { tinhtrang = value; }
        }
        public DateTime Ngayden
        {
            get { return ngayden; }
            set { ngayden = value; }
        }
        public DateTime Ngaydi
        {
            get { return ngaydi; }
            set { ngaydi = value; }
        }
        public hoadon()
        {
            this.mahd = string.Empty;
            this.makh = string.Empty;
            this.total = 0.0;
            maphong = "";
            tinhtrang = "";
            ngaydi = DateTime.Now;
            ngayden = DateTime.Now;
        }
    }
}
