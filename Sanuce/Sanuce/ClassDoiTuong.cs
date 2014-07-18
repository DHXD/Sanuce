using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Autodesk.AutoCAD.Geometry;

namespace Sanuce
{
    public class ClassDoiTuong
    {
        public ClassDoiTuong DoiTuongThamChieu = null;
        public  List<Object> listThuocTinh = new List<Object>();
        public bool flag = false;
        public Point3d Pos = new Point3d(0, 0, 0);
    }
}
