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
        public FormFloors ParentFormFloors;

        public FormMoreFloors(FormFloors formFloors)
        {
            InitializeComponent();

            ParentFormFloors = formFloors;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonDongY_Click(object sender, EventArgs e)
        {
            MessageBox.Show(string.Format("Them tang {0} \n Chieu Cao {1}", textThemTang.Text, textCao.Text)); 
            
        }

        private void txtThemTang_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
