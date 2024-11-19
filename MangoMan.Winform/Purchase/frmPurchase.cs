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
using MangoMan.DAL.Purchase;
using MangoMan.Model.Purchase;
using MangoMan.Model.Opening_Stock;
using DevExpress.XtraGrid.Views.Base;

namespace MangoMan.Winform.Purchase
{
    public partial class frmPurchase : DevExpress.XtraEditors.XtraForm
    {

        int PurchaseID;
        PurchaseDAL DALobj;
        ItemDAL ItemObj;
        OpeningStockDAL osDAL;
        public List<ItemLookUpListViewModel> dsItem;
        List<PurchaseProductDetailsViewModel> dsProductDetail;

        public frmPurchase()
        {
            InitializeComponent();
            DALobj = new PurchaseDAL();
            ItemObj = new ItemDAL();
            osDAL = new OpeningStockDAL();
            PurchaseID = 0;

            dsProductDetail = new List<PurchaseProductDetailsViewModel>();
            purchaseProductDetailsViewModelBindingSource.DataSource = dsProductDetail;
        }
        public frmPurchase(int id)
        {
            InitializeComponent();
            DALobj = new PurchaseDAL();
            ItemObj = new ItemDAL();
            osDAL = new OpeningStockDAL();

            PurchaseID = id;
        }
        protected override void OnLoad(EventArgs e)
        {
            dtePurchaseDate.DateTime = DateTime.Now;
            OnLoadLookUpData();
            OnAssignLookUpData();
            if (PurchaseID != 0)
            { FillRecord(); }
            else { txtPurchaseNo.EditValue = (DALobj.PurchaseNoMax() + 1); }
            base.OnLoad(e);
        }
        public void OnLoadLookUpData()
        {
            dsItem = ItemObj.GetLookUpList();
        }
        public void OnAssignLookUpData()
        {
            repositoryItemlueItem.DisplayMember = "ItemName";
            repositoryItemlueItem.ValueMember = "ItemID";
            repositoryItemlueItem.DataSource = dsItem;
        }
        public void FillRecord()
        {
            PurchaseViewModel EditingRecord = DALobj.GetDataByPrimaryKey(PurchaseID);

            dtePurchaseDate.EditValue = EditingRecord.PurchaseDate;
            txtPurchaseNo.EditValue = EditingRecord.PurchaseNo;
            dsProductDetail = EditingRecord.ProductDetails;
            purchaseProductDetailsViewModelBindingSource.DataSource = dsProductDetail;
        }
        public PurchaseViewModel OnGetViewModelForSave()
        {
            return new PurchaseViewModel
            {
                PurchaseID = PurchaseID,
                PurchaseNo = (int)txtPurchaseNo.EditValue,
                PurchaseDate = (DateTime)dtePurchaseDate.EditValue,
                ProductDetails = dsProductDetail,
            };
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            #region Validation

            this.ValidateChildren(ValidationConstraints.None);

            string Errors = null;
            string ErrorText = null;
            Control ErrorControl = null;

            ErrorText = dxErrorProvider1.GetError(dtePurchaseDate);
            if (!String.IsNullOrWhiteSpace(ErrorText))
            {
                Errors = (!String.IsNullOrWhiteSpace(Errors) ? "\r\n" : "") + ErrorText;
                if (ErrorControl == null) { ErrorControl = dtePurchaseDate; }
            }
            
            if (Errors != null)
            {
                XtraMessageBox.Show($"Please fix the following {Errors}Validation errors.", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                XtraMessageBox.Show("Saved Successfully.", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            else
            {
                string error = $"NOt Saved.{DALobj.Exception.Message.ToString()}";
                XtraMessageBox.Show(error, "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
        }


        #region Validation
        private void dateEdit1_Validating(object sender, CancelEventArgs e)
        {
            if (dtePurchaseDate.EditValue == null)
            {
                dxErrorProvider1.SetError(dtePurchaseDate, "Please select Date.");
            }
            else
            {
                dxErrorProvider1.SetError(dtePurchaseDate, null);
            }
        }
        #endregion

        #region RepositoryItemEvents
        private void lueItems_EditValueChanged(object sender, EventArgs e)
        {
            object value = (sender as LookUpEdit).EditValue;
            if (dsItem != null && value != null)
            {
                decimal b = dsItem.Where(r => r.ItemID == (int)(sender as LookUpEdit).EditValue).FirstOrDefault().PurchaseRate;
                var row = (PurchaseProductDetailsViewModel)gridView1.GetFocusedRow();
                if (row != null)
                {
                    row.Rate = b;
                }
            }
        }

        private void repositoryItemtxtQuantity_EditValueChanged(object sender, EventArgs e)
        {
            var row = (PurchaseProductDetailsViewModel)gridView1.GetFocusedRow();
            if (row != null)
            {
                decimal a = row.Rate * row.Quantity;
                row.Amount = a;
            }
        }

        private void repositoryItemButtonEdit1_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var row = (PurchaseProductDetailsViewModel)gridView1.GetFocusedRow();
            if (row != null && XtraMessageBox.Show($"Are you sure want to delete ?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                gridView1.DeleteSelectedRows();
                XtraMessageBox.Show("Deleted.", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        #endregion
    }
}
