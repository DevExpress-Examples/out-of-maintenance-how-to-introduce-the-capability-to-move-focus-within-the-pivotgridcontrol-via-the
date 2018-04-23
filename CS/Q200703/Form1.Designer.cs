namespace Q200703 {
    partial class Form1 {
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
            this.nwindDataSet = new Q200703.nwindDataSet();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.salesPersonTableAdapter = new Q200703.nwindDataSetTableAdapters.SalesPersonTableAdapter();
            this.myPivotGridControl1 = new DXSample.MyPivotGridControl();
            this.fieldCategoryName = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldExtendedPrice = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldSalesPerson = new DevExpress.XtraPivotGrid.PivotGridField();
            ((System.ComponentModel.ISupportInitialize)(this.nwindDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myPivotGridControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // nwindDataSet
            // 
            this.nwindDataSet.DataSetName = "nwindDataSet";
            this.nwindDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "SalesPerson";
            this.bindingSource1.DataSource = this.nwindDataSet;
            // 
            // salesPersonTableAdapter
            // 
            this.salesPersonTableAdapter.ClearBeforeFill = true;
            // 
            // myPivotGridControl1
            // 
            this.myPivotGridControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.myPivotGridControl1.DataSource = this.bindingSource1;
            this.myPivotGridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.myPivotGridControl1.Fields.AddRange(new DevExpress.XtraPivotGrid.PivotGridField[] {
            this.fieldCategoryName,
            this.fieldExtendedPrice,
            this.fieldSalesPerson});
            this.myPivotGridControl1.Location = new System.Drawing.Point(0, 0);
            this.myPivotGridControl1.Name = "myPivotGridControl1";
            this.myPivotGridControl1.Size = new System.Drawing.Size(891, 574);
            this.myPivotGridControl1.TabIndex = 0;
            this.myPivotGridControl1.Leave += new System.EventHandler(this.myPivotGridControl1_Leave);
            // 
            // fieldCategoryName
            // 
            this.fieldCategoryName.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.fieldCategoryName.AreaIndex = 0;
            this.fieldCategoryName.Caption = "Category Name";
            this.fieldCategoryName.FieldName = "CategoryName";
            this.fieldCategoryName.Name = "fieldCategoryName";
            // 
            // fieldExtendedPrice
            // 
            this.fieldExtendedPrice.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldExtendedPrice.AreaIndex = 0;
            this.fieldExtendedPrice.Caption = "Extended Price";
            this.fieldExtendedPrice.FieldName = "Extended Price";
            this.fieldExtendedPrice.Name = "fieldExtendedPrice";
            // 
            // fieldSalesPerson
            // 
            this.fieldSalesPerson.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldSalesPerson.AreaIndex = 0;
            this.fieldSalesPerson.Caption = "Sales Person";
            this.fieldSalesPerson.FieldName = "Sales Person";
            this.fieldSalesPerson.Name = "fieldSalesPerson";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 574);
            this.Controls.Add(this.myPivotGridControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nwindDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myPivotGridControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private nwindDataSet nwindDataSet;
        private System.Windows.Forms.BindingSource bindingSource1;
        private Q200703.nwindDataSetTableAdapters.SalesPersonTableAdapter salesPersonTableAdapter;
        private DXSample.MyPivotGridControl myPivotGridControl1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldCategoryName;
        private DevExpress.XtraPivotGrid.PivotGridField fieldExtendedPrice;
        private DevExpress.XtraPivotGrid.PivotGridField fieldSalesPerson;

    }
}

