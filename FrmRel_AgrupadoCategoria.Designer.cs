namespace Money
{
    partial class FrmRel_AgrupadoCategoria
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
            this.categoriaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bdfinancaDataSet = new Money.bdfinancaDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.subcategoriaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.subcategoriaTableAdapter = new Money.bdfinancaDataSetTableAdapters.subcategoriaTableAdapter();
            this.categoriaTableAdapter = new Money.bdfinancaDataSetTableAdapters.categoriaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdfinancaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subcategoriaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // categoriaBindingSource
            // 
            this.categoriaBindingSource.DataMember = "categoria";
            this.categoriaBindingSource.DataSource = this.bdfinancaDataSet;
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
            reportDataSource1.Value = this.categoriaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Money.Relatórios.Rel_AgrupadoCentroCusto.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(543, 560);
            this.reportViewer1.TabIndex = 0;
            // 
            // subcategoriaBindingSource
            // 
            this.subcategoriaBindingSource.DataMember = "subcategoria";
            this.subcategoriaBindingSource.DataSource = this.bdfinancaDataSet;
            // 
            // subcategoriaTableAdapter
            // 
            this.subcategoriaTableAdapter.ClearBeforeFill = true;
            // 
            // categoriaTableAdapter
            // 
            this.categoriaTableAdapter.ClearBeforeFill = true;
            // 
            // FrmRel_AgrupadoCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 560);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmRel_AgrupadoCategoria";
            this.Text = "Money - Relatório Agrupado por Categoria";
            this.Load += new System.EventHandler(this.FrmRel_AgrupadoCategoria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.categoriaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdfinancaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subcategoriaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource subcategoriaBindingSource;
        private bdfinancaDataSet bdfinancaDataSet;
        private bdfinancaDataSetTableAdapters.subcategoriaTableAdapter subcategoriaTableAdapter;
        private System.Windows.Forms.BindingSource categoriaBindingSource;
        private bdfinancaDataSetTableAdapters.categoriaTableAdapter categoriaTableAdapter;
    }
}