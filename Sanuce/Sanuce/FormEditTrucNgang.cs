using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Sanuce
{
    public partial class FormEditTrucNgang : Form
    {
        public FormGridAxis ParentSuaTrucNgang;

        public FormEditTrucNgang(FormGridAxis formDrawGirdAxis)
        {
            InitializeComponent();

            ParentSuaTrucNgang = formDrawGirdAxis;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormEditTrucNgang_Load(object sender, EventArgs e)
        {
            txtTrucCanSua.Text = "";

            for (int i = 0; i < ParentSuaTrucNgang.listBoxTrucNgang.SelectedIndices.Count; i++)
            {
                txtTrucCanSua.Text += (i > 0 ? ", " : "") + (ParentSuaTrucNgang.listBoxTrucNgang.SelectedIndices[i] + 1);   
            }
        }

        private void btnDongY_Click(object sender, EventArgs e)
        {
            float khoangCach;

            float.TryParse(txtNKhoangCach.Text, out khoangCach);

            if (khoangCach < 1)
            {
                DialogResult thongbao;
                thongbao = MessageBox.Show("Chưa nhập khoảng cách trục cần sửa ! ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int truccansua;
            float khoangcachsua;

            int.TryParse(txtTrucCanSua.Text, out truccansua);
            float.TryParse(txtNKhoangCach.Text, out khoangcachsua);

            for (int i = 0; i < ParentSuaTrucNgang.listBoxTrucNgang.SelectedIndices.Count; i++ )
            {
<<<<<<< HEAD
                ClassTrucNgang TrucNgang = ParentSuaTrucNgang.ParentCommandsDGA.DuLieuTruc.listTrucNgang[ParentSuaTrucNgang.listBoxTrucNgang.SelectedIndices[i]];
                TrucNgang.khoangCachTrucNgang = khoangcachsua;
                TrucNgang.listThuocTinh[0] = khoangcachsua;
                TrucNgang.flag = true;
                ParentSuaTrucNgang.ParentCommandsDGA.DrawGridAxis();
                TrucNgang.Change_ViTri_Event();
            }

            //ParentSuaTrucNgang.ParentCommandsDGA.DuLieuTruc.Call_DuLieuTrucChange("Edit");
=======
                ClassTrucNgang DGANgang = ParentSuaTrucNgang.ParentCommandsDGA.DuLieuTruc.listTrucNgang[ParentSuaTrucNgang.listBoxTrucNgang.SelectedIndices[i]];
                DGANgang.khoangCachTrucNgang = khoangcachsua;
                DGANgang.listThuocTinh[0] = khoangcachsua;
                DGANgang.flag = true;
            }

            ParentSuaTrucNgang.ParentCommandsDGA.DuLieuTruc.Call_DuLieuTrucChange("Edit");

>>>>>>> a4ba73e0b897cbddee7b2620c4f09ce53b65bfb5
            this.Close();
        }

        private void txtNKhoangCach_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
