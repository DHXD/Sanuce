// (C) Copyright 2013 by  
//
using System;
using System.Runtime;
using System.Collections.Generic;
using Autodesk.AutoCAD.Runtime;
using Autodesk.AutoCAD.ApplicationServices;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.Geometry;
using Autodesk.AutoCAD.EditorInput;

// This line is not mandatory, but improves loading performances
[assembly: CommandClass(typeof(Sanuce.MyCommands))]

namespace Sanuce
{

    // This class is instantiated by AutoCAD for each document when
    // a command is called by the user the first time in the context
    // of a given document. In other words, non static data in this class
    // is implicitly per-document!
    public class MyCommands
    {
        // The CommandMethod attribute can be applied to any public  member 
        // function of any public class.
        // The function should take no arguments and return nothing.
        // If the method is an intance member then the enclosing class is 
        // intantiated for each document. If the member is a static member then
        // the enclosing class is NOT intantiated.
        //
        // NOTE: CommandMethod has overloads where you can provide helpid and
        // context menu.

        public ClassDuLieu DuLieu = new ClassDuLieu();

        public ClassDuLieuTruc DuLieuTruc = new ClassDuLieuTruc();

        // Modal Command with localized name
        
        [CommandMethod("MyGroup", "MyCommand", "MyCommandLocal", CommandFlags.Modal)]
        
        [CommandMethod("XD")]
        
        public void MyCommand() // This method can have any name
        {
            // Put your command code here
            Autodesk.AutoCAD.Windows.PaletteSet ps = null;
            ps = new Autodesk.AutoCAD.Windows.PaletteSet("Sanuce");
            Palette myPalette = new Palette(this);
            ps.Add("Sanuce", myPalette);
            ps.Visible = true;
        }

        [CommandMethod("DrawGridAxis")]
        public void DrawGridAxis()
        {
            float ToaDoDiemDauTheoX, ToaDoDiemDauTheoY;
            float doDaiTheoTrucX = 0, doDaiTheoTrucY = 0;

            if (DuLieuTruc.listTrucDoc.Count <= 0)
            {               
                return; //
            }

            ClassTrucDoc TrucDoc = DuLieuTruc.listTrucDoc[0];
            ToaDoDiemDauTheoX = TrucDoc.khoangCachTrucDoc;

            ClassTrucNgang TrucNgang = DuLieuTruc.listTrucNgang[0];
            ToaDoDiemDauTheoY = TrucNgang.khoangCachTrucNgang;

            //Xac dinh do dai cac truc theo truc X va Y
            for (int i = 1; i < DuLieuTruc.listTrucNgang.Count; i++)
            {
                ClassTrucNgang DGANgang = DuLieuTruc.listTrucNgang[i];
                doDaiTheoTrucX += DGANgang.khoangCachTrucNgang;
            }

            for (int i = 1; i < DuLieuTruc.listTrucDoc.Count; i++)
            {
                ClassTrucDoc DGADoc = DuLieuTruc.listTrucDoc[i];
                doDaiTheoTrucY += DGADoc.khoangCachTrucDoc;
            }
            
            //Ve truc ngang len CAD
            for (int i = 0; i < DuLieuTruc.listTrucNgang.Count; i++)
            {
                ClassTrucNgang TrucNgang1 = DuLieuTruc.listTrucNgang[i];

                // Get the current database and start the Transaction Manager
                Document acDoc = Autodesk.AutoCAD.ApplicationServices.Application.DocumentManager.MdiActiveDocument;
                Database acCurDb = acDoc.Database;

                if (DuLieuTruc.listTrucDoc.Count > 0)
                {
                    ClassTrucDoc DGADoc = DuLieuTruc.listTrucDoc[0];
                }
                TrucNgang1.ToaDoDiemDau = ToaDoDiemDauTheoX ;
                TrucNgang1.doDai = doDaiTheoTrucY;
                TrucNgang1.tinhToan();
                TrucNgang1.Ve();
            }

            //Ve truc doc len CAD
            for (int i = 0; i < DuLieuTruc.listTrucDoc.Count; i++)
            {
                ClassTrucDoc TrucDoc1 = DuLieuTruc.listTrucDoc[i];
         
                // Get the current database and start the Transaction Manager
                Document acDoc = Autodesk.AutoCAD.ApplicationServices.Application.DocumentManager.MdiActiveDocument;
                Database acCurDb = acDoc.Database;

                if(DuLieuTruc.listTrucNgang.Count>0)
                {
                    ClassTrucNgang DGANgang=DuLieuTruc.listTrucNgang[0];
                }

                TrucDoc1.doDai = doDaiTheoTrucX;
                TrucDoc1.ToaDoDiemDau = ToaDoDiemDauTheoY;
                TrucDoc1.TinhToan();
                TrucDoc1.Ve();
            }
        }

        // Modal Command with pickfirst selection
        [CommandMethod("MyGroup", "MyPickFirst", "MyPickFirstLocal", CommandFlags.Modal | CommandFlags.UsePickSet)]
        public void MyPickFirst() // This method can have any name
        {
            PromptSelectionResult result = Application.DocumentManager.MdiActiveDocument.Editor.GetSelection();
            if (result.Status == PromptStatus.OK)
            {
                // There are selected entities
                // Put your command using pickfirst set code here
            }
            else
            {
                // There are no selected entities
                // Put your command code here
            }
        }

        // Application Session Command with localized name
        [CommandMethod("MyGroup", "MySessionCmd", "MySessionCmdLocal", CommandFlags.Modal | CommandFlags.Session)]
        public void MySessionCmd() // This method can have any name
        {
            // Put your command code here
        }

        // LispFunction is similar to CommandMethod but it creates a lisp 
        // callable function. Many return types are supported not just string
        // or integer.
        [LispFunction("MyLispFunction", "MyLispFunctionLocal")]
        public int MyLispFunction(ResultBuffer args) // This method can have any name
        {
            // Put your command code here

            // Return a value to the AutoCAD Lisp Interpreter
            return 1;
        }

    }
}


