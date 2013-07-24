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
    public partial class FormAddFloors : Form
    {

        public FormFloors ParentFormFloors;

        public FormAddFloors(FormFloors formFloors)
        {
            InitializeComponent();

            ParentFormFloors = formFloors;
        }


        private void txtThemTang_TextChanged(object sender, EventArgs e)
        {

        }

        private void textCao_TextChanged(object sender, EventArgs e)
        {
 
        }


        private void buttonDongY_Click(object sender, EventArgs e)
        {

            int t, u;
            float d, n;


            // Kiem tra nhap ....
            int.TryParse(TxtThemTang.Text, out  u);
            float.TryParse(TxtCao.Text, out n);

            if (u < 1)
            {
                DialogResult thongBao;
                thongBao = MessageBox.Show("Chưa nhập Số tầng cần thêm ! ", "Thông báo: ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (n < 0.1)
            {
                DialogResult thongBao;
                thongBao = MessageBox.Show("Chưa nhập Chiều cao ! ", "Thông báo: ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            int.TryParse(TxtThemTang.Text, out t);
            float.TryParse(TxtCao.Text, out d);

            // kiem tra gia tri...

            for (int i = 0; i < t; i++)
            {
                ClassTang tang = new ClassTang(t, d);
                ParentFormFloors.ParentCommands.DuLieu.listTang.Add(tang);

            }

            this.Close();
        }




        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}

