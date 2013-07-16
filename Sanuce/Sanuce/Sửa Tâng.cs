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
    public partial class Sửa_Tâng : Form
    {
        List<MyCommands> listTang = new List<MyCommands>();

        public FormFloors ParentSuaTang;

        public Sửa_Tâng(FormFloors formFloors)
        {
            InitializeComponent();

            ParentSuaTang = formFloors;
        }

        private void textNCao_TextChanged(object sender, EventArgs e)
        {

        }

        private void Sửa_Tâng_Load(object sender, EventArgs e)
        {

        }

        private void txtSua_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonDongY_Click(object sender, EventArgs e)
        {
           
        }


        private void Sửa_Tâng_Load(object sender, EventArgs e)
        {

        }

        private void textSua_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
