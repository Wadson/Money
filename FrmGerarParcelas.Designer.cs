namespace Money
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDias = new System.Windows.Forms.NumericUpDown();
            this.label16 = new System.Windows.Forms.Label();
            this.checkBoxIntervaloEntreParc = new System.Windows.Forms.CheckBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtQtdParcelas = new System.Windows.Forms.NumericUpDown();
            this.dtPrimeiraParc = new System.Windows.Forms.DateTimePicker();
            this.dataGrid_Parcelas = new System.Windows.Forms.DataGridView();
            this.id_parcela = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.num_parcela = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valor_parc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dt_vcto_parcela = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_venda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txtIdVenda = new System.Windows.Forms.TextBox();
            this.txtNomeCliente = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDias)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQtdParcelas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_Parcelas)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(2, 449);
            this.panel2.Size = new System.Drawing.Size(835, 2);
            // 
            // panel3
            // 
            this.panel3.Size = new System.Drawing.Size(835, 25);
            // 
            // panel4
            // 
            this.panel4.Size = new System.Drawing.Size(2, 451);
            // 
            // panel5
            // 
            this.panel5.Location = new System.Drawing.Point(837, 0);
            this.panel5.Size = new System.Drawing.Size(2, 451);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.Location = new System.Drawing.Point(799, 3);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(15, 286);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 17);
            this.label5.TabIndex = 518;
            this.label5.Text = "Qtd. Dia";
            // 
            // txtDias
            // 
            this.txtDias.Enabled = false;
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
            1,
            0,
            0,
            0});
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label16.Location = new System.Drawing.Point(15, 194);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(182, 16);
            this.label16.TabIndex = 514;
            this.label16.Text = "Data 1º Parcela                           ";
            // 
            // checkBoxIntervaloEntreParc
            // 
            this.checkBoxIntervaloEntreParc.AutoSize = true;
            this.checkBoxIntervaloEntreParc.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.checkBoxIntervaloEntreParc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxIntervaloEntreParc.ForeColor = System.Drawing.Color.White;
            this.checkBoxIntervaloEntreParc.Location = new System.Drawing.Point(15, 265);
            this.checkBoxIntervaloEntreParc.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxIntervaloEntreParc.Name = "checkBoxIntervaloEntreParc";
            this.checkBoxIntervaloEntreParc.Size = new System.Drawing.Size(184, 20);
            this.checkBoxIntervaloEntreParc.TabIndex = 517;
            this.checkBoxIntervaloEntreParc.Text = "Intervalo entre parcelas      ";
            this.checkBoxIntervaloEntreParc.UseVisualStyleBackColor = false;
            this.checkBoxIntervaloEntreParc.CheckedChanged += new System.EventHandler(this.checkBoxIntervaloEntreParc_CheckedChanged);
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
            this.valor_parc,
            this.dt_vcto_parcela,
            this.id_venda});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(76)))), ((int)(((byte)(172)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGrid_Parcelas.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGrid_Parcelas.EnableHeadersVisualStyles = false;
            this.dataGrid_Parcelas.GridColor = System.Drawing.Color.SteelBlue;
            this.dataGrid_Parcelas.Location = new System.Drawing.Point(208, 130);
            this.dataGrid_Parcelas.Margin = new System.Windows.Forms.Padding(4);
            this.dataGrid_Parcelas.Name = "dataGrid_Parcelas";
            this.dataGrid_Parcelas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(76)))), ((int)(((byte)(172)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGrid_Parcelas.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGrid_Parcelas.RowHeadersWidth = 20;
            this.dataGrid_Parcelas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGrid_Parcelas.Size = new System.Drawing.Size(622, 260);
            this.dataGrid_Parcelas.TabIndex = 519;
            // 
            // id_parcela
            // 
            this.id_parcela.DataPropertyName = "id_parcela";
            this.id_parcela.DividerWidth = 1;
            this.id_parcela.HeaderText = "Cód. Parc";
            this.id_parcela.Name = "id_parcela";
            this.id_parcela.Visible = false;
            this.id_parcela.Width = 92;
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
            // valor_parc
            // 
            this.valor_parc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.valor_parc.DataPropertyName = "valor_parcela";
            this.valor_parc.DividerWidth = 1;
            this.valor_parc.HeaderText = "Valor Parc";
            this.valor_parc.Name = "valor_parc";
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
            this.id_venda.DataPropertyName = "id_venda";
            this.id_venda.DividerWidth = 1;
            this.id_venda.HeaderText = "Cód. Venda";
            this.id_venda.Name = "id_venda";
            this.id_venda.Width = 102;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.75F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(145, -1);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 29);
            this.label2.TabIndex = 527;
            this.label2.Text = "Gerar Parcelas";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.75F);
            this.label1.ForeColor = System.Drawing.Color.White;
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
            this.label4.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.75F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(15, 336);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(182, 18);
            this.label4.TabIndex = 526;
            this.label4.Text = "Nº Parcela                          ";
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSalvar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(80)))));
            this.btnSalvar.Location = new System.Drawing.Point(207, 398);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(623, 34);
            this.btnSalvar.TabIndex = 529;
            this.btnSalvar.Text = "&Salvar";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label9.Location = new System.Drawing.Point(12, 64);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(101, 17);
            this.label9.TabIndex = 533;
            this.label9.Text = "Código Venda:";
            // 
            // txtIdVenda
            // 
            this.txtIdVenda.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtIdVenda.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.txtIdVenda.Location = new System.Drawing.Point(15, 85);
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
            this.txtNomeCliente.Location = new System.Drawing.Point(120, 85);
            this.txtNomeCliente.Name = "txtNomeCliente";
            this.txtNomeCliente.ReadOnly = true;
            this.txtNomeCliente.Size = new System.Drawing.Size(372, 24);
            this.txtNomeCliente.TabIndex = 530;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label14.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label14.Location = new System.Drawing.Point(119, 63);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(55, 17);
            this.label14.TabIndex = 531;
            this.label14.Text = "Cliente:";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(2, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(837, 35);
            this.panel1.TabIndex = 534;
            // 
            // FrmGerarParcelas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 451);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtIdVenda);
            this.Controls.Add(this.txtNomeCliente);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtQtdParcelas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGrid_Parcelas);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtDias);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.checkBoxIntervaloEntreParc);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.dtPrimeiraParc);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FrmGerarParcelas";
            this.Text = "FrmGerarParcelas";
            this.Load += new System.EventHandler(this.FrmGerarParcelas_Load);
            this.Controls.SetChildIndex(this.dtPrimeiraParc, 0);
            this.Controls.SetChildIndex(this.txtTotal, 0);
            this.Controls.SetChildIndex(this.checkBoxIntervaloEntreParc, 0);
            this.Controls.SetChildIndex(this.label16, 0);
            this.Controls.SetChildIndex(this.txtDias, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.dataGrid_Parcelas, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.txtQtdParcelas, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.btnSalvar, 0);
            this.Controls.SetChildIndex(this.label14, 0);
            this.Controls.SetChildIndex(this.txtNomeCliente, 0);
            this.Controls.SetChildIndex(this.txtIdVenda, 0);
            this.Controls.SetChildIndex(this.label9, 0);
            this.Controls.SetChildIndex(this.panel5, 0);
            this.Controls.SetChildIndex(this.panel4, 0);
            this.Controls.SetChildIndex(this.panel3, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDias)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQtdParcelas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_Parcelas)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.CheckBox checkBoxIntervaloEntreParc;
        public System.Windows.Forms.TextBox txtTotal;
        public System.Windows.Forms.NumericUpDown txtQtdParcelas;
        public System.Windows.Forms.DateTimePicker dtPrimeiraParc;
        private System.Windows.Forms.DataGridView dataGrid_Parcelas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.TextBox txtIdVenda;
        public System.Windows.Forms.TextBox txtNomeCliente;
        private System.Windows.Forms.Label label14;
        public System.Windows.Forms.NumericUpDown txtDias;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_parcela;
        private System.Windows.Forms.DataGridViewTextBoxColumn num_parcela;
        private System.Windows.Forms.DataGridViewTextBoxColumn valor_parc;
        private System.Windows.Forms.DataGridViewTextBoxColumn dt_vcto_parcela;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_venda;
    }
}