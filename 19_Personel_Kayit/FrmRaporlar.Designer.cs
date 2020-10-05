namespace _19_Personel_Kayit
{
    partial class FrmRaporlar
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.Tbl_PersonelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PersonelVeriTabaniDataSet1 = new _19_Personel_Kayit.PersonelVeriTabaniDataSet1();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.Tbl_PersonelTableAdapter = new _19_Personel_Kayit.PersonelVeriTabaniDataSet1TableAdapters.Tbl_PersonelTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.Tbl_PersonelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PersonelVeriTabaniDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // Tbl_PersonelBindingSource
            // 
            this.Tbl_PersonelBindingSource.DataMember = "Tbl_Personel";
            this.Tbl_PersonelBindingSource.DataSource = this.PersonelVeriTabaniDataSet1;
            // 
            // PersonelVeriTabaniDataSet1
            // 
            this.PersonelVeriTabaniDataSet1.DataSetName = "PersonelVeriTabaniDataSet1";
            this.PersonelVeriTabaniDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.Tbl_PersonelBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "_19_Personel_Kayit.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(833, 594);
            this.reportViewer1.TabIndex = 0;
            // 
            // Tbl_PersonelTableAdapter
            // 
            this.Tbl_PersonelTableAdapter.ClearBeforeFill = true;
            // 
            // FrmRaporlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 594);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FrmRaporlar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmRaporlar";
            this.Load += new System.EventHandler(this.FrmRaporlar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Tbl_PersonelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PersonelVeriTabaniDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource Tbl_PersonelBindingSource;
        private PersonelVeriTabaniDataSet1 PersonelVeriTabaniDataSet1;
        private PersonelVeriTabaniDataSet1TableAdapters.Tbl_PersonelTableAdapter Tbl_PersonelTableAdapter;
    }
}