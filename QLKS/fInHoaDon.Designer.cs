namespace QLKS
{
    partial class fInHoaDon
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dtSet_InHoaDon = new QLKS.dtSet_InHoaDon();
            this.udf_InHoaDonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.udf_InHoaDonTableAdapter = new QLKS.dtSet_InHoaDonTableAdapters.udf_InHoaDonTableAdapter();
            this.QLKSDataSet = new QLKS.QLKSDataSet();
            this.USP_InThongKeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.USP_InThongKeTableAdapter = new QLKS.QLKSDataSetTableAdapters.USP_InThongKeTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dtSet_InHoaDon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udf_InHoaDonBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QLKSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.USP_InThongKeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.udf_InHoaDonBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QLKS.Report2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(26, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(470, 372);
            this.reportViewer1.TabIndex = 0;
            // 
            // dtSet_InHoaDon
            // 
            this.dtSet_InHoaDon.DataSetName = "dtSet_InHoaDon";
            this.dtSet_InHoaDon.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // udf_InHoaDonBindingSource
            // 
            this.udf_InHoaDonBindingSource.DataMember = "udf_InHoaDon";
            this.udf_InHoaDonBindingSource.DataSource = this.dtSet_InHoaDon;
            // 
            // udf_InHoaDonTableAdapter
            // 
            this.udf_InHoaDonTableAdapter.ClearBeforeFill = true;
            // 
            // QLKSDataSet
            // 
            this.QLKSDataSet.DataSetName = "QLKSDataSet";
            this.QLKSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // USP_InThongKeBindingSource
            // 
            this.USP_InThongKeBindingSource.DataMember = "USP_InThongKe";
            this.USP_InThongKeBindingSource.DataSource = this.QLKSDataSet;
            // 
            // USP_InThongKeTableAdapter
            // 
            this.USP_InThongKeTableAdapter.ClearBeforeFill = true;
            // 
            // fInHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 400);
            this.Controls.Add(this.reportViewer1);
            this.Name = "fInHoaDon";
            this.Text = "fInHoaDon";
            this.Load += new System.EventHandler(this.fInHoaDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtSet_InHoaDon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udf_InHoaDonBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QLKSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.USP_InThongKeBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource udf_InHoaDonBindingSource;
        private dtSet_InHoaDon dtSet_InHoaDon;
        private dtSet_InHoaDonTableAdapters.udf_InHoaDonTableAdapter udf_InHoaDonTableAdapter;
        private System.Windows.Forms.BindingSource USP_InThongKeBindingSource;
        private QLKSDataSet QLKSDataSet;
        private QLKSDataSetTableAdapters.USP_InThongKeTableAdapter USP_InThongKeTableAdapter;
    }
}