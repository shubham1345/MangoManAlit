using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;

namespace MangoMan.Winform.Navigation
{
    public partial class frmNavigation : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmNavigation()
        {
            InitializeComponent();
        }

        public void closeform()
        {
            for (int i = 0; i < Application.OpenForms.Count; i++)
            {
                Form fc = Application.OpenForms[i];
                if (fc != this)
                {
                    fc.Close();
                }
            }
        }

        private void btnItem_ItemClick(object sender, ItemClickEventArgs e)
        {
            closeform();
            Item.frmItemDashboard frm = new Item.frmItemDashboard();
            frm.MdiParent = this;
            frm.Show();
        }
        private void btnSale_ItemClick(object sender, ItemClickEventArgs e)
        {
            closeform();
            Sale.frmSaleDashboard frm= new Sale.frmSaleDashboard();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnPurchase_ItemClick(object sender, ItemClickEventArgs e)
        {
            closeform();
            Purchase.frmPurchaseDashboard frm = new Purchase.frmPurchaseDashboard();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}