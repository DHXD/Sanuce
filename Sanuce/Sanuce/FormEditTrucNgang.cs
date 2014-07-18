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
                ClassTrucNgang DGANgang = ParentSuaTrucNgang.ParentCommandsDGA.DuLieuTruc.listTrucNgang[ParentSuaTrucNgang.listBoxTrucNgang.SelectedIndices[i]];
                DGANgang.khoangCachTrucNgang = khoangcachsua;
                DGANgang.listThuocTinh[0] = khoangcachsua;
                DGANgang.flag = true;
            }

            ParentSuaTrucNgang.ParentCommandsDGA.DuLieuTruc.Call_DuLieuTrucChange("Edit");

            this.Close();
        }

        private void txtNKhoangCach_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
