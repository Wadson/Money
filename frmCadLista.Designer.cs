namespace Money
{
    partial class frmCadLista
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
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUf = new System.Windows.Forms.TextBox();
            this.txtCodCidade = new System.Windows.Forms.TextBox();
            this.txtCelular = new System.Windows.Forms.TextBox();
            this.txtFonee = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnGravar = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnLimpa = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(129, 89);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(308, 20);
            this.txtCidade.TabIndex = 3;
            this.txtCidade.Leave += new System.EventHandler(this.txtCidade_Leave);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(22, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 51;
            this.label1.Text = "Endereço";
            // 
            // txtUf
            // 
            this.txtUf.Enabled = false;
            this.txtUf.Location = new System.Drawing.Point(462, 89);
            this.txtUf.Name = "txtUf";
            this.txtUf.Size = new System.Drawing.Size(41, 20);
            this.txtUf.TabIndex = 50;
            this.txtUf.TabStop = false;
            this.txtUf.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCodCidade
            // 
            this.txtCodCidade.Location = new System.Drawing.Point(79, 89);
            this.txtCodCidade.Name = "txtCodCidade";
            this.txtCodCidade.Size = new System.Drawing.Size(50, 20);
            this.txtCodCidade.TabIndex = 2;
            this.txtCodCidade.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCodCidade.TextChanged += new System.EventHandler(this.txtCodCidade_TextChanged);
            // 
            // txtCelular
            // 
            this.txtCelular.Location = new System.Drawing.Point(79, 130);
            this.txtCelular.MaxLength = 13;
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Size = new System.Drawing.Size(97, 20);
            this.txtCelular.TabIndex = 5;
            this.txtCelular.Click += new System.EventHandler(this.txtCelular_Click);
            this.txtCelular.Enter += new System.EventHandler(this.txtCelular_Enter);
            this.txtCelular.Leave += new System.EventHandler(this.txtCelular_Leave);
            // 
            // txtFonee
            // 
            this.txtFonee.Location = new System.Drawing.Point(79, 110);
            this.txtFonee.MaxLength = 13;
            this.txtFonee.Name = "txtFonee";
            this.txtFonee.Size = new System.Drawing.Size(97, 20);
            this.txtFonee.TabIndex = 4;
            this.txtFonee.Click += new System.EventHandler(this.txtFonee_Click);
            this.txtFonee.Enter += new System.EventHandler(this.txtFonee_Enter);
            this.txtFonee.Leave += new System.EventHandler(this.txtFonee_Leave);
            // 
            // txtEmail
            // 
            this.txtEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txtEmail.Location = new System.Drawing.Point(79, 150);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(371, 20);
            this.txtEmail.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(37, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 45;
            this.label3.Text = "Código";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Location = new System.Drawing.Point(79, 29);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(65, 20);
            this.txtCodigo.TabIndex = 44;
            this.txtCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(44, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 38;
            this.label5.Text = "Fone";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(42, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 35;
            this.label4.Text = "Nome";
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(37, 94);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 41;
            this.label8.Text = "Cidade";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(37, 134);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 39;
            this.label6.Text = "Celular";
            // 
            // txtEndereco
            // 
            this.txtEndereco.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtEndereco.Location = new System.Drawing.Point(79, 69);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(424, 20);
            this.txtEndereco.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(437, 92);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(21, 13);
            this.label9.TabIndex = 43;
            this.label9.Text = "UF";
            // 
            // txtNome
            // 
            this.txtNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNome.Location = new System.Drawing.Point(79, 49);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(424, 20);
            this.txtNome.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(45, 155);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 13);
            this.label7.TabIndex = 30;
            this.label7.Text = "Email";
            // 
            // btnExcluir
            // 
            this.btnExcluir.Image = global::Money.Properties.Resources.Erase;
            this.btnExcluir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnExcluir.Location = new System.Drawing.Point(270, 190);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(47, 45);
            this.btnExcluir.TabIndex = 10;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip1.SetToolTip(this.btnExcluir, "Excluir Registro");
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnSair
            // 
            this.btnSair.Image = global::Money.Properties.Resources.Sair_;
            this.btnSair.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSair.Location = new System.Drawing.Point(317, 190);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(47, 45);
            this.btnSair.TabIndex = 11;
            this.btnSair.Text = "Sair";
            this.btnSair.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip1.SetToolTip(this.btnSair, "Sair");
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnGravar
            // 
            this.btnGravar.Image = global::Money.Properties.Resources.Salvar_;
            this.btnGravar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnGravar.Location = new System.Drawing.Point(129, 190);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(47, 45);
            this.btnGravar.TabIndex = 7;
            this.btnGravar.Text = "Gravar";
            this.btnGravar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip1.SetToolTip(this.btnGravar, "Grava Registro");
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Image = global::Money.Properties.Resources.Modify;
            this.btnAlterar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAlterar.Location = new System.Drawing.Point(223, 190);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(47, 45);
            this.btnAlterar.TabIndex = 9;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip1.SetToolTip(this.btnAlterar, "Altera Registro");
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnLimpa
            // 
            this.btnLimpa.Image = global::Money.Properties.Resources.New_document;
            this.btnLimpa.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnLimpa.Location = new System.Drawing.Point(176, 190);
            this.btnLimpa.Name = "btnLimpa";
            this.btnLimpa.Size = new System.Drawing.Size(47, 45);
            this.btnLimpa.TabIndex = 8;
            this.btnLimpa.Text = "Limpar";
            this.btnLimpa.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip1.SetToolTip(this.btnLimpa, "Limpa Campo");
            this.btnLimpa.UseVisualStyleBackColor = true;
            this.btnLimpa.Click += new System.EventHandler(this.btnLimpa_Click);
            // 
            // frmCadLista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(543, 255);
            this.Controls.Add(this.btnLimpa);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.txtCidade);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtUf);
            this.Controls.Add(this.txtCodCidade);
            this.Controls.Add(this.txtCelular);
            this.Controls.Add(this.txtFonee);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtEndereco);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label7);
            this.Name = "frmCadLista";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtCodigo;
        public System.Windows.Forms.TextBox txtCodCidade;
        public System.Windows.Forms.TextBox txtUf;
        public System.Windows.Forms.TextBox txtCelular;
        public System.Windows.Forms.TextBox txtFonee;
        public System.Windows.Forms.TextBox txtEmail;
        public System.Windows.Forms.TextBox txtEndereco;
        public System.Windows.Forms.TextBox txtNome;
        public System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.ToolTip toolTip1;
        public System.Windows.Forms.Button btnExcluir;
        public System.Windows.Forms.Button btnSair;
        public System.Windows.Forms.Button btnGravar;
        public System.Windows.Forms.Button btnAlterar;
        public System.Windows.Forms.Button btnLimpa;
    }
}
