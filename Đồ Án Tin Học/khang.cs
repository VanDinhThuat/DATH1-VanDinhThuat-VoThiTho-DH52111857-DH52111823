using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Đồ_Án_Tin_Học
{
    [Serializable]
    internal class khang
    {
        private string ID;
        private string Name;
        private string makh;
        private string cccd;
        private string maphong;
        private string loaiphong;
        private DateTime ngayden;
        private DateTime ngaydi;
        private string gia;
        private string note;

        public khang()
        {
            ID ="";
            Name = "";
            this.makh = "";
            this.cccd = "";
            this.maphong = "";
            this.loaiphong = "";
            this.ngayden = DateTime.Now;
            this.ngaydi = DateTime.Now;
                
        }

        public string ID1 { get => ID; set => ID = value; }
        public string Name1 { get => Name; set => Name = value; }
        public string Makh { get => makh; set => makh = value; }
        public string Cccd { get => cccd; set => cccd = value; }
        public string Maphong { get => maphong; set => maphong = value; }
        public string Loaiphong { get => loaiphong; set => loaiphong = value; }
        public DateTime Ngayden { get => ngayden; set => ngayden = value; }
        public DateTime Ngaydi { get => ngaydi; set => ngaydi = value; }
        public string Gia {  get => gia; set => gia = value; }
        public string Note {  get => note; set => note = value;}

    }
}
