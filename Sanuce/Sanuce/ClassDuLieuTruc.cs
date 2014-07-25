using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sanuce
{
    public class ClassDuLieuTruc
    {
        public List<ClassTrucNgang> listTrucNgang = new List<ClassTrucNgang>();
        
        public List<ClassTrucDoc> listTrucDoc = new List<ClassTrucDoc>();
        
        public class DuLieuTruc_EventArgs : EventArgs
        {
            public string ChangeTypeTruc;

            public DuLieuTruc_EventArgs(string changeTypeTruc)
            {
                ChangeTypeTruc = changeTypeTruc;
            }
        }

        public delegate void DuLieuDGA_EventHandler(ClassDuLieuTruc sender, DuLieuTruc_EventArgs se);
        public event DuLieuDGA_EventHandler DuLieuDGAChangeEvent;

        public ClassDuLieuTruc()
        {

        }

        public void AddTrucNgang(ClassTrucNgang DGA)
        {
            listTrucNgang.Add(DGA);
        }

        public void AddTrucDoc(ClassTrucDoc DGA)
        {
            listTrucDoc.Add(DGA);
        }
        public void Call_DuLieuTrucChange(string changeTypeTruc)
        {
            DuLieuTruc_EventArgs thamso = new DuLieuTruc_EventArgs(changeTypeTruc);
            if (DuLieuDGAChangeEvent != null) DuLieuDGAChangeEvent(this, thamso);
        }
    }
}
