using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Đồ_Án_Tin_Học
{
    internal class danhsachphong
    {
        private string m_ID;
        private string m_maphong;
        private string m_tinhtrang;
        private string m_loaiphong;
        public string ID {  get { return m_ID; } set {  m_ID = value; } }
        public string Tinhtrang { get {  return m_tinhtrang; } set { m_tinhtrang = value; } }
        public string Maphong { get { return m_maphong; } set { m_maphong = value; } }
        public string Loaiphong { get { return m_loaiphong; } set { m_loaiphong = value; } }
        public danhsachphong() {
            m_ID = "";
            m_loaiphong = "";
            m_tinhtrang = "";
            m_maphong = "";
        }
    }
}
