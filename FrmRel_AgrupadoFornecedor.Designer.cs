namespace Money
{
    partial class FrmRel_AgrupadoFornecedor
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
            this.Fornecedor_AgrupadoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bdfinancaDataSet = new Money.bdfinancaDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.Fornecedor_AgrupadoTableAdapter = new Money.bdfinancaDataSetTableAdapters.Fornecedor_AgrupadoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.Fornecedor_AgrupadoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdfinancaDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // Fornecedor_AgrupadoBindingSource
            // 
            this.Fornecedor_AgrupadoBindingSource.DataMember = "Fornecedor_Agrupado";
            this.Fornecedor_AgrupadoBindingSource.DataSource = this.bdfinancaDataSet;
            // 
            // bdfinancaDataSet
            // 
            this.bdfinancaDataSet.DataSetName = "bdfinancaDataSet";
            this.bdfinancaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.Fornecedor_AgrupadoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Money.Relatórios.Rel_FornecedorAgrupado.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(543, 560);
            this.reportViewer1.TabIndex = 0;
            // 
            // Fornecedor_AgrupadoTableAdapter
            // 
            this.Fornecedor_AgrupadoTableAdapter.ClearBeforeFill = true;
            // 
            // FrmRel_AgrupadoFornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 560);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmRel_AgrupadoFornecedor";
            this.Text = "Money - Relatório  Agrupado por Fornecedor";
            this.Load += new System.EventHandler(this.FrmRel_AgrupadoFornecedor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Fornecedor_AgrupadoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdfinancaDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource Fornecedor_AgrupadoBindingSource;
        private bdfinancaDataSet bdfinancaDataSet;
        private bdfinancaDataSetTableAdapters.Fornecedor_AgrupadoTableAdapter Fornecedor_AgrupadoTableAdapter;

    }
}