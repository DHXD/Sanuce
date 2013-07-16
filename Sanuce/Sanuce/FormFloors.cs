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
        }

        public FormFloors()
        {
            InitializeComponent();

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)

        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Sửa_Tâng suatang = new Sửa_Tâng(this);
            suatang.ShowDialog();
        }

        private void FormFloors_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Xóa_Tầng xoatang = new Xóa_Tầng(this);
            xoatang.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}



