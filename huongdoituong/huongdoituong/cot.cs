using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace huongdoituong
{
    public class cot
    {
        abstract int Cao;
        abstract int Rong;
        public long DienTich;
        public int ChieuRong
        {

        get { ChieuRong = Rong; }
        set { Rong = value; }
        }
        public int ChieuCao
        {
        get { ChieuCao = Cao; }
        set { Cao = value; }
        }

        public void TinhDienTich()
        {
        DienTich = Cao * Rong;
        }
    }
}
