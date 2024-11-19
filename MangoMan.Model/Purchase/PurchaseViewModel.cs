using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MangoMan.Model.Purchase
{
    public class PurchaseViewModel
    {
        [Browsable(false)]
        public int PurchaseID { get; set; }

        [Browsable(false)]
        public int OpeningStockID { get; set; }

        [Browsable(false)]
        public int ItemID { get; set; }

        [DisplayName("Purchase No")]
        public int PurchaseNo { get; set; }

        [DisplayName("Purchase Date")]
        public DateTime PurchaseDate { get; set; }

        [DisplayName("Purchase Amount")]
        public decimal PurchaseAmount { get; set; }

        [DisplayName("Narration")]
        public string Narration { get; set; }

        [Browsable(false)]
        public List<PurchaseProductDetailsViewModel> ProductDetails { get; set; }

    }

    public class PurchaseDashboardViewModel
    {
        [Browsable(false)]
        public int PurchaseID { get; set; }

        [Browsable(false)]
        public int ItemID { get; set; }

        [DisplayName("Purchase No")]
        public int PurchaseNo { get; set; }

        [DisplayName("Purchase Date")]
        public DateTime? PurchaseDate { get; set; }

        [DisplayName("Purchase Amount")]
        public decimal PurchaseAmount { get; set; }

    }

    public class PurchaseProductDetailsViewModel
    {
        [Browsable(false)]
        public int PurchaseProductID { get; set; }

        [Browsable(false)]
        public int PurchaseID { get; set; }
            
        [DisplayName("Product Name")]
        public int ItemID { get; set; }

        [DisplayName("Description")]
        public string Description { get; set; }

        [DisplayName("Quantity")]
        public decimal Quantity { get; set; }

        [DisplayName("Rate")]
        public decimal Rate { get; set; }

        [DisplayName("Amount")]
        public decimal Amount { get; set; }
    }
}
