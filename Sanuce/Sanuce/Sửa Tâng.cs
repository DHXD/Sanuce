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
        public FormFloors ParentSuaTang;

        public Sửa_Tâng(FormFloors formFloors)
        {
            InitializeComponent();

            ParentSuaTang = formFloors;
        }
    }
}
