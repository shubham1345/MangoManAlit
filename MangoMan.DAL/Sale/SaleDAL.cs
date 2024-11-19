using MangoMan.Model.Sale;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MangoMan.DBO;

namespace MangoMan.DAL.Sale
{
    public class SaleDAL
    {
        
        public Exception Exception = null;
        public Exception delException = null;
        public bool SaveRecord(SaleViewModel ViewModel)
        {
            bool IsRecordSave = false;
            using (dbMangoManEntities db = new dbMangoManEntities())
            {
                tblSale SaveModel;
                if (ViewModel.SaleID == 0)
                {
                    SaveModel = new tblSale();
                    SaveModel.rcdt = DateTime.Now;
                    db.tblSales.Add(SaveModel);
                }
                else
                {
                    SaveModel = db.tblSales.Find(ViewModel.SaleID);
                    SaveModel.redt = DateTime.Now;
                    db.tblSales.Attach(SaveModel);
                    db.Entry(SaveModel).State = System.Data.Entity.EntityState.Modified;
                    db.tblSaleProductDetails.RemoveRange(db.tblSaleProductDetails.Where(r => r.SaleID == ViewModel.SaleID));

                }

                SaveModel.SaleNo = ViewModel.SaleNo;
                SaveModel.SaleAmount = ViewModel.ProductDetails.Sum(r => r.Amount);
                SaveModel.Narration = ViewModel.Narration;
                SaveModel.SaleDate = ViewModel.SaleDate;

                tblOpeningStock SaveModelos;
                tblSaleProductDetail Model ;
                foreach (var id in ViewModel.ProductDetails.Where(r => r.Quantity != 0))
                {
                    Model = db.tblSaleProductDetails.FirstOrDefault(r => r.SaleProductID == id.SaleProductID);
                    SaveModelos = db.tblOpeningStocks.FirstOrDefault(r => r.ItemID == id.ItemID);
                    if (db.tblOpeningStocks.Any(r => r.ItemID == id.ItemID))
                    {
                        SaveModelos.redt = DateTime.Now;

                        if (Model != null && ViewModel.SaleID != 0) { SaveModelos.Quantity = SaveModelos.Quantity + Model.Quantity - id.Quantity ; }
                        else { SaveModelos.Quantity = SaveModelos.Quantity - id.Quantity; }
                        
                        db.tblOpeningStocks.Attach(SaveModelos);
                        db.Entry(SaveModelos).State = System.Data.Entity.EntityState.Modified;
                        
                    }
                    else
                    {
                        SaveModelos = new tblOpeningStock();
                        SaveModelos.rcdt = DateTime.Now;
                        SaveModelos.ItemID = id.ItemID;
                        SaveModelos.Quantity = -id.Quantity;

                        db.tblOpeningStocks.Add(SaveModelos);
                        
                    }
                }
                db.tblSaleProductDetails.AddRange(ViewModel.ProductDetails.Where(r => r.ItemID != 0).Select(r => new tblSaleProductDetail
                {

                    tblSale = SaveModel,
                    ItemID = r.ItemID,
                    Rate = r.Rate,
                    Quantity = r.Quantity,
                    Description = r.Description,
                    Amount = r.Amount,
                }));
                try
                    {
                        db.SaveChanges();
                        IsRecordSave = true;
                    }
                    catch (Exception ex)
                    {
                        Exception = ex;
                    }
                
                return IsRecordSave;
            }
        }
        public List<SaleDashboardViewModel> GetDashboardData()
        {
            using (dbMangoManEntities db = new dbMangoManEntities())
            {
                var res = (from r in db.tblSales
                           
                           select new SaleDashboardViewModel()
                           {
                               SaleID = r.SaleID,
                               SaleNo = r.SaleNo,
                               SaleDate = r.SaleDate,
                               SaleAmount = r.SaleAmount,
                           }
                    ).ToList();
                return res;
            }
        }
        public SaleViewModel GetViewModelByPrimaryKey(long ID)
        {
            using (dbMangoManEntities db = new dbMangoManEntities())
            {
                return (from r in db.tblSales
                        where r.SaleID == ID
                        select new SaleViewModel()
                        {
                            SaleNo = r.SaleNo,
                            SaleDate = r.SaleDate,
                            //SaleAmount = r.SaleAmount,
                            Narration = r.Narration,
                            ProductDetails = (from pd in db.tblSaleProductDetails

                                              where pd.SaleID == r.SaleID

                                              select new SaleProductDetailsViewModel()
                                              {
                                                  ItemID = pd.ItemID,
                                                  SaleID = pd.SaleID,
                                                  SaleProductID = pd.SaleProductID,
                                                  Description = pd.Description,
                                                  Quantity = pd.Quantity,
                                                  Rate = pd.Rate,
                                                  Amount = pd.Amount,

                                              }
                                              ).ToList(),
                        }
                        ).FirstOrDefault();
            }
        }
        public int SaleNoMax()
        {
            using (dbMangoManEntities db = new dbMangoManEntities())
            {
                if (db.tblSales.Any(r => r.SaleNo == 1))
                { return db.tblSales.Max(r => r.SaleNo); }
                else { return 0; }
            }
        }
        public bool DeleteRecord(long ID)
        {
            bool IsRecordDelete = false;
            using (dbMangoManEntities db = new dbMangoManEntities())
            {
                tblOpeningStock SaveModelos;
                
                var record = db.tblSaleProductDetails.Where(r => r.SaleID == ID).ToList();

                foreach (var Item in record)
                {

                    SaveModelos = db.tblOpeningStocks.FirstOrDefault(r => r.ItemID == Item.ItemID);
                    if (SaveModelos != null)
                    {
                        SaveModelos.redt = DateTime.Now;

                        SaveModelos.Quantity += Item.Quantity;

                        db.tblOpeningStocks.Attach(SaveModelos);
                        db.Entry(SaveModelos).State = System.Data.Entity.EntityState.Modified;
                    }
                }
                db.tblSaleProductDetails.RemoveRange(db.tblSaleProductDetails.Where(r => r.SaleID == ID));
                db.tblSales.RemoveRange(db.tblSales.Where(r => r.SaleID == ID));
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

        
    }
    }

