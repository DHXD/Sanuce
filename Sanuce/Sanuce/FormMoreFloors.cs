﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Sanuce
{
    public partial class FormMoreFloors : Form
    {
        
        public FormFloors ParentFormFloors;

        public FormMoreFloors(FormFloors formFloors)
        {
            InitializeComponent();

            ParentFormFloors = formFloors;
        }


        private void txtThemTang_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void textCao_TextChanged(object sender, EventArgs e)
        {
            ////bool bItemselected = (TxtCao.SelectionLength > 0);

            ////buttonDongY.Enabled = bItemselected;
        }


        private void buttonDongY_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            int t,u,n ;
=======

            int t, u, n;
>>>>>>> e7581d57874fdc42ca6fdd8eac9eb7497eea22d2
            float d;


            // Kiem tra nhap ....
            int.TryParse(TxtThemTang.Text, out  u);
            int.TryParse(TxtCao.Text, out n);
<<<<<<< HEAD
            
            if(u < 1 ) 
            {
                DialogResult thongBao;
                thongBao = MessageBox.Show("Chưa nhập Số tầng cần thêm ! ","Thông báo: ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                
            }

            if (n<1)
            {
                DialogResult thongBao;
                thongBao = MessageBox.Show("Chưa nhập Chiều cao ! ", "Thông báo: ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                
            }

            if (n>0 && u>0)
            {
                int.TryParse(TxtThemTang.Text, out t);
                float.TryParse(TxtCao.Text, out d);

                // kiem tra gia tri...

=======

            if (u < 1)
            {
                DialogResult thongBao;
                thongBao = MessageBox.Show("Chưa nhập Số tầng cần thêm ! ", "Thông báo: ", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

            if (n < 1)
            {
                DialogResult thongBao;
                thongBao = MessageBox.Show("Chưa nhập Chiều cao ! ", "Thông báo: ", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

            if (n > 0 && u > 0)
            {
                // kiem tra nhap...
                //////if(...) {
                //////    MessageBox(...);
                //////    return;
                //////}

                int.TryParse(TxtThemTang.Text, out t);
                float.TryParse(TxtCao.Text, out d);

                // kiem tra gia tri...

>>>>>>> e7581d57874fdc42ca6fdd8eac9eb7497eea22d2

                for (int i = 0; i < t; i++)
                {
                    ClassTang tang = new ClassTang(t, d);
                    ParentFormFloors.ParentCommands.listTang.Add(tang);

                }

                ////for (int i = 0; i < t; i++)
                ////{
                ////    ClassTang tang = listTang[i];
                ////    ParentFormFloors.listBox1.Items.Add("Tầng thứ: " + i + ", Chiều Cao là: " + tang.chieuCao);
                ////}

                this.Close();
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
