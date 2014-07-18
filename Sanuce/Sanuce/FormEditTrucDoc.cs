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
    public partial class FormEditTrucDoc : Form
    {
        public FormGridAxis ParentSuaTrucDoc;

        public FormEditTrucDoc(FormGridAxis formDrawGridAxis)
        {
            InitializeComponent();

            ParentSuaTrucDoc = formDrawGridAxis;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtNKhoangCach_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTrucCanSua_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormEditTrucDoc_Load(object sender, EventArgs e)
        {
            txtTrucCanSua.Text = "";

            for (int i = 0; i < ParentSuaTrucDoc.listBoxTrucDoc.SelectedIndices.Count; i++)
            {
                txtTrucCanSua.Text += (i > 0 ? ", " : "") + (ParentSuaTrucDoc.listBoxTrucDoc.SelectedIndices[i] + 1);
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

            for (int i = 0; i < ParentSuaTrucDoc.listBoxTrucDoc.SelectedIndices.Count; i++)
            {
                ClassTrucDoc DGADoc = ParentSuaTrucDoc.ParentCommandsDGA.DuLieuTruc.listTrucDoc[ParentSuaTrucDoc.listBoxTrucDoc.SelectedIndices[i]];
                DGADoc.khoangCachTrucDoc = khoangcachsua;
                DGADoc.listThuocTinh[0] = khoangcachsua;
                DGADoc.flag = true;
            }

            //ParentSuaTrucDoc.ParentCommandsDGA.DuLieuTruc.Call_DuLieuTrucChange("Edit");

            this.Close();
        }
    }
}
