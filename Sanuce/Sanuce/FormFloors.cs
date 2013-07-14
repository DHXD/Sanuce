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
        }
        public FormFloors()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)

        {

        }
    }

}



