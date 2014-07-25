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
<<<<<<< HEAD

        public String Name = "";

        public delegate void ViTri_ChangeHandler
        (
            ClassDoiTuong DoiTuongBiThayDoi
        );

        // The event we publish
        public event ViTri_ChangeHandler ViTri_Change = null;

        public void Change_ViTri_Event()
        {
            if (ViTri_Change != null) ViTri_Change(this);
        }

        //virtual public void XuLySuKien_ViTriChange(ClassDoiTuong doiTuongThayDoi)
        //{
        //    // không viết mà xử lý ở các class con
        //}

        
=======
>>>>>>> a4ba73e0b897cbddee7b2620c4f09ce53b65bfb5
    }
}
