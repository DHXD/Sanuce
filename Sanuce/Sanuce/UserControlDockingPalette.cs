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

       
        private void UserControlDockingPalette_Load(object sender, EventArgs e)
        {
            ParentCommands.DuLieu.DuLieuChangeEvent += new ClassDuLieu.DuLieu_EventHandler(DuLieu_Change);

        }

        // ham bat su kien DuLieuChangeEvent cua ClassDuLieu
        void DuLieu_Change(ClassDuLieu o, ClassDuLieu.DuLieu_EventArgs thamso)  
        {
            MessageBox.Show("Docking palette biet rang du lieu vua thay doi: " + thamso.ChangeType);
        }

        private void button1_Click(object sender, EventArgs e)
        {

            FormFloors Floors = new FormFloors(ParentCommands);
            Floors.ShowDialog();
            
           
        }

    }
}
