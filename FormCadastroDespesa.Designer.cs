﻿namespace Money
{
    partial class FormCadastroDespesa
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
            this.txtDescricao = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txtDespesaID = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpDataCadastro = new ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker();
            this.kryptonLabel4 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel3 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txtValorTotal = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel7 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txtNumeroParcelas = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel8 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txtValorParcela = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel5 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.dtpDataVencimento = new ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker();
            this.kryptonLabel9 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.txtMetodoPgto = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.btnLocalizarMetodoPagamento = new System.Windows.Forms.Button();
            this.txtCategoria = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.btnLocalizarCategoria = new System.Windows.Forms.Button();
            this.panelTitulo = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblDataCadastro_e_Pagamento = new System.Windows.Forms.Label();
            this.btnParcelar = new System.Windows.Forms.Button();
            this.groupBoxParcelar = new System.Windows.Forms.GroupBox();
            this.radiobtnNao = new System.Windows.Forms.RadioButton();
            this.radiobtnSim = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radiobtnPendente = new System.Windows.Forms.RadioButton();
            this.radiobtnPago = new System.Windows.Forms.RadioButton();
            this.panelTitulo.SuspendLayout();
            this.groupBoxParcelar.SuspendLayout();
            this.groupBox1.SuspendLayout();
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
            this.kryptonPalette1.CalendarDay.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette1.CalendarDay.StateCommon.Border.Rounding = 12;
            this.kryptonPalette1.CalendarDay.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.kryptonPalette1.CalendarDay.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette1.CalendarDay.StateNormal.Border.Rounding = 20;
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
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(215, 102);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(394, 35);
            this.txtDescricao.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.txtDescricao.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.txtDescricao.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.txtDescricao.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtDescricao.StateCommon.Border.Rounding = 20;
            this.txtDescricao.StateCommon.Border.Width = 1;
            this.txtDescricao.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(76)))), ((int)(((byte)(172)))));
            this.txtDescricao.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.txtDescricao.TabIndex = 2;
            // 
            // txtDespesaID
            // 
            this.txtDespesaID.Location = new System.Drawing.Point(14, 26);
            this.txtDespesaID.Name = "txtDespesaID";
            this.txtDespesaID.ReadOnly = true;
            this.txtDespesaID.Size = new System.Drawing.Size(77, 35);
            this.txtDespesaID.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.txtDespesaID.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.txtDespesaID.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.txtDespesaID.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtDespesaID.StateCommon.Border.Rounding = 20;
            this.txtDespesaID.StateCommon.Border.Width = 1;
            this.txtDespesaID.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(76)))), ((int)(((byte)(172)))));
            this.txtDespesaID.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.txtDespesaID.TabIndex = 14;
            this.txtDespesaID.TabStop = false;
            this.txtDespesaID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(26, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código";
            // 
            // dtpDataCadastro
            // 
            this.dtpDataCadastro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpDataCadastro.CalendarDayStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Gallery;
            this.dtpDataCadastro.CalendarDimensions = new System.Drawing.Size(2, 2);
            this.dtpDataCadastro.CalendarHeaderStyle = ComponentFactory.Krypton.Toolkit.HeaderStyle.Form;
            this.dtpDataCadastro.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataCadastro.Location = new System.Drawing.Point(476, 24);
            this.dtpDataCadastro.Name = "dtpDataCadastro";
            this.dtpDataCadastro.Palette = this.kryptonPalette1;
            this.dtpDataCadastro.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.dtpDataCadastro.Size = new System.Drawing.Size(131, 37);
            this.dtpDataCadastro.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.dtpDataCadastro.StateCommon.Border.Rounding = 20;
            this.dtpDataCadastro.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F);
            this.dtpDataCadastro.TabIndex = 264;
            this.dtpDataCadastro.TabStop = false;
            // 
            // kryptonLabel4
            // 
            this.kryptonLabel4.Location = new System.Drawing.Point(230, 76);
            this.kryptonLabel4.Name = "kryptonLabel4";
            this.kryptonLabel4.Size = new System.Drawing.Size(138, 21);
            this.kryptonLabel4.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(76)))), ((int)(((byte)(172)))));
            this.kryptonLabel4.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel4.TabIndex = 39;
            this.kryptonLabel4.Values.Text = "Descrição da despesa";
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.Location = new System.Drawing.Point(121, 79);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(75, 21);
            this.kryptonLabel3.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(76)))), ((int)(((byte)(172)))));
            this.kryptonLabel3.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel3.TabIndex = 38;
            this.kryptonLabel3.Values.Text = "Valor Total";
            // 
            // txtValorTotal
            // 
            this.txtValorTotal.Location = new System.Drawing.Point(106, 102);
            this.txtValorTotal.Name = "txtValorTotal";
            this.txtValorTotal.Size = new System.Drawing.Size(103, 35);
            this.txtValorTotal.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.txtValorTotal.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.txtValorTotal.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.txtValorTotal.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtValorTotal.StateCommon.Border.Rounding = 20;
            this.txtValorTotal.StateCommon.Border.Width = 1;
            this.txtValorTotal.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(76)))), ((int)(((byte)(172)))));
            this.txtValorTotal.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.txtValorTotal.TabIndex = 1;
            this.txtValorTotal.TextChanged += new System.EventHandler(this.txtValorTotal_TextChanged);
            this.txtValorTotal.Leave += new System.EventHandler(this.txtValor_Leave);
            // 
            // kryptonLabel7
            // 
            this.kryptonLabel7.Location = new System.Drawing.Point(141, 156);
            this.kryptonLabel7.Name = "kryptonLabel7";
            this.kryptonLabel7.Size = new System.Drawing.Size(68, 21);
            this.kryptonLabel7.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(76)))), ((int)(((byte)(172)))));
            this.kryptonLabel7.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel7.TabIndex = 253;
            this.kryptonLabel7.Values.Text = "Categoria";
            // 
            // txtNumeroParcelas
            // 
            this.txtNumeroParcelas.Location = new System.Drawing.Point(402, 179);
            this.txtNumeroParcelas.Name = "txtNumeroParcelas";
            this.txtNumeroParcelas.Size = new System.Drawing.Size(82, 36);
            this.txtNumeroParcelas.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.txtNumeroParcelas.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.txtNumeroParcelas.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.txtNumeroParcelas.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtNumeroParcelas.StateCommon.Border.Rounding = 20;
            this.txtNumeroParcelas.StateCommon.Border.Width = 1;
            this.txtNumeroParcelas.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(76)))), ((int)(((byte)(172)))));
            this.txtNumeroParcelas.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.txtNumeroParcelas.TabIndex = 41;
            this.txtNumeroParcelas.TabStop = false;
            this.txtNumeroParcelas.Text = "1";
            this.txtNumeroParcelas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNumeroParcelas.TextChanged += new System.EventHandler(this.txtNumeroParcelas_TextChanged);
            this.txtNumeroParcelas.Leave += new System.EventHandler(this.txtNumeroParcelas_Leave);
            // 
            // kryptonLabel8
            // 
            this.kryptonLabel8.Location = new System.Drawing.Point(405, 156);
            this.kryptonLabel8.Name = "kryptonLabel8";
            this.kryptonLabel8.Size = new System.Drawing.Size(80, 21);
            this.kryptonLabel8.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(76)))), ((int)(((byte)(172)))));
            this.kryptonLabel8.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel8.TabIndex = 255;
            this.kryptonLabel8.Values.Text = "Nº de Parc.:";
            // 
            // txtValorParcela
            // 
            this.txtValorParcela.Location = new System.Drawing.Point(489, 180);
            this.txtValorParcela.Name = "txtValorParcela";
            this.txtValorParcela.ReadOnly = true;
            this.txtValorParcela.Size = new System.Drawing.Size(120, 35);
            this.txtValorParcela.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.txtValorParcela.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.txtValorParcela.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.txtValorParcela.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtValorParcela.StateCommon.Border.Rounding = 20;
            this.txtValorParcela.StateCommon.Border.Width = 1;
            this.txtValorParcela.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(76)))), ((int)(((byte)(172)))));
            this.txtValorParcela.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.txtValorParcela.TabIndex = 60;
            this.txtValorParcela.TabStop = false;
            this.txtValorParcela.Leave += new System.EventHandler(this.txtValorParcela_Leave);
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(499, 156);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(106, 21);
            this.kryptonLabel1.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(76)))), ((int)(((byte)(172)))));
            this.kryptonLabel1.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel1.TabIndex = 257;
            this.kryptonLabel1.Values.Text = "Valor da Parcela";
            // 
            // kryptonLabel5
            // 
            this.kryptonLabel5.Location = new System.Drawing.Point(12, 223);
            this.kryptonLabel5.Name = "kryptonLabel5";
            this.kryptonLabel5.Size = new System.Drawing.Size(131, 21);
            this.kryptonLabel5.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(76)))), ((int)(((byte)(172)))));
            this.kryptonLabel5.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel5.TabIndex = 262;
            this.kryptonLabel5.Values.Text = "Meio de Pagamento";
            // 
            // dtpDataVencimento
            // 
            this.dtpDataVencimento.CalendarDayStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Gallery;
            this.dtpDataVencimento.CalendarDimensions = new System.Drawing.Size(2, 2);
            this.dtpDataVencimento.CalendarHeaderStyle = ComponentFactory.Krypton.Toolkit.HeaderStyle.Form;
            this.dtpDataVencimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataVencimento.Location = new System.Drawing.Point(5, 179);
            this.dtpDataVencimento.Name = "dtpDataVencimento";
            this.dtpDataVencimento.Palette = this.kryptonPalette1;
            this.dtpDataVencimento.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.dtpDataVencimento.Size = new System.Drawing.Size(126, 37);
            this.dtpDataVencimento.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.dtpDataVencimento.StateCommon.Border.Rounding = 20;
            this.dtpDataVencimento.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F);
            this.dtpDataVencimento.TabIndex = 3;
            // 
            // kryptonLabel9
            // 
            this.kryptonLabel9.Location = new System.Drawing.Point(11, 156);
            this.kryptonLabel9.Name = "kryptonLabel9";
            this.kryptonLabel9.Size = new System.Drawing.Size(102, 21);
            this.kryptonLabel9.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(76)))), ((int)(((byte)(172)))));
            this.kryptonLabel9.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel9.TabIndex = 264;
            this.kryptonLabel9.Values.Text = "Data de Vencto";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSalvar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnSalvar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnSalvar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LimeGreen;
            this.btnSalvar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.ForeColor = System.Drawing.Color.White;
            this.btnSalvar.Location = new System.Drawing.Point(12, 312);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(110, 36);
            this.btnSalvar.TabIndex = 6;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnSair.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnSair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LimeGreen;
            this.btnSair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.ForeColor = System.Drawing.Color.White;
            this.btnSair.Location = new System.Drawing.Point(492, 312);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(110, 36);
            this.btnSair.TabIndex = 301;
            this.btnSair.TabStop = false;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnNovo.BackColor = System.Drawing.Color.LimeGreen;
            this.btnNovo.FlatAppearance.BorderColor = System.Drawing.Color.LimeGreen;
            this.btnNovo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnNovo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.btnNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovo.ForeColor = System.Drawing.Color.White;
            this.btnNovo.Location = new System.Drawing.Point(128, 312);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(110, 36);
            this.btnNovo.TabIndex = 302;
            this.btnNovo.TabStop = false;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = false;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // txtMetodoPgto
            // 
            this.txtMetodoPgto.Location = new System.Drawing.Point(5, 243);
            this.txtMetodoPgto.Name = "txtMetodoPgto";
            this.txtMetodoPgto.Size = new System.Drawing.Size(350, 35);
            this.txtMetodoPgto.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.txtMetodoPgto.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.txtMetodoPgto.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.txtMetodoPgto.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtMetodoPgto.StateCommon.Border.Rounding = 20;
            this.txtMetodoPgto.StateCommon.Border.Width = 1;
            this.txtMetodoPgto.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(76)))), ((int)(((byte)(172)))));
            this.txtMetodoPgto.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.txtMetodoPgto.TabIndex = 5;
            this.txtMetodoPgto.TextChanged += new System.EventHandler(this.txtMetodoPgto_TextChanged);
            // 
            // btnLocalizarMetodoPagamento
            // 
            this.btnLocalizarMetodoPagamento.BackColor = System.Drawing.Color.Transparent;
            this.btnLocalizarMetodoPagamento.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnLocalizarMetodoPagamento.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.btnLocalizarMetodoPagamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLocalizarMetodoPagamento.ForeColor = System.Drawing.Color.White;
            this.btnLocalizarMetodoPagamento.Image = global::Money.Properties.Resources.search;
            this.btnLocalizarMetodoPagamento.Location = new System.Drawing.Point(361, 242);
            this.btnLocalizarMetodoPagamento.Name = "btnLocalizarMetodoPagamento";
            this.btnLocalizarMetodoPagamento.Size = new System.Drawing.Size(36, 36);
            this.btnLocalizarMetodoPagamento.TabIndex = 70;
            this.btnLocalizarMetodoPagamento.TabStop = false;
            this.btnLocalizarMetodoPagamento.UseVisualStyleBackColor = false;
            this.btnLocalizarMetodoPagamento.Click += new System.EventHandler(this.btnLocalizarMetodoPagamento_Click);
            // 
            // txtCategoria
            // 
            this.txtCategoria.Location = new System.Drawing.Point(134, 180);
            this.txtCategoria.Name = "txtCategoria";
            this.txtCategoria.Size = new System.Drawing.Size(221, 35);
            this.txtCategoria.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.txtCategoria.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.txtCategoria.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.txtCategoria.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtCategoria.StateCommon.Border.Rounding = 20;
            this.txtCategoria.StateCommon.Border.Width = 1;
            this.txtCategoria.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(76)))), ((int)(((byte)(172)))));
            this.txtCategoria.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.txtCategoria.TabIndex = 4;
            this.txtCategoria.TextChanged += new System.EventHandler(this.txtCategoria_TextChanged);
            // 
            // btnLocalizarCategoria
            // 
            this.btnLocalizarCategoria.BackColor = System.Drawing.Color.Transparent;
            this.btnLocalizarCategoria.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnLocalizarCategoria.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.btnLocalizarCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLocalizarCategoria.ForeColor = System.Drawing.Color.White;
            this.btnLocalizarCategoria.Image = global::Money.Properties.Resources.search;
            this.btnLocalizarCategoria.Location = new System.Drawing.Point(358, 179);
            this.btnLocalizarCategoria.Name = "btnLocalizarCategoria";
            this.btnLocalizarCategoria.Size = new System.Drawing.Size(37, 36);
            this.btnLocalizarCategoria.TabIndex = 40;
            this.btnLocalizarCategoria.TabStop = false;
            this.btnLocalizarCategoria.UseVisualStyleBackColor = false;
            this.btnLocalizarCategoria.Click += new System.EventHandler(this.btnLocalizarCategoria_Click);
            // 
            // panelTitulo
            // 
            this.panelTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panelTitulo.Controls.Add(this.lblTitulo);
            this.panelTitulo.Controls.Add(this.lblDataCadastro_e_Pagamento);
            this.panelTitulo.Controls.Add(this.dtpDataCadastro);
            this.panelTitulo.Controls.Add(this.label1);
            this.panelTitulo.Controls.Add(this.txtDespesaID);
            this.panelTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitulo.Location = new System.Drawing.Point(0, 0);
            this.panelTitulo.Name = "panelTitulo";
            this.panelTitulo.Size = new System.Drawing.Size(612, 70);
            this.panelTitulo.TabIndex = 303;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(197, 19);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(75, 29);
            this.lblTitulo.TabIndex = 266;
            this.lblTitulo.Text = "Titulo";
            // 
            // lblDataCadastro_e_Pagamento
            // 
            this.lblDataCadastro_e_Pagamento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDataCadastro_e_Pagamento.AutoSize = true;
            this.lblDataCadastro_e_Pagamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lblDataCadastro_e_Pagamento.ForeColor = System.Drawing.Color.White;
            this.lblDataCadastro_e_Pagamento.Location = new System.Drawing.Point(486, 4);
            this.lblDataCadastro_e_Pagamento.Name = "lblDataCadastro_e_Pagamento";
            this.lblDataCadastro_e_Pagamento.Size = new System.Drawing.Size(119, 17);
            this.lblDataCadastro_e_Pagamento.TabIndex = 265;
            this.lblDataCadastro_e_Pagamento.Text = "Data de Cadastro";
            // 
            // btnParcelar
            // 
            this.btnParcelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnParcelar.BackColor = System.Drawing.Color.OrangeRed;
            this.btnParcelar.FlatAppearance.BorderSize = 0;
            this.btnParcelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.btnParcelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnParcelar.ForeColor = System.Drawing.Color.White;
            this.btnParcelar.Location = new System.Drawing.Point(116, 12);
            this.btnParcelar.Name = "btnParcelar";
            this.btnParcelar.Size = new System.Drawing.Size(82, 36);
            this.btnParcelar.TabIndex = 304;
            this.btnParcelar.TabStop = false;
            this.btnParcelar.Text = "Parcelar";
            this.btnParcelar.UseVisualStyleBackColor = false;
            this.btnParcelar.Click += new System.EventHandler(this.btnParcelar_Click);
            // 
            // groupBoxParcelar
            // 
            this.groupBoxParcelar.Controls.Add(this.radiobtnNao);
            this.groupBoxParcelar.Controls.Add(this.btnParcelar);
            this.groupBoxParcelar.Controls.Add(this.radiobtnSim);
            this.groupBoxParcelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxParcelar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(76)))), ((int)(((byte)(172)))));
            this.groupBoxParcelar.Location = new System.Drawing.Point(402, 227);
            this.groupBoxParcelar.Name = "groupBoxParcelar";
            this.groupBoxParcelar.Size = new System.Drawing.Size(203, 54);
            this.groupBoxParcelar.TabIndex = 306;
            this.groupBoxParcelar.TabStop = false;
            this.groupBoxParcelar.Text = "Parcelar?";
            // 
            // radiobtnNao
            // 
            this.radiobtnNao.AutoSize = true;
            this.radiobtnNao.Checked = true;
            this.radiobtnNao.ForeColor = System.Drawing.Color.Red;
            this.radiobtnNao.Location = new System.Drawing.Point(58, 22);
            this.radiobtnNao.Name = "radiobtnNao";
            this.radiobtnNao.Size = new System.Drawing.Size(51, 20);
            this.radiobtnNao.TabIndex = 307;
            this.radiobtnNao.TabStop = true;
            this.radiobtnNao.Text = "Não";
            this.radiobtnNao.UseVisualStyleBackColor = true;
            this.radiobtnNao.CheckedChanged += new System.EventHandler(this.radiobtnNao_CheckedChanged);
            // 
            // radiobtnSim
            // 
            this.radiobtnSim.AutoSize = true;
            this.radiobtnSim.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(76)))), ((int)(((byte)(172)))));
            this.radiobtnSim.Location = new System.Drawing.Point(6, 22);
            this.radiobtnSim.Name = "radiobtnSim";
            this.radiobtnSim.Size = new System.Drawing.Size(48, 20);
            this.radiobtnSim.TabIndex = 306;
            this.radiobtnSim.Text = "Sim";
            this.radiobtnSim.UseVisualStyleBackColor = true;
            this.radiobtnSim.CheckedChanged += new System.EventHandler(this.radiobtnSim_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radiobtnPendente);
            this.groupBox1.Controls.Add(this.radiobtnPago);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(76)))), ((int)(((byte)(172)))));
            this.groupBox1.Location = new System.Drawing.Point(5, 71);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(95, 67);
            this.groupBox1.TabIndex = 307;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Status";
            // 
            // radiobtnPendente
            // 
            this.radiobtnPendente.AutoSize = true;
            this.radiobtnPendente.Checked = true;
            this.radiobtnPendente.ForeColor = System.Drawing.Color.Red;
            this.radiobtnPendente.Location = new System.Drawing.Point(3, 39);
            this.radiobtnPendente.Name = "radiobtnPendente";
            this.radiobtnPendente.Size = new System.Drawing.Size(83, 20);
            this.radiobtnPendente.TabIndex = 307;
            this.radiobtnPendente.TabStop = true;
            this.radiobtnPendente.Text = "Pendente";
            this.radiobtnPendente.UseVisualStyleBackColor = true;
            this.radiobtnPendente.CheckedChanged += new System.EventHandler(this.radiobtnPendente_CheckedChanged);
            // 
            // radiobtnPago
            // 
            this.radiobtnPago.AutoSize = true;
            this.radiobtnPago.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(76)))), ((int)(((byte)(172)))));
            this.radiobtnPago.Location = new System.Drawing.Point(6, 19);
            this.radiobtnPago.Name = "radiobtnPago";
            this.radiobtnPago.Size = new System.Drawing.Size(58, 20);
            this.radiobtnPago.TabIndex = 306;
            this.radiobtnPago.Text = "Pago";
            this.radiobtnPago.UseVisualStyleBackColor = true;
            this.radiobtnPago.CheckedChanged += new System.EventHandler(this.radiobtnPago_CheckedChanged);
            // 
            // FormCadastroDespesa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(612, 367);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBoxParcelar);
            this.Controls.Add(this.panelTitulo);
            this.Controls.Add(this.btnLocalizarCategoria);
            this.Controls.Add(this.txtCategoria);
            this.Controls.Add(this.btnLocalizarMetodoPagamento);
            this.Controls.Add(this.txtMetodoPgto);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.kryptonLabel9);
            this.Controls.Add(this.dtpDataVencimento);
            this.Controls.Add(this.kryptonLabel5);
            this.Controls.Add(this.txtValorParcela);
            this.Controls.Add(this.kryptonLabel1);
            this.Controls.Add(this.txtNumeroParcelas);
            this.Controls.Add(this.kryptonLabel8);
            this.Controls.Add(this.kryptonLabel7);
            this.Controls.Add(this.txtValorTotal);
            this.Controls.Add(this.kryptonLabel4);
            this.Controls.Add(this.kryptonLabel3);
            this.Controls.Add(this.txtDescricao);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCadastroDespesa";
            this.Palette = this.kryptonPalette1;
            this.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cadastro de Despesas";
            this.Load += new System.EventHandler(this.FormCadastroTipoReceita_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormCadastroCategorias_KeyDown);
            this.panelTitulo.ResumeLayout(false);
            this.panelTitulo.PerformLayout();
            this.groupBoxParcelar.ResumeLayout(false);
            this.groupBoxParcelar.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonPalette kryptonPalette1;
        public ComponentFactory.Krypton.Toolkit.KryptonTextBox txtDescricao;
        public ComponentFactory.Krypton.Toolkit.KryptonTextBox txtDespesaID;
        private System.Windows.Forms.Label label1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel4;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel3;
        public ComponentFactory.Krypton.Toolkit.KryptonTextBox txtValorTotal;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel7;
        public ComponentFactory.Krypton.Toolkit.KryptonTextBox txtNumeroParcelas;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel8;
        public ComponentFactory.Krypton.Toolkit.KryptonTextBox txtValorParcela;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel5;
        public ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker dtpDataVencimento;
        public ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker dtpDataCadastro;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel9;
        public System.Windows.Forms.Button btnSalvar;
        public System.Windows.Forms.Button btnSair;
        public System.Windows.Forms.Button btnNovo;
        public ComponentFactory.Krypton.Toolkit.KryptonTextBox txtMetodoPgto;
        public System.Windows.Forms.Button btnLocalizarMetodoPagamento;
        public ComponentFactory.Krypton.Toolkit.KryptonTextBox txtCategoria;
        public System.Windows.Forms.Button btnLocalizarCategoria;
        public System.Windows.Forms.Panel panelTitulo;
        public System.Windows.Forms.Label lblTitulo;
        public System.Windows.Forms.Label lblDataCadastro_e_Pagamento;
        public System.Windows.Forms.Button btnParcelar;
        private System.Windows.Forms.RadioButton radiobtnNao;
        private System.Windows.Forms.RadioButton radiobtnSim;
        public System.Windows.Forms.GroupBox groupBoxParcelar;
        public System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.RadioButton radiobtnPendente;
        public System.Windows.Forms.RadioButton radiobtnPago;
    }
}

