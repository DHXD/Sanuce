using System;
using System.Runtime;
using System.Collections.Generic;
using Autodesk.AutoCAD.Runtime;
using Autodesk.AutoCAD.ApplicationServices;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.Geometry;
using Autodesk.AutoCAD.EditorInput;
<<<<<<< HEAD
using DBTransMan = Autodesk.AutoCAD.DatabaseServices.TransactionManager;
using System.Linq;
using System.Text;
using System.Reflection;
=======
using System.Collections.Generic;
using DBTransMan = Autodesk.AutoCAD.DatabaseServices.TransactionManager;
using System.Linq;
using System.Text;
>>>>>>> a4ba73e0b897cbddee7b2620c4f09ce53b65bfb5


namespace Sanuce
{

    public class ClassTrucNgang: ClassDoiTuong
    {
        public int soTrucNgang;
<<<<<<< HEAD
        public float doDai = 1000;
        public float ToaDoDiemDau = 0;
=======

>>>>>>> a4ba73e0b897cbddee7b2620c4f09ce53b65bfb5
        public ObjectId idTruc;
        private bool hasDrawObject = false;
        
        public float khoangCachTrucNgang;

        private Point3d ptStart;
        private Point3d ptEnd;
<<<<<<< HEAD
        private Matrix3d transformMatrix;
        public Vector3d hieuKC;
=======
>>>>>>> a4ba73e0b897cbddee7b2620c4f09ce53b65bfb5

        public ClassTrucNgang()
        {
           
        }
<<<<<<< HEAD

        public void XuLySuKien_ViTriChange(ClassDoiTuong doiTuongThayDoi)
        {
            // xu ly
            tinhToan();
            Ve();

            // raise event
            this.Change_ViTri_Event();
        }

        public void Subscribe(ClassDoiTuong doiTuongBiTheoDoi)
        {
            doiTuongBiTheoDoi.ViTri_Change += new ViTri_ChangeHandler(XuLySuKien_ViTriChange);
        }

=======
        
>>>>>>> a4ba73e0b897cbddee7b2620c4f09ce53b65bfb5
        public ClassTrucNgang(float kctrucngang, int trucngang)
        {
            soTrucNgang = trucngang;
            khoangCachTrucNgang = kctrucngang;
        }

<<<<<<< HEAD
       

        public void tinhToan()
        {
            khoangCachTrucNgang = (float)this.listThuocTinh[0];
            ClassTrucNgang TrucThamChieu = (ClassTrucNgang)this.DoiTuongThamChieu;
            
            Point3d Pos2 = new Point3d(TrucThamChieu.Pos.X, TrucThamChieu.Pos.Y + khoangCachTrucNgang, 0);
            hieuKC = new Vector3d(Pos2.X - Pos.X, Pos2.Y - Pos.Y, Pos2.Z - Pos.Z);       
            transformMatrix = Matrix3d.Displacement(hieuKC);

            Pos = Pos2;

            ptStart = new Point3d(Pos.X + ToaDoDiemDau, Pos.Y, Pos.Z);
            ptEnd = new Point3d(Pos.X + doDai + ToaDoDiemDau, Pos.Y, Pos.Z);
        }

        public void Ve()            //Ve truc ngang len CAD
        {   
=======
        public void tinhToan(float x, float ToaDoDiemDau)
        {
            khoangCachTrucNgang = (float)this.listThuocTinh[0];
            ClassTrucNgang TrucThamChieu = (ClassTrucNgang)this.DoiTuongThamChieu;

            Pos = new Point3d(TrucThamChieu.Pos.X, TrucThamChieu.Pos.Y + khoangCachTrucNgang, 0);


            ptStart = new Point3d(Pos.X + ToaDoDiemDau, Pos.Y, Pos.Z);
            ptEnd = new Point3d(Pos.X + x + ToaDoDiemDau, Pos.Y, Pos.Z);
        }

        public void Ve()
        {   
            //Ve truc ngang len CAD
            //ClassTrucNgang TrucNgang = DuLieuDGA.listDGANgang[i];
           
>>>>>>> a4ba73e0b897cbddee7b2620c4f09ce53b65bfb5
            // Get the current database and start the Transaction Manager
            Document acDoc = Autodesk.AutoCAD.ApplicationServices.Application.DocumentManager.MdiActiveDocument;
            Database acCurDb = acDoc.Database;

<<<<<<< HEAD
            // Start a transaction
            using (Transaction acTrans = acCurDb.TransactionManager.StartTransaction())
            {
                if (!hasDrawObject) // chua ve thi ve
                {
=======
           
            // Start a transaction
            using (Transaction acTrans = acCurDb.TransactionManager.StartTransaction())
            {

                if (!hasDrawObject) // chua ve thi ve
                {

>>>>>>> a4ba73e0b897cbddee7b2620c4f09ce53b65bfb5
                    BlockTable acBlkTbl;
                    BlockTableRecord acBlkTblRec;

                    // Open Model space for write
                    acBlkTbl = acTrans.GetObject(acCurDb.BlockTableId, OpenMode.ForRead) as BlockTable;
                    acDoc.LockDocument();
                    acBlkTblRec = acTrans.GetObject(acBlkTbl[BlockTableRecord.ModelSpace], OpenMode.ForWrite) as BlockTableRecord;

                    // Define the new line
                    Line acLine = new Line(ptStart, ptEnd);
                    acLine.SetDatabaseDefaults();

                    // Add the line to the drawing
                    idTruc = acBlkTblRec.AppendEntity(acLine);
                    acTrans.AddNewlyCreatedDBObject(acLine, true);
<<<<<<< HEAD
                    hasDrawObject = true;                
                }
                else   // ve roi thi sua vi tri, do dai, xoa
                {
                    Database db = Application.DocumentManager.MdiActiveDocument.Database;
                    DBTransMan tm = db.TransactionManager;
                    //start a transaction
                    Transaction ta = tm.StartTransaction();                                                
                    try
                    {
                        Entity ent = (Entity)tm.GetObject(this.idTruc, OpenMode.ForWrite) as Entity;
                        ((Line)ent).TransformBy(transformMatrix);
        
                        if(((Line)ent).StartPoint.X != ToaDoDiemDau)
                        {
                            double ToaDoDauBienDoi = ToaDoDiemDau-((Line)ent).StartPoint.X;
                            Vector3d vt = new Vector3d(ToaDoDauBienDoi,0,0);
                            Matrix3d mt = Matrix3d.Displacement(vt);
                            ((Line)ent).TransformBy(mt);                                
                        }

                        if (((Line)ent).Length != doDai)
                        {
                            double doDaiBienDoi = doDai - ((Line)ent).Length;
                            Vector3d vt = new Vector3d(doDaiBienDoi, 0, 0);
                            Matrix3d mat = Matrix3d.Displacement(vt);
                            Point3d res = ((Point3d)((Line)ent).EndPoint).TransformBy(mat);
                            ent.GetType().InvokeMember("EndPoint", BindingFlags.SetProperty, null, ent, new object[] { res });
                        }

                        ta.Commit();
                    }
                    catch
                    {
                        Console.WriteLine("Loi sua khoang cach");
                    }
                    finally
                    {
                        ta.Dispose();
                    }
                }             
=======
                    hasDrawObject = true;

                   
                }
                else   // ve roi thi sua vi tri
                {
                    if (this.flag == true)
                    {
                        Database db = Application.DocumentManager.MdiActiveDocument.Database;
                        DBTransMan tm = db.TransactionManager;
                        //start a transaction
                        Transaction ta = tm.StartTransaction();
                        try
                        {
                            Entity ent = (Entity)tm.GetObject(this.idTruc, OpenMode.ForWrite, true);
                            ent.ColorIndex = 1;

                            ta.Commit();
                        }
                        catch
                        {
                            Console.WriteLine("Loi sua khoang cach");
                        }
                        finally
                        {
                            ta.Dispose();
                        }
                    }
                }
              

                // Zoom to the extents or limits of the drawing
                //acDoc.SendStringToExecute("._zoom _all ", true, false, false);
>>>>>>> a4ba73e0b897cbddee7b2620c4f09ce53b65bfb5

                // Commit the changes and dispose of the transaction
                acTrans.Commit();
            }
<<<<<<< HEAD
        }    

        public void xoa()
        {
            Document doc = Application.DocumentManager.MdiActiveDocument;
            Database db = doc.Database;
            ObjectIdCollection erased = new ObjectIdCollection();
            Transaction tr = db.TransactionManager.StartTransaction();
            using (tr)
            {
                BlockTable bt = (BlockTable)tr.GetObject(db.BlockTableId, OpenMode.ForRead);
                doc.LockDocument();
                BlockTableRecord btr = (BlockTableRecord)tr.GetObject(bt[BlockTableRecord.ModelSpace], OpenMode.ForRead);

                foreach (ObjectId id in btr)
                {
                    DBObject obj = tr.GetObject(id, OpenMode.ForRead);
                    Line ln = obj as Line;
                    if (ln.Id == this.idTruc)
                    {
                        ln.UpgradeOpen();
                        ln.Erase();
                        erased.Add(this.idTruc);
                    }
                }
                tr.Commit();
            }
            db.ReclaimMemoryFromErasedObjects(erased);
=======
        }

        internal void tinhToan()
        {
            throw new NotImplementedException();
>>>>>>> a4ba73e0b897cbddee7b2620c4f09ce53b65bfb5
        }
    }

    public class ClassTrucDoc: ClassDoiTuong
<<<<<<< HEAD
    {        
=======
    {
>>>>>>> a4ba73e0b897cbddee7b2620c4f09ce53b65bfb5
        public int soTrucDoc;
        public ObjectId idTruc;
        private bool hasDrawObject = false;
        public float khoangCachTrucDoc;

        private Point3d ptStart;
        private Point3d ptEnd;
<<<<<<< HEAD
        private Matrix3d transformMatrix;

        public float doDai = 1000;
        public float ToaDoDiemDau = 0;
=======
>>>>>>> a4ba73e0b897cbddee7b2620c4f09ce53b65bfb5
        
        public ClassTrucDoc() { }

        public ClassTrucDoc(float kctrucdoc, int trucdoc)
        {
            soTrucDoc = trucdoc;
            khoangCachTrucDoc = kctrucdoc;
        }

<<<<<<< HEAD
        public void XuLySuKien_ViTriChange(ClassDoiTuong doiTuongThayDoi)
        {
            // xu ly
            TinhToan();
            Ve();
            
            // raise event
            this.Change_ViTri_Event();
        }

        public void Subscribe(ClassDoiTuong doiTuongBiTheoDoi)
        {
            doiTuongBiTheoDoi.ViTri_Change += new ViTri_ChangeHandler(XuLySuKien_ViTriChange);
        }

        public void TinhToan()
        {
            khoangCachTrucDoc = (float)this.listThuocTinh[0];
            ClassTrucDoc TrucThamChieu = (ClassTrucDoc)this.DoiTuongThamChieu;
            Point3d Pos2 = new Point3d(TrucThamChieu.Pos.X + khoangCachTrucDoc, TrucThamChieu.Pos.Y, 0);
            transformMatrix = Matrix3d.Displacement(new Vector3d(Pos2.X - Pos.X, Pos2.Y - Pos.Y, Pos2.Z - Pos.Z ));

            Pos = Pos2;

            ptStart = new Point3d(Pos.X, Pos.Y + ToaDoDiemDau, Pos.Z);
            ptEnd = new Point3d(Pos.X, Pos.Y + doDai + ToaDoDiemDau, Pos.Z);
          
=======
        public void TinhToan(float y, float ToaDoDiemDau)
        {
            khoangCachTrucDoc = (float)this.listThuocTinh[0];
            ClassTrucDoc TrucThamChieu = (ClassTrucDoc)this.DoiTuongThamChieu;

            Pos = new Point3d(TrucThamChieu.Pos.X + khoangCachTrucDoc, TrucThamChieu.Pos.Y, 0);

            ptStart = new Point3d(Pos.X, Pos.Y + ToaDoDiemDau, Pos.Z);
            ptEnd = new Point3d(Pos.X, Pos.Y + y + ToaDoDiemDau, Pos.Z);
>>>>>>> a4ba73e0b897cbddee7b2620c4f09ce53b65bfb5
        }

        public void Ve()
        {
              Document acDoc = Autodesk.AutoCAD.ApplicationServices.Application.DocumentManager.MdiActiveDocument;
              Database acCurDb = acDoc.Database;

              using (Transaction acTrans = acCurDb.TransactionManager.StartTransaction())
<<<<<<< HEAD
              {
                if (!hasDrawObject) // Chua ve thi ve
                {
                    BlockTable acBlkTbl;
                    BlockTableRecord acBlkTblRec;

                    // Open Model space for write
                    acBlkTbl = acTrans.GetObject(acCurDb.BlockTableId, OpenMode.ForRead) as BlockTable;
                    acDoc.LockDocument();
                    acBlkTblRec = acTrans.GetObject(acBlkTbl[BlockTableRecord.ModelSpace], OpenMode.ForWrite) as BlockTableRecord;

                    // Define the new line
                    Line acLine = new Line(ptStart, ptEnd);
                    acLine.SetDatabaseDefaults();
                        
                    // Add the line to the drawing
                    idTruc = acBlkTblRec.AppendEntity(acLine);
                    acTrans.AddNewlyCreatedDBObject(acLine, true);
                    hasDrawObject = true;
                }
                else // Ve roi thi sua vi tri
                {
                    Database db = Application.DocumentManager.MdiActiveDocument.Database;
                    DBTransMan tm = db.TransactionManager;
                    //start a transaction
                    Transaction ta = tm.StartTransaction();
                    try
                    {                                
                        Entity ent = (Entity)tm.GetObject(this.idTruc, OpenMode.ForWrite)as Entity;
                        ((Line)ent).TransformBy(transformMatrix);
                        if (((Line)ent).StartPoint.Y != ToaDoDiemDau)
                        {
                            double ToaDoDauBienDoi = ToaDoDiemDau - ((Line)ent).StartPoint.Y;
                            Vector3d vt = new Vector3d(0,ToaDoDauBienDoi, 0);
                            Matrix3d mt = Matrix3d.Displacement(vt);
                            ((Line)ent).TransformBy(mt);
                        }
                                
                        if (((Line)ent).Length != doDai)
                        {
                            double doDaiBienDoi = doDai - ((Line)ent).Length;
                            Vector3d vt = new Vector3d(0, doDaiBienDoi, 0);
                            Matrix3d mat = Matrix3d.Displacement(vt);
                            Point3d res = ((Point3d)((Line)ent).EndPoint).TransformBy(mat);
                            ent.GetType().InvokeMember("EndPoint", BindingFlags.SetProperty, null, ent, new object[] { res });                                
                        }
                        ta.Commit();
                    }
                    catch
                    {
                        Console.WriteLine("Loi sua khoang cach");
                    }
                    finally
                    {
                        ta.Dispose();
                    }             
                }
                // Zoom to the extents or limits of the drawing
                //acDoc.SendStringToExecute("._zoom _all ", true, false, false);
                // Commit the changes and dispose of the transaction
                acTrans.Commit();
            }
        }
        public void xoa()
        {
            Document doc = Application.DocumentManager.MdiActiveDocument;
            Database db = doc.Database;
            ObjectIdCollection erased = new ObjectIdCollection();
            Transaction tr = db.TransactionManager.StartTransaction();
            using (tr)
            {
                BlockTable bt = (BlockTable)tr.GetObject(db.BlockTableId, OpenMode.ForRead);
                doc.LockDocument();
                BlockTableRecord btr = (BlockTableRecord)tr.GetObject(bt[BlockTableRecord.ModelSpace], OpenMode.ForRead);

                foreach (ObjectId id in btr)
                {
                    DBObject obj = tr.GetObject(id, OpenMode.ForRead);
                    Line ln = obj as Line;
                    if (ln.Id == this.idTruc)
                    {
                        ln.UpgradeOpen();
                        ln.Erase();
                        erased.Add(this.idTruc);
                    }
                }
                tr.Commit();
            }
            db.ReclaimMemoryFromErasedObjects(erased);
=======
                {
                    if (!hasDrawObject) // Chua ve thi ve
                    {
                        BlockTable acBlkTbl;
                        BlockTableRecord acBlkTblRec;

                        // Open Model space for write
                        acBlkTbl = acTrans.GetObject(acCurDb.BlockTableId, OpenMode.ForRead) as BlockTable;
                        acDoc.LockDocument();
                        acBlkTblRec = acTrans.GetObject(acBlkTbl[BlockTableRecord.ModelSpace], OpenMode.ForWrite) as BlockTableRecord;

                        // Define the new line
                        Line acLine = new Line(ptStart, ptEnd);
                        acLine.SetDatabaseDefaults();

                        // Add the line to the drawing
                        idTruc = acBlkTblRec.AppendEntity(acLine);
                        acTrans.AddNewlyCreatedDBObject(acLine, true);
                        hasDrawObject = true;
                    }
                    else // Ve roi thi sua vi tri
                    {
                        if (this.flag == true)
                        {
                            Database db = Application.DocumentManager.MdiActiveDocument.Database;
                            DBTransMan tm = db.TransactionManager;
                            //start a transaction
                            Transaction ta = tm.StartTransaction();
                            try
                            {
                                Entity ent = (Entity)tm.GetObject(this.idTruc, OpenMode.ForWrite, true);
                                ent.ColorIndex = 1;
                               // ent
                                ta.Commit();
                            }
                            catch
                            {
                                Console.WriteLine("Loi sua khoang cach");
                            }
                            finally
                            {
                                ta.Dispose();
                            }
                        }
                    }


                    // Zoom to the extents or limits of the drawing
                   // acDoc.SendStringToExecute("._zoom _all ", true, false, false);

                    // Commit the changes and dispose of the transaction
                    acTrans.Commit();
                }
>>>>>>> a4ba73e0b897cbddee7b2620c4f09ce53b65bfb5
        }
    }
}
