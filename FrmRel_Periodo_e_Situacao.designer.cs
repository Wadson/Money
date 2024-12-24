namespace Money
{
    partial class FrmRel_Periodo_e_Situacao
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
            this.PeriodoSituacaoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bdfinancaDataSet = new Money.bdfinancaDataSet();
            this.Periodo_e_SituacaoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PeriodoSituacaoTableAdapter = new Money.bdfinancaDataSetTableAdapters.PeriodoSituacaoTableAdapter();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rb_nao_pagos = new System.Windows.Forms.RadioButton();
            this.rb_pago = new System.Windows.Forms.RadioButton();
            this.dt_Final = new System.Windows.Forms.DateTimePicker();
            this.dt_Inicial = new System.Windows.Forms.DateTimePicker();
            this.lbl_ate = new System.Windows.Forms.Label();
            this.btn_ok = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PeriodoSituacaoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdfinancaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Periodo_e_SituacaoBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // PeriodoSituacaoBindingSource
            // 
            this.PeriodoSituacaoBindingSource.DataMember = "PeriodoSituacao";
            this.PeriodoSituacaoBindingSource.DataSource = this.bdfinancaDataSet;
            // 
            // bdfinancaDataSet
            // 
            this.bdfinancaDataSet.DataSetName = "bdfinancaDataSet";
            this.bdfinancaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Periodo_e_SituacaoBindingSource
            // 
            this.Periodo_e_SituacaoBindingSource.DataMember = "Periodo_e_Situacao";
            this.Periodo_e_SituacaoBindingSource.DataSource = this.bdfinancaDataSet;
            // 
            // PeriodoSituacaoTableAdapter
            // 
            this.PeriodoSituacaoTableAdapter.ClearBeforeFill = true;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.PeriodoSituacaoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Money.Relatórios.RelPeriodoSituacao.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 66);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(543, 493);
            this.reportViewer1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rb_nao_pagos);
            this.groupBox1.Controls.Add(this.rb_pago);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(53, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(90, 49);
            this.groupBox1.TabIndex = 297;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Status(Pagas?)";
            // 
            // rb_nao_pagos
            // 
            this.rb_nao_pagos.AutoSize = true;
            this.rb_nao_pagos.Checked = true;
            this.rb_nao_pagos.Location = new System.Drawing.Point(45, 19);
            this.rb_nao_pagos.Name = "rb_nao_pagos";
            this.rb_nao_pagos.Size = new System.Drawing.Size(45, 17);
            this.rb_nao_pagos.TabIndex = 0;
            this.rb_nao_pagos.TabStop = true;
            this.rb_nao_pagos.Text = "Não";
            this.rb_nao_pagos.UseVisualStyleBackColor = true;
            // 
            // rb_pago
            // 
            this.rb_pago.AutoSize = true;
            this.rb_pago.Location = new System.Drawing.Point(4, 19);
            this.rb_pago.Name = "rb_pago";
            this.rb_pago.Size = new System.Drawing.Size(42, 17);
            this.rb_pago.TabIndex = 1;
            this.rb_pago.Text = "Sim";
            this.rb_pago.UseVisualStyleBackColor = true;
            // 
            // dt_Final
            // 
            this.dt_Final.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_Final.Location = new System.Drawing.Point(260, 12);
            this.dt_Final.Name = "dt_Final";
            this.dt_Final.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dt_Final.Size = new System.Drawing.Size(96, 20);
            this.dt_Final.TabIndex = 294;
            // 
            // dt_Inicial
            // 
            this.dt_Inicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_Inicial.Location = new System.Drawing.Point(145, 12);
            this.dt_Inicial.Name = "dt_Inicial";
            this.dt_Inicial.Size = new System.Drawing.Size(96, 20);
            this.dt_Inicial.TabIndex = 293;
            // 
            // lbl_ate
            // 
            this.lbl_ate.AutoSize = true;
            this.lbl_ate.ForeColor = System.Drawing.Color.White;
            this.lbl_ate.Location = new System.Drawing.Point(244, 16);
            this.lbl_ate.Name = "lbl_ate";
            this.lbl_ate.Size = new System.Drawing.Size(13, 13);
            this.lbl_ate.TabIndex = 296;
            this.lbl_ate.Text = "a";
            // 
            // btn_ok
            // 
            this.btn_ok.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(182)))));
            this.btn_ok.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_ok.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_ok.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ok.ForeColor = System.Drawing.Color.White;
            this.btn_ok.Location = new System.Drawing.Point(145, 38);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(210, 22);
            this.btn_ok.TabIndex = 295;
            this.btn_ok.Text = "&OK";
            this.btn_ok.UseVisualStyleBackColor = false;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Money.Properties.Resources.rising;
            this.pictureBox1.Location = new System.Drawing.Point(2, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(49, 61);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 298;
            this.pictureBox1.TabStop = false;
            // 
            // FrmRel_Periodo_e_Situacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(543, 560);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dt_Final);
            this.Controls.Add(this.dt_Inicial);
            this.Controls.Add(this.lbl_ate);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MinimizeBox = false;
            this.Name = "FrmRel_Periodo_e_Situacao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Money - Relatório de contas por Período e Situação";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Frm_Rel_Periodo_e_Situacao_FormClosing);
            this.Load += new System.EventHandler(this.Frm_Rel_Periodo_e_Situacao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PeriodoSituacaoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdfinancaDataSet)).EndInit();
            //((System.ComponentModel.ISupportInitialize)(this.Periodo_e_SituacaoBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource Periodo_e_SituacaoBindingSource;
        private bdfinancaDataSet bdfinancaDataSet;
        private System.Windows.Forms.BindingSource PeriodoSituacaoBindingSource;
        private bdfinancaDataSetTableAdapters.PeriodoSituacaoTableAdapter PeriodoSituacaoTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rb_nao_pagos;
        private System.Windows.Forms.RadioButton rb_pago;
        private System.Windows.Forms.DateTimePicker dt_Final;
        private System.Windows.Forms.DateTimePicker dt_Inicial;
        private System.Windows.Forms.Label lbl_ate;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.PictureBox pictureBox1;
      

      
    }
}