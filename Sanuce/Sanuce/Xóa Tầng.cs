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
    public partial class Xóa_Tầng : Form
    {
        public FormFloors ParentXoaTang;

        public Xóa_Tầng(FormFloors formFloors)
        {
            InitializeComponent();
            ParentXoaTang = formFloors;
        }

        private void Xóa_Tầng_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(string.Format("Xoa tang {0} \n",textXoa.Text )); 
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(string.Format("Xoa tat ca {0} \n", textXoa.Text));
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
