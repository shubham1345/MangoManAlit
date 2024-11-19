namespace MangoMan.Winform.Sale
{
    partial class frmSale
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
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.saleProductDetailsViewModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colItemID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemlueItem = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemtxtDescription = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.colQuantity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemtxtQuantity = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.colRate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemtxtRate = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.colAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemtxtAmount = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItembtnDelete = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.txtSaleNo = new DevExpress.XtraEditors.TextEdit();
            this.dteSaleDate = new DevExpress.XtraEditors.DateEdit();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem3 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.dxErrorProvider1 = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.saleProductDetailsViewModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemlueItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemtxtDescription)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemtxtQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemtxtRate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemtxtAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItembtnDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSaleNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteSaleDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteSaleDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.gridControl1);
            this.layoutControl1.Controls.Add(this.txtSaleNo);
            this.layoutControl1.Controls.Add(this.dteSaleDate);
            this.layoutControl1.Controls.Add(this.btnCancel);
            this.layoutControl1.Controls.Add(this.btnSave);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(911, 437);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.saleProductDetailsViewModelBindingSource;
            this.gridControl1.Location = new System.Drawing.Point(12, 36);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItembtnDelete,
            this.repositoryItemlueItem,
            this.repositoryItemtxtQuantity,
            this.repositoryItemtxtDescription,
            this.repositoryItemtxtRate,
            this.repositoryItemtxtAmount});
            this.gridControl1.Size = new System.Drawing.Size(887, 349);
            this.gridControl1.TabIndex = 15;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // saleProductDetailsViewModelBindingSource
            // 
            this.saleProductDetailsViewModelBindingSource.DataSource = typeof(MangoMan.Model.Sale.SaleProductDetailsViewModel);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colItemID,
            this.colDescription,
            this.colQuantity,
            this.colRate,
            this.colAmount,
            this.gridColumn1});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
            this.gridView1.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.True;
            this.gridView1.OptionsNavigation.EnterMoveNextColumn = true;
            this.gridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.gridView1.OptionsView.ShowFooter = true;
            // 
            // colItemID
            // 
            this.colItemID.AppearanceHeader.FontSizeDelta = 1;
            this.colItemID.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.colItemID.AppearanceHeader.Options.UseFont = true;
            this.colItemID.ColumnEdit = this.repositoryItemlueItem;
            this.colItemID.FieldName = "ItemID";
            this.colItemID.MaxWidth = 420;
            this.colItemID.MinWidth = 100;
            this.colItemID.Name = "colItemID";
            this.colItemID.Visible = true;
            this.colItemID.VisibleIndex = 0;
            this.colItemID.Width = 100;
            // 
            // repositoryItemlueItem
            // 
            this.repositoryItemlueItem.AutoHeight = false;
            this.repositoryItemlueItem.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemlueItem.Name = "repositoryItemlueItem";
            this.repositoryItemlueItem.NullText = "Select Item";
            this.repositoryItemlueItem.PopupWidth = 400;
            this.repositoryItemlueItem.EditValueChanged += new System.EventHandler(this.lueItem_EditValueChanged);
            // 
            // colDescription
            // 
            this.colDescription.AppearanceHeader.FontSizeDelta = 1;
            this.colDescription.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.colDescription.AppearanceHeader.Options.UseFont = true;
            this.colDescription.ColumnEdit = this.repositoryItemtxtDescription;
            this.colDescription.FieldName = "Description";
            this.colDescription.MaxWidth = 200;
            this.colDescription.MinWidth = 80;
            this.colDescription.Name = "colDescription";
            this.colDescription.Visible = true;
            this.colDescription.VisibleIndex = 1;
            this.colDescription.Width = 80;
            // 
            // repositoryItemtxtDescription
            // 
            this.repositoryItemtxtDescription.AutoHeight = false;
            this.repositoryItemtxtDescription.MaxLength = 500;
            this.repositoryItemtxtDescription.Name = "repositoryItemtxtDescription";
            // 
            // colQuantity
            // 
            this.colQuantity.AppearanceHeader.FontSizeDelta = 1;
            this.colQuantity.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.colQuantity.AppearanceHeader.Options.UseFont = true;
            this.colQuantity.ColumnEdit = this.repositoryItemtxtQuantity;
            this.colQuantity.FieldName = "Quantity";
            this.colQuantity.MaxWidth = 130;
            this.colQuantity.MinWidth = 70;
            this.colQuantity.Name = "colQuantity";
            this.colQuantity.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Quantity", "{0:0.##}")});
            this.colQuantity.Visible = true;
            this.colQuantity.VisibleIndex = 2;
            this.colQuantity.Width = 124;
            // 
            // repositoryItemtxtQuantity
            // 
            this.repositoryItemtxtQuantity.AutoHeight = false;
            this.repositoryItemtxtQuantity.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repositoryItemtxtQuantity.Mask.EditMask = "n2";
            this.repositoryItemtxtQuantity.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.repositoryItemtxtQuantity.Mask.UseMaskAsDisplayFormat = true;
            this.repositoryItemtxtQuantity.MaxLength = 12;
            this.repositoryItemtxtQuantity.Name = "repositoryItemtxtQuantity";
            this.repositoryItemtxtQuantity.EditValueChanged += new System.EventHandler(this.repositoryItemtxtQuantity_EditValueChanged);
            // 
            // colRate
            // 
            this.colRate.AppearanceHeader.FontSizeDelta = 1;
            this.colRate.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.colRate.AppearanceHeader.Options.UseFont = true;
            this.colRate.ColumnEdit = this.repositoryItemtxtRate;
            this.colRate.FieldName = "Rate";
            this.colRate.MaxWidth = 130;
            this.colRate.MinWidth = 50;
            this.colRate.Name = "colRate";
            this.colRate.OptionsColumn.ReadOnly = true;
            this.colRate.OptionsColumn.TabStop = false;
            this.colRate.Visible = true;
            this.colRate.VisibleIndex = 3;
            this.colRate.Width = 120;
            // 
            // repositoryItemtxtRate
            // 
            this.repositoryItemtxtRate.AutoHeight = false;
            this.repositoryItemtxtRate.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repositoryItemtxtRate.Mask.EditMask = "n2";
            this.repositoryItemtxtRate.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.repositoryItemtxtRate.Mask.UseMaskAsDisplayFormat = true;
            this.repositoryItemtxtRate.MaxLength = 12;
            this.repositoryItemtxtRate.Name = "repositoryItemtxtRate";
            // 
            // colAmount
            // 
            this.colAmount.AppearanceHeader.FontSizeDelta = 1;
            this.colAmount.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.colAmount.AppearanceHeader.Options.UseFont = true;
            this.colAmount.ColumnEdit = this.repositoryItemtxtAmount;
            this.colAmount.FieldName = "Amount";
            this.colAmount.MaxWidth = 170;
            this.colAmount.MinWidth = 70;
            this.colAmount.Name = "colAmount";
            this.colAmount.OptionsColumn.ReadOnly = true;
            this.colAmount.OptionsColumn.TabStop = false;
            this.colAmount.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Amount", "{0:0.##}")});
            this.colAmount.Visible = true;
            this.colAmount.VisibleIndex = 4;
            this.colAmount.Width = 111;
            // 
            // repositoryItemtxtAmount
            // 
            this.repositoryItemtxtAmount.AutoHeight = false;
            this.repositoryItemtxtAmount.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repositoryItemtxtAmount.Mask.EditMask = "n2";
            this.repositoryItemtxtAmount.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.repositoryItemtxtAmount.Mask.UseMaskAsDisplayFormat = true;
            this.repositoryItemtxtAmount.MaxLength = 18;
            this.repositoryItemtxtAmount.Name = "repositoryItemtxtAmount";
            // 
            // gridColumn1
            // 
            this.gridColumn1.ColumnEdit = this.repositoryItembtnDelete;
            this.gridColumn1.MaxWidth = 20;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.TabStop = false;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 5;
            this.gridColumn1.Width = 20;
            // 
            // repositoryItembtnDelete
            // 
            this.repositoryItembtnDelete.AutoHeight = false;
            this.repositoryItembtnDelete.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete)});
            this.repositoryItembtnDelete.Name = "repositoryItembtnDelete";
            this.repositoryItembtnDelete.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.repositoryItembtnDelete.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.repositoryItemButtonEdit1_ButtonClick);
            // 
            // txtSaleNo
            // 
            this.txtSaleNo.EditValue = 0;
            this.txtSaleNo.EnterMoveNextControl = true;
            this.dxErrorProvider1.SetIconAlignment(this.txtSaleNo, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
            this.txtSaleNo.Location = new System.Drawing.Point(224, 12);
            this.txtSaleNo.MaximumSize = new System.Drawing.Size(85, 20);
            this.txtSaleNo.Name = "txtSaleNo";
            this.txtSaleNo.Properties.Appearance.Options.UseTextOptions = true;
            this.txtSaleNo.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtSaleNo.Properties.Mask.EditMask = "n0";
            this.txtSaleNo.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtSaleNo.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtSaleNo.Properties.MaxLength = 8;
            this.txtSaleNo.Properties.ReadOnly = true;
            this.txtSaleNo.Size = new System.Drawing.Size(85, 20);
            this.txtSaleNo.StyleController = this.layoutControl1;
            this.txtSaleNo.TabIndex = 14;
            this.txtSaleNo.TabStop = false;
            // 
            // dteSaleDate
            // 
            this.dteSaleDate.EditValue = new System.DateTime(2021, 7, 17, 11, 5, 4, 0);
            this.dteSaleDate.EnterMoveNextControl = true;
            this.dxErrorProvider1.SetIconAlignment(this.dteSaleDate, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
            this.dteSaleDate.Location = new System.Drawing.Point(61, 12);
            this.dteSaleDate.MaximumSize = new System.Drawing.Size(110, 20);
            this.dteSaleDate.MinimumSize = new System.Drawing.Size(110, 20);
            this.dteSaleDate.Name = "dteSaleDate";
            this.dteSaleDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dteSaleDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dteSaleDate.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
            this.dteSaleDate.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.dteSaleDate.Size = new System.Drawing.Size(110, 20);
            this.dteSaleDate.StyleController = this.layoutControl1;
            this.dteSaleDate.TabIndex = 12;
            this.dteSaleDate.Validating += new System.ComponentModel.CancelEventHandler(this.dateEdit1_Validating);
            // 
            // btnCancel
            // 
            this.btnCancel.Appearance.FontSizeDelta = 1;
            this.btnCancel.Appearance.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.btnCancel.Appearance.Options.UseFont = true;
            this.btnCancel.ImageOptions.Image = global::MangoMan.Winform.Properties.Resources.icons8_cancel_32__1_;
            this.btnCancel.Location = new System.Drawing.Point(799, 389);
            this.btnCancel.MaximumSize = new System.Drawing.Size(100, 35);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 35);
            this.btnCancel.StyleController = this.layoutControl1;
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Appearance.FontSizeDelta = 1;
            this.btnSave.Appearance.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.btnSave.Appearance.Options.UseFont = true;
            this.btnSave.ImageOptions.Image = global::MangoMan.Winform.Properties.Resources.icons8_save_32;
            this.btnSave.Location = new System.Drawing.Point(12, 389);
            this.btnSave.MaximumSize = new System.Drawing.Size(100, 35);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 35);
            this.btnSave.StyleController = this.layoutControl1;
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem7,
            this.emptySpaceItem2,
            this.layoutControlItem8,
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.emptySpaceItem3,
            this.layoutControlItem3});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(911, 437);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.btnSave;
            this.layoutControlItem7.Location = new System.Drawing.Point(0, 377);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(104, 40);
            this.layoutControlItem7.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem7.TextVisible = false;
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(104, 377);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(683, 40);
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem8
            // 
            this.layoutControlItem8.Control = this.btnCancel;
            this.layoutControlItem8.Location = new System.Drawing.Point(787, 377);
            this.layoutControlItem8.Name = "layoutControlItem8";
            this.layoutControlItem8.Size = new System.Drawing.Size(104, 40);
            this.layoutControlItem8.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem8.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.dteSaleDate;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(163, 24);
            this.layoutControlItem1.Text = "Sale Date";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(46, 13);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.txtSaleNo;
            this.layoutControlItem2.Location = new System.Drawing.Point(163, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(138, 24);
            this.layoutControlItem2.Text = "Sale No.";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(46, 13);
            // 
            // emptySpaceItem3
            // 
            this.emptySpaceItem3.AllowHotTrack = false;
            this.emptySpaceItem3.Location = new System.Drawing.Point(301, 0);
            this.emptySpaceItem3.Name = "emptySpaceItem3";
            this.emptySpaceItem3.Size = new System.Drawing.Size(590, 24);
            this.emptySpaceItem3.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.gridControl1;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(891, 353);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // dxErrorProvider1
            // 
            this.dxErrorProvider1.ContainerControl = this;
            // 
            // frmSale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 437);
            this.Controls.Add(this.layoutControl1);
            this.Name = "frmSale";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Sale";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.saleProductDetailsViewModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemlueItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemtxtDescription)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemtxtQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemtxtRate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemtxtAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItembtnDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSaleNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteSaleDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteSaleDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
        private DevExpress.XtraEditors.DateEdit dteSaleDate;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraEditors.TextEdit txtSaleNo;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem3;
        private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider dxErrorProvider1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemlueItem;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemtxtQuantity;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItembtnDelete;
        private System.Windows.Forms.BindingSource saleProductDetailsViewModelBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colItemID;
        private DevExpress.XtraGrid.Columns.GridColumn colDescription;
        private DevExpress.XtraGrid.Columns.GridColumn colQuantity;
        private DevExpress.XtraGrid.Columns.GridColumn colRate;
        private DevExpress.XtraGrid.Columns.GridColumn colAmount;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemtxtDescription;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemtxtRate;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemtxtAmount;
    }
}