namespace Money
{
    partial class FrmCadClientes
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
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.txtDTCadastroCli = new System.Windows.Forms.DateTimePicker();
            this.txtNomeCliente = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtCodigoCli = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEnderecoCliente = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBairroCliente = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCidadeCliente = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtEstadoCliente = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnFechar = new System.Windows.Forms.Button();
            this.txtTelefoneCli = new System.Windows.Forms.MaskedTextBox();
            this.txtIdCidade = new System.Windows.Forms.MaskedTextBox();
            this.btnLocalizar = new System.Windows.Forms.Button();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(2, 362);
            this.panel2.Size = new System.Drawing.Size(667, 2);
            // 
            // panel3
            // 
            this.panel3.Size = new System.Drawing.Size(667, 25);
            // 
            // panel4
            // 
            this.panel4.Size = new System.Drawing.Size(2, 364);
            // 
            // panel5
            // 
            this.panel5.Location = new System.Drawing.Point(669, 0);
            this.panel5.Size = new System.Drawing.Size(2, 364);
            // 
            // btnExit
            // 
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.Location = new System.Drawing.Point(1969, 3);
            // 
            // btnNovo
            // 
            this.btnNovo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(182)))));
            this.btnNovo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnNovo.ForeColor = System.Drawing.Color.White;
            this.btnNovo.Location = new System.Drawing.Point(250, 314);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(120, 35);
            this.btnNovo.TabIndex = 133;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = false;
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(182)))));
            this.btnSalvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnSalvar.ForeColor = System.Drawing.Color.White;
            this.btnSalvar.Location = new System.Drawing.Point(110, 314);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(120, 35);
            this.btnSalvar.TabIndex = 6;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // txtDTCadastroCli
            // 
            this.txtDTCadastroCli.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtDTCadastroCli.Location = new System.Drawing.Point(115, 111);
            this.txtDTCadastroCli.Name = "txtDTCadastroCli";
            this.txtDTCadastroCli.Size = new System.Drawing.Size(143, 21);
            this.txtDTCadastroCli.TabIndex = 138;
            this.txtDTCadastroCli.TabStop = false;
            // 
            // txtNomeCliente
            // 
            this.txtNomeCliente.Location = new System.Drawing.Point(115, 137);
            this.txtNomeCliente.MaxLength = 100;
            this.txtNomeCliente.Name = "txtNomeCliente";
            this.txtNomeCliente.Size = new System.Drawing.Size(439, 21);
            this.txtNomeCliente.TabIndex = 1;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(76)))), ((int)(((byte)(172)))));
            this.label16.Location = new System.Drawing.Point(23, 87);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(57, 16);
            this.label16.TabIndex = 137;
            this.label16.Text = "Código";
            // 
            // txtCodigoCli
            // 
            this.txtCodigoCli.Location = new System.Drawing.Point(115, 85);
            this.txtCodigoCli.Name = "txtCodigoCli";
            this.txtCodigoCli.ReadOnly = true;
            this.txtCodigoCli.Size = new System.Drawing.Size(48, 21);
            this.txtCodigoCli.TabIndex = 136;
            this.txtCodigoCli.TabStop = false;
            this.txtCodigoCli.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(76)))), ((int)(((byte)(172)))));
            this.label2.Location = new System.Drawing.Point(23, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 16);
            this.label2.TabIndex = 135;
            this.label2.Text = "Nome Cliente";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(76)))), ((int)(((byte)(172)))));
            this.label1.Location = new System.Drawing.Point(23, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 16);
            this.label1.TabIndex = 134;
            this.label1.Text = "Data Cadastro";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Money.Properties.Resources.Clientes;
            this.pictureBox1.Location = new System.Drawing.Point(569, 106);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(90, 193);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 139;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(76)))), ((int)(((byte)(172)))));
            this.label3.Location = new System.Drawing.Point(24, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 16);
            this.label3.TabIndex = 141;
            this.label3.Text = "Telefone";
            // 
            // txtEnderecoCliente
            // 
            this.txtEnderecoCliente.Location = new System.Drawing.Point(115, 197);
            this.txtEnderecoCliente.MaxLength = 100;
            this.txtEnderecoCliente.Name = "txtEnderecoCliente";
            this.txtEnderecoCliente.Size = new System.Drawing.Size(439, 21);
            this.txtEnderecoCliente.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(76)))), ((int)(((byte)(172)))));
            this.label4.Location = new System.Drawing.Point(23, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 16);
            this.label4.TabIndex = 143;
            this.label4.Text = "Endereço";
            // 
            // txtBairroCliente
            // 
            this.txtBairroCliente.Location = new System.Drawing.Point(115, 224);
            this.txtBairroCliente.MaxLength = 100;
            this.txtBairroCliente.Name = "txtBairroCliente";
            this.txtBairroCliente.Size = new System.Drawing.Size(439, 21);
            this.txtBairroCliente.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(76)))), ((int)(((byte)(172)))));
            this.label5.Location = new System.Drawing.Point(23, 225);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 16);
            this.label5.TabIndex = 145;
            this.label5.Text = "Bairro";
            // 
            // txtCidadeCliente
            // 
            this.txtCidadeCliente.Location = new System.Drawing.Point(164, 251);
            this.txtCidadeCliente.MaxLength = 100;
            this.txtCidadeCliente.Name = "txtCidadeCliente";
            this.txtCidadeCliente.Size = new System.Drawing.Size(324, 21);
            this.txtCidadeCliente.TabIndex = 5;
            this.txtCidadeCliente.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(76)))), ((int)(((byte)(172)))));
            this.label6.Location = new System.Drawing.Point(23, 252);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 16);
            this.label6.TabIndex = 147;
            this.label6.Text = "Cidade";
            // 
            // txtEstadoCliente
            // 
            this.txtEstadoCliente.Location = new System.Drawing.Point(115, 278);
            this.txtEstadoCliente.MaxLength = 100;
            this.txtEstadoCliente.Name = "txtEstadoCliente";
            this.txtEstadoCliente.ReadOnly = true;
            this.txtEstadoCliente.Size = new System.Drawing.Size(439, 21);
            this.txtEstadoCliente.TabIndex = 6;
            this.txtEstadoCliente.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(76)))), ((int)(((byte)(172)))));
            this.label7.Location = new System.Drawing.Point(23, 279);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 16);
            this.label7.TabIndex = 149;
            this.label7.Text = "Estado";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(76)))), ((int)(((byte)(172)))));
            this.label8.Location = new System.Drawing.Point(217, 45);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(202, 22);
            this.label8.TabIndex = 150;
            this.label8.Text = "Cadastro de Clientes";
            // 
            // btnFechar
            // 
            this.btnFechar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(182)))));
            this.btnFechar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnFechar.ForeColor = System.Drawing.Color.White;
            this.btnFechar.Location = new System.Drawing.Point(398, 314);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(120, 35);
            this.btnFechar.TabIndex = 151;
            this.btnFechar.Text = "&Fechar";
            this.btnFechar.UseVisualStyleBackColor = false;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // txtTelefoneCli
            // 
            this.txtTelefoneCli.Location = new System.Drawing.Point(115, 168);
            this.txtTelefoneCli.Mask = "(99) 0 0000-0000";
            this.txtTelefoneCli.Name = "txtTelefoneCli";
            this.txtTelefoneCli.Size = new System.Drawing.Size(143, 21);
            this.txtTelefoneCli.TabIndex = 2;
            // 
            // txtIdCidade
            // 
            this.txtIdCidade.Location = new System.Drawing.Point(115, 251);
            this.txtIdCidade.Name = "txtIdCidade";
            this.txtIdCidade.ReadOnly = true;
            this.txtIdCidade.Size = new System.Drawing.Size(48, 21);
            this.txtIdCidade.TabIndex = 153;
            this.txtIdCidade.TabStop = false;
            this.txtIdCidade.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnLocalizar
            // 
            this.btnLocalizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(182)))));
            this.btnLocalizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnLocalizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLocalizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnLocalizar.ForeColor = System.Drawing.Color.White;
            this.btnLocalizar.Location = new System.Drawing.Point(487, 250);
            this.btnLocalizar.Name = "btnLocalizar";
            this.btnLocalizar.Size = new System.Drawing.Size(67, 23);
            this.btnLocalizar.TabIndex = 5;
            this.btnLocalizar.Text = "&Localizar";
            this.btnLocalizar.UseVisualStyleBackColor = false;
            this.btnLocalizar.Click += new System.EventHandler(this.btnLocalizar_Click);
            // 
            // FrmCadClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 364);
            this.Controls.Add(this.btnLocalizar);
            this.Controls.Add(this.txtIdCidade);
            this.Controls.Add(this.txtTelefoneCli);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtEstadoCliente);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtCidadeCliente);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtBairroCliente);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtEnderecoCliente);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.txtDTCadastroCli);
            this.Controls.Add(this.txtNomeCliente);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.txtCodigoCli);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FrmCadClientes";
            this.Text = "FrmCadClientes";
            this.Load += new System.EventHandler(this.FrmCadClientes_Load);
            this.Controls.SetChildIndex(this.panel5, 0);
            this.Controls.SetChildIndex(this.panel4, 0);
            this.Controls.SetChildIndex(this.panel3, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.Controls.SetChildIndex(this.pictureBox1, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.txtCodigoCli, 0);
            this.Controls.SetChildIndex(this.label16, 0);
            this.Controls.SetChildIndex(this.txtNomeCliente, 0);
            this.Controls.SetChildIndex(this.txtDTCadastroCli, 0);
            this.Controls.SetChildIndex(this.btnSalvar, 0);
            this.Controls.SetChildIndex(this.btnNovo, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.txtEnderecoCliente, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.txtBairroCliente, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.txtCidadeCliente, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.txtEstadoCliente, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            this.Controls.SetChildIndex(this.btnFechar, 0);
            this.Controls.SetChildIndex(this.txtTelefoneCli, 0);
            this.Controls.SetChildIndex(this.txtIdCidade, 0);
            this.Controls.SetChildIndex(this.btnLocalizar, 0);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnSalvar;
        public System.Windows.Forms.DateTimePicker txtDTCadastroCli;
        public System.Windows.Forms.TextBox txtNomeCliente;
        private System.Windows.Forms.Label label16;
        public System.Windows.Forms.MaskedTextBox txtCodigoCli;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txtEnderecoCliente;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txtBairroCliente;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox txtCidadeCliente;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox txtEstadoCliente;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnFechar;
        public System.Windows.Forms.MaskedTextBox txtIdCidade;
        private System.Windows.Forms.Button btnLocalizar;
        public System.Windows.Forms.MaskedTextBox txtTelefoneCli;
    }
}