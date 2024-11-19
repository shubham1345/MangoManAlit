using System;

namespace MangoMan.Winform.Item
{
    partial class frmItemCRUD
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.txtQuantity = new DevExpress.XtraEditors.TextEdit();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.txtSaleRate = new DevExpress.XtraEditors.TextEdit();
            this.txtPurchaseRate = new DevExpress.XtraEditors.TextEdit();
            this.txtUnitName = new DevExpress.XtraEditors.TextEdit();
            this.txtItemName = new DevExpress.XtraEditors.TextEdit();
            this.txtHSN = new DevExpress.XtraEditors.TextEdit();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.meDescription = new DevExpress.XtraEditors.MemoEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.LayoutControlHSN = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItemName = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlUnitName = new DevExpress.XtraLayout.LayoutControlItem();
            this.LayoutControlSaleRate = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.btnCance = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlDescription = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlPurchase = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem3 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.dxErrorProvider1 = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuantity.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSaleRate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPurchaseRate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUnitName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtItemName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHSN.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.meDescription.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LayoutControlHSN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlUnitName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LayoutControlSaleRate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlDescription)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlPurchase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.txtQuantity);
            this.layoutControl1.Controls.Add(this.btnSave);
            this.layoutControl1.Controls.Add(this.txtSaleRate);
            this.layoutControl1.Controls.Add(this.txtPurchaseRate);
            this.layoutControl1.Controls.Add(this.txtUnitName);
            this.layoutControl1.Controls.Add(this.txtItemName);
            this.layoutControl1.Controls.Add(this.txtHSN);
            this.layoutControl1.Controls.Add(this.btnCancel);
            this.layoutControl1.Controls.Add(this.meDescription);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(716, 246, 650, 400);
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(520, 372);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // txtQuantity
            // 
            this.txtQuantity.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            131072});
            this.txtQuantity.EnterMoveNextControl = true;
            this.txtQuantity.Location = new System.Drawing.Point(85, 238);
            this.txtQuantity.MaximumSize = new System.Drawing.Size(110, 20);
            this.txtQuantity.MinimumSize = new System.Drawing.Size(100, 20);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Properties.Appearance.Options.UseTextOptions = true;
            this.txtQuantity.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtQuantity.Properties.Mask.EditMask = "n2";
            this.txtQuantity.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtQuantity.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtQuantity.Properties.MaxLength = 12;
            this.txtQuantity.Size = new System.Drawing.Size(110, 20);
            this.txtQuantity.StyleController = this.layoutControl1;
            this.txtQuantity.TabIndex = 8;
            this.txtQuantity.Validating += new System.ComponentModel.CancelEventHandler(this.txtQuantity_Validating);
            // 
            // btnSave
            // 
            this.btnSave.Appearance.FontSizeDelta = 1;
            this.btnSave.Appearance.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.btnSave.Appearance.Options.UseFont = true;
            this.btnSave.ImageOptions.Image = global::MangoMan.Winform.Properties.Resources.icons8_save_32;
            this.btnSave.Location = new System.Drawing.Point(12, 324);
            this.btnSave.MaximumSize = new System.Drawing.Size(100, 36);
            this.btnSave.MinimumSize = new System.Drawing.Size(80, 20);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 36);
            this.btnSave.StyleController = this.layoutControl1;
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtSaleRate
            // 
            this.txtSaleRate.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            131072});
            this.txtSaleRate.EnterMoveNextControl = true;
            this.dxErrorProvider1.SetIconAlignment(this.txtSaleRate, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
            this.txtSaleRate.Location = new System.Drawing.Point(85, 286);
            this.txtSaleRate.MaximumSize = new System.Drawing.Size(110, 20);
            this.txtSaleRate.MinimumSize = new System.Drawing.Size(100, 20);
            this.txtSaleRate.Name = "txtSaleRate";
            this.txtSaleRate.Properties.Appearance.Options.UseTextOptions = true;
            this.txtSaleRate.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtSaleRate.Properties.Mask.EditMask = "n2";
            this.txtSaleRate.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtSaleRate.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtSaleRate.Properties.MaxLength = 12;
            this.txtSaleRate.Size = new System.Drawing.Size(110, 20);
            this.txtSaleRate.StyleController = this.layoutControl1;
            this.txtSaleRate.TabIndex = 5;
            this.txtSaleRate.Validating += new System.ComponentModel.CancelEventHandler(this.txtSaleRate_Validating);
            // 
            // txtPurchaseRate
            // 
            this.txtPurchaseRate.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            131072});
            this.txtPurchaseRate.EnterMoveNextControl = true;
            this.dxErrorProvider1.SetIconAlignment(this.txtPurchaseRate, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
            this.txtPurchaseRate.Location = new System.Drawing.Point(85, 262);
            this.txtPurchaseRate.MaximumSize = new System.Drawing.Size(110, 20);
            this.txtPurchaseRate.MinimumSize = new System.Drawing.Size(100, 20);
            this.txtPurchaseRate.Name = "txtPurchaseRate";
            this.txtPurchaseRate.Properties.Appearance.Options.UseTextOptions = true;
            this.txtPurchaseRate.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtPurchaseRate.Properties.Mask.EditMask = "n2";
            this.txtPurchaseRate.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtPurchaseRate.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtPurchaseRate.Properties.MaxLength = 12;
            this.txtPurchaseRate.Size = new System.Drawing.Size(110, 20);
            this.txtPurchaseRate.StyleController = this.layoutControl1;
            this.txtPurchaseRate.TabIndex = 4;
            this.txtPurchaseRate.Validating += new System.ComponentModel.CancelEventHandler(this.txtPurchaseRate_Validating);
            // 
            // txtUnitName
            // 
            this.txtUnitName.EnterMoveNextControl = true;
            this.dxErrorProvider1.SetIconAlignment(this.txtUnitName, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
            this.txtUnitName.Location = new System.Drawing.Point(85, 60);
            this.txtUnitName.MaximumSize = new System.Drawing.Size(100, 20);
            this.txtUnitName.MinimumSize = new System.Drawing.Size(100, 20);
            this.txtUnitName.Name = "txtUnitName";
            this.txtUnitName.Properties.MaxLength = 10;
            this.txtUnitName.Size = new System.Drawing.Size(100, 20);
            this.txtUnitName.StyleController = this.layoutControl1;
            this.txtUnitName.TabIndex = 2;
            this.txtUnitName.Validating += new System.ComponentModel.CancelEventHandler(this.txtUnitName_Validating);
            // 
            // txtItemName
            // 
            this.txtItemName.EditValue = "";
            this.txtItemName.EnterMoveNextControl = true;
            this.dxErrorProvider1.SetIconAlignment(this.txtItemName, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
            this.txtItemName.Location = new System.Drawing.Point(85, 36);
            this.txtItemName.MaximumSize = new System.Drawing.Size(420, 20);
            this.txtItemName.MinimumSize = new System.Drawing.Size(100, 20);
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.Properties.MaxLength = 50;
            this.txtItemName.Size = new System.Drawing.Size(420, 20);
            this.txtItemName.StyleController = this.layoutControl1;
            this.txtItemName.TabIndex = 1;
            this.txtItemName.Validating += new System.ComponentModel.CancelEventHandler(this.txtItemName_Validating);
            // 
            // txtHSN
            // 
            this.txtHSN.EnterMoveNextControl = true;
            this.dxErrorProvider1.SetIconAlignment(this.txtHSN, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
            this.txtHSN.Location = new System.Drawing.Point(85, 12);
            this.txtHSN.MaximumSize = new System.Drawing.Size(170, 20);
            this.txtHSN.MinimumSize = new System.Drawing.Size(100, 20);
            this.txtHSN.Name = "txtHSN";
            this.txtHSN.Properties.MaxLength = 20;
            this.txtHSN.Size = new System.Drawing.Size(170, 20);
            this.txtHSN.StyleController = this.layoutControl1;
            this.txtHSN.TabIndex = 0;
            this.txtHSN.Validating += new System.ComponentModel.CancelEventHandler(this.txtHSN_Validating);
            // 
            // btnCancel
            // 
            this.btnCancel.Appearance.FontSizeDelta = 1;
            this.btnCancel.Appearance.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.btnCancel.Appearance.Options.UseFont = true;
            this.btnCancel.ImageOptions.Image = global::MangoMan.Winform.Properties.Resources.icons8_cancel_32__1_;
            this.btnCancel.Location = new System.Drawing.Point(408, 324);
            this.btnCancel.MaximumSize = new System.Drawing.Size(100, 36);
            this.btnCancel.MinimumSize = new System.Drawing.Size(80, 20);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 36);
            this.btnCancel.StyleController = this.layoutControl1;
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // meDescription
            // 
            this.meDescription.EnterMoveNextControl = true;
            this.meDescription.Location = new System.Drawing.Point(85, 84);
            this.meDescription.MaximumSize = new System.Drawing.Size(420, 150);
            this.meDescription.MinimumSize = new System.Drawing.Size(100, 80);
            this.meDescription.Name = "meDescription";
            this.meDescription.Properties.MaxLength = 500;
            this.meDescription.Size = new System.Drawing.Size(420, 150);
            this.meDescription.StyleController = this.layoutControl1;
            this.meDescription.TabIndex = 3;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.LayoutControlHSN,
            this.layoutControlItemName,
            this.layoutControlUnitName,
            this.LayoutControlSaleRate,
            this.layoutControlItem1,
            this.btnCance,
            this.layoutControlDescription,
            this.layoutControlPurchase,
            this.layoutControlItem2,
            this.emptySpaceItem3,
            this.emptySpaceItem2});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(520, 372);
            this.Root.TextVisible = false;
            // 
            // LayoutControlHSN
            // 
            this.LayoutControlHSN.Control = this.txtHSN;
            this.LayoutControlHSN.Location = new System.Drawing.Point(0, 0);
            this.LayoutControlHSN.Name = "LayoutControlHSN";
            this.LayoutControlHSN.Size = new System.Drawing.Size(500, 24);
            this.LayoutControlHSN.Text = "HSN";
            this.LayoutControlHSN.TextSize = new System.Drawing.Size(70, 13);
            // 
            // layoutControlItemName
            // 
            this.layoutControlItemName.Control = this.txtItemName;
            this.layoutControlItemName.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItemName.Name = "layoutControlItemName";
            this.layoutControlItemName.Size = new System.Drawing.Size(500, 24);
            this.layoutControlItemName.Text = "Item Name";
            this.layoutControlItemName.TextSize = new System.Drawing.Size(70, 13);
            // 
            // layoutControlUnitName
            // 
            this.layoutControlUnitName.Control = this.txtUnitName;
            this.layoutControlUnitName.Location = new System.Drawing.Point(0, 48);
            this.layoutControlUnitName.Name = "layoutControlUnitName";
            this.layoutControlUnitName.Size = new System.Drawing.Size(500, 24);
            this.layoutControlUnitName.Text = "Unit Name";
            this.layoutControlUnitName.TextSize = new System.Drawing.Size(70, 13);
            // 
            // LayoutControlSaleRate
            // 
            this.LayoutControlSaleRate.Control = this.txtSaleRate;
            this.LayoutControlSaleRate.Location = new System.Drawing.Point(0, 274);
            this.LayoutControlSaleRate.Name = "LayoutControlSaleRate";
            this.LayoutControlSaleRate.Size = new System.Drawing.Size(500, 24);
            this.LayoutControlSaleRate.Text = "Sale Rate";
            this.LayoutControlSaleRate.TextSize = new System.Drawing.Size(70, 13);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.btnSave;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 312);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(104, 40);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // btnCance
            // 
            this.btnCance.Control = this.btnCancel;
            this.btnCance.Location = new System.Drawing.Point(396, 312);
            this.btnCance.Name = "btnCance";
            this.btnCance.Size = new System.Drawing.Size(104, 40);
            this.btnCance.TextSize = new System.Drawing.Size(0, 0);
            this.btnCance.TextVisible = false;
            // 
            // layoutControlDescription
            // 
            this.layoutControlDescription.Control = this.meDescription;
            this.layoutControlDescription.Location = new System.Drawing.Point(0, 72);
            this.layoutControlDescription.Name = "layoutControlDescription";
            this.layoutControlDescription.Size = new System.Drawing.Size(500, 154);
            this.layoutControlDescription.Text = "Description";
            this.layoutControlDescription.TextSize = new System.Drawing.Size(70, 13);
            // 
            // layoutControlPurchase
            // 
            this.layoutControlPurchase.Control = this.txtPurchaseRate;
            this.layoutControlPurchase.Location = new System.Drawing.Point(0, 250);
            this.layoutControlPurchase.Name = "layoutControlPurchase";
            this.layoutControlPurchase.Size = new System.Drawing.Size(500, 24);
            this.layoutControlPurchase.Text = "Purchase Rate";
            this.layoutControlPurchase.TextSize = new System.Drawing.Size(70, 13);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.txtQuantity;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 226);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(500, 24);
            this.layoutControlItem2.Text = "Quantity";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(70, 13);
            // 
            // emptySpaceItem3
            // 
            this.emptySpaceItem3.AllowHotTrack = false;
            this.emptySpaceItem3.Location = new System.Drawing.Point(104, 312);
            this.emptySpaceItem3.Name = "emptySpaceItem3";
            this.emptySpaceItem3.Size = new System.Drawing.Size(292, 40);
            this.emptySpaceItem3.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(0, 298);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(500, 14);
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // dxErrorProvider1
            // 
            this.dxErrorProvider1.ContainerControl = this;
            // 
            // frmItemCRUD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 372);
            this.Controls.Add(this.layoutControl1);
            this.Name = "frmItemCRUD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Item Master";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtQuantity.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSaleRate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPurchaseRate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUnitName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtItemName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHSN.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.meDescription.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LayoutControlHSN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlUnitName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LayoutControlSaleRate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlDescription)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlPurchase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraEditors.TextEdit txtSaleRate;
        private DevExpress.XtraEditors.TextEdit txtPurchaseRate;
        private DevExpress.XtraEditors.TextEdit txtUnitName;
        private DevExpress.XtraEditors.TextEdit txtItemName;
        private DevExpress.XtraLayout.LayoutControlItem LayoutControlHSN;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItemName;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlUnitName;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlPurchase;
        private DevExpress.XtraLayout.LayoutControlItem LayoutControlSaleRate;
        private DevExpress.XtraEditors.TextEdit txtHSN;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraEditors.MemoEdit meDescription;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlDescription;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraLayout.LayoutControlItem btnCance;
        private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider dxErrorProvider1;
        private DevExpress.XtraEditors.TextEdit txtQuantity;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem3;
    }
}