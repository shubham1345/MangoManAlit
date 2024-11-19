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
using MangoMan.DAL.Sale;
using MangoMan.Model.Sale;
using MangoMan.Model.Opening_Stock;
using MangoMan.DAL.OpeningStock;

namespace MangoMan.Winform.Sale
{
    public partial class frmSaleDashboard : DevExpress.XtraEditors.XtraForm
    {
        SaleDAL DALobj;
        OpeningStockDAL dalos;
        public frmSaleDashboard()
        {
            InitializeComponent();
            DALobj = new SaleDAL();
            dalos = new OpeningStockDAL();
            Refreshed();
        }
        protected override void OnLoad(EventArgs e)
        {
            frmSaleDashboard ft = new frmSaleDashboard();
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
            saleDashboardViewModelBindingSource.DataSource = r;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmSale frm = new frmSale();
            frm.ShowDialog();
            Refreshed();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            var r = (SaleDashboardViewModel)gridView1.GetFocusedRow();
            if(r != null)
            {
                int ID = r.SaleID;
                frmSale frm = new frmSale(ID);
                frm.ShowDialog();
            }
            Refreshed();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(XtraMessageBox.Show("Are you sure?\r\nDo you want to delete.", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                var r = (SaleDashboardViewModel)gridView1.GetFocusedRow();
                if (r != null)
                {
                    int id = r.SaleID;

                    var suc = DALobj.DeleteRecord(id);
                    if (suc == true)
                    {
                        XtraMessageBox.Show("Deleted Successfully.", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        string error = "Can not Deleted." + DALobj.delException.Message.ToString() + "";
                        XtraMessageBox.Show(error, "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            Refreshed();
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            var r = (SaleDashboardViewModel)gridView1.GetFocusedRow();
            if (r != null)
            {
                int ID = r.SaleID;
                frmSale frm = new frmSale(ID);
                frm.ShowDialog();
            }
            Refreshed();
        }
    }
}