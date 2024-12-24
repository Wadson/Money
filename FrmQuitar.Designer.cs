namespace Money
{
    partial class FrmQuitar
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rbJuros = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDescontoJuros = new System.Windows.Forms.TextBox();
            this.rbDesconto = new System.Windows.Forms.RadioButton();
            this.txtDtPgto = new System.Windows.Forms.DateTimePicker();
            this.txtValorPago = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.txtVencimento = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_OK = new System.Windows.Forms.Button();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox7.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(2, 259);
            this.panel2.Size = new System.Drawing.Size(400, 2);
            // 
            // panel3
            // 
            this.panel3.Size = new System.Drawing.Size(400, 25);
            // 
            // panel4
            // 
            this.panel4.Size = new System.Drawing.Size(2, 261);
            // 
            // panel5
            // 
            this.panel5.Location = new System.Drawing.Point(402, 0);
            this.panel5.Size = new System.Drawing.Size(2, 261);
            // 
            // btnExit
            // 
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.Location = new System.Drawing.Point(368, 1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.Image = global::Money.Properties.Resources.payment;
            this.pictureBox1.Location = new System.Drawing.Point(299, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(99, 232);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 363;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox7
            // 
            this.groupBox7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox7.Controls.Add(this.label5);
            this.groupBox7.Controls.Add(this.groupBox5);
            this.groupBox7.Controls.Add(this.txtDtPgto);
            this.groupBox7.Controls.Add(this.txtValorPago);
            this.groupBox7.Controls.Add(this.label21);
            this.groupBox7.Controls.Add(this.label19);
            this.groupBox7.Controls.Add(this.txtVencimento);
            this.groupBox7.Controls.Add(this.label3);
            this.groupBox7.Controls.Add(this.txtValor);
            this.groupBox7.ForeColor = System.Drawing.Color.Black;
            this.groupBox7.Location = new System.Drawing.Point(5, 29);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(291, 190);
            this.groupBox7.TabIndex = 360;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Dados";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(76)))), ((int)(((byte)(172)))));
            this.label5.Location = new System.Drawing.Point(37, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 16);
            this.label5.TabIndex = 362;
            this.label5.Text = "Valor";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label2);
            this.groupBox5.Controls.Add(this.rbJuros);
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Controls.Add(this.txtDescontoJuros);
            this.groupBox5.Controls.Add(this.rbDesconto);
            this.groupBox5.ForeColor = System.Drawing.Color.Black;
            this.groupBox5.Location = new System.Drawing.Point(21, 93);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(261, 53);
            this.groupBox5.TabIndex = 361;
            this.groupBox5.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(1, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 20);
            this.label2.TabIndex = 360;
            this.label2.Text = "-";
            // 
            // rbJuros
            // 
            this.rbJuros.AutoSize = true;
            this.rbJuros.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.rbJuros.ForeColor = System.Drawing.Color.Red;
            this.rbJuros.Location = new System.Drawing.Point(18, 31);
            this.rbJuros.Name = "rbJuros";
            this.rbJuros.Size = new System.Drawing.Size(52, 20);
            this.rbJuros.TabIndex = 362;
            this.rbJuros.Text = "Juros";
            this.rbJuros.UseVisualStyleBackColor = true;
            this.rbJuros.CheckedChanged += new System.EventHandler(this.rbJuros_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(1, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 20);
            this.label4.TabIndex = 361;
            this.label4.Text = "+";
            // 
            // txtDescontoJuros
            // 
            this.txtDescontoJuros.ForeColor = System.Drawing.Color.Red;
            this.txtDescontoJuros.Location = new System.Drawing.Point(101, 20);
            this.txtDescontoJuros.Name = "txtDescontoJuros";
            this.txtDescontoJuros.Size = new System.Drawing.Size(150, 21);
            this.txtDescontoJuros.TabIndex = 1;
            this.txtDescontoJuros.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDescontoJuros.Leave += new System.EventHandler(this.txtDescontoJuros_Leave);
            // 
            // rbDesconto
            // 
            this.rbDesconto.AutoSize = true;
            this.rbDesconto.Checked = true;
            this.rbDesconto.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.rbDesconto.ForeColor = System.Drawing.Color.Blue;
            this.rbDesconto.Location = new System.Drawing.Point(18, 11);
            this.rbDesconto.Name = "rbDesconto";
            this.rbDesconto.Size = new System.Drawing.Size(77, 20);
            this.rbDesconto.TabIndex = 363;
            this.rbDesconto.TabStop = true;
            this.rbDesconto.Text = "Desconto";
            this.rbDesconto.UseVisualStyleBackColor = true;
            this.rbDesconto.CheckedChanged += new System.EventHandler(this.rbDesconto_CheckedChanged);
            // 
            // txtDtPgto
            // 
            this.txtDtPgto.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.txtDtPgto.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txtDtPgto.CalendarTitleBackColor = System.Drawing.Color.Yellow;
            this.txtDtPgto.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.txtDtPgto.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtDtPgto.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtDtPgto.Location = new System.Drawing.Point(122, 72);
            this.txtDtPgto.Name = "txtDtPgto";
            this.txtDtPgto.Size = new System.Drawing.Size(160, 21);
            this.txtDtPgto.TabIndex = 0;
            // 
            // txtValorPago
            // 
            this.txtValorPago.ForeColor = System.Drawing.Color.Green;
            this.txtValorPago.Location = new System.Drawing.Point(122, 153);
            this.txtValorPago.Name = "txtValorPago";
            this.txtValorPago.Size = new System.Drawing.Size(160, 21);
            this.txtValorPago.TabIndex = 2;
            this.txtValorPago.TabStop = false;
            this.txtValorPago.Click += new System.EventHandler(this.txt_Valor_Pago_Click);
            this.txtValorPago.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtValorPago_KeyUp);
            this.txtValorPago.Leave += new System.EventHandler(this.txtValorPago_Leave);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(76)))), ((int)(((byte)(172)))));
            this.label21.Location = new System.Drawing.Point(37, 155);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(67, 16);
            this.label21.TabIndex = 285;
            this.label21.Text = "Valor Pago";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(76)))), ((int)(((byte)(172)))));
            this.label19.Location = new System.Drawing.Point(37, 74);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(65, 16);
            this.label19.TabIndex = 359;
            this.label19.Text = "Data pgto";
            // 
            // txtVencimento
            // 
            this.txtVencimento.Enabled = false;
            this.txtVencimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtVencimento.Location = new System.Drawing.Point(122, 20);
            this.txtVencimento.Name = "txtVencimento";
            this.txtVencimento.Size = new System.Drawing.Size(160, 21);
            this.txtVencimento.TabIndex = 2;
            this.txtVencimento.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(76)))), ((int)(((byte)(172)))));
            this.label3.Location = new System.Drawing.Point(37, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Vencimento";
            // 
            // txtValor
            // 
            this.txtValor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.txtValor.Location = new System.Drawing.Point(122, 46);
            this.txtValor.Name = "txtValor";
            this.txtValor.ReadOnly = true;
            this.txtValor.Size = new System.Drawing.Size(160, 21);
            this.txtValor.TabIndex = 4;
            this.txtValor.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(37, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Valor";
            // 
            // btn_OK
            // 
            this.btn_OK.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_OK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(182)))));
            this.btn_OK.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_OK.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_OK.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_OK.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btn_OK.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(80)))));
            this.btn_OK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_OK.ForeColor = System.Drawing.Color.White;
            this.btn_OK.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_OK.Location = new System.Drawing.Point(127, 225);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(160, 28);
            this.btn_OK.TabIndex = 0;
            this.btn_OK.Text = "&Quitar";
            this.btn_OK.UseVisualStyleBackColor = false;
            this.btn_OK.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // FrmQuitar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(404, 261);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.btn_OK);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmQuitar";
            this.Text = "Quitar?";
            this.Load += new System.EventHandler(this.Frm_Quitar_Load);
            this.Controls.SetChildIndex(this.btn_OK, 0);
            this.Controls.SetChildIndex(this.groupBox7, 0);
            this.Controls.SetChildIndex(this.pictureBox1, 0);
            this.Controls.SetChildIndex(this.panel5, 0);
            this.Controls.SetChildIndex(this.panel4, 0);
            this.Controls.SetChildIndex(this.panel3, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label21;
        public System.Windows.Forms.TextBox txtValorPago;
        public System.Windows.Forms.TextBox txtDescontoJuros;
        public System.Windows.Forms.TextBox txtValor;
        public System.Windows.Forms.DateTimePicker txtVencimento;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Button btn_OK;
        public System.Windows.Forms.DateTimePicker txtDtPgto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rbDesconto;
        private System.Windows.Forms.RadioButton rbJuros;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
    }
}