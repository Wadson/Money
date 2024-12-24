namespace Money
{
    partial class frmPesquisaConta
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
            this.datagridpesquisa = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbCentroCusto = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dtInicial = new System.Windows.Forms.DateTimePicker();
            this.txtLocalizar = new System.Windows.Forms.TextBox();
            this.dtFinal = new System.Windows.Forms.DateTimePicker();
            this.groupBoxOpcoes = new System.Windows.Forms.GroupBox();
            this.checkBoxPagas = new System.Windows.Forms.CheckBox();
            this.rbCentroCusto = new System.Windows.Forms.RadioButton();
            this.checkBoxNãoPagas = new System.Windows.Forms.CheckBox();
            this.rbVencimento = new System.Windows.Forms.RadioButton();
            this.rbFornecedor = new System.Windows.Forms.RadioButton();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolstripRegistros = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.datagridpesquisa)).BeginInit();
            this.groupBoxOpcoes.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // datagridpesquisa
            // 
            this.datagridpesquisa.AllowUserToAddRows = false;
            this.datagridpesquisa.AllowUserToDeleteRows = false;
            this.datagridpesquisa.AllowUserToOrderColumns = true;
            this.datagridpesquisa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.datagridpesquisa.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.datagridpesquisa.Location = new System.Drawing.Point(13, 126);
            this.datagridpesquisa.Name = "datagridpesquisa";
            this.datagridpesquisa.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.datagridpesquisa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagridpesquisa.Size = new System.Drawing.Size(836, 290);
            this.datagridpesquisa.StandardTab = true;
            this.datagridpesquisa.TabIndex = 83;
            this.datagridpesquisa.TabStop = false;
            this.datagridpesquisa.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagridpesquisa_CellClick);
            this.datagridpesquisa.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagridpesquisa_CellDoubleClick);
            this.datagridpesquisa.SelectionChanged += new System.EventHandler(this.datagridpesquisa_SelectionChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label1.Location = new System.Drawing.Point(295, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 17);
            this.label1.TabIndex = 246;
            this.label1.Text = "Centro custo";
            // 
            // cmbCentroCusto
            // 
            this.cmbCentroCusto.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmbCentroCusto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCentroCusto.FormattingEnabled = true;
            this.cmbCentroCusto.Location = new System.Drawing.Point(296, 48);
            this.cmbCentroCusto.Name = "cmbCentroCusto";
            this.cmbCentroCusto.Size = new System.Drawing.Size(155, 21);
            this.cmbCentroCusto.TabIndex = 245;
            this.cmbCentroCusto.TabStop = false;
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.DarkCyan;
            this.label11.Location = new System.Drawing.Point(716, 50);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(22, 13);
            this.label11.TabIndex = 244;
            this.label11.Text = "até";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label8.ForeColor = System.Drawing.Color.Blue;
            this.label8.Location = new System.Drawing.Point(452, 31);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(365, 17);
            this.label8.TabIndex = 242;
            this.label8.Text = "Informe as iniciais do fornecdor ou um intervalo de datas";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.DarkCyan;
            this.label9.Location = new System.Drawing.Point(583, 51);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(19, 13);
            this.label9.TabIndex = 243;
            this.label9.Text = "de";
            // 
            // dtInicial
            // 
            this.dtInicial.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtInicial.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtInicial.Location = new System.Drawing.Point(606, 48);
            this.dtInicial.Name = "dtInicial";
            this.dtInicial.Size = new System.Drawing.Size(103, 20);
            this.dtInicial.TabIndex = 1;
            // 
            // txtLocalizar
            // 
            this.txtLocalizar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtLocalizar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLocalizar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtLocalizar.Location = new System.Drawing.Point(457, 48);
            this.txtLocalizar.Name = "txtLocalizar";
            this.txtLocalizar.Size = new System.Drawing.Size(122, 20);
            this.txtLocalizar.TabIndex = 0;
            this.txtLocalizar.Enter += new System.EventHandler(this.txtLocalizar_Enter);
            this.txtLocalizar.Leave += new System.EventHandler(this.txtLocalizar_Leave);
            // 
            // dtFinal
            // 
            this.dtFinal.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtFinal.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtFinal.Location = new System.Drawing.Point(742, 48);
            this.dtFinal.Name = "dtFinal";
            this.dtFinal.Size = new System.Drawing.Size(95, 20);
            this.dtFinal.TabIndex = 2;
            // 
            // groupBoxOpcoes
            // 
            this.groupBoxOpcoes.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBoxOpcoes.Controls.Add(this.checkBoxPagas);
            this.groupBoxOpcoes.Controls.Add(this.rbCentroCusto);
            this.groupBoxOpcoes.Controls.Add(this.checkBoxNãoPagas);
            this.groupBoxOpcoes.Controls.Add(this.rbVencimento);
            this.groupBoxOpcoes.Controls.Add(this.rbFornecedor);
            this.groupBoxOpcoes.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBoxOpcoes.Location = new System.Drawing.Point(29, 31);
            this.groupBoxOpcoes.Name = "groupBoxOpcoes";
            this.groupBoxOpcoes.Size = new System.Drawing.Size(262, 68);
            this.groupBoxOpcoes.TabIndex = 239;
            this.groupBoxOpcoes.TabStop = false;
            this.groupBoxOpcoes.Text = "Filtro Opcional por:";
            // 
            // checkBoxPagas
            // 
            this.checkBoxPagas.AutoSize = true;
            this.checkBoxPagas.Location = new System.Drawing.Point(7, 45);
            this.checkBoxPagas.Name = "checkBoxPagas";
            this.checkBoxPagas.Size = new System.Drawing.Size(56, 17);
            this.checkBoxPagas.TabIndex = 239;
            this.checkBoxPagas.TabStop = false;
            this.checkBoxPagas.Text = "Pagas";
            this.checkBoxPagas.UseVisualStyleBackColor = true;
            // 
            // rbCentroCusto
            // 
            this.rbCentroCusto.AutoSize = true;
            this.rbCentroCusto.FlatAppearance.BorderColor = System.Drawing.Color.Cyan;
            this.rbCentroCusto.FlatAppearance.CheckedBackColor = System.Drawing.Color.Red;
            this.rbCentroCusto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.rbCentroCusto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.rbCentroCusto.Location = new System.Drawing.Point(170, 19);
            this.rbCentroCusto.Name = "rbCentroCusto";
            this.rbCentroCusto.Size = new System.Drawing.Size(85, 17);
            this.rbCentroCusto.TabIndex = 85;
            this.rbCentroCusto.Text = "Centro custo";
            this.rbCentroCusto.UseVisualStyleBackColor = true;
            this.rbCentroCusto.CheckedChanged += new System.EventHandler(this.rbCentroCusto_CheckedChanged);
            // 
            // checkBoxNãoPagas
            // 
            this.checkBoxNãoPagas.AutoSize = true;
            this.checkBoxNãoPagas.Location = new System.Drawing.Point(89, 45);
            this.checkBoxNãoPagas.Name = "checkBoxNãoPagas";
            this.checkBoxNãoPagas.Size = new System.Drawing.Size(79, 17);
            this.checkBoxNãoPagas.TabIndex = 238;
            this.checkBoxNãoPagas.TabStop = false;
            this.checkBoxNãoPagas.Text = "Não Pagas";
            this.checkBoxNãoPagas.UseVisualStyleBackColor = true;
            // 
            // rbVencimento
            // 
            this.rbVencimento.AutoSize = true;
            this.rbVencimento.FlatAppearance.BorderColor = System.Drawing.Color.Cyan;
            this.rbVencimento.FlatAppearance.CheckedBackColor = System.Drawing.Color.Red;
            this.rbVencimento.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.rbVencimento.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.rbVencimento.Location = new System.Drawing.Point(89, 19);
            this.rbVencimento.Name = "rbVencimento";
            this.rbVencimento.Size = new System.Drawing.Size(81, 17);
            this.rbVencimento.TabIndex = 84;
            this.rbVencimento.Text = "Vencimento";
            this.rbVencimento.UseVisualStyleBackColor = true;
            this.rbVencimento.CheckedChanged += new System.EventHandler(this.rbVencimento_CheckedChanged);
            // 
            // rbFornecedor
            // 
            this.rbFornecedor.AutoSize = true;
            this.rbFornecedor.FlatAppearance.BorderColor = System.Drawing.Color.Cyan;
            this.rbFornecedor.FlatAppearance.CheckedBackColor = System.Drawing.Color.Red;
            this.rbFornecedor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.rbFornecedor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.rbFornecedor.Location = new System.Drawing.Point(7, 19);
            this.rbFornecedor.Name = "rbFornecedor";
            this.rbFornecedor.Size = new System.Drawing.Size(82, 17);
            this.rbFornecedor.TabIndex = 82;
            this.rbFornecedor.Text = "Fornecedor ";
            this.rbFornecedor.UseVisualStyleBackColor = true;
            this.rbFornecedor.CheckedChanged += new System.EventHandler(this.rbFornecedor_CheckedChanged);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnPesquisar.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnPesquisar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnPesquisar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.btnPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisar.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnPesquisar.Location = new System.Drawing.Point(707, 76);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(62, 26);
            this.btnPesquisar.TabIndex = 3;
            this.btnPesquisar.Text = "OK";
            this.btnPesquisar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPesquisar.UseVisualStyleBackColor = false;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnVoltar.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnVoltar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnVoltar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVoltar.Location = new System.Drawing.Point(769, 76);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(62, 26);
            this.btnVoltar.TabIndex = 248;
            this.btnVoltar.TabStop = false;
            this.btnVoltar.Text = "&Sair";
            this.btnVoltar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolstripRegistros,
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 427);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(873, 22);
            this.statusStrip1.TabIndex = 249;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolstripRegistros
            // 
            this.toolstripRegistros.Name = "toolstripRegistros";
            this.toolstripRegistros.Size = new System.Drawing.Size(0, 17);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.BackColor = System.Drawing.SystemColors.Control;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(63, 17);
            this.toolStripStatusLabel1.Text = "Registro(s)";
            // 
            // frmPesquisaConta
            // 
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(873, 449);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbCentroCusto);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dtInicial);
            this.Controls.Add(this.txtLocalizar);
            this.Controls.Add(this.dtFinal);
            this.Controls.Add(this.groupBoxOpcoes);
            this.Controls.Add(this.datagridpesquisa);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frmPesquisaConta";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pesquisa Contas";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPesquisaConta_FormClosing);
            this.Load += new System.EventHandler(this.frmPesquisaConta_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmPesquisaConta_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.datagridpesquisa)).EndInit();
            this.groupBoxOpcoes.ResumeLayout(false);
            this.groupBoxOpcoes.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView datagridpesquisa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbCentroCusto;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dtInicial;
        private System.Windows.Forms.TextBox txtLocalizar;
        private System.Windows.Forms.DateTimePicker dtFinal;
        private System.Windows.Forms.GroupBox groupBoxOpcoes;
        private System.Windows.Forms.CheckBox checkBoxPagas;
        private System.Windows.Forms.RadioButton rbCentroCusto;
        private System.Windows.Forms.CheckBox checkBoxNãoPagas;
        private System.Windows.Forms.RadioButton rbVencimento;
        private System.Windows.Forms.RadioButton rbFornecedor;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolstripRegistros;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}
