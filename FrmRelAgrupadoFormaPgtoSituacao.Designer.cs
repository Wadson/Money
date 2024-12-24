namespace Money
{
    partial class FrmRelAgrupadoFormaPgtoSituacao
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
            this.AgrupagoFormaPgtoSituacaoPeriodoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bdfinancaDataSet = new Money.bdfinancaDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dt_Final = new System.Windows.Forms.DateTimePicker();
            this.dt_Inicial = new System.Windows.Forms.DateTimePicker();
            this.lbl_ate = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rb_nao_pagos = new System.Windows.Forms.RadioButton();
            this.rb_pago = new System.Windows.Forms.RadioButton();
            this.AgrupagoFormaPgtoSituacaoPeriodoTableAdapter = new Money.bdfinancaDataSetTableAdapters.AgrupagoFormaPgtoSituacaoPeriodoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.AgrupagoFormaPgtoSituacaoPeriodoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdfinancaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // AgrupagoFormaPgtoSituacaoPeriodoBindingSource
            // 
            this.AgrupagoFormaPgtoSituacaoPeriodoBindingSource.DataMember = "AgrupagoFormaPgtoSituacaoPeriodo";
            this.AgrupagoFormaPgtoSituacaoPeriodoBindingSource.DataSource = this.bdfinancaDataSet;
            // 
            // bdfinancaDataSet
            // 
            this.bdfinancaDataSet.DataSetName = "bdfinancaDataSet";
            this.bdfinancaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.AgrupagoFormaPgtoSituacaoPeriodoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Money.Relatórios.Rel_AgrupadoFormaPgtoPeriodoSituacao.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(2, 53);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(360, 444);
            this.reportViewer1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Money.Properties.Resources.app;
            this.pictureBox1.Location = new System.Drawing.Point(2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(45, 45);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 313;
            this.pictureBox1.TabStop = false;
            // 
            // dt_Final
            // 
            this.dt_Final.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_Final.Location = new System.Drawing.Point(262, 2);
            this.dt_Final.Name = "dt_Final";
            this.dt_Final.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dt_Final.Size = new System.Drawing.Size(100, 20);
            this.dt_Final.TabIndex = 311;
            // 
            // dt_Inicial
            // 
            this.dt_Inicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_Inicial.Location = new System.Drawing.Point(150, 2);
            this.dt_Inicial.Name = "dt_Inicial";
            this.dt_Inicial.Size = new System.Drawing.Size(100, 20);
            this.dt_Inicial.TabIndex = 310;
            // 
            // lbl_ate
            // 
            this.lbl_ate.AutoSize = true;
            this.lbl_ate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(182)))));
            this.lbl_ate.Location = new System.Drawing.Point(249, 6);
            this.lbl_ate.Name = "lbl_ate";
            this.lbl_ate.Size = new System.Drawing.Size(13, 13);
            this.lbl_ate.TabIndex = 312;
            this.lbl_ate.Text = "a";
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(182)))));
            this.btnOK.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnOK.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOK.ForeColor = System.Drawing.Color.White;
            this.btnOK.Location = new System.Drawing.Point(150, 24);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(212, 23);
            this.btnOK.TabIndex = 309;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rb_nao_pagos);
            this.groupBox1.Controls.Add(this.rb_pago);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(182)))));
            this.groupBox1.Location = new System.Drawing.Point(53, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(95, 43);
            this.groupBox1.TabIndex = 308;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Status(Pago?)";
            // 
            // rb_nao_pagos
            // 
            this.rb_nao_pagos.AutoSize = true;
            this.rb_nao_pagos.Checked = true;
            this.rb_nao_pagos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(182)))));
            this.rb_nao_pagos.Location = new System.Drawing.Point(48, 18);
            this.rb_nao_pagos.Name = "rb_nao_pagos";
            this.rb_nao_pagos.Size = new System.Drawing.Size(45, 17);
            this.rb_nao_pagos.TabIndex = 1;
            this.rb_nao_pagos.TabStop = true;
            this.rb_nao_pagos.Text = "Não";
            this.rb_nao_pagos.UseVisualStyleBackColor = true;
            // 
            // rb_pago
            // 
            this.rb_pago.AutoSize = true;
            this.rb_pago.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(182)))));
            this.rb_pago.Location = new System.Drawing.Point(6, 18);
            this.rb_pago.Name = "rb_pago";
            this.rb_pago.Size = new System.Drawing.Size(42, 17);
            this.rb_pago.TabIndex = 2;
            this.rb_pago.Text = "Sim";
            this.rb_pago.UseVisualStyleBackColor = true;
            // 
            // AgrupagoFormaPgtoSituacaoPeriodoTableAdapter
            // 
            this.AgrupagoFormaPgtoSituacaoPeriodoTableAdapter.ClearBeforeFill = true;
            // 
            // FrmRelAgrupadoFormaPgtoSituacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 494);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dt_Final);
            this.Controls.Add(this.dt_Inicial);
            this.Controls.Add(this.lbl_ate);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmRelAgrupadoFormaPgtoSituacao";
            this.Text = "FrmRelAgrupadoFormaPgtoSituacao";
            this.Load += new System.EventHandler(this.FrmRelAgrupadoFormaPgtoSituacao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AgrupagoFormaPgtoSituacaoPeriodoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdfinancaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DateTimePicker dt_Final;
        private System.Windows.Forms.DateTimePicker dt_Inicial;
        private System.Windows.Forms.Label lbl_ate;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rb_nao_pagos;
        private System.Windows.Forms.RadioButton rb_pago;
        private System.Windows.Forms.BindingSource AgrupagoFormaPgtoSituacaoPeriodoBindingSource;
        private bdfinancaDataSet bdfinancaDataSet;
        private bdfinancaDataSetTableAdapters.AgrupagoFormaPgtoSituacaoPeriodoTableAdapter AgrupagoFormaPgtoSituacaoPeriodoTableAdapter;
    }
}