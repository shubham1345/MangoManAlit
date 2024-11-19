using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MangoMan.Model.Sale
{
    public class SaleViewModel
    {
        [Browsable(false)]
        public int SaleID { get; set; }

        [Browsable(false)]
        public int OpeningStockID { get; set; }

        [Browsable(false)]
        public int ItemID { get; set; }

        [DisplayName("Sale No")]
        public int SaleNo { get; set; }

        [DisplayName("Sale Date")]
        public DateTime SaleDate { get; set; }

        [DisplayName("Narration")]
        public string Narration { get; set; }

        [Browsable(false)]
        public List<SaleProductDetailsViewModel> ProductDetails { get; set; }

    }

    public class SaleDashboardViewModel
    {
        [Browsable(false)]
        public int SaleID { get; set; }

        [Browsable(false)]
        public int ItemID { get; set; }

        [DisplayName("Sale No")]
        public int SaleNo { get; set; }

        [DisplayName("Sale Date")]
        public DateTime? SaleDate { get; set; }

        [DisplayName("Sale Amount")]
        public decimal SaleAmount { get; set; }

    }
    public class SaleProductDetailsViewModel
    {
        [Browsable(false)]
        public int SaleProductID{ get; set; }

        [Browsable(false)]
        public int SaleID { get; set; }

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
