namespace Money
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
            this.kryptonLabel6 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel7 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txtNumeroParcelas = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel8 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txtValorParcela = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel5 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radiobtnNao = new System.Windows.Forms.RadioButton();
            this.radiobtnSim = new System.Windows.Forms.RadioButton();
            this.btnGerarParcelas = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.dtpDataVencimento = new ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker();
            this.kryptonLabel9 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.cmbStatus = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
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
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbStatus)).BeginInit();
            this.panelTitulo.SuspendLayout();
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
            this.txtDescricao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDescricao.Location = new System.Drawing.Point(268, 118);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(464, 35);
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
            this.txtDescricao.TabIndex = 1;
            // 
            // txtDespesaID
            // 
            this.txtDespesaID.Location = new System.Drawing.Point(14, 26);
            this.txtDespesaID.Name = "txtDespesaID";
            this.txtDespesaID.ReadOnly = true;
            this.txtDespesaID.Size = new System.Drawing.Size(103, 35);
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
            this.label1.Location = new System.Drawing.Point(39, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código";
            // 
            // dtpDataCadastro
            // 
            this.dtpDataCadastro.CalendarDayStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Gallery;
            this.dtpDataCadastro.CalendarDimensions = new System.Drawing.Size(2, 2);
            this.dtpDataCadastro.CalendarHeaderStyle = ComponentFactory.Krypton.Toolkit.HeaderStyle.Form;
            this.dtpDataCadastro.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataCadastro.Location = new System.Drawing.Point(596, 24);
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
            this.kryptonLabel4.Location = new System.Drawing.Point(278, 95);
            this.kryptonLabel4.Name = "kryptonLabel4";
            this.kryptonLabel4.Size = new System.Drawing.Size(128, 20);
            this.kryptonLabel4.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(76)))), ((int)(((byte)(172)))));
            this.kryptonLabel4.TabIndex = 39;
            this.kryptonLabel4.Values.Text = "Descrição da despesa";
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.Location = new System.Drawing.Point(158, 95);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(101, 20);
            this.kryptonLabel3.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(76)))), ((int)(((byte)(172)))));
            this.kryptonLabel3.TabIndex = 38;
            this.kryptonLabel3.Values.Text = "Valor Total ( R$ )";
            // 
            // txtValorTotal
            // 
            this.txtValorTotal.Location = new System.Drawing.Point(147, 118);
            this.txtValorTotal.Name = "txtValorTotal";
            this.txtValorTotal.Size = new System.Drawing.Size(118, 35);
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
            this.txtValorTotal.TabIndex = 0;
            this.txtValorTotal.Leave += new System.EventHandler(this.txtValor_Leave);
            // 
            // kryptonLabel6
            // 
            this.kryptonLabel6.Location = new System.Drawing.Point(20, 93);
            this.kryptonLabel6.Name = "kryptonLabel6";
            this.kryptonLabel6.Size = new System.Drawing.Size(44, 20);
            this.kryptonLabel6.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(76)))), ((int)(((byte)(172)))));
            this.kryptonLabel6.TabIndex = 254;
            this.kryptonLabel6.Values.Text = "Status";
            // 
            // kryptonLabel7
            // 
            this.kryptonLabel7.Location = new System.Drawing.Point(159, 172);
            this.kryptonLabel7.Name = "kryptonLabel7";
            this.kryptonLabel7.Size = new System.Drawing.Size(63, 20);
            this.kryptonLabel7.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(76)))), ((int)(((byte)(172)))));
            this.kryptonLabel7.TabIndex = 253;
            this.kryptonLabel7.Values.Text = "Categoria";
            // 
            // txtNumeroParcelas
            // 
            this.txtNumeroParcelas.Location = new System.Drawing.Point(481, 195);
            this.txtNumeroParcelas.Name = "txtNumeroParcelas";
            this.txtNumeroParcelas.Size = new System.Drawing.Size(128, 36);
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
            this.txtNumeroParcelas.TabIndex = 5;
            this.txtNumeroParcelas.Text = "1";
            this.txtNumeroParcelas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNumeroParcelas.Leave += new System.EventHandler(this.txtNumeroParcelas_Leave);
            // 
            // kryptonLabel8
            // 
            this.kryptonLabel8.Location = new System.Drawing.Point(505, 171);
            this.kryptonLabel8.Name = "kryptonLabel8";
            this.kryptonLabel8.Size = new System.Drawing.Size(90, 20);
            this.kryptonLabel8.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(76)))), ((int)(((byte)(172)))));
            this.kryptonLabel8.TabIndex = 255;
            this.kryptonLabel8.Values.Text = "Nº de Parcelas";
            // 
            // txtValorParcela
            // 
            this.txtValorParcela.Location = new System.Drawing.Point(613, 195);
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
            this.kryptonLabel1.Location = new System.Drawing.Point(623, 171);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(98, 20);
            this.kryptonLabel1.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(76)))), ((int)(((byte)(172)))));
            this.kryptonLabel1.TabIndex = 257;
            this.kryptonLabel1.Values.Text = "Valor da Parcela";
            // 
            // kryptonLabel5
            // 
            this.kryptonLabel5.Location = new System.Drawing.Point(12, 233);
            this.kryptonLabel5.Name = "kryptonLabel5";
            this.kryptonLabel5.Size = new System.Drawing.Size(121, 20);
            this.kryptonLabel5.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(76)))), ((int)(((byte)(172)))));
            this.kryptonLabel5.TabIndex = 262;
            this.kryptonLabel5.Values.Text = "Meio de Pagamento";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radiobtnNao);
            this.groupBox1.Controls.Add(this.radiobtnSim);
            this.groupBox1.Controls.Add(this.btnGerarParcelas);
            this.groupBox1.Location = new System.Drawing.Point(487, 233);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(250, 57);
            this.groupBox1.TabIndex = 263;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Parcelar?";
            // 
            // radiobtnNao
            // 
            this.radiobtnNao.AutoSize = true;
            this.radiobtnNao.Checked = true;
            this.radiobtnNao.Location = new System.Drawing.Point(54, 24);
            this.radiobtnNao.Name = "radiobtnNao";
            this.radiobtnNao.Size = new System.Drawing.Size(45, 17);
            this.radiobtnNao.TabIndex = 267;
            this.radiobtnNao.TabStop = true;
            this.radiobtnNao.Text = "Não";
            this.radiobtnNao.UseVisualStyleBackColor = true;
            this.radiobtnNao.CheckedChanged += new System.EventHandler(this.radiobtnNao_CheckedChanged);
            // 
            // radiobtnSim
            // 
            this.radiobtnSim.AutoSize = true;
            this.radiobtnSim.Location = new System.Drawing.Point(6, 24);
            this.radiobtnSim.Name = "radiobtnSim";
            this.radiobtnSim.Size = new System.Drawing.Size(42, 17);
            this.radiobtnSim.TabIndex = 266;
            this.radiobtnSim.TabStop = true;
            this.radiobtnSim.Text = "Sim";
            this.radiobtnSim.UseVisualStyleBackColor = true;
            this.radiobtnSim.CheckedChanged += new System.EventHandler(this.radiobtnSim_CheckedChanged);
            // 
            // btnGerarParcelas
            // 
            this.btnGerarParcelas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnGerarParcelas.Location = new System.Drawing.Point(114, 9);
            this.btnGerarParcelas.Name = "btnGerarParcelas";
            this.btnGerarParcelas.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.btnGerarParcelas.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.btnGerarParcelas.OverrideDefault.Back.ColorAngle = 45F;
            this.btnGerarParcelas.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnGerarParcelas.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnGerarParcelas.OverrideDefault.Border.ColorAngle = 45F;
            this.btnGerarParcelas.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnGerarParcelas.OverrideDefault.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnGerarParcelas.OverrideDefault.Border.Rounding = 20;
            this.btnGerarParcelas.OverrideDefault.Border.Width = 1;
            this.btnGerarParcelas.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.btnGerarParcelas.Size = new System.Drawing.Size(131, 39);
            this.btnGerarParcelas.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.btnGerarParcelas.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.btnGerarParcelas.StateCommon.Back.ColorAngle = 45F;
            this.btnGerarParcelas.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnGerarParcelas.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnGerarParcelas.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnGerarParcelas.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnGerarParcelas.StateCommon.Border.Rounding = 20;
            this.btnGerarParcelas.StateCommon.Border.Width = 1;
            this.btnGerarParcelas.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnGerarParcelas.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnGerarParcelas.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGerarParcelas.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(145)))), ((int)(((byte)(198)))));
            this.btnGerarParcelas.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(121)))), ((int)(((byte)(206)))));
            this.btnGerarParcelas.StatePressed.Back.ColorAngle = 135F;
            this.btnGerarParcelas.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(145)))), ((int)(((byte)(198)))));
            this.btnGerarParcelas.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(121)))), ((int)(((byte)(206)))));
            this.btnGerarParcelas.StatePressed.Border.ColorAngle = 135F;
            this.btnGerarParcelas.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnGerarParcelas.StatePressed.Border.Rounding = 20;
            this.btnGerarParcelas.StatePressed.Border.Width = 1;
            this.btnGerarParcelas.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnGerarParcelas.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnGerarParcelas.StateTracking.Back.ColorAngle = 45F;
            this.btnGerarParcelas.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnGerarParcelas.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnGerarParcelas.StateTracking.Border.ColorAngle = 45F;
            this.btnGerarParcelas.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnGerarParcelas.StateTracking.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnGerarParcelas.StateTracking.Border.Rounding = 20;
            this.btnGerarParcelas.StateTracking.Border.Width = 1;
            this.btnGerarParcelas.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnGerarParcelas.TabIndex = 265;
            this.btnGerarParcelas.TabStop = false;
            this.btnGerarParcelas.Values.Text = "Parcelamento";
            this.btnGerarParcelas.Click += new System.EventHandler(this.btnGerarParcelas_Click);
            // 
            // dtpDataVencimento
            // 
            this.dtpDataVencimento.CalendarDayStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Gallery;
            this.dtpDataVencimento.CalendarDimensions = new System.Drawing.Size(2, 2);
            this.dtpDataVencimento.CalendarHeaderStyle = ComponentFactory.Krypton.Toolkit.HeaderStyle.Form;
            this.dtpDataVencimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataVencimento.Location = new System.Drawing.Point(5, 193);
            this.dtpDataVencimento.Name = "dtpDataVencimento";
            this.dtpDataVencimento.Palette = this.kryptonPalette1;
            this.dtpDataVencimento.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.dtpDataVencimento.Size = new System.Drawing.Size(141, 37);
            this.dtpDataVencimento.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.dtpDataVencimento.StateCommon.Border.Rounding = 20;
            this.dtpDataVencimento.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F);
            this.dtpDataVencimento.TabIndex = 2;
            // 
            // kryptonLabel9
            // 
            this.kryptonLabel9.Location = new System.Drawing.Point(11, 172);
            this.kryptonLabel9.Name = "kryptonLabel9";
            this.kryptonLabel9.Size = new System.Drawing.Size(122, 20);
            this.kryptonLabel9.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(76)))), ((int)(((byte)(172)))));
            this.kryptonLabel9.TabIndex = 264;
            this.kryptonLabel9.Values.Text = "Data de Vencimento";
            // 
            // cmbStatus
            // 
            this.cmbStatus.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbStatus.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbStatus.DropDownWidth = 138;
            this.cmbStatus.Items.AddRange(new object[] {
            "Pendente",
            "Pago"});
            this.cmbStatus.Location = new System.Drawing.Point(5, 118);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(136, 33);
            this.cmbStatus.StateCommon.ComboBox.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.cmbStatus.StateCommon.ComboBox.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.cmbStatus.StateCommon.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cmbStatus.StateCommon.ComboBox.Border.Rounding = 20;
            this.cmbStatus.TabIndex = 300;
            this.cmbStatus.TabStop = false;
            this.cmbStatus.Text = "Pendente";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSalvar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnSalvar.FlatAppearance.BorderColor = System.Drawing.Color.LightGreen;
            this.btnSalvar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LimeGreen;
            this.btnSalvar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.ForeColor = System.Drawing.Color.White;
            this.btnSalvar.Location = new System.Drawing.Point(12, 381);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(110, 36);
            this.btnSalvar.TabIndex = 8;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnSair.FlatAppearance.BorderColor = System.Drawing.Color.LightGreen;
            this.btnSair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LimeGreen;
            this.btnSair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.ForeColor = System.Drawing.Color.White;
            this.btnSair.Location = new System.Drawing.Point(609, 388);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(110, 36);
            this.btnSair.TabIndex = 301;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnNovo.BackColor = System.Drawing.Color.LimeGreen;
            this.btnNovo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnNovo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.btnNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovo.ForeColor = System.Drawing.Color.White;
            this.btnNovo.Location = new System.Drawing.Point(128, 381);
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
            this.txtMetodoPgto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtMetodoPgto.Location = new System.Drawing.Point(5, 255);
            this.txtMetodoPgto.Name = "txtMetodoPgto";
            this.txtMetodoPgto.Size = new System.Drawing.Size(436, 35);
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
            this.txtMetodoPgto.TabIndex = 6;
            this.txtMetodoPgto.TextChanged += new System.EventHandler(this.txtMetodoPgto_TextChanged);
            // 
            // btnLocalizarMetodoPagamento
            // 
            this.btnLocalizarMetodoPagamento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLocalizarMetodoPagamento.BackColor = System.Drawing.Color.Transparent;
            this.btnLocalizarMetodoPagamento.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnLocalizarMetodoPagamento.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.btnLocalizarMetodoPagamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLocalizarMetodoPagamento.ForeColor = System.Drawing.Color.White;
            this.btnLocalizarMetodoPagamento.Image = global::Money.Properties.Resources.search;
            this.btnLocalizarMetodoPagamento.Location = new System.Drawing.Point(441, 254);
            this.btnLocalizarMetodoPagamento.Name = "btnLocalizarMetodoPagamento";
            this.btnLocalizarMetodoPagamento.Size = new System.Drawing.Size(36, 36);
            this.btnLocalizarMetodoPagamento.TabIndex = 7;
            this.btnLocalizarMetodoPagamento.UseVisualStyleBackColor = false;
            this.btnLocalizarMetodoPagamento.Click += new System.EventHandler(this.btnLocalizarMetodoPagamento_Click);
            // 
            // txtCategoria
            // 
            this.txtCategoria.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCategoria.Location = new System.Drawing.Point(152, 195);
            this.txtCategoria.Name = "txtCategoria";
            this.txtCategoria.Size = new System.Drawing.Size(289, 35);
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
            this.txtCategoria.TabIndex = 3;
            this.txtCategoria.TextChanged += new System.EventHandler(this.txtCategoria_TextChanged);
            // 
            // btnLocalizarCategoria
            // 
            this.btnLocalizarCategoria.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLocalizarCategoria.BackColor = System.Drawing.Color.Transparent;
            this.btnLocalizarCategoria.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnLocalizarCategoria.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.btnLocalizarCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLocalizarCategoria.ForeColor = System.Drawing.Color.White;
            this.btnLocalizarCategoria.Image = global::Money.Properties.Resources.search;
            this.btnLocalizarCategoria.Location = new System.Drawing.Point(441, 195);
            this.btnLocalizarCategoria.Name = "btnLocalizarCategoria";
            this.btnLocalizarCategoria.Size = new System.Drawing.Size(37, 36);
            this.btnLocalizarCategoria.TabIndex = 4;
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
            this.panelTitulo.Size = new System.Drawing.Size(737, 70);
            this.panelTitulo.TabIndex = 303;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(263, 20);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(75, 29);
            this.lblTitulo.TabIndex = 266;
            this.lblTitulo.Text = "Titulo";
            // 
            // lblDataCadastro_e_Pagamento
            // 
            this.lblDataCadastro_e_Pagamento.AutoSize = true;
            this.lblDataCadastro_e_Pagamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lblDataCadastro_e_Pagamento.ForeColor = System.Drawing.Color.White;
            this.lblDataCadastro_e_Pagamento.Location = new System.Drawing.Point(606, 4);
            this.lblDataCadastro_e_Pagamento.Name = "lblDataCadastro_e_Pagamento";
            this.lblDataCadastro_e_Pagamento.Size = new System.Drawing.Size(119, 17);
            this.lblDataCadastro_e_Pagamento.TabIndex = 265;
            this.lblDataCadastro_e_Pagamento.Text = "Data de Cadastro";
            // 
            // FormCadastroDespesa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(737, 436);
            this.Controls.Add(this.panelTitulo);
            this.Controls.Add(this.btnLocalizarCategoria);
            this.Controls.Add(this.txtCategoria);
            this.Controls.Add(this.btnLocalizarMetodoPagamento);
            this.Controls.Add(this.txtMetodoPgto);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.cmbStatus);
            this.Controls.Add(this.kryptonLabel9);
            this.Controls.Add(this.dtpDataVencimento);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.kryptonLabel5);
            this.Controls.Add(this.txtValorParcela);
            this.Controls.Add(this.kryptonLabel1);
            this.Controls.Add(this.txtNumeroParcelas);
            this.Controls.Add(this.kryptonLabel8);
            this.Controls.Add(this.kryptonLabel6);
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
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbStatus)).EndInit();
            this.panelTitulo.ResumeLayout(false);
            this.panelTitulo.PerformLayout();
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
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel6;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel7;
        public ComponentFactory.Krypton.Toolkit.KryptonTextBox txtNumeroParcelas;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel8;
        public ComponentFactory.Krypton.Toolkit.KryptonTextBox txtValorParcela;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel5;
        private System.Windows.Forms.GroupBox groupBox1;
        public ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker dtpDataVencimento;
        public ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker dtpDataCadastro;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel9;
        public ComponentFactory.Krypton.Toolkit.KryptonButton btnGerarParcelas;
        public ComponentFactory.Krypton.Toolkit.KryptonComboBox cmbStatus;
        private System.Windows.Forms.RadioButton radiobtnNao;
        private System.Windows.Forms.RadioButton radiobtnSim;
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
    }
}

