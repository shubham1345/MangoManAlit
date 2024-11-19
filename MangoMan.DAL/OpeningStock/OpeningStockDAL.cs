using MangoMan.Model.Opening_Stock;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MangoMan.DBO;
using MangoMan.Model;

namespace MangoMan.DAL.OpeningStock
{
    public class OpeningStockDAL
    {
        public OpeningStockViewModel GetViewModelByPrimaryKey(long OpeningStockID)
        {
            using (dbMangoManEntities db = new dbMangoManEntities())
            {
                return (from r in db.tblOpeningStocks
                        where r.OpeningStockID == OpeningStockID
                        select new OpeningStockViewModel()
                        {
                            ItemID = r.ItemID,
                            Quantity = r.Quantity,
                        }
                        ).FirstOrDefault();
            }
        }
       
        public int FindOSIDbyItemID(int id)
        {
            using (dbMangoManEntities db = new dbMangoManEntities())
            {
                if(db.tblOpeningStocks.Any(r => r.ItemID == id))
                {
                    return db.tblOpeningStocks.Where(r => r.ItemID == id).FirstOrDefault().OpeningStockID;
                }
                else { return 0; }
            }
        }
    }
}
