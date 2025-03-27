namespace Money
{
    partial class FormFluxoFinanceiro
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.kryptonPalette1 = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
            this.dtpMesAno = new ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker();
            this.kryptonPanel2 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.txtTotalSelecionado = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSaldo = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txtTotalDespesas = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txtTotalReceitas = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.btnSair = new System.Windows.Forms.Button();
            this.lblSald = new System.Windows.Forms.Label();
            this.lblTotalReceita = new System.Windows.Forms.Label();
            this.lblTotalDespesa = new System.Windows.Forms.Label();
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.listViewDespesas = new System.Windows.Forms.ListView();
            this.listViewReceitas = new System.Windows.Forms.ListView();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).BeginInit();
            this.kryptonPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // kryptonPalette1
            // 
            this.kryptonPalette1.ButtonSpecs.FormClose.Image = global::Money.Properties.Resources.Sair_24;
            this.kryptonPalette1.ButtonSpecs.FormClose.ImageStates.ImagePressed = global::Money.Properties.Resources.Sair24;
            this.kryptonPalette1.ButtonSpecs.FormClose.ImageStates.ImageTracking = global::Money.Properties.Resources.Sair24;
            this.kryptonPalette1.ButtonSpecs.FormMax.Image = global::Money.Properties.Resources.Maximize;
            this.kryptonPalette1.ButtonSpecs.FormMax.ImageStates.ImagePressed = global::Money.Properties.Resources.Minimiza24;
            this.kryptonPalette1.ButtonSpecs.FormMax.ImageStates.ImageTracking = global::Money.Properties.Resources.Minimiza24;
            this.kryptonPalette1.ButtonSpecs.FormMin.Image = global::Money.Properties.Resources.Minimize;
            this.kryptonPalette1.ButtonSpecs.FormMin.ImageStates.ImagePressed = global::Money.Properties.Resources.Minimizar24;
            this.kryptonPalette1.ButtonSpecs.FormMin.ImageStates.ImageTracking = global::Money.Properties.Resources.Minimizar24;
            this.kryptonPalette1.ButtonSpecs.FormRestore.Image = global::Money.Properties.Resources.Maximize;
            this.kryptonPalette1.ButtonSpecs.FormRestore.ImageStates.ImagePressed = global::Money.Properties.Resources.Minimiza24;
            this.kryptonPalette1.ButtonSpecs.FormRestore.ImageStates.ImageTracking = global::Money.Properties.Resources.Minimiza24;
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.None;
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Border.Rounding = 12;
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.ButtonEdgeInset = 10;
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, -1, -1, -1);
            // 
            // dtpMesAno
            // 
            this.dtpMesAno.CalendarDayStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Gallery;
            this.dtpMesAno.CalendarHeaderStyle = ComponentFactory.Krypton.Toolkit.HeaderStyle.Form;
            this.dtpMesAno.CalendarTodayDate = new System.DateTime(2025, 3, 13, 0, 0, 0, 0);
            this.dtpMesAno.CustomFormat = "MM/yyyy";
            this.dtpMesAno.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpMesAno.Location = new System.Drawing.Point(96, 3);
            this.dtpMesAno.Name = "dtpMesAno";
            this.dtpMesAno.Palette = this.kryptonPalette1;
            this.dtpMesAno.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.dtpMesAno.Size = new System.Drawing.Size(118, 37);
            this.dtpMesAno.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.dtpMesAno.StateCommon.Border.Rounding = 20;
            this.dtpMesAno.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F);
            this.dtpMesAno.TabIndex = 311;
            this.dtpMesAno.ValueChanged += new System.EventHandler(this.dtpMesAno_ValueChanged);
            // 
            // kryptonPanel2
            // 
            this.kryptonPanel2.Controls.Add(this.txtTotalSelecionado);
            this.kryptonPanel2.Controls.Add(this.label2);
            this.kryptonPanel2.Controls.Add(this.txtSaldo);
            this.kryptonPanel2.Controls.Add(this.txtTotalDespesas);
            this.kryptonPanel2.Controls.Add(this.txtTotalReceitas);
            this.kryptonPanel2.Controls.Add(this.btnSair);
            this.kryptonPanel2.Controls.Add(this.lblSald);
            this.kryptonPanel2.Controls.Add(this.lblTotalReceita);
            this.kryptonPanel2.Controls.Add(this.lblTotalDespesa);
            this.kryptonPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.kryptonPanel2.Location = new System.Drawing.Point(0, 446);
            this.kryptonPanel2.Name = "kryptonPanel2";
            this.kryptonPanel2.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Blue;
            this.kryptonPanel2.PanelBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.SeparatorHighProfile;
            this.kryptonPanel2.Size = new System.Drawing.Size(937, 83);
            this.kryptonPanel2.TabIndex = 316;
            // 
            // txtTotalSelecionado
            // 
            this.txtTotalSelecionado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtTotalSelecionado.Location = new System.Drawing.Point(579, 36);
            this.txtTotalSelecionado.Name = "txtTotalSelecionado";
            this.txtTotalSelecionado.ReadOnly = true;
            this.txtTotalSelecionado.Size = new System.Drawing.Size(150, 39);
            this.txtTotalSelecionado.StateCommon.Back.Color1 = System.Drawing.Color.SteelBlue;
            this.txtTotalSelecionado.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.txtTotalSelecionado.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.txtTotalSelecionado.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtTotalSelecionado.StateCommon.Border.Rounding = 20;
            this.txtTotalSelecionado.StateCommon.Border.Width = 1;
            this.txtTotalSelecionado.StateCommon.Content.Color1 = System.Drawing.Color.LightCyan;
            this.txtTotalSelecionado.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalSelecionado.TabIndex = 324;
            this.txtTotalSelecionado.Text = "R$ 0,00";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(76)))), ((int)(((byte)(172)))));
            this.label2.Location = new System.Drawing.Point(590, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 20);
            this.label2.TabIndex = 323;
            this.label2.Text = "Total Selecionado";
            // 
            // txtSaldo
            // 
            this.txtSaldo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtSaldo.Location = new System.Drawing.Point(309, 36);
            this.txtSaldo.Name = "txtSaldo";
            this.txtSaldo.ReadOnly = true;
            this.txtSaldo.Size = new System.Drawing.Size(150, 39);
            this.txtSaldo.StateCommon.Back.Color1 = System.Drawing.Color.SteelBlue;
            this.txtSaldo.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.txtSaldo.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.txtSaldo.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtSaldo.StateCommon.Border.Rounding = 20;
            this.txtSaldo.StateCommon.Border.Width = 1;
            this.txtSaldo.StateCommon.Content.Color1 = System.Drawing.Color.Lime;
            this.txtSaldo.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSaldo.TabIndex = 322;
            this.txtSaldo.Text = "R$ 0,00";
            // 
            // txtTotalDespesas
            // 
            this.txtTotalDespesas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtTotalDespesas.Location = new System.Drawing.Point(159, 36);
            this.txtTotalDespesas.Name = "txtTotalDespesas";
            this.txtTotalDespesas.ReadOnly = true;
            this.txtTotalDespesas.Size = new System.Drawing.Size(150, 39);
            this.txtTotalDespesas.StateCommon.Back.Color1 = System.Drawing.Color.SteelBlue;
            this.txtTotalDespesas.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.txtTotalDespesas.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.txtTotalDespesas.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtTotalDespesas.StateCommon.Border.Rounding = 20;
            this.txtTotalDespesas.StateCommon.Border.Width = 1;
            this.txtTotalDespesas.StateCommon.Content.Color1 = System.Drawing.Color.DarkRed;
            this.txtTotalDespesas.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalDespesas.TabIndex = 321;
            this.txtTotalDespesas.Text = "R$ 0,00";
            // 
            // txtTotalReceitas
            // 
            this.txtTotalReceitas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtTotalReceitas.Location = new System.Drawing.Point(9, 36);
            this.txtTotalReceitas.Name = "txtTotalReceitas";
            this.txtTotalReceitas.ReadOnly = true;
            this.txtTotalReceitas.Size = new System.Drawing.Size(150, 39);
            this.txtTotalReceitas.StateCommon.Back.Color1 = System.Drawing.Color.SteelBlue;
            this.txtTotalReceitas.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.txtTotalReceitas.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.txtTotalReceitas.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtTotalReceitas.StateCommon.Border.Rounding = 20;
            this.txtTotalReceitas.StateCommon.Border.Width = 1;
            this.txtTotalReceitas.StateCommon.Content.Color1 = System.Drawing.Color.LightCyan;
            this.txtTotalReceitas.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalReceitas.TabIndex = 320;
            this.txtTotalReceitas.Text = "R$ 0,00";
            // 
            // btnSair
            // 
            this.btnSair.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSair.BackColor = System.Drawing.Color.LimeGreen;
            this.btnSair.FlatAppearance.BorderColor = System.Drawing.Color.LightGreen;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.btnSair.ForeColor = System.Drawing.Color.White;
            this.btnSair.Location = new System.Drawing.Point(824, 25);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(110, 36);
            this.btnSair.TabIndex = 318;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // lblSald
            // 
            this.lblSald.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblSald.AutoSize = true;
            this.lblSald.BackColor = System.Drawing.Color.Transparent;
            this.lblSald.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblSald.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(76)))), ((int)(((byte)(172)))));
            this.lblSald.Location = new System.Drawing.Point(350, 14);
            this.lblSald.Name = "lblSald";
            this.lblSald.Size = new System.Drawing.Size(51, 20);
            this.lblSald.TabIndex = 319;
            this.lblSald.Text = "Saldo";
            // 
            // lblTotalReceita
            // 
            this.lblTotalReceita.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTotalReceita.AutoSize = true;
            this.lblTotalReceita.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalReceita.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblTotalReceita.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(76)))), ((int)(((byte)(172)))));
            this.lblTotalReceita.Location = new System.Drawing.Point(20, 14);
            this.lblTotalReceita.Name = "lblTotalReceita";
            this.lblTotalReceita.Size = new System.Drawing.Size(117, 20);
            this.lblTotalReceita.TabIndex = 318;
            this.lblTotalReceita.Text = "Total Receitas";
            // 
            // lblTotalDespesa
            // 
            this.lblTotalDespesa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTotalDespesa.AutoSize = true;
            this.lblTotalDespesa.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalDespesa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblTotalDespesa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(76)))), ((int)(((byte)(172)))));
            this.lblTotalDespesa.Location = new System.Drawing.Point(170, 14);
            this.lblTotalDespesa.Name = "lblTotalDespesa";
            this.lblTotalDespesa.Size = new System.Drawing.Size(127, 20);
            this.lblTotalDespesa.TabIndex = 317;
            this.lblTotalDespesa.Text = "Total Despesas";
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.dtpMesAno);
            this.kryptonPanel1.Controls.Add(this.label1);
            this.kryptonPanel1.Controls.Add(this.lblStatus);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Blue;
            this.kryptonPanel1.PanelBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.SeparatorHighProfile;
            this.kryptonPanel1.Size = new System.Drawing.Size(937, 44);
            this.kryptonPanel1.TabIndex = 322;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(76)))), ((int)(((byte)(172)))));
            this.label1.Location = new System.Drawing.Point(5, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 20);
            this.label1.TabIndex = 323;
            this.label1.Text = "Mês / Ano";
            // 
            // lblStatus
            // 
            this.lblStatus.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblStatus.AutoSize = true;
            this.lblStatus.BackColor = System.Drawing.Color.Transparent;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(76)))), ((int)(((byte)(172)))));
            this.lblStatus.Location = new System.Drawing.Point(395, 10);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(153, 24);
            this.lblStatus.TabIndex = 248;
            this.lblStatus.Text = "Fluxo Financeiro";
            // 
            // listViewDespesas
            // 
            this.listViewDespesas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewDespesas.HideSelection = false;
            this.listViewDespesas.Location = new System.Drawing.Point(412, 50);
            this.listViewDespesas.Name = "listViewDespesas";
            this.listViewDespesas.Size = new System.Drawing.Size(522, 366);
            this.listViewDespesas.TabIndex = 323;
            this.listViewDespesas.UseCompatibleStateImageBehavior = false;
            this.listViewDespesas.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.listViewDespesas_ItemCheck);
            // 
            // listViewReceitas
            // 
            this.listViewReceitas.HideSelection = false;
            this.listViewReceitas.Location = new System.Drawing.Point(19, 50);
            this.listViewReceitas.Name = "listViewReceitas";
            this.listViewReceitas.Size = new System.Drawing.Size(377, 366);
            this.listViewReceitas.TabIndex = 324;
            this.listViewReceitas.UseCompatibleStateImageBehavior = false;
            // 
            // FormFluxoFinanceiro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(937, 529);
            this.Controls.Add(this.listViewReceitas);
            this.Controls.Add(this.listViewDespesas);
            this.Controls.Add(this.kryptonPanel1);
            this.Controls.Add(this.kryptonPanel2);
            this.KeyPreview = true;
            this.Name = "FormFluxoFinanceiro";
            this.Palette = this.kryptonPalette1;
            this.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Fluxo Financeiro";
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).EndInit();
            this.kryptonPanel2.ResumeLayout(false);
            this.kryptonPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonPalette kryptonPalette1;
        public ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker dtpMesAno;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel2;
        public System.Windows.Forms.Label lblSald;
        public System.Windows.Forms.Label lblTotalReceita;
        public System.Windows.Forms.Label lblTotalDespesa;
        public System.Windows.Forms.Button btnSair;
        public ComponentFactory.Krypton.Toolkit.KryptonTextBox txtSaldo;
        public ComponentFactory.Krypton.Toolkit.KryptonTextBox txtTotalDespesas;
        public ComponentFactory.Krypton.Toolkit.KryptonTextBox txtTotalReceitas;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
        public System.Windows.Forms.Label lblStatus;
        public System.Windows.Forms.Label label1;
        public ComponentFactory.Krypton.Toolkit.KryptonTextBox txtTotalSelecionado;
        public System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView listViewDespesas;
        private System.Windows.Forms.ListView listViewReceitas;
    }
}

