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
    }
}
