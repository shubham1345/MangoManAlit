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
using MangoMan.DAL.Item;
using MangoMan.Model.Item;
using MangoMan.DAL.OpeningStock;
using MangoMan.Model.Opening_Stock;

namespace MangoMan.Winform.Sale
{
    public partial class frmSale : DevExpress.XtraEditors.XtraForm
    {
        SaleDAL DALobj;
        ItemDAL dalobj;
        OpeningStockDAL dalos;
        public List<ItemLookUpListViewModel> dsItem;
        public List<SaleProductDetailsViewModel> dsProductDetail;
        int SaleID;
        public frmSale()
        {
            InitializeComponent();
            DALobj = new SaleDAL();
            dalobj = new ItemDAL();
            dalos = new OpeningStockDAL();
            SaleID = 0;
            dsProductDetail = new List<SaleProductDetailsViewModel>();
            saleProductDetailsViewModelBindingSource.DataSource = dsProductDetail;

        }
        public frmSale(int ID) : base()
        {
            InitializeComponent();
            DALobj = new SaleDAL();
            dalobj = new ItemDAL();
            dalos = new OpeningStockDAL();
            SaleID = ID;

        }
        protected override void OnLoad(EventArgs e)
        {
            dteSaleDate.DateTime = DateTime.Now;
            OnLoadLookUpData();
            OnAssignLookUpData();
            if (SaleID != 0) { FillingRecord(); }
            else { txtSaleNo.EditValue = (DALobj.SaleNoMax() + 1); }
            base.OnLoad(e);
        }
        public void FillingRecord()
        {
            SaleViewModel EditingRecord = DALobj.GetViewModelByPrimaryKey(SaleID);

            txtSaleNo.EditValue = EditingRecord.SaleNo;
            dteSaleDate.EditValue = EditingRecord.SaleDate;
            dsProductDetail = EditingRecord.ProductDetails;
            saleProductDetailsViewModelBindingSource.DataSource = dsProductDetail;
        }
        public void OnLoadLookUpData()
        {
            dsItem = dalobj.GetLookUpList();
        }
        public void OnAssignLookUpData()
        {
            repositoryItemlueItem.DisplayMember = "ItemName";
            repositoryItemlueItem.ValueMember = "ItemID";
            repositoryItemlueItem.DataSource = dsItem;
        }
        public SaleViewModel OnGetViewModelForSave()
        {
            return new SaleViewModel
            {
                SaleID = SaleID,
                SaleNo = (int)txtSaleNo.EditValue,
                SaleDate = (DateTime)dteSaleDate.EditValue,
                ProductDetails = dsProductDetail,

            };
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            #region Validation
            this.ValidateChildren(ValidationConstraints.None);

            string Errors = null;
            string ErrorText = null;
            Control ErrorControl = null;

            ErrorText = dxErrorProvider1.GetError(dteSaleDate);
            if (!String.IsNullOrWhiteSpace(ErrorText))
            {
                Errors += (!String.IsNullOrWhiteSpace(Errors) ? "\r\n" : "") + ErrorText;
                if (ErrorControl == null) { ErrorControl = dteSaleDate; }
            }
            if (Errors != null)
            {
                XtraMessageBox.Show($"Please fix the following validation errors{Errors}\r\n.", "saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (ErrorControl != null)
                {
                    ErrorControl.Focus();
                }
                return;
            }
            #endregion
            
            var res = DALobj.SaveRecord(OnGetViewModelForSave());
            if (DALobj.Exception == null && res == true)
            {              
                XtraMessageBox.Show("Saved successfully.", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            else
            {
                string er = "ex" + DALobj.Exception.Message.ToString() + "";
                XtraMessageBox.Show(er, "ex", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
        }
        
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
        #region validating
        private void dateEdit1_Validating(object sender, CancelEventArgs e)
        {
            if (dteSaleDate.EditValue == null)
            {
                dxErrorProvider1.SetError(dteSaleDate, "Please select Date.");
            }
            else
            {
                dxErrorProvider1.SetError(dteSaleDate, null);
            }
        }

        #endregion

        private void lueItem_EditValueChanged(object sender, EventArgs e)
        {
            object value = (sender as LookUpEdit).EditValue;
            if (dsItem != null && value != null)
            {
                decimal b = dsItem.Where(r => r.ItemID == (int)(sender as LookUpEdit).EditValue).FirstOrDefault().SaleRate;
                var row = (SaleProductDetailsViewModel)gridView1.GetFocusedRow();
                if (row != null)
                {
                    row.Rate = b;
                }
            }
        }

        private void repositoryItemButtonEdit1_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var row = (SaleProductDetailsViewModel)gridView1.GetFocusedRow();
            if (row != null && XtraMessageBox.Show($"Are you sure want to delete ?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                gridView1.DeleteSelectedRows();
                XtraMessageBox.Show("Deleted.", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void repositoryItemtxtQuantity_EditValueChanged(object sender, EventArgs e)
        {
            var row = (SaleProductDetailsViewModel)gridView1.GetFocusedRow();
            if (row != null)
            {
                decimal a = row.Rate * row.Quantity;
                row.Amount = a;
            }
        }
    }
}