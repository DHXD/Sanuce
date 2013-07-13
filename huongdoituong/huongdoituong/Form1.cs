using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace huongdoituong
{
    public partial class Form1 : Form
    {
        public class Form1()
        {
            public ClassDuLieu DuLieu = new ClassDuLieu();
            private void  // ERROR: Handles clauses are not supported in C#
            btnNhapDuLieu_Click(System.Object sender, System.EventArgs e)
        {
            frmNhapDuLieu f = new frmNhapDuLieu(this);
            f.ShowDialog();
        }
             private void  // ERROR: Handles clauses are not supported in C#
             Form1_Load(System.Object sender, System.EventArgs e)
        {
        }
            private void  // ERROR: Handles clauses are not supported in C#
            btnXuatKetQua_Click(System.Object sender, System.EventArgs e)
        {
            frmKetQua f = new frmKetQua(this);
            f.ShowDialog();
        }

            private void  // ERROR: Handles clauses are not supported in C#
            btnTinhToan_Click(System.Object sender, System.EventArgs e)
        {
            for (int i = 0; i <= DuLieu.DanhSachCot.Count - 1; i++) {
            DuLieu.DanhSachCot.Item(i).TinhDienTich();
        }

            MessageBox("Đã tính toán diện tích xong");
        }

            private void  // ERROR: Handles clauses are not supported in C#
            TạoMớiToolStripMenuItem_Click(System.Object sender, System.EventArgs e)
        {
        }
            private void  // ERROR: Handles clauses are not supported in C#
            TệpToolStripMenuItem_Click(System.Object sender, System.EventArgs e)
        {
        }
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
