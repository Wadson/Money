namespace Money
{
    partial class FrmCadUsuario
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
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.lblSenha = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.btnData = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtdtNascimento = new System.Windows.Forms.MaskedTextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lblNivel = new System.Windows.Forms.Label();
            this.lblConfSenha = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbNivelAcesso = new System.Windows.Forms.ComboBox();
            this.txtRepitasenha = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtCodigo
            // 
            this.txtCodigo.BackColor = System.Drawing.Color.Ivory;
            this.txtCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Location = new System.Drawing.Point(5, 21);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(69, 24);
            this.txtCodigo.TabIndex = 127;
            this.txtCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnSair
            // 
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSair.Image = global::Money.Properties.Resources.direita;
            this.btnSair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSair.Location = new System.Drawing.Point(231, 191);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(97, 26);
            this.btnSair.TabIndex = 126;
            this.btnSair.Text = "Sair";
            this.btnSair.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSalvar.Image = global::Money.Properties.Resources.Apply;
            this.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalvar.Location = new System.Drawing.Point(5, 191);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(97, 26);
            this.btnSalvar.TabIndex = 125;
            this.btnSalvar.Text = "&Salvar";
            this.btnSalvar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(5, 5);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(46, 13);
            this.label16.TabIndex = 122;
            this.label16.Text = "Registro";
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblSenha.ForeColor = System.Drawing.Color.Red;
            this.lblSenha.Location = new System.Drawing.Point(149, 130);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(15, 20);
            this.lblSenha.TabIndex = 46;
            this.lblSenha.Text = "*";
            this.lblSenha.Visible = false;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblUsuario.ForeColor = System.Drawing.Color.Red;
            this.lblUsuario.Location = new System.Drawing.Point(208, 91);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(17, 24);
            this.lblUsuario.TabIndex = 45;
            this.lblUsuario.Text = "*";
            this.lblUsuario.Visible = false;
            // 
            // btnData
            // 
            this.btnData.BackgroundImage = global::Money.Properties.Resources.Data;
            this.btnData.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnData.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnData.Location = new System.Drawing.Point(305, 95);
            this.btnData.Name = "btnData";
            this.btnData.Size = new System.Drawing.Size(22, 20);
            this.btnData.TabIndex = 44;
            this.btnData.Text = "...";
            this.btnData.UseVisualStyleBackColor = true;
            this.btnData.Click += new System.EventHandler(this.btnData_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(184, 114);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(85, 13);
            this.label10.TabIndex = 43;
            this.label10.Text = "Confirmar Senha";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(232, 80);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 13);
            this.label9.TabIndex = 42;
            this.label9.Text = "Dt.Nascmto";
            // 
            // txtdtNascimento
            // 
            this.txtdtNascimento.BackColor = System.Drawing.Color.Ivory;
            this.txtdtNascimento.Location = new System.Drawing.Point(233, 94);
            this.txtdtNascimento.Mask = "00/00/0000";
            this.txtdtNascimento.Name = "txtdtNascimento";
            this.txtdtNascimento.Size = new System.Drawing.Size(95, 20);
            this.txtdtNascimento.TabIndex = 2;
            this.txtdtNascimento.ValidatingType = typeof(System.DateTime);
            this.txtdtNascimento.Enter += new System.EventHandler(this.dtNascimento_Enter);
            this.txtdtNascimento.Leave += new System.EventHandler(this.dtNascimento_Leave);
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblNome.ForeColor = System.Drawing.Color.Red;
            this.lblNome.Location = new System.Drawing.Point(330, 59);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(17, 24);
            this.lblNome.TabIndex = 40;
            this.lblNome.Text = "*";
            this.lblNome.Visible = false;
            // 
            // txtNome
            // 
            this.txtNome.BackColor = System.Drawing.Color.Ivory;
            this.txtNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNome.Location = new System.Drawing.Point(5, 60);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(323, 20);
            this.txtNome.TabIndex = 0;
            this.txtNome.Enter += new System.EventHandler(this.txtNome_Enter);
            this.txtNome.Leave += new System.EventHandler(this.txtNome_Leave);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(5, 47);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 39;
            this.label8.Text = "Nome";
            // 
            // lblNivel
            // 
            this.lblNivel.AutoSize = true;
            this.lblNivel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblNivel.ForeColor = System.Drawing.Color.Red;
            this.lblNivel.Location = new System.Drawing.Point(328, 158);
            this.lblNivel.Name = "lblNivel";
            this.lblNivel.Size = new System.Drawing.Size(17, 24);
            this.lblNivel.TabIndex = 37;
            this.lblNivel.Text = "*";
            this.lblNivel.Visible = false;
            // 
            // lblConfSenha
            // 
            this.lblConfSenha.AutoSize = true;
            this.lblConfSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblConfSenha.ForeColor = System.Drawing.Color.Red;
            this.lblConfSenha.Location = new System.Drawing.Point(328, 128);
            this.lblConfSenha.Name = "lblConfSenha";
            this.lblConfSenha.Size = new System.Drawing.Size(17, 24);
            this.lblConfSenha.TabIndex = 36;
            this.lblConfSenha.Text = "*";
            this.lblConfSenha.Visible = false;
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblData.ForeColor = System.Drawing.Color.Red;
            this.lblData.Location = new System.Drawing.Point(328, 95);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(17, 24);
            this.lblData.TabIndex = 35;
            this.lblData.Text = "*";
            this.lblData.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 34;
            this.label4.Text = "Nivel de Acesso";
            // 
            // cmbNivelAcesso
            // 
            this.cmbNivelAcesso.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbNivelAcesso.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbNivelAcesso.BackColor = System.Drawing.Color.Ivory;
            this.cmbNivelAcesso.FormattingEnabled = true;
            this.cmbNivelAcesso.Items.AddRange(new object[] {
            "",
            "Administrador",
            "Operador"});
            this.cmbNivelAcesso.Location = new System.Drawing.Point(5, 163);
            this.cmbNivelAcesso.Name = "cmbNivelAcesso";
            this.cmbNivelAcesso.Size = new System.Drawing.Size(323, 21);
            this.cmbNivelAcesso.TabIndex = 5;
            this.cmbNivelAcesso.Enter += new System.EventHandler(this.cmbNivelAcesso_Enter);
            this.cmbNivelAcesso.Leave += new System.EventHandler(this.cmbNivelAcesso_Leave);
            // 
            // txtRepitasenha
            // 
            this.txtRepitasenha.BackColor = System.Drawing.Color.Ivory;
            this.txtRepitasenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.txtRepitasenha.Location = new System.Drawing.Point(186, 127);
            this.txtRepitasenha.Name = "txtRepitasenha";
            this.txtRepitasenha.Size = new System.Drawing.Size(140, 21);
            this.txtRepitasenha.TabIndex = 4;
            this.txtRepitasenha.UseSystemPasswordChar = true;
            this.txtRepitasenha.Enter += new System.EventHandler(this.txtRepitasenha_Enter);
            this.txtRepitasenha.Leave += new System.EventHandler(this.txtRepitasenha_Leave);
            // 
            // txtSenha
            // 
            this.txtSenha.BackColor = System.Drawing.Color.Ivory;
            this.txtSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.txtSenha.Location = new System.Drawing.Point(5, 127);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(140, 21);
            this.txtSenha.TabIndex = 3;
            this.txtSenha.UseSystemPasswordChar = true;
            this.txtSenha.Enter += new System.EventHandler(this.txtSenha_Enter);
            this.txtSenha.Leave += new System.EventHandler(this.txtSenha_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 33;
            this.label3.Text = "Senha";
            // 
            // txtUsuario
            // 
            this.txtUsuario.BackColor = System.Drawing.Color.Ivory;
            this.txtUsuario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtUsuario.Location = new System.Drawing.Point(5, 94);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(199, 20);
            this.txtUsuario.TabIndex = 1;
            this.txtUsuario.Enter += new System.EventHandler(this.txtUsuario_Enter);
            this.txtUsuario.Leave += new System.EventHandler(this.txtUsuario_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 32;
            this.label1.Text = "Usuário";
            // 
            // FrmCadUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(347, 224);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.btnData);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtdtNascimento);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblNivel);
            this.Controls.Add(this.lblConfSenha);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbNivelAcesso);
            this.Controls.Add(this.txtRepitasenha);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.label1);
            this.Name = "FrmCadUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Usuários";
            this.Load += new System.EventHandler(this.Frm_Cad_Usuario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNivel;
        private System.Windows.Forms.Label lblConfSenha;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtRepitasenha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnData;
        public System.Windows.Forms.MaskedTextBox txtdtNascimento;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblSenha;
        public System.Windows.Forms.ComboBox cmbNivelAcesso;
        public System.Windows.Forms.TextBox txtSenha;
        public System.Windows.Forms.TextBox txtUsuario;
        public System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnSalvar;
        public System.Windows.Forms.TextBox txtCodigo;
    }
}
