using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using MangoMan.DAL.Purchase;
using MangoMan.Model.Purchase;
using MangoMan.DAL.OpeningStock;
using MangoMan.Model.Opening_Stock;

namespace MangoMan.Winform.Purchase
{
    public partial class frmPurchaseDashboard : DevExpress.XtraEditors.XtraForm
    {
        PurchaseDAL DALobj;
        OpeningStockDAL dalos;
        public frmPurchaseDashboard()
        {
            InitializeComponent();
            DALobj = new PurchaseDAL();
            dalos = new OpeningStockDAL();

            Refreshed();
        }
        protected override void OnLoad(EventArgs e)
        {
            frmPurchaseDashboard ft = new frmPurchaseDashboard();
            lblTitle.Text = ft.Text;
            base.OnLoad(e);
        }
        public void Refreshed()
        {
            var r = DALobj.GetDashboardData();
            if(r.Count == 0)
            {
                btnEdit.Enabled = false;
                btnDelete.Enabled = false;
            }
            else
            {
                btnEdit.Enabled = true;
                btnDelete.Enabled = true;
            }
            purchaseDashboardViewModelBindingSource.DataSource = r;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmPurchase frm = new frmPurchase();
            frm.ShowDialog();
            Refreshed();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            var res = (PurchaseDashboardViewModel)gridView1.GetFocusedRow();

            if(res != null)
            {
                int ID = res.PurchaseID;
                frmPurchase frm = new frmPurchase(ID);
                frm.ShowDialog();
            }
            Refreshed();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(XtraMessageBox.Show("Are you sure!\r\n Do you want to Delete.", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                var res = (PurchaseDashboardViewModel)gridView1.GetFocusedRow();
                if(res != null)
                {
                    int ID = res.PurchaseID;

                    var suc = DALobj.DeleteRecord(ID);
                    if(suc == true)
                    {
                        XtraMessageBox.Show("Deleted Successfully.", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        string error = $"Not Delete.\r\n{DALobj.delException.Message.ToString()}";
                        XtraMessageBox.Show(error, "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            Refreshed();
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            var res = (PurchaseDashboardViewModel)gridView1.GetFocusedRow();

            if (res != null)
            {
                int ID = res.PurchaseID;
                frmPurchase frm = new frmPurchase(ID);
                frm.ShowDialog();
            }
            Refreshed();
        }
    }
}