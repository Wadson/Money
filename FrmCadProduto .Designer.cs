namespace Money
{
    partial class FrmCadProduto
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
            this.txtProduto = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtIdProduto = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.txtDescricaoProduto = new System.Windows.Forms.TextBox();
            this.btnFechar = new System.Windows.Forms.Button();
            this.txtMarcaProduto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPrecoCustoProduto = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtLucroProduto = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPrecoVendaProduto = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(2, 311);
            this.panel2.Size = new System.Drawing.Size(497, 2);
            // 
            // panel3
            // 
            this.panel3.Size = new System.Drawing.Size(497, 25);
            // 
            // panel4
            // 
            this.panel4.Size = new System.Drawing.Size(2, 313);
            // 
            // panel5
            // 
            this.panel5.Location = new System.Drawing.Point(499, 0);
            this.panel5.Size = new System.Drawing.Size(2, 313);
            // 
            // btnExit
            // 
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.Location = new System.Drawing.Point(463, 3);
            // 
            // txtProduto
            // 
            this.txtProduto.Location = new System.Drawing.Point(135, 97);
            this.txtProduto.MaxLength = 100;
            this.txtProduto.Name = "txtProduto";
            this.txtProduto.Size = new System.Drawing.Size(329, 21);
            this.txtProduto.TabIndex = 0;
            this.txtProduto.Enter += new System.EventHandler(this.txtProduto_Enter);
            this.txtProduto.Leave += new System.EventHandler(this.txtProduto_Leave);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(76)))), ((int)(((byte)(172)))));
            this.label16.Location = new System.Drawing.Point(65, 71);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(57, 16);
            this.label16.TabIndex = 106;
            this.label16.Text = "Código";
            // 
            // txtIdProduto
            // 
            this.txtIdProduto.Location = new System.Drawing.Point(135, 69);
            this.txtIdProduto.Name = "txtIdProduto";
            this.txtIdProduto.ReadOnly = true;
            this.txtIdProduto.Size = new System.Drawing.Size(329, 21);
            this.txtIdProduto.TabIndex = 105;
            this.txtIdProduto.TabStop = false;
            this.txtIdProduto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(76)))), ((int)(((byte)(172)))));
            this.label2.Location = new System.Drawing.Point(80, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 16);
            this.label2.TabIndex = 99;
            this.label2.Text = "Nome:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(76)))), ((int)(((byte)(172)))));
            this.label1.Location = new System.Drawing.Point(59, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 16);
            this.label1.TabIndex = 98;
            this.label1.Text = "Descrição:";
            // 
            // btnNovo
            // 
            this.btnNovo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(182)))));
            this.btnNovo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnNovo.ForeColor = System.Drawing.Color.White;
            this.btnNovo.Location = new System.Drawing.Point(258, 259);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(76, 35);
            this.btnNovo.TabIndex = 7;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = false;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click_1);
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(182)))));
            this.btnSalvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnSalvar.ForeColor = System.Drawing.Color.White;
            this.btnSalvar.Location = new System.Drawing.Point(135, 259);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(76, 35);
            this.btnSalvar.TabIndex = 6;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // txtDescricaoProduto
            // 
            this.txtDescricaoProduto.Location = new System.Drawing.Point(135, 124);
            this.txtDescricaoProduto.MaxLength = 100;
            this.txtDescricaoProduto.Name = "txtDescricaoProduto";
            this.txtDescricaoProduto.Size = new System.Drawing.Size(329, 21);
            this.txtDescricaoProduto.TabIndex = 1;
            this.txtDescricaoProduto.Enter += new System.EventHandler(this.txtDescricaoProduto_Enter);
            this.txtDescricaoProduto.Leave += new System.EventHandler(this.txtDescricaoProduto_Leave);
            // 
            // btnFechar
            // 
            this.btnFechar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(182)))));
            this.btnFechar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnFechar.ForeColor = System.Drawing.Color.White;
            this.btnFechar.Location = new System.Drawing.Point(388, 259);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(76, 35);
            this.btnFechar.TabIndex = 8;
            this.btnFechar.Text = "&Fechar";
            this.btnFechar.UseVisualStyleBackColor = false;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // txtMarcaProduto
            // 
            this.txtMarcaProduto.Location = new System.Drawing.Point(135, 151);
            this.txtMarcaProduto.MaxLength = 100;
            this.txtMarcaProduto.Name = "txtMarcaProduto";
            this.txtMarcaProduto.Size = new System.Drawing.Size(329, 21);
            this.txtMarcaProduto.TabIndex = 2;
            this.txtMarcaProduto.Enter += new System.EventHandler(this.txtMarcaProduto_Enter);
            this.txtMarcaProduto.Leave += new System.EventHandler(this.txtMarcaProduto_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(76)))), ((int)(((byte)(172)))));
            this.label3.Location = new System.Drawing.Point(75, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 16);
            this.label3.TabIndex = 108;
            this.label3.Text = "Marca:";
            // 
            // txtPrecoCustoProduto
            // 
            this.txtPrecoCustoProduto.Location = new System.Drawing.Point(135, 178);
            this.txtPrecoCustoProduto.MaxLength = 100;
            this.txtPrecoCustoProduto.Name = "txtPrecoCustoProduto";
            this.txtPrecoCustoProduto.Size = new System.Drawing.Size(329, 21);
            this.txtPrecoCustoProduto.TabIndex = 3;
            this.txtPrecoCustoProduto.Enter += new System.EventHandler(this.txtPrecoCustoProduto_Enter);
            this.txtPrecoCustoProduto.Leave += new System.EventHandler(this.txtPrecoCustoProduto_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(76)))), ((int)(((byte)(172)))));
            this.label4.Location = new System.Drawing.Point(29, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 16);
            this.label4.TabIndex = 110;
            this.label4.Text = "Preço de Custo:";
            // 
            // txtLucroProduto
            // 
            this.txtLucroProduto.Location = new System.Drawing.Point(135, 205);
            this.txtLucroProduto.MaxLength = 100;
            this.txtLucroProduto.Name = "txtLucroProduto";
            this.txtLucroProduto.Size = new System.Drawing.Size(329, 21);
            this.txtLucroProduto.TabIndex = 4;
            this.txtLucroProduto.Enter += new System.EventHandler(this.txtLucroProduto_Enter);
            this.txtLucroProduto.Leave += new System.EventHandler(this.txtLucroProduto_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(76)))), ((int)(((byte)(172)))));
            this.label5.Location = new System.Drawing.Point(66, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 16);
            this.label5.TabIndex = 112;
            this.label5.Text = "Lucro(%);";
            // 
            // txtPrecoVendaProduto
            // 
            this.txtPrecoVendaProduto.Location = new System.Drawing.Point(135, 232);
            this.txtPrecoVendaProduto.MaxLength = 100;
            this.txtPrecoVendaProduto.Name = "txtPrecoVendaProduto";
            this.txtPrecoVendaProduto.Size = new System.Drawing.Size(329, 21);
            this.txtPrecoVendaProduto.TabIndex = 5;
            this.txtPrecoVendaProduto.Enter += new System.EventHandler(this.txtPrecoVendaProduto_Enter);
            this.txtPrecoVendaProduto.Leave += new System.EventHandler(this.txtPrecoVendaProduto_Leave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(76)))), ((int)(((byte)(172)))));
            this.label6.Location = new System.Drawing.Point(23, 237);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 16);
            this.label6.TabIndex = 114;
            this.label6.Text = "Preço de Venda:";
            // 
            // FrmCadProduto
            // 
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(501, 313);
            this.Controls.Add(this.txtPrecoVendaProduto);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtLucroProduto);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtPrecoCustoProduto);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtMarcaProduto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.txtDescricaoProduto);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.txtProduto);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.txtIdProduto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmCadProduto";
            this.Text = "Cadastro de Fornecedores";
            this.Load += new System.EventHandler(this.FrmCadProduto_Load);
            this.Controls.SetChildIndex(this.panel5, 0);
            this.Controls.SetChildIndex(this.panel4, 0);
            this.Controls.SetChildIndex(this.panel3, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.txtIdProduto, 0);
            this.Controls.SetChildIndex(this.label16, 0);
            this.Controls.SetChildIndex(this.txtProduto, 0);
            this.Controls.SetChildIndex(this.btnSalvar, 0);
            this.Controls.SetChildIndex(this.btnNovo, 0);
            this.Controls.SetChildIndex(this.txtDescricaoProduto, 0);
            this.Controls.SetChildIndex(this.btnFechar, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.txtMarcaProduto, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.txtPrecoCustoProduto, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.txtLucroProduto, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.txtPrecoVendaProduto, 0);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox txtProduto;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.MaskedTextBox txtIdProduto;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnSalvar;
        public System.Windows.Forms.TextBox txtDescricaoProduto;
        private System.Windows.Forms.Button btnFechar;
        public System.Windows.Forms.TextBox txtMarcaProduto;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txtPrecoCustoProduto;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txtLucroProduto;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox txtPrecoVendaProduto;
        private System.Windows.Forms.Label label6;
    }
}
