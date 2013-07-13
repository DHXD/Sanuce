using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace huongdoituong
{
    public class ClassDuLieu
    {
        // Khai bao bien
        public List<Cot> DanhSachCot;
        public List<Dam> DanhSachDam;
        public ClassDuLieu()
        {
            DanhSachCot = new List<Cot>();
            // Khoi tao bien
            DanhSachDam = new List<Dam>();
        }
    }
}
