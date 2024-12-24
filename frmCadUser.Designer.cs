namespace Money
{
    partial class frmCadUser
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
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnGravar = new System.Windows.Forms.Button();
            this.txtCpf = new System.Windows.Forms.TextBox();
            this.lblSituacaoCPF = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbNivelAcesso = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtCadastro = new System.Windows.Forms.DateTimePicker();
            this.txtSenhaRep = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Usuario = new System.Windows.Forms.TextBox();
            this.txt_CodUsuario = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            // 
            // btnNovo
            // 
            this.btnNovo.FlatAppearance.BorderSize = 0;
            this.btnNovo.Image = global::Money.Properties.Resources.document;
            this.btnNovo.Location = new System.Drawing.Point(189, 148);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(43, 33);
            this.btnNovo.TabIndex = 76;
            this.btnNovo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolTip1.SetToolTip(this.btnNovo, "Limpa campo");
            this.btnNovo.UseVisualStyleBackColor = false;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.FlatAppearance.BorderSize = 0;
            this.btnAlterar.Image = global::Money.Properties.Resources.Modify;
            this.btnAlterar.Location = new System.Drawing.Point(275, 148);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(43, 33);
            this.btnAlterar.TabIndex = 5;
            this.btnAlterar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolTip1.SetToolTip(this.btnAlterar, "Altera usuario");
            this.btnAlterar.UseVisualStyleBackColor = false;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.FlatAppearance.BorderSize = 0;
            this.btnExcluir.Image = global::Money.Properties.Resources.deletar;
            this.btnExcluir.Location = new System.Drawing.Point(318, 148);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(43, 33);
            this.btnExcluir.TabIndex = 74;
            this.btnExcluir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolTip1.SetToolTip(this.btnExcluir, "Deleta usuário");
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnSair
            // 
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.Image = global::Money.Properties.Resources.Sair_;
            this.btnSair.Location = new System.Drawing.Point(361, 148);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(43, 33);
            this.btnSair.TabIndex = 72;
            this.btnSair.TabStop = false;
            this.btnSair.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolTip1.SetToolTip(this.btnSair, "Fechar tela");
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnGravar
            // 
            this.btnGravar.FlatAppearance.BorderSize = 0;
            this.btnGravar.Image = global::Money.Properties.Resources.tick;
            this.btnGravar.Location = new System.Drawing.Point(232, 148);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(43, 33);
            this.btnGravar.TabIndex = 5;
            this.btnGravar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolTip1.SetToolTip(this.btnGravar, "Salva cadastro");
            this.btnGravar.UseVisualStyleBackColor = false;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // txtCpf
            // 
            this.txtCpf.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCpf.ForeColor = System.Drawing.Color.Black;
            this.txtCpf.Location = new System.Drawing.Point(128, 79);
            this.txtCpf.MaxLength = 11;
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(139, 20);
            this.txtCpf.TabIndex = 1;
            this.txtCpf.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCpf_KeyPress);
            this.txtCpf.Leave += new System.EventHandler(this.txtCpf_Leave);
            // 
            // lblSituacaoCPF
            // 
            this.lblSituacaoCPF.AutoSize = true;
            this.lblSituacaoCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lblSituacaoCPF.Location = new System.Drawing.Point(273, 81);
            this.lblSituacaoCPF.Name = "lblSituacaoCPF";
            this.lblSituacaoCPF.Size = new System.Drawing.Size(13, 17);
            this.lblSituacaoCPF.TabIndex = 85;
            this.lblSituacaoCPF.Text = "-";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label7.Location = new System.Drawing.Point(82, 79);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 17);
            this.label7.TabIndex = 84;
            this.label7.Text = "CPF";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label5.Location = new System.Drawing.Point(33, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 17);
            this.label5.TabIndex = 80;
            this.label5.Text = "Nível Acesso";
            // 
            // cmbNivelAcesso
            // 
            this.cmbNivelAcesso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNivelAcesso.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbNivelAcesso.FormattingEnabled = true;
            this.cmbNivelAcesso.Items.AddRange(new object[] {
            "",
            "Operador",
            "Administrador"});
            this.cmbNivelAcesso.Location = new System.Drawing.Point(128, 122);
            this.cmbNivelAcesso.Name = "cmbNivelAcesso";
            this.cmbNivelAcesso.Size = new System.Drawing.Size(145, 21);
            this.cmbNivelAcesso.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label3.Location = new System.Drawing.Point(23, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 17);
            this.label3.TabIndex = 78;
            this.label3.Text = "Data Cadastro";
            // 
            // dtCadastro
            // 
            this.dtCadastro.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtCadastro.Location = new System.Drawing.Point(128, 38);
            this.dtCadastro.Name = "dtCadastro";
            this.dtCadastro.Size = new System.Drawing.Size(137, 20);
            this.dtCadastro.TabIndex = 77;
            // 
            // txtSenhaRep
            // 
            this.txtSenhaRep.ForeColor = System.Drawing.Color.Black;
            this.txtSenhaRep.Location = new System.Drawing.Point(267, 102);
            this.txtSenhaRep.Name = "txtSenhaRep";
            this.txtSenhaRep.Size = new System.Drawing.Size(137, 20);
            this.txtSenhaRep.TabIndex = 3;
            this.txtSenhaRep.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label4.Location = new System.Drawing.Point(73, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 17);
            this.label4.TabIndex = 42;
            this.label4.Text = "Senha";
            // 
            // txtSenha
            // 
            this.txtSenha.ForeColor = System.Drawing.Color.Black;
            this.txtSenha.Location = new System.Drawing.Point(128, 102);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(137, 20);
            this.txtSenha.TabIndex = 2;
            this.txtSenha.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label2.Location = new System.Drawing.Point(65, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 17);
            this.label2.TabIndex = 41;
            this.label2.Text = "Usuario";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label1.Location = new System.Drawing.Point(70, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 17);
            this.label1.TabIndex = 40;
            this.label1.Text = "Código";
            // 
            // txt_Usuario
            // 
            this.txt_Usuario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_Usuario.ForeColor = System.Drawing.Color.Black;
            this.txt_Usuario.Location = new System.Drawing.Point(128, 58);
            this.txt_Usuario.MaxLength = 20;
            this.txt_Usuario.Name = "txt_Usuario";
            this.txt_Usuario.Size = new System.Drawing.Size(277, 20);
            this.txt_Usuario.TabIndex = 0;
            // 
            // txt_CodUsuario
            // 
            this.txt_CodUsuario.Enabled = false;
            this.txt_CodUsuario.ForeColor = System.Drawing.Color.Black;
            this.txt_CodUsuario.Location = new System.Drawing.Point(128, 18);
            this.txt_CodUsuario.Name = "txt_CodUsuario";
            this.txt_CodUsuario.ReadOnly = true;
            this.txt_CodUsuario.Size = new System.Drawing.Size(137, 20);
            this.txt_CodUsuario.TabIndex = 39;
            this.txt_CodUsuario.TabStop = false;
            this.txt_CodUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // frmCadUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 191);
            this.Controls.Add(this.txtCpf);
            this.Controls.Add(this.lblSituacaoCPF);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbNivelAcesso);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtCadastro);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.txtSenhaRep);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Usuario);
            this.Controls.Add(this.txt_CodUsuario);
            this.Name = "frmCadUser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSair;
        public System.Windows.Forms.Button btnGravar;
        public System.Windows.Forms.Button btnNovo;
        public System.Windows.Forms.Button btnAlterar;
        public System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.ToolTip toolTip1;
        public System.Windows.Forms.TextBox txtSenhaRep;
        public System.Windows.Forms.TextBox txtSenha;
        public System.Windows.Forms.TextBox txt_Usuario;
        public System.Windows.Forms.TextBox txt_CodUsuario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.DateTimePicker dtCadastro;
        public System.Windows.Forms.ComboBox cmbNivelAcesso;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblSituacaoCPF;
        public System.Windows.Forms.TextBox txtCpf;
    }
}