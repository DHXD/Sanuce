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
            FormMoreFloors MoreFloor = new FormMoreFloors(this);
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

            CapNhatDanhSach();
        }

        private void FormFloors_Load(object sender, EventArgs e)
        {
            CapNhatDanhSach();
        }

        void CapNhatDanhSach() 
        {
            listBox1.Items.Clear();
            for (int i = 0; i < ParentCommands.listTang.Count; i++)
            {
                ClassTang tang = ParentCommands.listTang[i];
                listBox1.Items.Add("Tầng thứ: " + (i + 1) + ", Chiều Cao là: " + tang.chieuCao);
            }
        }


        private void button3_Click(object sender, EventArgs e)
        {
            

            CapNhatDanhSach();
        }


        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Tầng_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void hienthicotcaodo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }
    }

}



