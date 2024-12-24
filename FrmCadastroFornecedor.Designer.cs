namespace Money
{
    partial class FrmCadastroFornecedor
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
            this.btnSair = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.txtObs = new System.Windows.Forms.TextBox();
            this.txtFornecedor = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.txtEmissor = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.txtContato = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtUf = new System.Windows.Forms.TextBox();
            this.txtInscricaoEstadual = new System.Windows.Forms.MaskedTextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.txtCep = new System.Windows.Forms.MaskedTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.txtCnpj = new System.Windows.Forms.MaskedTextBox();
            this.txtCelular = new System.Windows.Forms.MaskedTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCpf = new System.Windows.Forms.MaskedTextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCadastro = new System.Windows.Forms.MaskedTextBox();
            this.txtIdentidade = new System.Windows.Forms.TextBox();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.txtFone1 = new System.Windows.Forms.MaskedTextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtFone2 = new System.Windows.Forms.MaskedTextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSair
            // 
            this.btnSair.Image = global::Money.Properties.Resources.direita;
            this.btnSair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSair.Location = new System.Drawing.Point(440, 369);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(97, 37);
            this.btnSair.TabIndex = 18;
            this.btnSair.Text = "Sair";
            this.btnSair.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Image = global::Money.Properties.Resources.Apply;
            this.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalvar.Location = new System.Drawing.Point(439, 324);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(97, 37);
            this.btnSalvar.TabIndex = 17;
            this.btnSalvar.Text = "&Salvar";
            this.btnSalvar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // txtObs
            // 
            this.txtObs.BackColor = System.Drawing.SystemColors.Info;
            this.txtObs.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.txtObs.Location = new System.Drawing.Point(5, 325);
            this.txtObs.MaxLength = 280;
            this.txtObs.Multiline = true;
            this.txtObs.Name = "txtObs";
            this.txtObs.Size = new System.Drawing.Size(429, 81);
            this.txtObs.TabIndex = 16;
            // 
            // txtFornecedor
            // 
            this.txtFornecedor.BackColor = System.Drawing.SystemColors.Info;
            this.txtFornecedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.txtFornecedor.Location = new System.Drawing.Point(2, 65);
            this.txtFornecedor.MaxLength = 100;
            this.txtFornecedor.Name = "txtFornecedor";
            this.txtFornecedor.Size = new System.Drawing.Size(535, 23);
            this.txtFornecedor.TabIndex = 0;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(5, 309);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(132, 13);
            this.label13.TabIndex = 123;
            this.label13.Text = "Ocorrêcias / Observações";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(456, 257);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(43, 13);
            this.label28.TabIndex = 122;
            this.label28.Text = "Emissor";
            // 
            // txtEmissor
            // 
            this.txtEmissor.BackColor = System.Drawing.SystemColors.Info;
            this.txtEmissor.Location = new System.Drawing.Point(455, 273);
            this.txtEmissor.MaxLength = 8;
            this.txtEmissor.Name = "txtEmissor";
            this.txtEmissor.Size = new System.Drawing.Size(81, 20);
            this.txtEmissor.TabIndex = 15;
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.SystemColors.Info;
            this.txtEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txtEmail.Location = new System.Drawing.Point(5, 232);
            this.txtEmail.MaxLength = 30;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(300, 20);
            this.txtEmail.TabIndex = 9;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(5, 216);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(35, 13);
            this.label26.TabIndex = 121;
            this.label26.Text = "E-mail";
            // 
            // txtContato
            // 
            this.txtContato.BackColor = System.Drawing.SystemColors.Info;
            this.txtContato.Location = new System.Drawing.Point(311, 232);
            this.txtContato.MaxLength = 30;
            this.txtContato.Name = "txtContato";
            this.txtContato.Size = new System.Drawing.Size(225, 20);
            this.txtContato.TabIndex = 10;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(124, 257);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(35, 13);
            this.label11.TabIndex = 114;
            this.label11.Text = "Nº I.E";
            // 
            // txtUf
            // 
            this.txtUf.BackColor = System.Drawing.SystemColors.Info;
            this.txtUf.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtUf.Location = new System.Drawing.Point(487, 188);
            this.txtUf.Name = "txtUf";
            this.txtUf.Size = new System.Drawing.Size(49, 20);
            this.txtUf.TabIndex = 8;
            this.txtUf.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtInscricaoEstadual
            // 
            this.txtInscricaoEstadual.BackColor = System.Drawing.SystemColors.Info;
            this.txtInscricaoEstadual.Location = new System.Drawing.Point(121, 273);
            this.txtInscricaoEstadual.Mask = "00.000.000-00";
            this.txtInscricaoEstadual.Name = "txtInscricaoEstadual";
            this.txtInscricaoEstadual.Size = new System.Drawing.Size(94, 20);
            this.txtInscricaoEstadual.TabIndex = 12;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(494, 297);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(21, 13);
            this.label25.TabIndex = 116;
            this.label25.Text = "UF";
            // 
            // txtCep
            // 
            this.txtCep.BackColor = System.Drawing.SystemColors.Info;
            this.txtCep.Location = new System.Drawing.Point(393, 188);
            this.txtCep.Mask = "00.000-999";
            this.txtCep.Name = "txtCep";
            this.txtCep.Size = new System.Drawing.Size(89, 20);
            this.txtCep.TabIndex = 7;
            this.txtCep.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(5, 258);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 13);
            this.label10.TabIndex = 112;
            this.label10.Text = "Nº CNPJ";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(394, 172);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(28, 13);
            this.label24.TabIndex = 117;
            this.label24.Text = "CEP";
            // 
            // txtCnpj
            // 
            this.txtCnpj.BackColor = System.Drawing.SystemColors.Info;
            this.txtCnpj.Location = new System.Drawing.Point(5, 273);
            this.txtCnpj.Mask = "00.000.000/0000-00";
            this.txtCnpj.Name = "txtCnpj";
            this.txtCnpj.Size = new System.Drawing.Size(110, 20);
            this.txtCnpj.TabIndex = 11;
            // 
            // txtCelular
            // 
            this.txtCelular.BackColor = System.Drawing.SystemColors.Info;
            this.txtCelular.Location = new System.Drawing.Point(199, 188);
            this.txtCelular.Mask = "(99) 0000-0000";
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Size = new System.Drawing.Size(89, 20);
            this.txtCelular.TabIndex = 6;
            this.txtCelular.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(308, 216);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(44, 13);
            this.label12.TabIndex = 113;
            this.label12.Text = "Contato";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(238, 255);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 13);
            this.label9.TabIndex = 109;
            this.label9.Text = "Nº do CPF";
            // 
            // txtCpf
            // 
            this.txtCpf.BackColor = System.Drawing.SystemColors.Info;
            this.txtCpf.Location = new System.Drawing.Point(237, 273);
            this.txtCpf.Mask = "000.000.000-00";
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(97, 20);
            this.txtCpf.TabIndex = 13;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(196, 172);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(54, 13);
            this.label23.TabIndex = 120;
            this.label23.Text = "Nº Celular";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(342, 258);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 108;
            this.label8.Text = "Nº RG";
            // 
            // txtCadastro
            // 
            this.txtCadastro.Location = new System.Drawing.Point(462, 20);
            this.txtCadastro.Mask = "00/00/0000";
            this.txtCadastro.Name = "txtCadastro";
            this.txtCadastro.Size = new System.Drawing.Size(72, 20);
            this.txtCadastro.TabIndex = 119;
            this.txtCadastro.TabStop = false;
            this.txtCadastro.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCadastro.ValidatingType = typeof(System.DateTime);
            // 
            // txtIdentidade
            // 
            this.txtIdentidade.BackColor = System.Drawing.SystemColors.Info;
            this.txtIdentidade.Location = new System.Drawing.Point(341, 273);
            this.txtIdentidade.MaxLength = 15;
            this.txtIdentidade.Name = "txtIdentidade";
            this.txtIdentidade.Size = new System.Drawing.Size(110, 20);
            this.txtIdentidade.TabIndex = 14;
            // 
            // txtCidade
            // 
            this.txtCidade.BackColor = System.Drawing.SystemColors.Info;
            this.txtCidade.Location = new System.Drawing.Point(260, 149);
            this.txtCidade.MaxLength = 40;
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(275, 20);
            this.txtCidade.TabIndex = 3;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(257, 133);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(40, 13);
            this.label20.TabIndex = 118;
            this.label20.Text = "Cidade";
            // 
            // txtBairro
            // 
            this.txtBairro.BackColor = System.Drawing.SystemColors.Info;
            this.txtBairro.Location = new System.Drawing.Point(5, 149);
            this.txtBairro.MaxLength = 40;
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(249, 20);
            this.txtBairro.TabIndex = 2;
            // 
            // txtFone1
            // 
            this.txtFone1.BackColor = System.Drawing.SystemColors.Info;
            this.txtFone1.Location = new System.Drawing.Point(5, 188);
            this.txtFone1.Mask = "(99) 0000-0000";
            this.txtFone1.Name = "txtFone1";
            this.txtFone1.Size = new System.Drawing.Size(89, 20);
            this.txtFone1.TabIndex = 4;
            this.txtFone1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(5, 133);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(34, 13);
            this.label19.TabIndex = 115;
            this.label19.Text = "Bairro";
            // 
            // txtEndereco
            // 
            this.txtEndereco.BackColor = System.Drawing.SystemColors.Info;
            this.txtEndereco.Location = new System.Drawing.Point(5, 109);
            this.txtEndereco.MaxLength = 100;
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(530, 20);
            this.txtEndereco.TabIndex = 1;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(102, 172);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(62, 13);
            this.label14.TabIndex = 111;
            this.label14.Text = "2º Telefone";
            // 
            // txtFone2
            // 
            this.txtFone2.BackColor = System.Drawing.SystemColors.Info;
            this.txtFone2.Location = new System.Drawing.Point(101, 188);
            this.txtFone2.Mask = "(99) 0000-0000";
            this.txtFone2.Name = "txtFone2";
            this.txtFone2.Size = new System.Drawing.Size(89, 20);
            this.txtFone2.TabIndex = 5;
            this.txtFone2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(5, 93);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(53, 13);
            this.label17.TabIndex = 110;
            this.label17.Text = "Endereço";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(2, 2);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(46, 13);
            this.label16.TabIndex = 106;
            this.label16.Text = "Registro";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(5, 172);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(62, 13);
            this.label15.TabIndex = 107;
            this.label15.Text = "1º Telefone";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.txtCodigo.Location = new System.Drawing.Point(2, 17);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.ReadOnly = true;
            this.txtCodigo.Size = new System.Drawing.Size(62, 23);
            this.txtCodigo.TabIndex = 105;
            this.txtCodigo.TabStop = false;
            this.txtCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 13);
            this.label2.TabIndex = 99;
            this.label2.Text = "Nome do Fornecedor";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(459, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 98;
            this.label1.Text = "Data Cadastro";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(487, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 13);
            this.label3.TabIndex = 125;
            this.label3.Text = "UF";
            // 
            // FrmCadastroFornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(540, 413);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.txtObs);
            this.Controls.Add(this.txtFornecedor);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label28);
            this.Controls.Add(this.txtEmissor);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.txtContato);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtUf);
            this.Controls.Add(this.txtInscricaoEstadual);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.txtCep);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.txtCnpj);
            this.Controls.Add(this.txtCelular);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtCpf);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtCadastro);
            this.Controls.Add(this.txtIdentidade);
            this.Controls.Add(this.txtCidade);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.txtBairro);
            this.Controls.Add(this.txtFone1);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.txtEndereco);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtFone2);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmCadastroFornecedor";
            this.Text = "Cadastro de Fornecedores";
            this.Load += new System.EventHandler(this.FrmCadastroFornecedor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnSalvar;
        public System.Windows.Forms.TextBox txtObs;
        public System.Windows.Forms.TextBox txtFornecedor;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label28;
        public System.Windows.Forms.TextBox txtEmissor;
        public System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label26;
        public System.Windows.Forms.TextBox txtContato;
        private System.Windows.Forms.Label label11;
        public System.Windows.Forms.TextBox txtUf;
        public System.Windows.Forms.MaskedTextBox txtInscricaoEstadual;
        private System.Windows.Forms.Label label25;
        public System.Windows.Forms.MaskedTextBox txtCep;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label24;
        public System.Windows.Forms.MaskedTextBox txtCnpj;
        public System.Windows.Forms.MaskedTextBox txtCelular;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.MaskedTextBox txtCpf;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.MaskedTextBox txtCadastro;
        public System.Windows.Forms.TextBox txtIdentidade;
        public System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.Label label20;
        public System.Windows.Forms.TextBox txtBairro;
        public System.Windows.Forms.MaskedTextBox txtFone1;
        private System.Windows.Forms.Label label19;
        public System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.Label label14;
        public System.Windows.Forms.MaskedTextBox txtFone2;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        public System.Windows.Forms.MaskedTextBox txtCodigo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
    }
}
