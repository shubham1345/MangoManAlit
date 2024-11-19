namespace MangoMan.Winform.Purchase
{
    partial class frmPurchase
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
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.purchaseProductDetailsViewModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.txtPurchaseNo = new DevExpress.XtraEditors.TextEdit();
            this.dtePurchaseDate = new DevExpress.XtraEditors.DateEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem9 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.dxErrorProvider1 = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            this.Del = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseProductDetailsViewModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemlueItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemtxtDescription)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemtxtQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemtxtRate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemtxtAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItembtnDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPurchaseNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtePurchaseDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtePurchaseDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.groupControl1);
            this.layoutControl1.Controls.Add(this.btnCancel);
            this.layoutControl1.Controls.Add(this.btnSave);
            this.layoutControl1.Controls.Add(this.txtPurchaseNo);
            this.layoutControl1.Controls.Add(this.dtePurchaseDate);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(851, 410);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.gridControl1);
            this.groupControl1.Location = new System.Drawing.Point(12, 36);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(827, 301);
            this.groupControl1.TabIndex = 13;
            this.groupControl1.Text = "Product Detail";
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.purchaseProductDetailsViewModelBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(2, 23);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemlueItem,
            this.repositoryItemtxtQuantity,
            this.repositoryItembtnDelete,
            this.repositoryItemtxtDescription,
            this.repositoryItemtxtRate,
            this.repositoryItemtxtAmount});
            this.gridControl1.Size = new System.Drawing.Size(823, 276);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // purchaseProductDetailsViewModelBindingSource
            // 
            this.purchaseProductDetailsViewModelBindingSource.DataSource = typeof(MangoMan.Model.Purchase.PurchaseProductDetailsViewModel);
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
            this.gridView1.OptionsView.ShowGroupPanel = false;
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
            this.colItemID.Width = 207;
            // 
            // repositoryItemlueItem
            // 
            this.repositoryItemlueItem.AutoHeight = false;
            this.repositoryItemlueItem.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemlueItem.Name = "repositoryItemlueItem";
            this.repositoryItemlueItem.NullText = "Select";
            this.repositoryItemlueItem.PopupWidth = 400;
            this.repositoryItemlueItem.EditValueChanged += new System.EventHandler(this.lueItems_EditValueChanged);
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
            this.colDescription.Width = 200;
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
            this.colQuantity.MaxWidth = 170;
            this.colQuantity.MinWidth = 70;
            this.colQuantity.Name = "colQuantity";
            this.colQuantity.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Quantity", "{0:0.##}")});
            this.colQuantity.Visible = true;
            this.colQuantity.VisibleIndex = 2;
            this.colQuantity.Width = 130;
            // 
            // repositoryItemtxtQuantity
            // 
            this.repositoryItemtxtQuantity.AutoHeight = false;
            this.repositoryItemtxtQuantity.EditFormat.FormatString = "n2";
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
            this.colRate.Width = 67;
            // 
            // repositoryItemtxtRate
            // 
            this.repositoryItemtxtRate.AutoHeight = false;
            this.repositoryItemtxtRate.EditFormat.FormatString = "n2";
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
            this.colAmount.Width = 166;
            // 
            // repositoryItemtxtAmount
            // 
            this.repositoryItemtxtAmount.AutoHeight = false;
            this.repositoryItemtxtAmount.EditFormat.FormatString = "n2";
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
            this.gridColumn1.MaxWidth = 30;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.TabStop = false;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 5;
            this.gridColumn1.Width = 30;
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
            // btnCancel
            // 
            this.btnCancel.Appearance.FontSizeDelta = 1;
            this.btnCancel.Appearance.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.btnCancel.Appearance.Options.UseFont = true;
            this.btnCancel.ImageOptions.Image = global::MangoMan.Winform.Properties.Resources.icons8_cancel_32__1_;
            this.btnCancel.Location = new System.Drawing.Point(745, 362);
            this.btnCancel.MaximumSize = new System.Drawing.Size(100, 35);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(94, 35);
            this.btnCancel.StyleController = this.layoutControl1;
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Appearance.FontSizeDelta = 1;
            this.btnSave.Appearance.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.btnSave.Appearance.Options.UseFont = true;
            this.btnSave.ImageOptions.Image = global::MangoMan.Winform.Properties.Resources.icons8_save_32;
            this.btnSave.Location = new System.Drawing.Point(12, 362);
            this.btnSave.MaximumSize = new System.Drawing.Size(100, 35);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(94, 35);
            this.btnSave.StyleController = this.layoutControl1;
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtPurchaseNo
            // 
            this.txtPurchaseNo.EditValue = 0;
            this.txtPurchaseNo.EnterMoveNextControl = true;
            this.txtPurchaseNo.Location = new System.Drawing.Point(260, 12);
            this.txtPurchaseNo.MaximumSize = new System.Drawing.Size(85, 20);
            this.txtPurchaseNo.MinimumSize = new System.Drawing.Size(85, 20);
            this.txtPurchaseNo.Name = "txtPurchaseNo";
            this.txtPurchaseNo.Properties.Appearance.Options.UseTextOptions = true;
            this.txtPurchaseNo.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtPurchaseNo.Properties.Mask.EditMask = "n0";
            this.txtPurchaseNo.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtPurchaseNo.Properties.ReadOnly = true;
            this.txtPurchaseNo.Size = new System.Drawing.Size(85, 20);
            this.txtPurchaseNo.StyleController = this.layoutControl1;
            this.txtPurchaseNo.TabIndex = 6;
            this.txtPurchaseNo.TabStop = false;
            // 
            // dtePurchaseDate
            // 
            this.dtePurchaseDate.EditValue = new System.DateTime(2021, 7, 17, 11, 10, 42, 0);
            this.dtePurchaseDate.EnterMoveNextControl = true;
            this.dtePurchaseDate.Location = new System.Drawing.Point(79, 12);
            this.dtePurchaseDate.MaximumSize = new System.Drawing.Size(110, 20);
            this.dtePurchaseDate.MinimumSize = new System.Drawing.Size(110, 20);
            this.dtePurchaseDate.Name = "dtePurchaseDate";
            this.dtePurchaseDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtePurchaseDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtePurchaseDate.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
            this.dtePurchaseDate.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.dtePurchaseDate.Size = new System.Drawing.Size(110, 20);
            this.dtePurchaseDate.StyleController = this.layoutControl1;
            this.dtePurchaseDate.TabIndex = 4;
            this.dtePurchaseDate.Validating += new System.ComponentModel.CancelEventHandler(this.dateEdit1_Validating);
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem3,
            this.layoutControlItem8,
            this.layoutControlItem9,
            this.emptySpaceItem2,
            this.emptySpaceItem1,
            this.layoutControlItem2});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(851, 410);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.dtePurchaseDate;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(181, 24);
            this.layoutControlItem1.Text = "Date";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(64, 13);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.txtPurchaseNo;
            this.layoutControlItem3.Location = new System.Drawing.Point(181, 0);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(650, 24);
            this.layoutControlItem3.Text = "Purchase No.";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(64, 13);
            // 
            // layoutControlItem8
            // 
            this.layoutControlItem8.Control = this.btnSave;
            this.layoutControlItem8.Location = new System.Drawing.Point(0, 350);
            this.layoutControlItem8.Name = "layoutControlItem8";
            this.layoutControlItem8.Size = new System.Drawing.Size(98, 40);
            this.layoutControlItem8.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem8.TextVisible = false;
            // 
            // layoutControlItem9
            // 
            this.layoutControlItem9.Control = this.btnCancel;
            this.layoutControlItem9.Location = new System.Drawing.Point(733, 350);
            this.layoutControlItem9.Name = "layoutControlItem9";
            this.layoutControlItem9.Size = new System.Drawing.Size(98, 40);
            this.layoutControlItem9.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem9.TextVisible = false;
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(98, 350);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(635, 40);
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 329);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(831, 21);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.groupControl1;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(831, 305);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // dxErrorProvider1
            // 
            this.dxErrorProvider1.ContainerControl = this;
            // 
            // Del
            // 
            this.Del.Name = "Del";
            // 
            // frmPurchase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 410);
            this.Controls.Add(this.layoutControl1);
            this.Name = "frmPurchase";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Purchase";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseProductDetailsViewModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemlueItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemtxtDescription)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemtxtQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemtxtRate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemtxtAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItembtnDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPurchaseNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtePurchaseDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtePurchaseDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.TextEdit txtPurchaseNo;
        private DevExpress.XtraEditors.DateEdit dtePurchaseDate;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem9;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider dxErrorProvider1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraGrid.Columns.GridColumn Del;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemlueItem;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemtxtQuantity;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItembtnDelete;
        private System.Windows.Forms.BindingSource purchaseProductDetailsViewModelBindingSource;
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