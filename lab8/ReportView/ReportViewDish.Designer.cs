namespace lab8.ReportView
{
    partial class ReportViewDish
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.restaurantAppDataSet = new lab8.RestaurantAppDataSet();
            this.journalSalesTableAdapter = new lab8.RestaurantAppDataSetTableAdapters.JournalSalesTableAdapter();
            this.journalSalesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dishesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dishesTableAdapter = new lab8.RestaurantAppDataSetTableAdapters.DishesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.restaurantAppDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.journalSalesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dishesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // restaurantAppDataSet
            // 
            this.restaurantAppDataSet.DataSetName = "RestaurantAppDataSet";
            this.restaurantAppDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // journalSalesTableAdapter
            // 
            this.journalSalesTableAdapter.ClearBeforeFill = true;
            // 
            // journalSalesBindingSource
            // 
            this.journalSalesBindingSource.DataMember = "JournalSales";
            this.journalSalesBindingSource.DataSource = this.restaurantAppDataSet;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.dishesBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "lab8.ReportFile.ReportDish.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 12);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(776, 426);
            this.reportViewer1.TabIndex = 0;
            // 
            // dishesBindingSource
            // 
            this.dishesBindingSource.DataMember = "Dishes";
            this.dishesBindingSource.DataSource = this.restaurantAppDataSet;
            // 
            // dishesTableAdapter
            // 
            this.dishesTableAdapter.ClearBeforeFill = true;
            // 
            // ReportViewDish
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ReportViewDish";
            this.Text = "ReportViewDish";
            this.Load += new System.EventHandler(this.ReportViewDish_Load);
            ((System.ComponentModel.ISupportInitialize)(this.restaurantAppDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.journalSalesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dishesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private RestaurantAppDataSet restaurantAppDataSet;
        private RestaurantAppDataSetTableAdapters.JournalSalesTableAdapter journalSalesTableAdapter;
        private System.Windows.Forms.BindingSource journalSalesBindingSource;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource dishesBindingSource;
        private RestaurantAppDataSetTableAdapters.DishesTableAdapter dishesTableAdapter;
    }
}