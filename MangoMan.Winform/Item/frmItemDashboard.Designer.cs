namespace MangoMan.Winform.Item
{
    partial class frmItemDashboard
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
            this.lblTitle = new DevExpress.XtraEditors.LabelControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.itemDashboardViewModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colHSN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colItemName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUnitName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPurchaseRate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSaleRate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnEdit = new DevExpress.XtraEditors.SimpleButton();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemDashboardViewModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.lblTitle);
            this.layoutControl1.Controls.Add(this.gridControl1);
            this.layoutControl1.Controls.Add(this.btnDelete);
            this.layoutControl1.Controls.Add(this.btnEdit);
            this.layoutControl1.Controls.Add(this.btnAdd);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(630, 422);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // lblTitle
            // 
            this.lblTitle.Appearance.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Appearance.Options.UseFont = true;
            this.lblTitle.Appearance.Options.UseTextOptions = true;
            this.lblTitle.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblTitle.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.lblTitle.AppearanceDisabled.FontSizeDelta = 1;
            this.lblTitle.AppearanceDisabled.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.lblTitle.AppearanceDisabled.Options.UseFont = true;
            this.lblTitle.Location = new System.Drawing.Point(324, 12);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(294, 36);
            this.lblTitle.StyleController = this.layoutControl1;
            this.lblTitle.TabIndex = 8;
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.itemDashboardViewModelBindingSource;
            this.gridControl1.Location = new System.Drawing.Point(12, 52);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(606, 358);
            this.gridControl1.TabIndex = 7;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // itemDashboardViewModelBindingSource
            // 
            this.itemDashboardViewModelBindingSource.DataSource = typeof(MangoMan.Model.Item.ItemDashboardViewModel);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colHSN,
            this.colItemName,
            this.colUnitName,
            this.colPurchaseRate,
            this.colSaleRate});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.DoubleClick += new System.EventHandler(this.gridView1_DoubleClick);
            // 
            // colHSN
            // 
            this.colHSN.AppearanceHeader.FontSizeDelta = 1;
            this.colHSN.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.colHSN.AppearanceHeader.Options.UseFont = true;
            this.colHSN.FieldName = "HSN";
            this.colHSN.MaxWidth = 200;
            this.colHSN.MinWidth = 40;
            this.colHSN.Name = "colHSN";
            this.colHSN.Visible = true;
            this.colHSN.VisibleIndex = 0;
            this.colHSN.Width = 40;
            // 
            // colItemName
            // 
            this.colItemName.AppearanceHeader.FontSizeDelta = 1;
            this.colItemName.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.colItemName.AppearanceHeader.Options.UseFont = true;
            this.colItemName.FieldName = "ItemName";
            this.colItemName.MaxWidth = 420;
            this.colItemName.MinWidth = 80;
            this.colItemName.Name = "colItemName";
            this.colItemName.Visible = true;
            this.colItemName.VisibleIndex = 1;
            this.colItemName.Width = 80;
            // 
            // colUnitName
            // 
            this.colUnitName.AppearanceHeader.FontSizeDelta = 1;
            this.colUnitName.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.colUnitName.AppearanceHeader.Options.UseFont = true;
            this.colUnitName.FieldName = "UnitName";
            this.colUnitName.MaxWidth = 85;
            this.colUnitName.MinWidth = 70;
            this.colUnitName.Name = "colUnitName";
            this.colUnitName.Visible = true;
            this.colUnitName.VisibleIndex = 2;
            this.colUnitName.Width = 70;
            // 
            // colPurchaseRate
            // 
            this.colPurchaseRate.AppearanceHeader.FontSizeDelta = 1;
            this.colPurchaseRate.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.colPurchaseRate.AppearanceHeader.Options.UseFont = true;
            this.colPurchaseRate.FieldName = "PurchaseRate";
            this.colPurchaseRate.MaxWidth = 130;
            this.colPurchaseRate.MinWidth = 100;
            this.colPurchaseRate.Name = "colPurchaseRate";
            this.colPurchaseRate.Visible = true;
            this.colPurchaseRate.VisibleIndex = 3;
            this.colPurchaseRate.Width = 100;
            // 
            // colSaleRate
            // 
            this.colSaleRate.AppearanceHeader.FontSizeDelta = 1;
            this.colSaleRate.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.colSaleRate.AppearanceHeader.Options.UseFont = true;
            this.colSaleRate.FieldName = "SaleRate";
            this.colSaleRate.MaxWidth = 130;
            this.colSaleRate.MinWidth = 90;
            this.colSaleRate.Name = "colSaleRate";
            this.colSaleRate.Visible = true;
            this.colSaleRate.VisibleIndex = 4;
            this.colSaleRate.Width = 90;
            // 
            // btnDelete
            // 
            this.btnDelete.Appearance.FontSizeDelta = 1;
            this.btnDelete.Appearance.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.btnDelete.Appearance.Options.UseFont = true;
            this.btnDelete.ImageOptions.Image = global::MangoMan.Winform.Properties.Resources.icons8_delete_bin_32__1_;
            this.btnDelete.Location = new System.Drawing.Point(220, 12);
            this.btnDelete.MaximumSize = new System.Drawing.Size(100, 35);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 35);
            this.btnDelete.StyleController = this.layoutControl1;
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Delete";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Appearance.FontSizeDelta = 1;
            this.btnEdit.Appearance.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.btnEdit.Appearance.Options.UseFont = true;
            this.btnEdit.ImageOptions.Image = global::MangoMan.Winform.Properties.Resources.icons8_edit_property_32;
            this.btnEdit.Location = new System.Drawing.Point(116, 12);
            this.btnEdit.MaximumSize = new System.Drawing.Size(100, 35);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(100, 35);
            this.btnEdit.StyleController = this.layoutControl1;
            this.btnEdit.TabIndex = 5;
            this.btnEdit.Text = "Edit";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Appearance.FontSizeDelta = 1;
            this.btnAdd.Appearance.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.btnAdd.Appearance.Options.UseFont = true;
            this.btnAdd.ImageOptions.Image = global::MangoMan.Winform.Properties.Resources.icons8_add_32;
            this.btnAdd.Location = new System.Drawing.Point(12, 12);
            this.btnAdd.MaximumSize = new System.Drawing.Size(100, 35);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 35);
            this.btnAdd.StyleController = this.layoutControl1;
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem5});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(630, 422);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.btnAdd;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(104, 40);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.btnEdit;
            this.layoutControlItem2.Location = new System.Drawing.Point(104, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(104, 40);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.btnDelete;
            this.layoutControlItem3.Location = new System.Drawing.Point(208, 0);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(104, 40);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.gridControl1;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 40);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(610, 362);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.lblTitle;
            this.layoutControlItem5.Location = new System.Drawing.Point(312, 0);
            this.layoutControlItem5.MinSize = new System.Drawing.Size(4, 17);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(298, 40);
            this.layoutControlItem5.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // frmItemDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 422);
            this.Controls.Add(this.layoutControl1);
            this.Name = "frmItemDashboard";
            this.Text = "Item Dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemDashboardViewModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraEditors.SimpleButton btnEdit;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private System.Windows.Forms.BindingSource itemDashboardViewModelBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colHSN;
        private DevExpress.XtraGrid.Columns.GridColumn colItemName;
        private DevExpress.XtraGrid.Columns.GridColumn colUnitName;
        private DevExpress.XtraGrid.Columns.GridColumn colPurchaseRate;
        private DevExpress.XtraGrid.Columns.GridColumn colSaleRate;
        private DevExpress.XtraEditors.LabelControl lblTitle;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
    }
}