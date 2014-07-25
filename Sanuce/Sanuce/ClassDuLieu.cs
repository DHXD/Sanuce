using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Text;

namespace Sanuce
{
    public class ClassDuLieu
    {
        public List<ClassTang> listTang = new List<ClassTang>();

        public ClassTrucNgang TrucX = new ClassTrucNgang();
        public ClassTrucDoc TrucY = new ClassTrucDoc();

        public class DuLieu_EventArgs : EventArgs
        {
            public string ChangeType;

            public DuLieu_EventArgs(string changeType)
            {
                ChangeType = changeType;
            }
        }

        public delegate void DuLieu_EventHandler(ClassDuLieu sender, DuLieu_EventArgs se);
       
        public event DuLieu_EventHandler DuLieuChangeEvent;

        public ClassDuLieu()
        { 
           // _DuLieu = new ClassTang();
        }

        public void AddTang(ClassTang tang) 
        {
            listTang.Add(tang);

        }

        public void Call_DuLieuChange(string changeType)        // thong bao su kien DuLieuChangeEvent
        {
            DuLieu_EventArgs thamso = new DuLieu_EventArgs(changeType);
            if (DuLieuChangeEvent != null) DuLieuChangeEvent(this, thamso);
        }
        
    }
}
