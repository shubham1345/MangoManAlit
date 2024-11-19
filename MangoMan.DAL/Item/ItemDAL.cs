using MangoMan.DBO;
using MangoMan.Model.Item;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MangoMan.DAL.Item
{
    public class ItemDAL
    {
        public Exception Exception = null ;
        public Exception delException = null;
        public bool SaveRecord(ItemViewModel ViewModel)
        {
            bool IsRecordSave = false;

                        
            using (dbMangoManEntities db = new dbMangoManEntities())
            {
                
                tblItem SaveModel = null;

                if (ViewModel.ItemID == 0)
                {
                    SaveModel = new tblItem();

                    SaveModel.rcdt = DateTime.Now;
                    db.tblItems.Add(SaveModel);
                }
                else
                {
                    SaveModel = db.tblItems.Find(ViewModel.ItemID);
                    SaveModel.redt = DateTime.Now;

                    db.tblItems.Attach(SaveModel);
                    db.Entry(SaveModel).State = System.Data.Entity.EntityState.Modified;
                }

                SaveModel.HSN = ViewModel.HSN;
                SaveModel.ItemName = ViewModel.ItemName;
                SaveModel.UnitName = ViewModel.UnitName;
                SaveModel.Description = ViewModel.Description;
                SaveModel.PurchaseRate = ViewModel.PurchaseRate;
                SaveModel.SaleRate = ViewModel.SaleRate;

                if (ViewModel.Quantity != 0)
                {
                    tblOpeningStock SaveModelos;
                    if (ViewModel.OpeningStockID == 0)
                    {
                        SaveModelos = new tblOpeningStock();

                        SaveModelos.rcdt = DateTime.Now;
                        SaveModelos.tblItem = SaveModel;
                        SaveModelos.Quantity = ViewModel.Quantity;

                        db.tblOpeningStocks.Add(SaveModelos);
                    }
                    else
                    {
                        SaveModelos = db.tblOpeningStocks.Find(ViewModel.OpeningStockID);

                        if (SaveModelos != null)
                        {
                            SaveModelos.redt = DateTime.Now;

                            SaveModelos.Quantity = ViewModel.Quantity;

                            db.tblOpeningStocks.Attach(SaveModelos);
                            db.Entry(SaveModelos).State = System.Data.Entity.EntityState.Modified;
                        }
                    }
                }
                else
                {
                        db.tblOpeningStocks.RemoveRange(db.tblOpeningStocks.Where(r => r.OpeningStockID == ViewModel.OpeningStockID));
                }


                try
                {
                    db.SaveChanges();
                    IsRecordSave = true;
                }
                catch(Exception ex)
                {
                    Exception = ex;
                }
               
            }
            return IsRecordSave;
        }
        
        public enum ps
        {
            Item,
            Both_PS,
            Purchase,
            sale,
        }
        public int DeletRecord(int ID)
        {
            int a;         
            //bool IsRecordDelete = false;
            using (dbMangoManEntities db = new dbMangoManEntities())
            {
                if(db.tblPurchaseProductDetails.Any(s => s.ItemID == ID) && db.tblSaleProductDetails.Any(s => s.ItemID == ID))
                {
                    a= (int)ps.Both_PS;
                }
                else if (db.tblPurchaseProductDetails.Any(s => s.ItemID == ID))
                {
                    a = (int)ps.Purchase;
                }
                else if(db.tblSaleProductDetails.Any(s => s.ItemID == ID))
                {
                    a= (int)ps.sale;
                }
                else
                {
                    db.tblItems.RemoveRange(db.tblItems.Where(r => r.ItemID == ID));
                    db.tblOpeningStocks.RemoveRange(db.tblOpeningStocks.Where(r => r.ItemID == ID));
                    a= (int)ps.Item;
                    try
                    {
                        db.SaveChanges();
                        //IsRecordDelete = true;
                    }
                    catch (Exception ex)
                    {
                        delException = ex;
                    }
                    
                }
                return a;
                //db.tblPurchaseProductDetails.RemoveRange(db.tblPurchaseProductDetails.Where(r => r.ItemID == ID));
                //db.tblSaleProductDetails.RemoveRange(db.tblSaleProductDetails.Where(r => r.ItemID == ID));
            }

            
        }
        public List<ItemDashboardViewModel> GetDashBoardData()
        {
            using (dbMangoManEntities db = new dbMangoManEntities())
            {
                var res = (from r in db.tblItems

                           select new ItemDashboardViewModel()
                           {
                               ItemID = r.ItemID,
                               HSN = r.HSN,
                               ItemName = r.ItemName,
                               UnitName = r.UnitName,
                               PurchaseRate = r.PurchaseRate,
                               SaleRate = r.SaleRate,
                           }
                           ).ToList();

                    return res;
            }         
        }
        
        public ItemViewModel GetViewModelByPrimeKey(long ItemID)
        {
            using (dbMangoManEntities db = new dbMangoManEntities())
            {
                return (from r in db.tblItems

                        where r.ItemID == ItemID
                        select new ItemViewModel()
                        {
                            ItemID = r.ItemID,
                            HSN = r.HSN,
                            ItemName = r.ItemName,
                            UnitName = r.UnitName,
                            Description = r.Description,
                            PurchaseRate = r.PurchaseRate,
                            SaleRate = r.SaleRate,
                        }
                        ).FirstOrDefault();
            }
        }

        public List<ItemLookUpListViewModel> GetLookUpList()
        {
            using (dbMangoManEntities db = new dbMangoManEntities())
            {
                var res = (from r in db.tblItems

                           select new ItemLookUpListViewModel()
                           {
                               ItemID = r.ItemID,
                               HSN = r.HSN,
                               ItemName = r.ItemName,
                               UnitName = r.UnitName,
                               PurchaseRate = r.PurchaseRate,
                               SaleRate = r.SaleRate,
                           }
                           ).ToList();

                return res;
            }
        }

        public bool CheckDuplicate(string ItemName, int ExcludeID)
        {
            using (dbMangoManEntities db = new dbMangoManEntities())
            {
                return CheckDuplicate(ItemName, ExcludeID, db);
            }
        }
        public bool CheckDuplicate(string ItemName, int ExcludeID, dbMangoManEntities db)
        {
            ItemName = ItemName.ToUpper();
            return db.tblItems.Any(r => r.ItemName.ToUpper() == ItemName && r.ItemID != ExcludeID);
        }

        public bool CheckHSNDuplicate(string HSN, int ExcludeID)
        {
            using (dbMangoManEntities db = new dbMangoManEntities())
            {
                return CheckHSNDuplicate(HSN, ExcludeID, db);
            }
        }
        public bool CheckHSNDuplicate(string HSN, int ExcludeID, dbMangoManEntities db)
        {
            HSN = HSN.ToUpper();
            return db.tblItems.Any(r => r.HSN.ToUpper() == HSN && r.ItemID != ExcludeID);
        }
    }
}
