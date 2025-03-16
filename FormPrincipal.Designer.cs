namespace Money
{
    partial class FormPrincipal
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.pnlContainer = new MetroFramework.Controls.MetroPanel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cartãoDeCréditoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoriasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gastosComCombustíveisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.meiosDePagamentosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tiposDeReceitasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manutençãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.btnCategoria = new System.Windows.Forms.Button();
            this.btnUsuario = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnReceitas = new System.Windows.Forms.Button();
            this.btnPagamento = new System.Windows.Forms.Button();
            this.btnDespesas = new System.Windows.Forms.Button();
            this.btnRelatorio = new System.Windows.Forms.Button();
            this.ferramentasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cópiaDeSegurançaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gerarCópiaDeSegurançaBackupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restaurarCópiaDeSegurançaBackupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(20, 726);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1069, 22);
            this.statusStrip1.TabIndex = 16;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // pnlContainer
            // 
            this.pnlContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlContainer.HorizontalScrollbarBarColor = true;
            this.pnlContainer.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlContainer.HorizontalScrollbarSize = 10;
            this.pnlContainer.Location = new System.Drawing.Point(21, 186);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(1065, 538);
            this.pnlContainer.Style = MetroFramework.MetroColorStyle.Purple;
            this.pnlContainer.TabIndex = 17;
            this.pnlContainer.UseCustomBackColor = true;
            this.pnlContainer.UseCustomForeColor = true;
            this.pnlContainer.UseStyleColors = true;
            this.pnlContainer.VerticalScrollbar = true;
            this.pnlContainer.VerticalScrollbarBarColor = true;
            this.pnlContainer.VerticalScrollbarHighlightOnWheel = false;
            this.pnlContainer.VerticalScrollbarSize = 10;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroToolStripMenuItem,
            this.manutençãoToolStripMenuItem,
            this.ferramentasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(20, 60);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1069, 24);
            this.menuStrip1.TabIndex = 18;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastroToolStripMenuItem
            // 
            this.cadastroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cartãoDeCréditoToolStripMenuItem,
            this.categoriasToolStripMenuItem,
            this.gastosComCombustíveisToolStripMenuItem,
            this.meiosDePagamentosToolStripMenuItem,
            this.tiposDeReceitasToolStripMenuItem});
            this.cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            this.cadastroToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.cadastroToolStripMenuItem.Text = "Cadastro";
            // 
            // cartãoDeCréditoToolStripMenuItem
            // 
            this.cartãoDeCréditoToolStripMenuItem.Name = "cartãoDeCréditoToolStripMenuItem";
            this.cartãoDeCréditoToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.cartãoDeCréditoToolStripMenuItem.Text = "Cartão de Crédito";
            // 
            // categoriasToolStripMenuItem
            // 
            this.categoriasToolStripMenuItem.Name = "categoriasToolStripMenuItem";
            this.categoriasToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.categoriasToolStripMenuItem.Text = "Categorias";
            // 
            // gastosComCombustíveisToolStripMenuItem
            // 
            this.gastosComCombustíveisToolStripMenuItem.Name = "gastosComCombustíveisToolStripMenuItem";
            this.gastosComCombustíveisToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.gastosComCombustíveisToolStripMenuItem.Text = "Gastos com Combustíveis";
            // 
            // meiosDePagamentosToolStripMenuItem
            // 
            this.meiosDePagamentosToolStripMenuItem.Name = "meiosDePagamentosToolStripMenuItem";
            this.meiosDePagamentosToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.meiosDePagamentosToolStripMenuItem.Text = "Meios de Pagamentos";
            // 
            // tiposDeReceitasToolStripMenuItem
            // 
            this.tiposDeReceitasToolStripMenuItem.Name = "tiposDeReceitasToolStripMenuItem";
            this.tiposDeReceitasToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.tiposDeReceitasToolStripMenuItem.Text = "Tipos de Receitas";
            this.tiposDeReceitasToolStripMenuItem.Click += new System.EventHandler(this.tiposDeReceitasToolStripMenuItem_Click);
            // 
            // manutençãoToolStripMenuItem
            // 
            this.manutençãoToolStripMenuItem.Name = "manutençãoToolStripMenuItem";
            this.manutençãoToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.manutençãoToolStripMenuItem.Text = "Manutenção";
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.btnCategoria);
            this.kryptonPanel1.Controls.Add(this.btnUsuario);
            this.kryptonPanel1.Controls.Add(this.btnSair);
            this.kryptonPanel1.Controls.Add(this.btnReceitas);
            this.kryptonPanel1.Controls.Add(this.btnPagamento);
            this.kryptonPanel1.Controls.Add(this.btnDespesas);
            this.kryptonPanel1.Controls.Add(this.btnRelatorio);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.kryptonPanel1.Location = new System.Drawing.Point(20, 84);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.kryptonPanel1.PanelBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.SeparatorHighProfile;
            this.kryptonPanel1.Size = new System.Drawing.Size(1069, 94);
            this.kryptonPanel1.TabIndex = 19;
            // 
            // btnCategoria
            // 
            this.btnCategoria.BackColor = System.Drawing.Color.Transparent;
            this.btnCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCategoria.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnCategoria.Image = global::Money.Properties.Resources.categor64;
            this.btnCategoria.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCategoria.Location = new System.Drawing.Point(208, 3);
            this.btnCategoria.Name = "btnCategoria";
            this.btnCategoria.Size = new System.Drawing.Size(70, 88);
            this.btnCategoria.TabIndex = 23;
            this.btnCategoria.Text = "Categoria";
            this.btnCategoria.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCategoria.UseVisualStyleBackColor = false;
            this.btnCategoria.Click += new System.EventHandler(this.btnCategoria_Click);
            // 
            // btnUsuario
            // 
            this.btnUsuario.BackColor = System.Drawing.Color.Transparent;
            this.btnUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnUsuario.Image = global::Money.Properties.Resources.adicionar_usuar64;
            this.btnUsuario.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnUsuario.Location = new System.Drawing.Point(1, 3);
            this.btnUsuario.Name = "btnUsuario";
            this.btnUsuario.Size = new System.Drawing.Size(70, 88);
            this.btnUsuario.TabIndex = 19;
            this.btnUsuario.Text = "Usuario";
            this.btnUsuario.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnUsuario.UseVisualStyleBackColor = false;
            // 
            // btnSair
            // 
            this.btnSair.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSair.BackColor = System.Drawing.Color.Transparent;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnSair.Image = global::Money.Properties.Resources.Exit64;
            this.btnSair.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSair.Location = new System.Drawing.Point(991, 3);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(70, 88);
            this.btnSair.TabIndex = 25;
            this.btnSair.Text = "Sair";
            this.btnSair.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnReceitas
            // 
            this.btnReceitas.BackColor = System.Drawing.Color.Transparent;
            this.btnReceitas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReceitas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnReceitas.Image = global::Money.Properties.Resources.investimento64;
            this.btnReceitas.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnReceitas.Location = new System.Drawing.Point(70, 3);
            this.btnReceitas.Name = "btnReceitas";
            this.btnReceitas.Size = new System.Drawing.Size(70, 88);
            this.btnReceitas.TabIndex = 20;
            this.btnReceitas.Text = "Receitas";
            this.btnReceitas.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnReceitas.UseVisualStyleBackColor = false;
            this.btnReceitas.Click += new System.EventHandler(this.btnReceitas_Click);
            // 
            // btnPagamento
            // 
            this.btnPagamento.BackColor = System.Drawing.Color.Transparent;
            this.btnPagamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPagamento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnPagamento.Image = global::Money.Properties.Resources.pagamentos64;
            this.btnPagamento.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPagamento.Location = new System.Drawing.Point(346, 3);
            this.btnPagamento.Name = "btnPagamento";
            this.btnPagamento.Size = new System.Drawing.Size(70, 88);
            this.btnPagamento.TabIndex = 24;
            this.btnPagamento.Text = "Pgto";
            this.btnPagamento.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPagamento.UseVisualStyleBackColor = false;
            this.btnPagamento.Click += new System.EventHandler(this.btnPagamento_Click);
            // 
            // btnDespesas
            // 
            this.btnDespesas.BackColor = System.Drawing.Color.Transparent;
            this.btnDespesas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDespesas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnDespesas.Image = global::Money.Properties.Resources.Despesa64;
            this.btnDespesas.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDespesas.Location = new System.Drawing.Point(139, 3);
            this.btnDespesas.Name = "btnDespesas";
            this.btnDespesas.Size = new System.Drawing.Size(70, 88);
            this.btnDespesas.TabIndex = 21;
            this.btnDespesas.Text = "Despesas";
            this.btnDespesas.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDespesas.UseVisualStyleBackColor = false;
            this.btnDespesas.Click += new System.EventHandler(this.btnDespesas_Click);
            // 
            // btnRelatorio
            // 
            this.btnRelatorio.BackColor = System.Drawing.Color.Transparent;
            this.btnRelatorio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRelatorio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnRelatorio.Image = global::Money.Properties.Resources.analise_de_dados64;
            this.btnRelatorio.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnRelatorio.Location = new System.Drawing.Point(277, 3);
            this.btnRelatorio.Name = "btnRelatorio";
            this.btnRelatorio.Size = new System.Drawing.Size(70, 88);
            this.btnRelatorio.TabIndex = 22;
            this.btnRelatorio.Text = "Relatorios";
            this.btnRelatorio.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRelatorio.UseVisualStyleBackColor = false;
            this.btnRelatorio.Click += new System.EventHandler(this.btnRelatorio_Click);
            // 
            // ferramentasToolStripMenuItem
            // 
            this.ferramentasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cópiaDeSegurançaToolStripMenuItem});
            this.ferramentasToolStripMenuItem.Name = "ferramentasToolStripMenuItem";
            this.ferramentasToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.ferramentasToolStripMenuItem.Text = "Ferramentas";
            // 
            // cópiaDeSegurançaToolStripMenuItem
            // 
            this.cópiaDeSegurançaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gerarCópiaDeSegurançaBackupToolStripMenuItem,
            this.restaurarCópiaDeSegurançaBackupToolStripMenuItem});
            this.cópiaDeSegurançaToolStripMenuItem.Name = "cópiaDeSegurançaToolStripMenuItem";
            this.cópiaDeSegurançaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cópiaDeSegurançaToolStripMenuItem.Text = "Cópia de Segurança";
            // 
            // gerarCópiaDeSegurançaBackupToolStripMenuItem
            // 
            this.gerarCópiaDeSegurançaBackupToolStripMenuItem.Name = "gerarCópiaDeSegurançaBackupToolStripMenuItem";
            this.gerarCópiaDeSegurançaBackupToolStripMenuItem.Size = new System.Drawing.Size(281, 22);
            this.gerarCópiaDeSegurançaBackupToolStripMenuItem.Text = "Gerar Cópia de Segurança (Backup)";
            this.gerarCópiaDeSegurançaBackupToolStripMenuItem.Click += new System.EventHandler(this.gerarCópiaDeSegurançaBackupToolStripMenuItem_Click);
            // 
            // restaurarCópiaDeSegurançaBackupToolStripMenuItem
            // 
            this.restaurarCópiaDeSegurançaBackupToolStripMenuItem.Name = "restaurarCópiaDeSegurançaBackupToolStripMenuItem";
            this.restaurarCópiaDeSegurançaBackupToolStripMenuItem.Size = new System.Drawing.Size(281, 22);
            this.restaurarCópiaDeSegurançaBackupToolStripMenuItem.Text = "Restaurar Cópia de Segurança (Backup)";
            this.restaurarCópiaDeSegurançaBackupToolStripMenuItem.Click += new System.EventHandler(this.restaurarCópiaDeSegurançaBackupToolStripMenuItem_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1109, 768);
            this.Controls.Add(this.kryptonPanel1);
            this.Controls.Add(this.pnlContainer);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormPrincipal";
            this.Text = "Money - Sistema de Controle Financeiro";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.StatusStrip statusStrip1;
        private MetroFramework.Controls.MetroPanel pnlContainer;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manutençãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cartãoDeCréditoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoriasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gastosComCombustíveisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem meiosDePagamentosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tiposDeReceitasToolStripMenuItem;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private System.Windows.Forms.Button btnCategoria;
        private System.Windows.Forms.Button btnUsuario;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnReceitas;
        private System.Windows.Forms.Button btnPagamento;
        private System.Windows.Forms.Button btnDespesas;
        private System.Windows.Forms.Button btnRelatorio;
        private System.Windows.Forms.ToolStripMenuItem ferramentasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cópiaDeSegurançaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gerarCópiaDeSegurançaBackupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restaurarCópiaDeSegurançaBackupToolStripMenuItem;
    }
}