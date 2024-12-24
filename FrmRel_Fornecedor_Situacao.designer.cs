namespace Money
{
    partial class FrmRel_Fornecedor_Situacao
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
            this.Fornecedor_e_SituacaoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bdfinancaDataSet = new Money.bdfinancaDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.Fornecedor_e_SituacaoTableAdapter = new Money.bdfinancaDataSetTableAdapters.Fornecedor_e_SituacaoTableAdapter();
            this.btnOK = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rb_nao_pagos = new System.Windows.Forms.RadioButton();
            this.rb_pago = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_Forn = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Fornecedor_e_SituacaoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdfinancaDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(2, 558);
            this.panel2.Size = new System.Drawing.Size(541, 2);
            // 
            // panel3
            // 
            this.panel3.Size = new System.Drawing.Size(541, 25);
            // 
            // panel4
            // 
            this.panel4.Size = new System.Drawing.Size(2, 560);
            // 
            // panel5
            // 
            this.panel5.Location = new System.Drawing.Point(543, 0);
            this.panel5.Size = new System.Drawing.Size(2, 560);
            // 
            // btnExit
            // 
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.Location = new System.Drawing.Point(519, 3);
            // 
            // Fornecedor_e_SituacaoBindingSource
            // 
            this.Fornecedor_e_SituacaoBindingSource.DataMember = "Fornecedor_e_Situacao";
            this.Fornecedor_e_SituacaoBindingSource.DataSource = this.bdfinancaDataSet;
            // 
            // bdfinancaDataSet
            // 
            this.bdfinancaDataSet.DataSetName = "bdfinancaDataSet";
            this.bdfinancaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.Fornecedor_e_SituacaoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Money.Relatórios.Rel_Fornecedor_Situacao.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(-3, 102);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(549, 489);
            this.reportViewer1.TabIndex = 0;
            // 
            // Fornecedor_e_SituacaoTableAdapter
            // 
            this.Fornecedor_e_SituacaoTableAdapter.ClearBeforeFill = true;
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(182)))));
            this.btnOK.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnOK.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOK.ForeColor = System.Drawing.Color.White;
            this.btnOK.Location = new System.Drawing.Point(164, 59);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(186, 23);
            this.btnOK.TabIndex = 16;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rb_nao_pagos);
            this.groupBox1.Controls.Add(this.rb_pago);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(69, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(94, 51);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Status ( Pago? )";
            // 
            // rb_nao_pagos
            // 
            this.rb_nao_pagos.AutoSize = true;
            this.rb_nao_pagos.Checked = true;
            this.rb_nao_pagos.Location = new System.Drawing.Point(46, 18);
            this.rb_nao_pagos.Name = "rb_nao_pagos";
            this.rb_nao_pagos.Size = new System.Drawing.Size(49, 20);
            this.rb_nao_pagos.TabIndex = 1;
            this.rb_nao_pagos.TabStop = true;
            this.rb_nao_pagos.Text = "Não";
            this.rb_nao_pagos.UseVisualStyleBackColor = true;
            // 
            // rb_pago
            // 
            this.rb_pago.AutoSize = true;
            this.rb_pago.Location = new System.Drawing.Point(4, 18);
            this.rb_pago.Name = "rb_pago";
            this.rb_pago.Size = new System.Drawing.Size(44, 20);
            this.rb_pago.TabIndex = 2;
            this.rb_pago.Text = "Sim";
            this.rb_pago.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(154, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 16);
            this.label1.TabIndex = 14;
            this.label1.Text = "Fornecedor";
            // 
            // cmb_Forn
            // 
            this.cmb_Forn.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmb_Forn.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb_Forn.FormattingEnabled = true;
            this.cmb_Forn.Location = new System.Drawing.Point(164, 36);
            this.cmb_Forn.Name = "cmb_Forn";
            this.cmb_Forn.Size = new System.Drawing.Size(186, 24);
            this.cmb_Forn.TabIndex = 13;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Money.Properties.Resources.growth;
            this.pictureBox1.Location = new System.Drawing.Point(7, 36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 46);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 294;
            this.pictureBox1.TabStop = false;
            // 
            // FrmRel_Fornecedor_Situacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(545, 560);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmb_Forn);
            this.Controls.Add(this.reportViewer1);
            this.MinimizeBox = false;
            this.Name = "FrmRel_Fornecedor_Situacao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Money - Relatório Fornecedor e Periodo";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Frm_Rel_Fornecedor_Situacao_FormClosing);
            this.Load += new System.EventHandler(this.Frm_Rel_Fornecedor_Periodo_Load);
            this.Controls.SetChildIndex(this.reportViewer1, 0);
            this.Controls.SetChildIndex(this.cmb_Forn, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.btnOK, 0);
            this.Controls.SetChildIndex(this.pictureBox1, 0);
            this.Controls.SetChildIndex(this.panel5, 0);
            this.Controls.SetChildIndex(this.panel4, 0);
            this.Controls.SetChildIndex(this.panel3, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Fornecedor_e_SituacaoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdfinancaDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource Fornecedor_e_SituacaoBindingSource;
        private bdfinancaDataSet bdfinancaDataSet;
        private bdfinancaDataSetTableAdapters.Fornecedor_e_SituacaoTableAdapter Fornecedor_e_SituacaoTableAdapter;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rb_nao_pagos;
        private System.Windows.Forms.RadioButton rb_pago;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_Forn;
        private System.Windows.Forms.PictureBox pictureBox1;
  
    }
}