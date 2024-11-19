using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MangoMan.Model.Item
{
    public class ItemDashboardViewModel
    {
        [Browsable(false)]
        public int ItemID { get; set; }

        [DisplayName("HSN")]
        public string HSN { get; set; }

        [DisplayName("Item Name")]
        public string ItemName { get; set; }

        [DisplayName("Unit Name")]
        public string UnitName { get; set; }

        [DisplayName("Purchase Rate")]
        public decimal PurchaseRate { get; set; }

        [DisplayName("Sale Rate")]
        public decimal SaleRate { get; set; }

    }
    public class ItemViewModel
    {
        [Browsable(false)]
        public int ItemID { get; set; }

        [Browsable(false)]
        public int OpeningStockID { get; set; }

        [DisplayName("HSN")]
        public string HSN { get; set; }

        [DisplayName("Item Name")]
        public string ItemName { get; set; }
        
        [DisplayName("Unit Name")]
        public string UnitName { get; set; }

        [DisplayName("Description")]
        public string Description { get; set; }

        [DisplayName("Quantity")]
        public decimal Quantity { get; set; }

        [DisplayName("Purchase Rate")]
        public decimal PurchaseRate { get; set; }

        [DisplayName("Sale Rate")]
        public decimal SaleRate { get; set; }

    }

    public class ItemLookUpListViewModel
    {
        [Browsable(false)]
        public int ItemID { get; set; }

        [DisplayName("HSN")]
        public string HSN { get; set; }

        [DisplayName("Item Name")]
        public string ItemName { get; set; }

        [DisplayName("Unit Name")]
        public string UnitName { get; set; }

        [DisplayName("Purchase Rate")]
        public decimal PurchaseRate { get; set; }

        [DisplayName("Sale Rate")]
        public decimal SaleRate { get; set; }

    }

}
