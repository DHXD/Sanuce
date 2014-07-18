using System;
using System.Runtime;
using System.Collections.Generic;
using Autodesk.AutoCAD.Runtime;
using Autodesk.AutoCAD.ApplicationServices;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.Geometry;
using Autodesk.AutoCAD.EditorInput;
using System.Collections.Generic;
using DBTransMan = Autodesk.AutoCAD.DatabaseServices.TransactionManager;
using System.Linq;
using System.Text;


namespace Sanuce
{

    public class ClassTrucNgang: ClassDoiTuong
    {
        public int soTrucNgang;

        public ObjectId idTruc;
        private bool hasDrawObject = false;
        
        public float khoangCachTrucNgang;

        private Point3d ptStart;
        private Point3d ptEnd;

        public ClassTrucNgang()
        {
           
        }
        
        public ClassTrucNgang(float kctrucngang, int trucngang)
        {
            soTrucNgang = trucngang;
            khoangCachTrucNgang = kctrucngang;
        }

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
           
            // Get the current database and start the Transaction Manager
            Document acDoc = Autodesk.AutoCAD.ApplicationServices.Application.DocumentManager.MdiActiveDocument;
            Database acCurDb = acDoc.Database;

           
            // Start a transaction
            using (Transaction acTrans = acCurDb.TransactionManager.StartTransaction())
            {

                if (!hasDrawObject) // chua ve thi ve
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

                // Commit the changes and dispose of the transaction
                acTrans.Commit();
            }
        }

        internal void tinhToan()
        {
            throw new NotImplementedException();
        }
    }

    public class ClassTrucDoc: ClassDoiTuong
    {
        public int soTrucDoc;
        public ObjectId idTruc;
        private bool hasDrawObject = false;
        public float khoangCachTrucDoc;

        private Point3d ptStart;
        private Point3d ptEnd;
        
        public ClassTrucDoc() { }

        public ClassTrucDoc(float kctrucdoc, int trucdoc)
        {
            soTrucDoc = trucdoc;
            khoangCachTrucDoc = kctrucdoc;
        }

        public void TinhToan(float y, float ToaDoDiemDau)
        {
            khoangCachTrucDoc = (float)this.listThuocTinh[0];
            ClassTrucDoc TrucThamChieu = (ClassTrucDoc)this.DoiTuongThamChieu;

            Pos = new Point3d(TrucThamChieu.Pos.X + khoangCachTrucDoc, TrucThamChieu.Pos.Y, 0);

            ptStart = new Point3d(Pos.X, Pos.Y + ToaDoDiemDau, Pos.Z);
            ptEnd = new Point3d(Pos.X, Pos.Y + y + ToaDoDiemDau, Pos.Z);
        }

        public void Ve()
        {
              Document acDoc = Autodesk.AutoCAD.ApplicationServices.Application.DocumentManager.MdiActiveDocument;
              Database acCurDb = acDoc.Database;

              using (Transaction acTrans = acCurDb.TransactionManager.StartTransaction())
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
        }
    }
}
