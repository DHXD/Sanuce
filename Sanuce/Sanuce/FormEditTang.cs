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
    public partial class FormEditTang : Form
    {
        
        public FormFloors ParentSuaTang;

        public FormEditTang(FormFloors formFloors)
        {
            InitializeComponent();

            ParentSuaTang = formFloors;
        }



        private void Sửa_Tâng_Load(object sender, EventArgs e)
        {
            txtSua.Text = "";
            for (int i = 0; i < ParentSuaTang.listBox1.SelectedIndices.Count; i++)
            {
                txtSua.Text += (i > 0 ? ", " : "") + (ParentSuaTang.listBox1.SelectedIndices[i] + 1);
            }
            
        }

        private void txtSua_TextChanged(object sender, EventArgs e)
        {

        }

        private void textNCao_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonDongY_Click(object sender, EventArgs e)
        {
            

            float u;


            // Kiem tra nhap ....
            float.TryParse(txtNCao.Text, out  u);
            
            if(u < 1 ) 
            {
                DialogResult thongBao;
                thongBao = MessageBox.Show("Chưa nhập Số tầng cần thêm ! ","Thông báo: ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            int tangcansua;
            float chieucaosua;

            int.TryParse(txtSua.Text, out tangcansua);
            float.TryParse(txtNCao.Text, out chieucaosua);


            for (int i = 0; i < ParentSuaTang.listBox1.SelectedIndices.Count; i++)
            {
                ClassTang tang = ParentSuaTang.ParentCommands.DuLieu.listTang[ParentSuaTang.listBox1.SelectedIndices[i]];
                tang.chieuCao = chieucaosua;

            }

            ParentSuaTang.ParentCommands.DuLieu.Call_DuLieuChange("Edit");
            
            this.Close();
            
        }
    }
}
