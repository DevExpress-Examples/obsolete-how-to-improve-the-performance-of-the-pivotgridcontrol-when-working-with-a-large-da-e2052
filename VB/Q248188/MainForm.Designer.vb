Imports Microsoft.VisualBasic
Imports System
Namespace Q248188
	Partial Public Class MainForm
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Me.normalPivot = New DevExpress.XtraPivotGrid.PivotGridControl()
			Me.salesPersonBindingSource = New System.Windows.Forms.BindingSource(Me.components)
			Me.nwindDataSet = New Q248188.nwindDataSet()
			Me.fieldCountry = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.fieldProductName = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.fieldCategoryName = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.fieldUnitPrice = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.fieldQuantity = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.fieldDiscount = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.fieldExtendedPrice = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.fieldSalesPerson = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.optimizedPivot = New DevExpress.XtraPivotGrid.PivotGridControl()
			Me.salesPersonTableAdapter = New Q248188.nwindDataSetTableAdapters.SalesPersonTableAdapter()
			Me.labelControl1 = New DevExpress.XtraEditors.LabelControl()
			Me.labelControl2 = New DevExpress.XtraEditors.LabelControl()
			Me.refreshButton = New DevExpress.XtraEditors.SimpleButton()
			CType(Me.normalPivot, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.salesPersonBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.nwindDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.optimizedPivot, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' normalPivot
			' 
			Me.normalPivot.Cursor = System.Windows.Forms.Cursors.Default
			Me.normalPivot.DataSource = Me.salesPersonBindingSource
			Me.normalPivot.Fields.AddRange(New DevExpress.XtraPivotGrid.PivotGridField() { Me.fieldCountry, Me.fieldProductName, Me.fieldCategoryName, Me.fieldUnitPrice, Me.fieldQuantity, Me.fieldDiscount, Me.fieldExtendedPrice, Me.fieldSalesPerson})
			Me.normalPivot.Location = New System.Drawing.Point(3, 35)
			Me.normalPivot.Name = "normalPivot"
			Me.normalPivot.OptionsCustomization.AllowFilter = False
			Me.normalPivot.Size = New System.Drawing.Size(400, 258)
			Me.normalPivot.TabIndex = 0
			' 
			' salesPersonBindingSource
			' 
			Me.salesPersonBindingSource.DataMember = "SalesPerson"
			Me.salesPersonBindingSource.DataSource = Me.nwindDataSet
			' 
			' nwindDataSet
			' 
			Me.nwindDataSet.DataSetName = "nwindDataSet"
			Me.nwindDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
			' 
			' fieldCountry
			' 
			Me.fieldCountry.AreaIndex = 0
			Me.fieldCountry.Caption = "Country"
			Me.fieldCountry.FieldName = "Country"
			Me.fieldCountry.Name = "fieldCountry"
			' 
			' fieldProductName
			' 
			Me.fieldProductName.AreaIndex = 1
			Me.fieldProductName.Caption = "Product Name"
			Me.fieldProductName.FieldName = "ProductName"
			Me.fieldProductName.Name = "fieldProductName"
			' 
			' fieldCategoryName
			' 
			Me.fieldCategoryName.AreaIndex = 2
			Me.fieldCategoryName.Caption = "Category Name"
			Me.fieldCategoryName.FieldName = "CategoryName"
			Me.fieldCategoryName.Name = "fieldCategoryName"
			' 
			' fieldUnitPrice
			' 
			Me.fieldUnitPrice.AreaIndex = 3
			Me.fieldUnitPrice.Caption = "Unit Price"
			Me.fieldUnitPrice.FieldName = "UnitPrice"
			Me.fieldUnitPrice.Name = "fieldUnitPrice"
			' 
			' fieldQuantity
			' 
			Me.fieldQuantity.AreaIndex = 4
			Me.fieldQuantity.Caption = "Quantity"
			Me.fieldQuantity.FieldName = "Quantity"
			Me.fieldQuantity.Name = "fieldQuantity"
			' 
			' fieldDiscount
			' 
			Me.fieldDiscount.AreaIndex = 5
			Me.fieldDiscount.Caption = "Discount"
			Me.fieldDiscount.FieldName = "Discount"
			Me.fieldDiscount.Name = "fieldDiscount"
			' 
			' fieldExtendedPrice
			' 
			Me.fieldExtendedPrice.AreaIndex = 6
			Me.fieldExtendedPrice.Caption = "Extended Price"
			Me.fieldExtendedPrice.FieldName = "Extended Price"
			Me.fieldExtendedPrice.Name = "fieldExtendedPrice"
			' 
			' fieldSalesPerson
			' 
			Me.fieldSalesPerson.AreaIndex = 7
			Me.fieldSalesPerson.Caption = "Sales Person"
			Me.fieldSalesPerson.FieldName = "Sales Person"
			Me.fieldSalesPerson.Name = "fieldSalesPerson"
			' 
			' optimizedPivot
			' 
			Me.optimizedPivot.Cursor = System.Windows.Forms.Cursors.Default
			Me.optimizedPivot.Location = New System.Drawing.Point(409, 35)
			Me.optimizedPivot.Name = "optimizedPivot"
			Me.optimizedPivot.Size = New System.Drawing.Size(400, 258)
			Me.optimizedPivot.TabIndex = 1
			' 
			' salesPersonTableAdapter
			' 
			Me.salesPersonTableAdapter.ClearBeforeFill = True
			' 
			' labelControl1
			' 
			Me.labelControl1.Location = New System.Drawing.Point(12, 3)
			Me.labelControl1.Name = "labelControl1"
			Me.labelControl1.Size = New System.Drawing.Size(60, 13)
			Me.labelControl1.TabIndex = 2
			Me.labelControl1.Text = "Normal Pivot"
			' 
			' labelControl2
			' 
			Me.labelControl2.Location = New System.Drawing.Point(418, 3)
			Me.labelControl2.Name = "labelControl2"
			Me.labelControl2.Size = New System.Drawing.Size(74, 13)
			Me.labelControl2.TabIndex = 3
			Me.labelControl2.Text = "Optimized Pivot"
			' 
			' refreshButton
			' 
			Me.refreshButton.Appearance.ForeColor = System.Drawing.Color.Red
			Me.refreshButton.Appearance.Options.UseForeColor = True
			Me.refreshButton.Location = New System.Drawing.Point(508, 3)
			Me.refreshButton.Name = "refreshButton"
			Me.refreshButton.Size = New System.Drawing.Size(75, 26)
			Me.refreshButton.TabIndex = 4
			Me.refreshButton.Text = "Refresh"
			Me.refreshButton.Visible = False
'			Me.refreshButton.Click += New System.EventHandler(Me.OnRefreshButtonClick);
			' 
			' MainForm
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(815, 296)
			Me.Controls.Add(Me.refreshButton)
			Me.Controls.Add(Me.labelControl2)
			Me.Controls.Add(Me.labelControl1)
			Me.Controls.Add(Me.optimizedPivot)
			Me.Controls.Add(Me.normalPivot)
			Me.Name = "MainForm"
			Me.Text = "DX Sample"
'			Me.Load += New System.EventHandler(Me.MainForm_Load);
			CType(Me.normalPivot, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.salesPersonBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.nwindDataSet, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.optimizedPivot, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region

		Private normalPivot As DevExpress.XtraPivotGrid.PivotGridControl
		Private optimizedPivot As DevExpress.XtraPivotGrid.PivotGridControl
		Private nwindDataSet As nwindDataSet
		Private salesPersonBindingSource As System.Windows.Forms.BindingSource
		Private salesPersonTableAdapter As Q248188.nwindDataSetTableAdapters.SalesPersonTableAdapter
		Private fieldCountry As DevExpress.XtraPivotGrid.PivotGridField
		Private fieldProductName As DevExpress.XtraPivotGrid.PivotGridField
		Private fieldCategoryName As DevExpress.XtraPivotGrid.PivotGridField
		Private fieldUnitPrice As DevExpress.XtraPivotGrid.PivotGridField
		Private fieldQuantity As DevExpress.XtraPivotGrid.PivotGridField
		Private fieldDiscount As DevExpress.XtraPivotGrid.PivotGridField
		Private fieldExtendedPrice As DevExpress.XtraPivotGrid.PivotGridField
		Private fieldSalesPerson As DevExpress.XtraPivotGrid.PivotGridField
		Private labelControl1 As DevExpress.XtraEditors.LabelControl
		Private labelControl2 As DevExpress.XtraEditors.LabelControl
		Private WithEvents refreshButton As DevExpress.XtraEditors.SimpleButton
	End Class
End Namespace

