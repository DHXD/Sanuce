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
    public partial class FormDeleteTang : Form
    {
        public FormFloors ParentXoaTang;

        public FormDeleteTang(FormFloors formFloors)
        {
            InitializeComponent();

            ParentXoaTang = formFloors;
        }

        private void Xóa_Tầng_Load(object sender, EventArgs e)
        {

            textXoa.Text = " ";
            for (int i = 0; i < ParentXoaTang.listBox1.SelectedIndices.Count; i++)
            {
                textXoa.Text += (i > 0 ? ", " : "") + (ParentXoaTang.listBox1.SelectedIndices[i] + 1);
            }
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
<<<<<<< HEAD
            int tangcanxoa;
            int.TryParse(textXoa.Text, out tangcanxoa);
            for (int i = 1; i <= ParentXoaTang.listBox1.SelectedIndices.Count; i++)
            {
                if (tangcanxoa == ParentXoaTang.listBox1.SelectedIndices[i])
                {
                    ParentXoaTang.listBox1.SelectedIndices.Remove(ParentXoaTang.listBox1.SelectedIndices[i]);
                  
                }
             

            }

            this.Close();
=======
            
>>>>>>> c8884591c93b17ff5e12a9f93ae793d0ca5e853c
        }

       

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
