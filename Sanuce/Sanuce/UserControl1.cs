using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Sanuce
{
    public partial class Palette : UserControl
    {

        public MyCommands ParentCommands;

        public Palette(MyCommands myCommands)
        {
            InitializeComponent();

            ParentCommands = myCommands;
            
        }

       
        private void UserControl1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            FormFloors Floors = new FormFloors(ParentCommands);
            Floors.ShowDialog();
            
        }
    }
}
