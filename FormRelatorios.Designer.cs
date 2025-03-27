namespace Money
{
    partial class FormRelatorios
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
            this.cmbCategoria = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.cmbStatus = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.kryptonLabel9 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.dtpMesAno = new ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker();
            this.kryptonLabel6 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel7 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.btnGerarRelatorio = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.dgvRelatorio = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbMetodoPgto = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.kryptonLabel5 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.lblStatus = new System.Windows.Forms.Label();
            this.kryptonPanel2 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.btnExcel = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.lblTotalPago = new System.Windows.Forms.Label();
            this.lblTotalAberto = new System.Windows.Forms.Label();
            this.kryptonPanel3 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            ((System.ComponentModel.ISupportInitialize)(this.cmbCategoria)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRelatorio)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbMetodoPgto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).BeginInit();
            this.kryptonPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel3)).BeginInit();
            this.kryptonPanel3.SuspendLayout();
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
            // cmbCategoria
            // 
            this.cmbCategoria.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbCategoria.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbCategoria.DropDownWidth = 109;
            this.cmbCategoria.Location = new System.Drawing.Point(426, 40);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(242, 33);
            this.cmbCategoria.StateCommon.ComboBox.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.cmbCategoria.StateCommon.ComboBox.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.cmbCategoria.StateCommon.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cmbCategoria.StateCommon.ComboBox.Border.Rounding = 20;
            this.cmbCategoria.TabIndex = 302;
            // 
            // cmbStatus
            // 
            this.cmbStatus.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbStatus.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbStatus.DropDownWidth = 138;
            this.cmbStatus.Items.AddRange(new object[] {
            "Todos",
            "Pendente",
            "Pago",
            "Atrasado"});
            this.cmbStatus.Location = new System.Drawing.Point(6, 40);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(111, 33);
            this.cmbStatus.StateCommon.ComboBox.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.cmbStatus.StateCommon.ComboBox.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.cmbStatus.StateCommon.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cmbStatus.StateCommon.ComboBox.Border.Rounding = 20;
            this.cmbStatus.TabIndex = 311;
            this.cmbStatus.TabStop = false;
            this.cmbStatus.Text = "Pendente";
            // 
            // kryptonLabel9
            // 
            this.kryptonLabel9.Location = new System.Drawing.Point(136, 15);
            this.kryptonLabel9.Name = "kryptonLabel9";
            this.kryptonLabel9.Size = new System.Drawing.Size(60, 20);
            this.kryptonLabel9.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(76)))), ((int)(((byte)(172)))));
            this.kryptonLabel9.TabIndex = 310;
            this.kryptonLabel9.Values.Text = "Mês/Ano";
            // 
            // dtpMesAno
            // 
            this.dtpMesAno.CalendarDayStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Gallery;
            this.dtpMesAno.CalendarHeaderStyle = ComponentFactory.Krypton.Toolkit.HeaderStyle.Form;
            this.dtpMesAno.CalendarTodayDate = new System.DateTime(2025, 3, 13, 0, 0, 0, 0);
            this.dtpMesAno.CustomFormat = "MM/yyyy";
            this.dtpMesAno.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpMesAno.Location = new System.Drawing.Point(119, 38);
            this.dtpMesAno.Name = "dtpMesAno";
            this.dtpMesAno.Palette = this.kryptonPalette1;
            this.dtpMesAno.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.dtpMesAno.Size = new System.Drawing.Size(107, 37);
            this.dtpMesAno.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.dtpMesAno.StateCommon.Border.Rounding = 20;
            this.dtpMesAno.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F);
            this.dtpMesAno.TabIndex = 301;
            // 
            // kryptonLabel6
            // 
            this.kryptonLabel6.Location = new System.Drawing.Point(21, 15);
            this.kryptonLabel6.Name = "kryptonLabel6";
            this.kryptonLabel6.Size = new System.Drawing.Size(44, 20);
            this.kryptonLabel6.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(76)))), ((int)(((byte)(172)))));
            this.kryptonLabel6.TabIndex = 307;
            this.kryptonLabel6.Values.Text = "Status";
            // 
            // kryptonLabel7
            // 
            this.kryptonLabel7.Location = new System.Drawing.Point(438, 15);
            this.kryptonLabel7.Name = "kryptonLabel7";
            this.kryptonLabel7.Size = new System.Drawing.Size(63, 20);
            this.kryptonLabel7.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(76)))), ((int)(((byte)(172)))));
            this.kryptonLabel7.TabIndex = 306;
            this.kryptonLabel7.Values.Text = "Categoria";
            // 
            // btnGerarRelatorio
            // 
            this.btnGerarRelatorio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGerarRelatorio.Location = new System.Drawing.Point(680, 33);
            this.btnGerarRelatorio.Name = "btnGerarRelatorio";
            this.btnGerarRelatorio.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnGerarRelatorio.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnGerarRelatorio.OverrideDefault.Back.ColorAngle = 45F;
            this.btnGerarRelatorio.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnGerarRelatorio.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnGerarRelatorio.OverrideDefault.Border.ColorAngle = 45F;
            this.btnGerarRelatorio.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnGerarRelatorio.OverrideDefault.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnGerarRelatorio.OverrideDefault.Border.Rounding = 20;
            this.btnGerarRelatorio.OverrideDefault.Border.Width = 1;
            this.btnGerarRelatorio.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.btnGerarRelatorio.Size = new System.Drawing.Size(122, 40);
            this.btnGerarRelatorio.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnGerarRelatorio.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnGerarRelatorio.StateCommon.Back.ColorAngle = 45F;
            this.btnGerarRelatorio.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnGerarRelatorio.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnGerarRelatorio.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnGerarRelatorio.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnGerarRelatorio.StateCommon.Border.Rounding = 20;
            this.btnGerarRelatorio.StateCommon.Border.Width = 1;
            this.btnGerarRelatorio.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnGerarRelatorio.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnGerarRelatorio.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGerarRelatorio.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(145)))), ((int)(((byte)(198)))));
            this.btnGerarRelatorio.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(121)))), ((int)(((byte)(206)))));
            this.btnGerarRelatorio.StatePressed.Back.ColorAngle = 135F;
            this.btnGerarRelatorio.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(145)))), ((int)(((byte)(198)))));
            this.btnGerarRelatorio.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(121)))), ((int)(((byte)(206)))));
            this.btnGerarRelatorio.StatePressed.Border.ColorAngle = 135F;
            this.btnGerarRelatorio.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnGerarRelatorio.StatePressed.Border.Rounding = 20;
            this.btnGerarRelatorio.StatePressed.Border.Width = 1;
            this.btnGerarRelatorio.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnGerarRelatorio.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnGerarRelatorio.StateTracking.Back.ColorAngle = 45F;
            this.btnGerarRelatorio.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnGerarRelatorio.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnGerarRelatorio.StateTracking.Border.ColorAngle = 45F;
            this.btnGerarRelatorio.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnGerarRelatorio.StateTracking.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnGerarRelatorio.StateTracking.Border.Rounding = 20;
            this.btnGerarRelatorio.StateTracking.Border.Width = 1;
            this.btnGerarRelatorio.TabIndex = 304;
            this.btnGerarRelatorio.Values.Text = "Gerar Relatório";
            this.btnGerarRelatorio.Click += new System.EventHandler(this.btnGerarRelatorio_Click);
            // 
            // dgvRelatorio
            // 
            this.dgvRelatorio.AllowUserToAddRows = false;
            this.dgvRelatorio.AllowUserToDeleteRows = false;
            this.dgvRelatorio.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvRelatorio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRelatorio.Location = new System.Drawing.Point(13, 91);
            this.dgvRelatorio.Name = "dgvRelatorio";
            this.dgvRelatorio.ReadOnly = true;
            this.dgvRelatorio.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRelatorio.Size = new System.Drawing.Size(803, 236);
            this.dgvRelatorio.TabIndex = 312;
            this.dgvRelatorio.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvRelatorio_CellFormatting);
            this.dgvRelatorio.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvRelatorio_DataError);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.groupBox1.Controls.Add(this.cmbMetodoPgto);
            this.groupBox1.Controls.Add(this.kryptonLabel5);
            this.groupBox1.Controls.Add(this.cmbCategoria);
            this.groupBox1.Controls.Add(this.btnGerarRelatorio);
            this.groupBox1.Controls.Add(this.kryptonLabel7);
            this.groupBox1.Controls.Add(this.cmbStatus);
            this.groupBox1.Controls.Add(this.kryptonLabel6);
            this.groupBox1.Controls.Add(this.kryptonLabel9);
            this.groupBox1.Controls.Add(this.dtpMesAno);
            this.groupBox1.Location = new System.Drawing.Point(8, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(808, 80);
            this.groupBox1.TabIndex = 313;
            this.groupBox1.TabStop = false;
            // 
            // cmbMetodoPgto
            // 
            this.cmbMetodoPgto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbMetodoPgto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbMetodoPgto.DropDownWidth = 109;
            this.cmbMetodoPgto.Location = new System.Drawing.Point(230, 40);
            this.cmbMetodoPgto.Name = "cmbMetodoPgto";
            this.cmbMetodoPgto.Size = new System.Drawing.Size(193, 33);
            this.cmbMetodoPgto.StateCommon.ComboBox.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.cmbMetodoPgto.StateCommon.ComboBox.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.cmbMetodoPgto.StateCommon.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cmbMetodoPgto.StateCommon.ComboBox.Border.Rounding = 20;
            this.cmbMetodoPgto.TabIndex = 312;
            // 
            // kryptonLabel5
            // 
            this.kryptonLabel5.Location = new System.Drawing.Point(255, 20);
            this.kryptonLabel5.Name = "kryptonLabel5";
            this.kryptonLabel5.Size = new System.Drawing.Size(121, 20);
            this.kryptonLabel5.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(76)))), ((int)(((byte)(172)))));
            this.kryptonLabel5.TabIndex = 313;
            this.kryptonLabel5.Values.Text = "Meio de Pagamento";
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.lblStatus);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Blue;
            this.kryptonPanel1.PanelBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.SeparatorHighProfile;
            this.kryptonPanel1.Size = new System.Drawing.Size(832, 26);
            this.kryptonPanel1.TabIndex = 314;
            // 
            // lblStatus
            // 
            this.lblStatus.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblStatus.AutoSize = true;
            this.lblStatus.BackColor = System.Drawing.Color.Transparent;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(76)))), ((int)(((byte)(172)))));
            this.lblStatus.Location = new System.Drawing.Point(356, 1);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(130, 24);
            this.lblStatus.TabIndex = 248;
            this.lblStatus.Text = "RELATÓRIOS";
            // 
            // kryptonPanel2
            // 
            this.kryptonPanel2.Controls.Add(this.btnExcel);
            this.kryptonPanel2.Controls.Add(this.lblTotalPago);
            this.kryptonPanel2.Controls.Add(this.lblTotalAberto);
            this.kryptonPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.kryptonPanel2.Location = new System.Drawing.Point(0, 362);
            this.kryptonPanel2.Name = "kryptonPanel2";
            this.kryptonPanel2.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Blue;
            this.kryptonPanel2.PanelBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.SeparatorHighProfile;
            this.kryptonPanel2.Size = new System.Drawing.Size(832, 88);
            this.kryptonPanel2.TabIndex = 315;
            // 
            // btnExcel
            // 
            this.btnExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExcel.Location = new System.Drawing.Point(697, 27);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.btnExcel.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.btnExcel.OverrideDefault.Back.ColorAngle = 45F;
            this.btnExcel.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnExcel.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnExcel.OverrideDefault.Border.ColorAngle = 45F;
            this.btnExcel.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnExcel.OverrideDefault.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnExcel.OverrideDefault.Border.Rounding = 20;
            this.btnExcel.OverrideDefault.Border.Width = 1;
            this.btnExcel.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.btnExcel.Size = new System.Drawing.Size(123, 39);
            this.btnExcel.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.btnExcel.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.btnExcel.StateCommon.Back.ColorAngle = 45F;
            this.btnExcel.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnExcel.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnExcel.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnExcel.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnExcel.StateCommon.Border.Rounding = 20;
            this.btnExcel.StateCommon.Border.Width = 1;
            this.btnExcel.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnExcel.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnExcel.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btnExcel.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(145)))), ((int)(((byte)(198)))));
            this.btnExcel.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(121)))), ((int)(((byte)(206)))));
            this.btnExcel.StatePressed.Back.ColorAngle = 135F;
            this.btnExcel.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(145)))), ((int)(((byte)(198)))));
            this.btnExcel.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(121)))), ((int)(((byte)(206)))));
            this.btnExcel.StatePressed.Border.ColorAngle = 135F;
            this.btnExcel.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnExcel.StatePressed.Border.Rounding = 20;
            this.btnExcel.StatePressed.Border.Width = 1;
            this.btnExcel.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnExcel.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnExcel.StateTracking.Back.ColorAngle = 45F;
            this.btnExcel.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnExcel.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnExcel.StateTracking.Border.ColorAngle = 45F;
            this.btnExcel.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnExcel.StateTracking.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnExcel.StateTracking.Border.Rounding = 20;
            this.btnExcel.StateTracking.Border.Width = 1;
            this.btnExcel.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnExcel.TabIndex = 316;
            this.btnExcel.TabStop = false;
            this.btnExcel.Values.Text = "Excel";
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // lblTotalPago
            // 
            this.lblTotalPago.AutoSize = true;
            this.lblTotalPago.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblTotalPago.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(76)))), ((int)(((byte)(172)))));
            this.lblTotalPago.Location = new System.Drawing.Point(3, 16);
            this.lblTotalPago.Name = "lblTotalPago";
            this.lblTotalPago.Size = new System.Drawing.Size(89, 20);
            this.lblTotalPago.TabIndex = 249;
            this.lblTotalPago.Text = "Total Pago";
            // 
            // lblTotalAberto
            // 
            this.lblTotalAberto.AutoSize = true;
            this.lblTotalAberto.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalAberto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblTotalAberto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(76)))), ((int)(((byte)(172)))));
            this.lblTotalAberto.Location = new System.Drawing.Point(3, 46);
            this.lblTotalAberto.Name = "lblTotalAberto";
            this.lblTotalAberto.Size = new System.Drawing.Size(100, 20);
            this.lblTotalAberto.TabIndex = 248;
            this.lblTotalAberto.Text = "Total Aberto";
            // 
            // kryptonPanel3
            // 
            this.kryptonPanel3.Controls.Add(this.dgvRelatorio);
            this.kryptonPanel3.Controls.Add(this.groupBox1);
            this.kryptonPanel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.kryptonPanel3.Location = new System.Drawing.Point(0, 26);
            this.kryptonPanel3.Name = "kryptonPanel3";
            this.kryptonPanel3.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Blue;
            this.kryptonPanel3.PanelBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.SeparatorHighProfile;
            this.kryptonPanel3.Size = new System.Drawing.Size(832, 330);
            this.kryptonPanel3.TabIndex = 316;
            // 
            // FormRelatorios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(832, 450);
            this.Controls.Add(this.kryptonPanel3);
            this.Controls.Add(this.kryptonPanel2);
            this.Controls.Add(this.kryptonPanel1);
            this.Name = "FormRelatorios";
            this.Palette = this.kryptonPalette1;
            this.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.Text = "Relatorios";
            this.Load += new System.EventHandler(this.FormRelatorios_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormRelatorios_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.cmbCategoria)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRelatorio)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbMetodoPgto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).EndInit();
            this.kryptonPanel2.ResumeLayout(false);
            this.kryptonPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel3)).EndInit();
            this.kryptonPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonPalette kryptonPalette1;
        public ComponentFactory.Krypton.Toolkit.KryptonComboBox cmbCategoria;
        public ComponentFactory.Krypton.Toolkit.KryptonComboBox cmbStatus;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel9;
        public ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker dtpMesAno;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel6;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel7;
        public ComponentFactory.Krypton.Toolkit.KryptonButton btnGerarRelatorio;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView dgvRelatorio;
        private System.Windows.Forms.GroupBox groupBox1;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
        public System.Windows.Forms.Label lblStatus;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel2;
        public System.Windows.Forms.Label lblTotalAberto;
        public System.Windows.Forms.Label lblTotalPago;
        public ComponentFactory.Krypton.Toolkit.KryptonComboBox cmbMetodoPgto;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel5;
        public ComponentFactory.Krypton.Toolkit.KryptonButton btnExcel;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel3;
    }
}

