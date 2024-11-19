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
using MangoMan.Winform.Navigation;
using MangoMan.DAL.OpeningStock;
using MangoMan.Model.Opening_Stock;

namespace MangoMan.Winform.Item
{
    public partial class frmItemCRUD : DevExpress.XtraEditors.XtraForm
    {
        OpeningStockDAL DALos;
        ItemDAL DALObj;
        int ItemID;
        int OpeningStockID;
        public frmItemCRUD()
        {
            InitializeComponent();
            DALObj = new ItemDAL();
            DALos = new OpeningStockDAL();
            ItemID = 0;
            OpeningStockID = 0;
        }
        public frmItemCRUD(int id) : base()
        {
            InitializeComponent();
            DALObj = new ItemDAL();
            DALos = new OpeningStockDAL();
            ItemID = id;
            
            OpeningStockID = DALos.FindOSIDbyItemID(id);
        }
        protected override void OnLoad(EventArgs e)
        {
            if (ItemID != 0)
            {
                FillRecord();
            }
            base.OnLoad(e);
        }
        public ItemViewModel OnGetViewModelForSaving()
        {
            return new ItemViewModel
            {
                ItemID = ItemID,
                OpeningStockID =OpeningStockID,
                HSN = txtHSN.Text,
                ItemName = txtItemName.Text,
                UnitName = txtUnitName.Text,
                Description = meDescription.Text,
                Quantity = (decimal)txtQuantity.EditValue,
                PurchaseRate = (decimal)txtPurchaseRate.EditValue,
                SaleRate = (decimal)txtSaleRate.EditValue
            };
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            
            #region Validation
            this.ValidateChildren(ValidationConstraints.None);

            string Errors = null;
            string ErrorText = null;
            Control ErrorControl = null;

            ErrorText = dxErrorProvider1.GetError(txtHSN);
            if (!String.IsNullOrWhiteSpace(ErrorText))
            {
                Errors += (!String.IsNullOrWhiteSpace(Errors) ? "\r\n" : "") + ErrorText;
                if (ErrorControl == null) { ErrorControl = txtHSN; }
            }

            ErrorText = dxErrorProvider1.GetError(txtItemName);
            if (!String.IsNullOrWhiteSpace(ErrorText))
            {
                Errors += (!String.IsNullOrWhiteSpace(Errors) ? "\r\n" : "") + ErrorText;
                if (ErrorControl == null) { ErrorControl = txtItemName; }
            }

            ErrorText = dxErrorProvider1.GetError(txtUnitName);
            if (!String.IsNullOrWhiteSpace(ErrorText))
            {
                Errors += (!String.IsNullOrWhiteSpace(Errors) ? "\r\n" : "") + ErrorText;
                if (ErrorControl == null) { ErrorControl = txtUnitName; }
            }

            ErrorText = dxErrorProvider1.GetError(txtQuantity);
            if (!String.IsNullOrWhiteSpace(ErrorText))
            {
                Errors += (!String.IsNullOrWhiteSpace(Errors) ? "\r\n" : "") + ErrorText;
                if (ErrorControl == null) { ErrorControl = txtQuantity; }
            }

            ErrorText = dxErrorProvider1.GetError(txtPurchaseRate);
            if (!String.IsNullOrWhiteSpace(ErrorText))
            {
                Errors += (!String.IsNullOrWhiteSpace(Errors) ? "\r\n" : "") + ErrorText;
                if (ErrorControl == null) { ErrorControl = txtPurchaseRate; }
            }

            ErrorText = dxErrorProvider1.GetError(txtSaleRate);
            if (!String.IsNullOrWhiteSpace(ErrorText))
            {
                Errors += (!String.IsNullOrWhiteSpace(Errors) ? "\r\n" : "") + ErrorText;
                if (ErrorControl == null) { ErrorControl = txtSaleRate; }
            }

            if (Errors != null)
            {
                XtraMessageBox.Show($"Please fix following validation errors before saving.\r\n{Errors}", "Saving", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                if (ErrorControl != null)
                {
                    ErrorControl.Focus();
                }
                return;
            }
            #endregion
            var res = DALObj.SaveRecord(OnGetViewModelForSaving());
            if (DALObj.Exception == null && res == true )
            {
                XtraMessageBox.Show("Saved successfully.","Save",MessageBoxButtons.OK,MessageBoxIcon.Information);
                Close();
            }
            else
            {
                string error = "can not saved.\r\n" + DALObj.Exception.Message.ToString() + "";
                XtraMessageBox.Show(error, "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
        public void FillRecord()
        {
            int a = DALos.FindOSIDbyItemID(ItemID);
            ItemViewModel EditingRecord = DALObj.GetViewModelByPrimeKey(ItemID);
            if (a > 0)
            {
                OpeningStockViewModel ed = DALos.GetViewModelByPrimaryKey(a);
                txtQuantity.EditValue = ed.Quantity;
            }
            
            txtHSN.Text = EditingRecord.HSN;
            txtItemName.Text = EditingRecord.ItemName;
            txtUnitName.Text = EditingRecord.UnitName;
            meDescription.Text = EditingRecord.Description;     
            txtPurchaseRate.EditValue = EditingRecord.PurchaseRate;
            txtSaleRate.EditValue = EditingRecord.SaleRate;
        }
                
        #region Validation
        private void txtItemName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtItemName.Text))
            {
                dxErrorProvider1.SetError(txtItemName, "Please enter item name.");
            }
            else if (DALObj.CheckDuplicate(txtItemName.Text, ItemID))
            {
                dxErrorProvider1.SetError(txtItemName, "Can not accept duplicate Item Name.");
            }
            else
            {
                dxErrorProvider1.SetError(txtItemName, null);
            }
        }
        private void txtUnitName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUnitName.Text))
            {
                dxErrorProvider1.SetError(txtUnitName, "Please enter Unit Name.");
            }
            else
            {
                dxErrorProvider1.SetError(txtUnitName, null);
            }
        }
        private void txtQuantity_Validating(object sender, CancelEventArgs e)
        {
            decimal v;
            if (!decimal.TryParse(txtQuantity.Text, out v))
            {
                dxErrorProvider1.SetError(txtQuantity, "Please enter valid numeric value in Quantity.");
            }
            else
            {
                dxErrorProvider1.SetError(txtQuantity, null);
            }
        }
        private void txtPurchaseRate_Validating(object sender, CancelEventArgs e)
        {
            decimal v;
            if (!decimal.TryParse(txtPurchaseRate.Text, out v))
            {
                dxErrorProvider1.SetError(txtPurchaseRate, "Please enter valid numeric value in purchase rate.");
            }
            else if ( v < 1 )
            {
                dxErrorProvider1.SetError(txtPurchaseRate, "Purchase Rate should be greater than zero.");
            }
            else
            {
                dxErrorProvider1.SetError(txtPurchaseRate, null);
            }
        }
        private void txtSaleRate_Validating(object sender, CancelEventArgs e)
        {
            decimal v;
            if (!decimal.TryParse(txtSaleRate.Text, out v))
            {
                dxErrorProvider1.SetError(txtSaleRate, "Please enter valid numeric value in Sale Rate.");
            }
            else if (v < 1)
            {
                dxErrorProvider1.SetError(txtSaleRate, "Sale rate should be greater than zero.");
            }
            else
            {
                dxErrorProvider1.SetError(txtSaleRate, null);
            }
        }
        private void txtHSN_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtHSN.Text))
            {
                dxErrorProvider1.SetError(txtHSN, "Please enter HSN.");
            }
            else if (DALObj.CheckHSNDuplicate(txtHSN.Text ,ItemID))
            {
                dxErrorProvider1.SetError(txtHSN, "Can not accept Duplicate HSN.");
            }
            else
            {
                dxErrorProvider1.SetError(txtHSN, null);
            }
        }
        #endregion
    }
}