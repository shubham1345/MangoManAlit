using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MangoMan.Model.Opening_Stock
{
    public class OpeningStockViewModel
    {
        [Browsable(false)]
        public int OpeningStockID { get; set; }

        [Browsable(false)]
        public int ItemID { get; set; }

        
        [DisplayName("Quantity")]
        public decimal Quantity { get; set; }
    }
    
}

