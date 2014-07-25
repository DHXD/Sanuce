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
    public partial class FormFloors : Form
    {
        public MyCommands ParentCommands;

        public FormFloors(MyCommands myCommands)
        {
            InitializeComponent();

            ParentCommands = myCommands;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormAddFloors MoreFloor = new FormAddFloors(this);
            MoreFloor.ShowDialog();
            CapNhatDanhSach();
        }

        public FormFloors()
        {
            InitializeComponent();

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            bool bItemSelected = (listBox1.SelectedIndices.Count > 0);
            btnEdit.Enabled = bItemSelected;
            btnDelete.Enabled = bItemSelected;
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormEditTang suatang = new FormEditTang(this);
            suatang.ShowDialog();
            listBox1.SelectedIndices.Clear();
            CapNhatDanhSach();
        }

        private void FormFloors_Load(object sender, EventArgs e)
        {
            CapNhatDanhSach();
        }

        void CapNhatDanhSach() 
        {
            listBox1.Items.Clear();
            for (int i = 0; i < ParentCommands.DuLieu.listTang.Count; i++)
            {
                ClassTang tang = ParentCommands.DuLieu.listTang[i];
                listBox1.Items.Add("Tầng thứ: " + (i + 1) + ", Chiều Cao là: " + tang.chieuCao + " (mm)");
            }
        }


        private void btnXoa_Click(object sender, EventArgs e)
        {
            // xac nhan
            
            DialogResult traloi;
            traloi = MessageBox.Show("Bạn có chắc chắn không !", "Thông báo !", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traloi == DialogResult.OK)
            {

                for (int i = 0; i < listBox1.SelectedIndices.Count; i++)
                {
                    int j = listBox1.SelectedIndices[i];

                    ParentCommands.DuLieu.listTang.RemoveAt(j - i);
                }
            }

            listBox1.SelectedIndices.Clear();

            CapNhatDanhSach();

            ParentCommands.DuLieu.Call_DuLieuChange("Delete");
        }


        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }

}



