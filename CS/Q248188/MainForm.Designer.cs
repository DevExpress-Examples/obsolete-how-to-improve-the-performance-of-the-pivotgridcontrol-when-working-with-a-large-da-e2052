namespace Q248188 {
    partial class MainForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.normalPivot = new DevExpress.XtraPivotGrid.PivotGridControl();
            this.salesPersonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nwindDataSet = new Q248188.nwindDataSet();
            this.fieldCountry = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldProductName = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldCategoryName = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldUnitPrice = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldQuantity = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldDiscount = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldExtendedPrice = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldSalesPerson = new DevExpress.XtraPivotGrid.PivotGridField();
            this.optimizedPivot = new DevExpress.XtraPivotGrid.PivotGridControl();
            this.salesPersonTableAdapter = new Q248188.nwindDataSetTableAdapters.SalesPersonTableAdapter();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.refreshButton = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.normalPivot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesPersonBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nwindDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.optimizedPivot)).BeginInit();
            this.SuspendLayout();
            // 
            // normalPivot
            // 
            this.normalPivot.Cursor = System.Windows.Forms.Cursors.Default;
            this.normalPivot.DataSource = this.salesPersonBindingSource;
            this.normalPivot.Fields.AddRange(new DevExpress.XtraPivotGrid.PivotGridField[] {
            this.fieldCountry,
            this.fieldProductName,
            this.fieldCategoryName,
            this.fieldUnitPrice,
            this.fieldQuantity,
            this.fieldDiscount,
            this.fieldExtendedPrice,
            this.fieldSalesPerson});
            this.normalPivot.Location = new System.Drawing.Point(3, 35);
            this.normalPivot.Name = "normalPivot";
            this.normalPivot.OptionsCustomization.AllowFilter = false;
            this.normalPivot.Size = new System.Drawing.Size(400, 258);
            this.normalPivot.TabIndex = 0;
            // 
            // salesPersonBindingSource
            // 
            this.salesPersonBindingSource.DataMember = "SalesPerson";
            this.salesPersonBindingSource.DataSource = this.nwindDataSet;
            // 
            // nwindDataSet
            // 
            this.nwindDataSet.DataSetName = "nwindDataSet";
            this.nwindDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fieldCountry
            // 
            this.fieldCountry.AreaIndex = 0;
            this.fieldCountry.Caption = "Country";
            this.fieldCountry.FieldName = "Country";
            this.fieldCountry.Name = "fieldCountry";
            // 
            // fieldProductName
            // 
            this.fieldProductName.AreaIndex = 1;
            this.fieldProductName.Caption = "Product Name";
            this.fieldProductName.FieldName = "ProductName";
            this.fieldProductName.Name = "fieldProductName";
            // 
            // fieldCategoryName
            // 
            this.fieldCategoryName.AreaIndex = 2;
            this.fieldCategoryName.Caption = "Category Name";
            this.fieldCategoryName.FieldName = "CategoryName";
            this.fieldCategoryName.Name = "fieldCategoryName";
            // 
            // fieldUnitPrice
            // 
            this.fieldUnitPrice.AreaIndex = 3;
            this.fieldUnitPrice.Caption = "Unit Price";
            this.fieldUnitPrice.FieldName = "UnitPrice";
            this.fieldUnitPrice.Name = "fieldUnitPrice";
            // 
            // fieldQuantity
            // 
            this.fieldQuantity.AreaIndex = 4;
            this.fieldQuantity.Caption = "Quantity";
            this.fieldQuantity.FieldName = "Quantity";
            this.fieldQuantity.Name = "fieldQuantity";
            // 
            // fieldDiscount
            // 
            this.fieldDiscount.AreaIndex = 5;
            this.fieldDiscount.Caption = "Discount";
            this.fieldDiscount.FieldName = "Discount";
            this.fieldDiscount.Name = "fieldDiscount";
            // 
            // fieldExtendedPrice
            // 
            this.fieldExtendedPrice.AreaIndex = 6;
            this.fieldExtendedPrice.Caption = "Extended Price";
            this.fieldExtendedPrice.FieldName = "Extended Price";
            this.fieldExtendedPrice.Name = "fieldExtendedPrice";
            // 
            // fieldSalesPerson
            // 
            this.fieldSalesPerson.AreaIndex = 7;
            this.fieldSalesPerson.Caption = "Sales Person";
            this.fieldSalesPerson.FieldName = "Sales Person";
            this.fieldSalesPerson.Name = "fieldSalesPerson";
            // 
            // optimizedPivot
            // 
            this.optimizedPivot.Cursor = System.Windows.Forms.Cursors.Default;
            this.optimizedPivot.Location = new System.Drawing.Point(409, 35);
            this.optimizedPivot.Name = "optimizedPivot";
            this.optimizedPivot.Size = new System.Drawing.Size(400, 258);
            this.optimizedPivot.TabIndex = 1;
            // 
            // salesPersonTableAdapter
            // 
            this.salesPersonTableAdapter.ClearBeforeFill = true;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 3);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(60, 13);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Normal Pivot";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(418, 3);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(74, 13);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Optimized Pivot";
            // 
            // refreshButton
            // 
            this.refreshButton.Appearance.ForeColor = System.Drawing.Color.Red;
            this.refreshButton.Appearance.Options.UseForeColor = true;
            this.refreshButton.Location = new System.Drawing.Point(508, 3);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(75, 26);
            this.refreshButton.TabIndex = 4;
            this.refreshButton.Text = "Refresh";
            this.refreshButton.Visible = false;
            this.refreshButton.Click += new System.EventHandler(this.OnRefreshButtonClick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 296);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.optimizedPivot);
            this.Controls.Add(this.normalPivot);
            this.Name = "MainForm";
            this.Text = "DX Sample";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.normalPivot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesPersonBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nwindDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.optimizedPivot)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraPivotGrid.PivotGridControl normalPivot;
        private DevExpress.XtraPivotGrid.PivotGridControl optimizedPivot;
        private nwindDataSet nwindDataSet;
        private System.Windows.Forms.BindingSource salesPersonBindingSource;
        private Q248188.nwindDataSetTableAdapters.SalesPersonTableAdapter salesPersonTableAdapter;
        private DevExpress.XtraPivotGrid.PivotGridField fieldCountry;
        private DevExpress.XtraPivotGrid.PivotGridField fieldProductName;
        private DevExpress.XtraPivotGrid.PivotGridField fieldCategoryName;
        private DevExpress.XtraPivotGrid.PivotGridField fieldUnitPrice;
        private DevExpress.XtraPivotGrid.PivotGridField fieldQuantity;
        private DevExpress.XtraPivotGrid.PivotGridField fieldDiscount;
        private DevExpress.XtraPivotGrid.PivotGridField fieldExtendedPrice;
        private DevExpress.XtraPivotGrid.PivotGridField fieldSalesPerson;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton refreshButton;
    }
}

