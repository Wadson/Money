﻿namespace Money
{
    partial class FrmGerarParcelas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGerarParcelas));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtDias = new System.Windows.Forms.NumericUpDown();
            this.label16 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtQtdParcelas = new System.Windows.Forms.NumericUpDown();
            this.dtPrimeiraParc = new System.Windows.Forms.DateTimePicker();
            this.dataGrid_Parcelas = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtIdVenda = new System.Windows.Forms.TextBox();
            this.txtNomeCliente = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.id_parcela = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.num_parcela = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valor_parcela = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dt_vcto_parcela = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_venda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDias)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQtdParcelas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_Parcelas)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(2, 470);
            this.panel2.Size = new System.Drawing.Size(601, 2);
            // 
            // panel3
            // 
            this.panel3.Size = new System.Drawing.Size(601, 25);
            // 
            // panel4
            // 
            this.panel4.Size = new System.Drawing.Size(2, 472);
            // 
            // panel5
            // 
            this.panel5.Location = new System.Drawing.Point(603, 0);
            this.panel5.Size = new System.Drawing.Size(2, 472);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.Location = new System.Drawing.Point(1465, 3);
            // 
            // txtDias
            // 
            this.txtDias.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.75F);
            this.txtDias.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(182)))));
            this.txtDias.Location = new System.Drawing.Point(15, 286);
            this.txtDias.Margin = new System.Windows.Forms.Padding(4);
            this.txtDias.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtDias.Name = "txtDias";
            this.txtDias.Size = new System.Drawing.Size(185, 36);
            this.txtDias.TabIndex = 508;
            this.txtDias.TabStop = false;
            this.txtDias.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDias.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.AntiqueWhite;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(15, 194);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(182, 16);
            this.label16.TabIndex = 514;
            this.label16.Text = "Data 1º Parcela                           ";
            // 
            // txtTotal
            // 
            this.txtTotal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.75F);
            this.txtTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtTotal.Location = new System.Drawing.Point(15, 147);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(4);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(185, 36);
            this.txtTotal.TabIndex = 504;
            this.txtTotal.TabStop = false;
            this.txtTotal.Text = "0,00";
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtQtdParcelas
            // 
            this.txtQtdParcelas.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.75F);
            this.txtQtdParcelas.Location = new System.Drawing.Point(15, 354);
            this.txtQtdParcelas.Margin = new System.Windows.Forms.Padding(4);
            this.txtQtdParcelas.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.txtQtdParcelas.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtQtdParcelas.Name = "txtQtdParcelas";
            this.txtQtdParcelas.Size = new System.Drawing.Size(185, 36);
            this.txtQtdParcelas.TabIndex = 515;
            this.txtQtdParcelas.TabStop = false;
            this.txtQtdParcelas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtQtdParcelas.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtQtdParcelas.ValueChanged += new System.EventHandler(this.txtQtdParcelas_ValueChanged);
            // 
            // dtPrimeiraParc
            // 
            this.dtPrimeiraParc.CalendarForeColor = System.Drawing.Color.Blue;
            this.dtPrimeiraParc.CalendarTitleForeColor = System.Drawing.Color.AliceBlue;
            this.dtPrimeiraParc.CustomFormat = "dd/MM/yyyy";
            this.dtPrimeiraParc.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtPrimeiraParc.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.75F);
            this.dtPrimeiraParc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtPrimeiraParc.Location = new System.Drawing.Point(15, 212);
            this.dtPrimeiraParc.Margin = new System.Windows.Forms.Padding(4);
            this.dtPrimeiraParc.Name = "dtPrimeiraParc";
            this.dtPrimeiraParc.Size = new System.Drawing.Size(185, 36);
            this.dtPrimeiraParc.TabIndex = 513;
            // 
            // dataGrid_Parcelas
            // 
            this.dataGrid_Parcelas.AllowUserToAddRows = false;
            this.dataGrid_Parcelas.AllowUserToDeleteRows = false;
            this.dataGrid_Parcelas.AllowUserToResizeColumns = false;
            this.dataGrid_Parcelas.AllowUserToResizeRows = false;
            this.dataGrid_Parcelas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGrid_Parcelas.BackgroundColor = System.Drawing.Color.White;
            this.dataGrid_Parcelas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGrid_Parcelas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGrid_Parcelas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(76)))), ((int)(((byte)(172)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGrid_Parcelas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGrid_Parcelas.ColumnHeadersHeight = 20;
            this.dataGrid_Parcelas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_parcela,
            this.num_parcela,
            this.valor_parcela,
            this.dt_vcto_parcela,
            this.id_venda});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(76)))), ((int)(((byte)(172)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGrid_Parcelas.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGrid_Parcelas.EnableHeadersVisualStyles = false;
            this.dataGrid_Parcelas.GridColor = System.Drawing.Color.SteelBlue;
            this.dataGrid_Parcelas.Location = new System.Drawing.Point(208, 130);
            this.dataGrid_Parcelas.Margin = new System.Windows.Forms.Padding(4);
            this.dataGrid_Parcelas.Name = "dataGrid_Parcelas";
            this.dataGrid_Parcelas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(76)))), ((int)(((byte)(172)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGrid_Parcelas.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGrid_Parcelas.RowHeadersWidth = 20;
            this.dataGrid_Parcelas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGrid_Parcelas.Size = new System.Drawing.Size(389, 260);
            this.dataGrid_Parcelas.TabIndex = 519;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.75F);
            this.label2.Location = new System.Drawing.Point(203, 28);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 29);
            this.label2.TabIndex = 527;
            this.label2.Text = "Gerar Parcelas";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.AntiqueWhite;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.75F);
            this.label1.Location = new System.Drawing.Point(16, 130);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 18);
            this.label1.TabIndex = 522;
            this.label1.Text = "Valor Total                          ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.AntiqueWhite;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.75F);
            this.label4.Location = new System.Drawing.Point(15, 336);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(182, 18);
            this.label4.TabIndex = 526;
            this.label4.Text = "Nº Parcela                          ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.AntiqueWhite;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label9.Location = new System.Drawing.Point(12, 62);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(101, 17);
            this.label9.TabIndex = 533;
            this.label9.Text = "Código Venda:";
            // 
            // txtIdVenda
            // 
            this.txtIdVenda.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtIdVenda.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.txtIdVenda.Location = new System.Drawing.Point(15, 83);
            this.txtIdVenda.Name = "txtIdVenda";
            this.txtIdVenda.ReadOnly = true;
            this.txtIdVenda.Size = new System.Drawing.Size(98, 24);
            this.txtIdVenda.TabIndex = 532;
            this.txtIdVenda.TabStop = false;
            this.txtIdVenda.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtNomeCliente
            // 
            this.txtNomeCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNomeCliente.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.txtNomeCliente.Location = new System.Drawing.Point(120, 83);
            this.txtNomeCliente.Name = "txtNomeCliente";
            this.txtNomeCliente.ReadOnly = true;
            this.txtNomeCliente.Size = new System.Drawing.Size(473, 24);
            this.txtNomeCliente.TabIndex = 530;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.AntiqueWhite;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label14.Location = new System.Drawing.Point(119, 61);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(55, 17);
            this.label14.TabIndex = 531;
            this.label14.Text = "Cliente:";
            // 
            // btnFechar
            // 
            this.btnFechar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnFechar.BackColor = System.Drawing.Color.AntiqueWhite;
            this.btnFechar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnFechar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(182)))));
            this.btnFechar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Moccasin;
            this.btnFechar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.Image = global::Money.Properties.Resources.sair;
            this.btnFechar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFechar.Location = new System.Drawing.Point(493, 410);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(100, 37);
            this.btnFechar.TabIndex = 537;
            this.btnFechar.Text = "&Fechar";
            this.btnFechar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFechar.UseVisualStyleBackColor = false;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnFinalizar.BackColor = System.Drawing.Color.AntiqueWhite;
            this.btnFinalizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnFinalizar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(182)))));
            this.btnFinalizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnFinalizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.btnFinalizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinalizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinalizar.Image = ((System.Drawing.Image)(resources.GetObject("btnFinalizar.Image")));
            this.btnFinalizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFinalizar.Location = new System.Drawing.Point(387, 409);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(100, 37);
            this.btnFinalizar.TabIndex = 538;
            this.btnFinalizar.Text = "&Salvar";
            this.btnFinalizar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFinalizar.UseVisualStyleBackColor = false;
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.AntiqueWhite;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.75F);
            this.label3.Location = new System.Drawing.Point(15, 264);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 18);
            this.label3.TabIndex = 539;
            this.label3.Text = "Intervalo entre parcelas";
            // 
            // id_parcela
            // 
            this.id_parcela.DataPropertyName = "id_parcela";
            this.id_parcela.DividerWidth = 1;
            this.id_parcela.HeaderText = "Cód. Parc";
            this.id_parcela.Name = "id_parcela";
            this.id_parcela.Width = 90;
            // 
            // num_parcela
            // 
            this.num_parcela.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.num_parcela.DataPropertyName = "num_parcela";
            this.num_parcela.DividerWidth = 1;
            this.num_parcela.HeaderText = "Nº Parc";
            this.num_parcela.Name = "num_parcela";
            this.num_parcela.Width = 60;
            // 
            // valor_parcela
            // 
            this.valor_parcela.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.valor_parcela.DataPropertyName = "valor_parcela";
            this.valor_parcela.DividerWidth = 1;
            this.valor_parcela.HeaderText = "Valor Parc";
            this.valor_parcela.Name = "valor_parcela";
            // 
            // dt_vcto_parcela
            // 
            this.dt_vcto_parcela.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dt_vcto_parcela.DataPropertyName = "dt_vcto_parcela";
            dataGridViewCellStyle2.Format = "d";
            dataGridViewCellStyle2.NullValue = null;
            this.dt_vcto_parcela.DefaultCellStyle = dataGridViewCellStyle2;
            this.dt_vcto_parcela.DividerWidth = 1;
            this.dt_vcto_parcela.HeaderText = "Data Vencto";
            this.dt_vcto_parcela.Name = "dt_vcto_parcela";
            // 
            // id_venda
            // 
            this.id_venda.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.id_venda.DataPropertyName = "id_venda";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.id_venda.DefaultCellStyle = dataGridViewCellStyle3;
            this.id_venda.DividerWidth = 1;
            this.id_venda.HeaderText = "Cód. Venda";
            this.id_venda.Name = "id_venda";
            this.id_venda.Width = 102;
            // 
            // FrmGerarParcelas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 472);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnFinalizar);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtIdVenda);
            this.Controls.Add(this.txtNomeCliente);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtQtdParcelas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGrid_Parcelas);
            this.Controls.Add(this.txtDias);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.dtPrimeiraParc);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FrmGerarParcelas";
            this.Text = "FrmGerarParcelas";
            this.Load += new System.EventHandler(this.FrmGerarParcelas_Load);
            this.Controls.SetChildIndex(this.dtPrimeiraParc, 0);
            this.Controls.SetChildIndex(this.txtTotal, 0);
            this.Controls.SetChildIndex(this.label16, 0);
            this.Controls.SetChildIndex(this.txtDias, 0);
            this.Controls.SetChildIndex(this.dataGrid_Parcelas, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.txtQtdParcelas, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.label14, 0);
            this.Controls.SetChildIndex(this.txtNomeCliente, 0);
            this.Controls.SetChildIndex(this.txtIdVenda, 0);
            this.Controls.SetChildIndex(this.label9, 0);
            this.Controls.SetChildIndex(this.panel5, 0);
            this.Controls.SetChildIndex(this.panel4, 0);
            this.Controls.SetChildIndex(this.panel3, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.btnFechar, 0);
            this.Controls.SetChildIndex(this.btnFinalizar, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDias)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQtdParcelas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_Parcelas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label16;
        public System.Windows.Forms.TextBox txtTotal;
        public System.Windows.Forms.NumericUpDown txtQtdParcelas;
        public System.Windows.Forms.DateTimePicker dtPrimeiraParc;
        private System.Windows.Forms.DataGridView dataGrid_Parcelas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.TextBox txtIdVenda;
        public System.Windows.Forms.TextBox txtNomeCliente;
        private System.Windows.Forms.Label label14;
        public System.Windows.Forms.NumericUpDown txtDias;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnFinalizar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_parcela;
        private System.Windows.Forms.DataGridViewTextBoxColumn num_parcela;
        private System.Windows.Forms.DataGridViewTextBoxColumn valor_parcela;
        private System.Windows.Forms.DataGridViewTextBoxColumn dt_vcto_parcela;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_venda;
    }
}