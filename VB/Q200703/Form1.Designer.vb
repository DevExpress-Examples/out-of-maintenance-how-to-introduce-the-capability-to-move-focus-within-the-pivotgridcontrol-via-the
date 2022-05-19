Namespace Q200703
	Partial Public Class Form1
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
            Dim DataSourceColumnBinding1 As DevExpress.XtraPivotGrid.DataSourceColumnBinding = New DevExpress.XtraPivotGrid.DataSourceColumnBinding()
            Dim DataSourceColumnBinding2 As DevExpress.XtraPivotGrid.DataSourceColumnBinding = New DevExpress.XtraPivotGrid.DataSourceColumnBinding()
            Dim DataSourceColumnBinding3 As DevExpress.XtraPivotGrid.DataSourceColumnBinding = New DevExpress.XtraPivotGrid.DataSourceColumnBinding()
            Me.nwindDataSet = New nwindDataSet()
            Me.bindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
            Me.salesPersonTableAdapter = New nwindDataSetTableAdapters.SalesPersonTableAdapter()
            Me.myPivotGridControl1 = New DXSample.MyPivotGridControl()
            Me.fieldCategoryName1 = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.fieldExtendedPrice1 = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.fieldSalesPerson1 = New DevExpress.XtraPivotGrid.PivotGridField()
            CType(Me.nwindDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.bindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.myPivotGridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'nwindDataSet
            '
            Me.nwindDataSet.DataSetName = "nwindDataSet"
            Me.nwindDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
            '
            'bindingSource1
            '
            Me.bindingSource1.DataMember = "SalesPerson"
            Me.bindingSource1.DataSource = Me.nwindDataSet
            '
            'salesPersonTableAdapter
            '
            Me.salesPersonTableAdapter.ClearBeforeFill = True
            '
            'myPivotGridControl1
            '
            Me.myPivotGridControl1.Cursor = System.Windows.Forms.Cursors.Default
            Me.myPivotGridControl1.DataSource = Me.bindingSource1
            Me.myPivotGridControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.myPivotGridControl1.Fields.AddRange(New DevExpress.XtraPivotGrid.PivotGridField() {Me.fieldCategoryName1, Me.fieldExtendedPrice1, Me.fieldSalesPerson1})
            Me.myPivotGridControl1.Location = New System.Drawing.Point(0, 0)
            Me.myPivotGridControl1.Name = "myPivotGridControl1"
            Me.myPivotGridControl1.OptionsData.DataProcessingEngine = DevExpress.XtraPivotGrid.PivotDataProcessingEngine.Optimized
            Me.myPivotGridControl1.Size = New System.Drawing.Size(891, 574)
            Me.myPivotGridControl1.TabIndex = 2
            '
            'fieldCategoryName1
            '
            Me.fieldCategoryName1.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
            Me.fieldCategoryName1.AreaIndex = 0
            Me.fieldCategoryName1.Caption = "Category Name"
            DataSourceColumnBinding1.ColumnName = "CategoryName"
            Me.fieldCategoryName1.DataBinding = DataSourceColumnBinding1
            Me.fieldCategoryName1.Name = "fieldCategoryName1"
            '
            'fieldExtendedPrice1
            '
            Me.fieldExtendedPrice1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
            Me.fieldExtendedPrice1.AreaIndex = 0
            Me.fieldExtendedPrice1.Caption = "Extended Price"
            DataSourceColumnBinding2.ColumnName = "Extended Price"
            Me.fieldExtendedPrice1.DataBinding = DataSourceColumnBinding2
            Me.fieldExtendedPrice1.Name = "fieldExtendedPrice1"
            '
            'fieldSalesPerson1
            '
            Me.fieldSalesPerson1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
            Me.fieldSalesPerson1.AreaIndex = 0
            Me.fieldSalesPerson1.Caption = "Sales Person"
            DataSourceColumnBinding3.ColumnName = "Sales Person"
            Me.fieldSalesPerson1.DataBinding = DataSourceColumnBinding3
            Me.fieldSalesPerson1.Name = "fieldSalesPerson1"
            '
            'Form1
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(891, 574)
            Me.Controls.Add(Me.myPivotGridControl1)
            Me.Name = "Form1"
            Me.Text = "Form1"
            CType(Me.nwindDataSet, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.bindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.myPivotGridControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

#End Region

        Private nwindDataSet As nwindDataSet
        Private bindingSource1 As System.Windows.Forms.BindingSource
        Private salesPersonTableAdapter As nwindDataSetTableAdapters.SalesPersonTableAdapter
        Private myPivotGridControl1 As DXSample.MyPivotGridControl
        Private fieldCategoryName1 As DevExpress.XtraPivotGrid.PivotGridField
        Private fieldExtendedPrice1 As DevExpress.XtraPivotGrid.PivotGridField
        Private fieldSalesPerson1 As DevExpress.XtraPivotGrid.PivotGridField

    End Class
End Namespace

