using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MangoMan.Model.Purchase;
using MangoMan.DBO;

namespace MangoMan.DAL.Purchase
{
    public class PurchaseDAL
    {

        public Exception Exception = null;
        public Exception delException = null;
        
        public bool SaveRecord(PurchaseViewModel ViewModel)
        {
            bool ISRecordSave = false;
            using (dbMangoManEntities db = new dbMangoManEntities())
            {
                tblPurchase SaveModel;
                
                if (ViewModel.PurchaseID == 0)
                {
                    SaveModel = new tblPurchase();
                    SaveModel.rcdt = DateTime.Now;
                    db.tblPurchases.Add(SaveModel);
                }
                else
                {
                    SaveModel = db.tblPurchases.Find(ViewModel.PurchaseID);
                    SaveModel.redt = DateTime.Now;
                    db.tblPurchases.Attach(SaveModel);
                    db.Entry(SaveModel).State = System.Data.Entity.EntityState.Modified;

                    db.tblPurchaseProductDetails.RemoveRange(db.tblPurchaseProductDetails.Where(r => r.PurchaseID == ViewModel.PurchaseID));
                }

                SaveModel.PurchaseNo = ViewModel.PurchaseNo;
                SaveModel.PurchaseDate = ViewModel.PurchaseDate;
                SaveModel.PurchaseAmount = ViewModel.ProductDetails.Sum(r => r.Amount);
                SaveModel.Narration = ViewModel.Narration;

                tblOpeningStock SaveModelos;
                tblPurchaseProductDetail model ;
                foreach (var id in ViewModel.ProductDetails.Where(r => r.Quantity != 0))
                {
                    SaveModelos = db.tblOpeningStocks.FirstOrDefault(r => r.ItemID == id.ItemID);
                    if (SaveModelos != null)
                    { 
                        model = db.tblPurchaseProductDetails.FirstOrDefault(s => s.PurchaseProductID == id.PurchaseProductID);
                        if(model != null && ViewModel.PurchaseID != 0) { SaveModelos.Quantity = id.Quantity + SaveModelos.Quantity - model.Quantity; }
                        else { SaveModelos.Quantity = id.Quantity + SaveModelos.Quantity; }
                        SaveModelos.redt = DateTime.Now;
                        
                        db.tblOpeningStocks.Attach(SaveModelos);
                        db.Entry(SaveModelos).State = System.Data.Entity.EntityState.Modified;
                        
                    }
                    else
                    {
                        SaveModelos = new tblOpeningStock();
                        SaveModelos.rcdt = DateTime.Now;
                        SaveModelos.ItemID = id.ItemID;
                        SaveModelos.Quantity = id.Quantity;

                        db.tblOpeningStocks.Add(SaveModelos);
                    }
                }

                db.tblPurchaseProductDetails.AddRange(ViewModel.ProductDetails.Where(r => r.ItemID != 0).Select(r => new tblPurchaseProductDetail
                {
                    tblPurchase = SaveModel,
                    ItemID = r.ItemID,
                    Rate = r.Rate,
                    Quantity = r.Quantity,
                    Description = r.Description,
                    Amount = r.Amount,
                }));

                try
                {
                    db.SaveChanges();
                    ISRecordSave = true;
                }
                catch (Exception ex)
                {
                    Exception = ex;
                }
            }

            return ISRecordSave;
        }
        public List<PurchaseDashboardViewModel> GetDashboardData()
        {
            using (dbMangoManEntities db = new dbMangoManEntities())
            {
                var res = ( from r in db.tblPurchases
                            
                    select new PurchaseDashboardViewModel()
                    {
                        PurchaseID = r.PurchaseID,
                        PurchaseNo = r.PurchaseNo,
                        PurchaseDate = r.PurchaseDate,
                        PurchaseAmount = r.PurchaseAmount,
                    }
                    ).ToList();

                return res;
            }
        }
        
        public PurchaseViewModel GetDataByPrimaryKey(long ID)
        {
            using (dbMangoManEntities db = new dbMangoManEntities())
            {
                return (from r in db.tblPurchases
                        where r.PurchaseID == ID
                        select new PurchaseViewModel()
                        {
                            PurchaseNo = r.PurchaseNo,
                            PurchaseDate = r.PurchaseDate,
                            PurchaseAmount = r.PurchaseAmount,
                            Narration = r.Narration,

                            ProductDetails = (from pd in db.tblPurchaseProductDetails
                                              where pd.PurchaseID == r.PurchaseID

                                              select new PurchaseProductDetailsViewModel()
                                              {
                                                  ItemID = pd.ItemID,
                                                  PurchaseID = pd.PurchaseID,
                                                  PurchaseProductID = pd.PurchaseProductID,
                                                  Description= pd.Description,
                                                  Quantity = pd.Quantity,
                                                  Rate = pd.Rate,
                                                  Amount = pd.Amount,

                                              }
                                              ).ToList(),
                        }
                        ).FirstOrDefault();
            }
        }
        public bool DeleteRecord(long ID )
        {
            bool IsRecordDelete = false;
            using (dbMangoManEntities db = new dbMangoManEntities())
            {
                tblOpeningStock SaveModelos;

                var record = db.tblPurchaseProductDetails.Where(r => r.PurchaseID == ID).ToList();

                foreach (var Item in record)
                {
                
                    SaveModelos = db.tblOpeningStocks.FirstOrDefault(r => r.ItemID == Item.ItemID);
                    if (SaveModelos != null)
                    { 
                        SaveModelos.redt = DateTime.Now;

                        SaveModelos.Quantity -= Item.Quantity;

                        db.tblOpeningStocks.Attach(SaveModelos);
                        db.Entry(SaveModelos).State = System.Data.Entity.EntityState.Modified;
                    } 
                }
                
                db.tblPurchaseProductDetails.RemoveRange(db.tblPurchaseProductDetails.Where(r => r.PurchaseID == ID));
                db.tblPurchases.RemoveRange(db.tblPurchases.Where(r => r.PurchaseID == ID));
                db.tblOpeningStocks.RemoveRange(db.tblOpeningStocks.Where(r => r.Quantity == 0));

                try
                {
                        db.SaveChanges();
                        IsRecordDelete = true;
                    }
                catch (Exception ex)
                    {
                        delException = ex;
                    }
            }

            return IsRecordDelete;
            }
        
        public int PurchaseNoMax()
        {
            using (dbMangoManEntities db = new dbMangoManEntities())
            {
                if (db.tblPurchases.Any(r => r.PurchaseNo == 1))
                { return db.tblPurchases.Max(r => r.PurchaseNo); }
                else { return 0; }
            }
        }
    }
}
