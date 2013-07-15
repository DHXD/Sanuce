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
    public partial class FormMoreFloors : Form
    {
        List<MyCommands> listTang = new List<MyCommands>();

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

        }


        private void buttonDongY_Click(object sender, EventArgs e)
        {
            int t;
            float d;
            int.TryParse(TxtThemTang.Text, out t);
            float.TryParse(TxtCao.Text, out d);

      
            for (int i = 0; i < t; i++)
            {
                MyCommands  tang = new MyCommands();
                listTang.Add(tang);
            }

            
            for (int i = 0; i < t; i++)
            {
                MyCommands tang = listTang[i];
                ParentFormFloors.listBox1.Items.Add("Tầng thứ" + i + ",Chiều Cao là: " + tang.chieucao);
          
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
