using System;
using Autodesk.AutoCAD.ApplicationServices;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.EditorInput;
using Autodesk.AutoCAD.Runtime;
using Autodesk.AutoCAD.Geometry;
using System.Collections.Generic;
using System.ComponentModel;
using Autodesk.AutoCAD.Interop.Common;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Sanuce
{
    public partial class FormGridAxis : Form
    {
        public MyCommands ParentCommandsDGA;
        
        public int demNgang;
        public int demDoc;

        public FormGridAxis(MyCommands myCommands)
        {
            InitializeComponent();

            ParentCommandsDGA = myCommands;
        }

        public FormGridAxis()
        {
            // TODO: Complete member initialization

            InitializeComponent();
        }

        private void txtKhoangCachTrucX_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonThemTrucNgang_Click(object sender, EventArgs e)
        {           
            float kcNgang, ngang;

            float.TryParse(TxtKhoangCachTrucX.Text, out kcNgang);

            if (kcNgang < 1)
            {
                DialogResult thongbao;
                thongbao = MessageBox.Show("Chưa nhập khoảng cách trục cần thêm !", "Thông báo: ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else demNgang++;
            
            float.TryParse(TxtKhoangCachTrucX.Text, out ngang);

            ClassTrucNgang DGANgang = new ClassTrucNgang(ngang, demNgang);

            ClassDoiTuong TrucThamChieu = ParentCommandsDGA.DuLieu.TrucX;

            if (ParentCommandsDGA.DuLieuTruc.listTrucNgang.Count > 0) // la truc tiep theo
            {
                TrucThamChieu = ParentCommandsDGA.DuLieuTruc.listTrucNgang[ParentCommandsDGA.DuLieuTruc.listTrucNgang.Count - 1];

            }

            // gan cac thuoc tinh khoi tao de tinh toan khi ve
            DGANgang.DoiTuongThamChieu = TrucThamChieu;
            DGANgang.listThuocTinh.Add(kcNgang);

            ParentCommandsDGA.DuLieuTruc.AddTrucNgang(DGANgang);

            ParentCommandsDGA.DuLieuTruc.Call_DuLieuTrucChange("add");

            CapNhatDanhSachDGA_ListBoxNgang();
        }

        private void ClassDGA(float kcNgang, int demNgang)
        {
            throw new NotImplementedException();
        }

        private void buttonSuaTrucNgang_Click(object sender, EventArgs e)
        {
            if (listBoxTrucNgang.SelectedIndices.Count > 0)
            {
                FormEditTrucNgang suaTrucNgang = new FormEditTrucNgang(this);
                suaTrucNgang.ShowDialog();
                CapNhatDanhSachDGA_ListBoxNgang();
            }
            else
            {
                DialogResult thongbao;
                thongbao = MessageBox.Show("Chưa chọn trục cần sửa !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttonXoaTrucNgang_Click(object sender, EventArgs e)
        {
            if (listBoxTrucNgang.SelectedIndices.Count > 0)
            {
                DialogResult traloi;
                traloi = MessageBox.Show("Bạn có chắc chắn không !", "Thông báo !", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (traloi == DialogResult.OK)
                {
                    for (int i = 0; i < listBoxTrucNgang.SelectedIndices.Count; i++)
                    {
                        int j = listBoxTrucNgang.SelectedIndices[i];

                        ParentCommandsDGA.DuLieuTruc.listTrucNgang.RemoveAt(j - i);
                    }
                }
                CapNhatDanhSachDGA_ListBoxNgang();
            }
            else
            {
                DialogResult thongbao;
                thongbao = MessageBox.Show("Bạn chưa chọn trục cần xóa !", "Thông báo !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
           // ParentCommandsDGA.DuLieuDGA.Call_DuLieuDGAChange("Delete");
        }

        void CapNhatDanhSachDGA_ListBoxNgang()
        {
            listBoxTrucNgang.Items.Clear();

            for (int i = 0; i < ParentCommandsDGA.DuLieuTruc.listTrucNgang.Count; i++)
            {
                ClassTrucNgang DGANgang = ParentCommandsDGA.DuLieuTruc.listTrucNgang[i];
               
                listBoxTrucNgang.Items.Add("Trục " + (i) + " Khoảng cách " + DGANgang.khoangCachTrucNgang);
            }
        }

        void CapNhatDanhSachDGA_ListBoxDoc()
        {
            listBoxTrucDoc.Items.Clear();

            for (int i = 0; i < ParentCommandsDGA.DuLieuTruc.listTrucDoc.Count; i++)
            {
                ClassTrucDoc DGADoc = ParentCommandsDGA.DuLieuTruc.listTrucDoc[i];

                listBoxTrucDoc.Items.Add("Trục " + (i) + "  Khoảng cách " + DGADoc.khoangCachTrucDoc);
            }
        }

        private void listBoxTrucNgang_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool ItemSelectedListTrucNgang = (listBoxTrucNgang.SelectedIndices.Count > 0);
            buttonSuaTrucNgang.Enabled = ItemSelectedListTrucNgang;
            buttonXoaTrucNgang.Enabled = ItemSelectedListTrucNgang;
        }

        private void listBoxTrucDoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool ItemSelectedListTrucDoc = (listBoxTrucDoc.SelectedIndices.Count > 0);
            btnXoaTrucDoc.Enabled = ItemSelectedListTrucDoc;
            btnSuaTrucDoc.Enabled = ItemSelectedListTrucDoc;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnXuatBanVe_Click(object sender, EventArgs e)
        {

            ParentCommandsDGA.DrawGridAxis();
            this.Close();
        }

        private void btnThemTrucDoc_Click(object sender, EventArgs e)
        {
            float kcDoc, Doc;

            float.TryParse(TxtKhoangCachTrucY.Text, out kcDoc);

            if (kcDoc < 1)
            {
                DialogResult thongbao;
                thongbao = MessageBox.Show("Chưa nhập khoảng cách trục cần thêm !", "Thông báo: ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else demDoc++;

            float.TryParse(TxtKhoangCachTrucY.Text, out Doc);

            ClassTrucDoc DGADoc = new ClassTrucDoc(Doc, demDoc);

            ClassDoiTuong TrucThamChieu = ParentCommandsDGA.DuLieu.TrucY;

            if (ParentCommandsDGA.DuLieuTruc.listTrucDoc.Count > 0) // La truc tiep theo
            {
                TrucThamChieu = ParentCommandsDGA.DuLieuTruc.listTrucDoc[ParentCommandsDGA.DuLieuTruc.listTrucDoc.Count - 1];
            }

            // gan cac thuoc tinh khoi tao de tinh toan khi ve
            DGADoc.DoiTuongThamChieu = TrucThamChieu;
            DGADoc.listThuocTinh.Add(kcDoc);
          
            ParentCommandsDGA.DuLieuTruc.AddTrucDoc(DGADoc);

            ParentCommandsDGA.DuLieuTruc.Call_DuLieuTrucChange("add");

            CapNhatDanhSachDGA_ListBoxDoc();
        }

        private void btnSuaTrucDoc_Click(object sender, EventArgs e)
        {
            if (listBoxTrucDoc.SelectedIndices.Count > 0)
            {
                FormEditTrucDoc suaTrucDoc = new FormEditTrucDoc(this);
                suaTrucDoc.ShowDialog();
                CapNhatDanhSachDGA_ListBoxDoc();
            }
            else
            {
                DialogResult thongbao;
                thongbao = MessageBox.Show("Chưa chọn trục cần sửa !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            //FormEditTrucDoc suatruc = new FormEditTrucDoc(this);
            //suatruc.ShowDialog();

            //CapNhatDanhSachDGA_ListBoxDoc();
        }

        private void btnXoaTrucDoc_Click(object sender, EventArgs e)
        {
            if (listBoxTrucDoc.SelectedIndices.Count > 0)
            {
                DialogResult traloi;
                traloi = MessageBox.Show("Bạn có chắc chắn không !", "Thông báo !", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (traloi == DialogResult.OK)
                {
                    for (int i = 0; i < listBoxTrucDoc.SelectedIndices.Count; i++)
                    {
                        int j = listBoxTrucDoc.SelectedIndices[i];

                        ParentCommandsDGA.DuLieuTruc.listTrucDoc.RemoveAt(j - i);
                    }
                }
                CapNhatDanhSachDGA_ListBoxDoc();
            }
            else
            {
                DialogResult thongbao;
                thongbao = MessageBox.Show("Ban chưa chọn trục cần xóa !", "Thông báo !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            //ParentCommandsDGA.DuLieuDGA.Call_DuLieuDGAChange("Delete");
        }

        private void FormDrawGridAxis_Load(object sender, EventArgs e)
        {
            CapNhatDanhSachDGA_ListBoxDoc();

            CapNhatDanhSachDGA_ListBoxNgang();
        }

    }
}
