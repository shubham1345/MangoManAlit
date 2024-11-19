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
using MangoMan.DAL.Item;
using MangoMan.Model.Item;
using MangoMan.DAL.OpeningStock;
using MangoMan.DAL.Sale;
using MangoMan.DAL.Purchase;

namespace MangoMan.Winform.Item
{
    public partial class frmItemDashboard : DevExpress.XtraEditors.XtraForm
    {
        ItemDAL DALObj;
        OpeningStockDAL DALobjOp;
        PurchaseDAL DALp;
        SaleDAL DALs;

        public frmItemDashboard()
        {
            InitializeComponent();
            DALObj = new ItemDAL();
            Refreshed();
        }

        protected override void OnLoad(EventArgs e)
        {
            frmItemDashboard ft = new frmItemDashboard();
            lblTitle.Text = ft.Text;
            base.OnLoad(e);
        }
        public void Refreshed()
        {
            var r = DALObj.GetDashBoardData();
            if (r.Count == 0)
            {
                btnEdit.Enabled = false;
                btnDelete.Enabled = false;
            }
            else
            {
                btnEdit.Enabled = true;
                btnDelete.Enabled = true;
            }
            itemDashboardViewModelBindingSource.DataSource = r;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmItemCRUD frm = new frmItemCRUD();
            frm.ShowDialog();
            Refreshed();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            var res = (ItemDashboardViewModel)gridView1.GetFocusedRow();

            if (res != null)
            {
                int ID = res.ItemID;
                frmItemCRUD obj = new frmItemCRUD(ID);
                obj.ShowDialog();
            }
            Refreshed();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DALobjOp = new OpeningStockDAL();
            DALp = new PurchaseDAL();
            DALs = new SaleDAL();
            if (XtraMessageBox.Show("Are you sure. You want to delete.", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                var res = (ItemDashboardViewModel)gridView1.GetFocusedRow();
                if (res != null)
                {
                    int id = res.ItemID;
                    int suc = DALObj.DeletRecord(id);
                    if (suc == 0)
                    {
                        XtraMessageBox.Show("Deleted successfully.", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if(suc == 1)
                    {
                        XtraMessageBox.Show("First Delete from Purchase Dashboard and Sale Dashboard.", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if(suc == 2)
                    {
                        XtraMessageBox.Show("First Delete from Purchse Dashboard", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if(suc == 3)
                    {
                        XtraMessageBox.Show("First Delete from Sale Dashboard.", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if(DALObj.delException != null)
                    {
                        string error = "Can not Deleted." + DALObj.delException.Message.ToString() + "";
                        XtraMessageBox.Show(error, "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            Refreshed();
        }
        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            var res = (ItemDashboardViewModel)gridView1.GetFocusedRow();

            if (res != null)
            {
                int ID = res.ItemID;
                frmItemCRUD obj = new frmItemCRUD(ID);
                obj.ShowDialog();
            }
            Refreshed();
        }
    }
}