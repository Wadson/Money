namespace Money
{
    partial class FrmManutContasPagar
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timerAtualizaMetodo = new System.Windows.Forms.Timer(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblMens = new System.Windows.Forms.ToolStripStatusLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.dataGridPesquisa = new System.Windows.Forms.DataGridView();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnLocalizar = new System.Windows.Forms.Button();
            this.btnPagar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.lblTotalPesquisa = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblContaRegistros = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblTotalSelecionado = new System.Windows.Forms.Label();
            this.lblMensagem = new System.Windows.Forms.Label();
            this.rbFornecedor = new System.Windows.Forms.RadioButton();
            this.rbFormapgto = new System.Windows.Forms.RadioButton();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPesquisa)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(10, 424);
            this.panel2.Size = new System.Drawing.Size(582, 10);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(10, 0);
            this.panel3.Size = new System.Drawing.Size(582, 25);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Size = new System.Drawing.Size(10, 434);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Location = new System.Drawing.Point(592, 0);
            this.panel5.Size = new System.Drawing.Size(10, 434);
            // 
            // btnExit
            // 
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.Location = new System.Drawing.Point(675, 3);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            
            // 
            // timerAtualizaMetodo
            // 
            this.timerAtualizaMetodo.Tick += new System.EventHandler(this.timerAtualizaMetodo_Tick);
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left;
            this.toolStripStatusLabel3.BorderStyle = System.Windows.Forms.Border3DStyle.Raised;
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(76, 19);
            this.toolStripStatusLabel3.Text = "Mensagem: ";
            // 
            // lblMens
            // 
            this.lblMens.ActiveLinkColor = System.Drawing.Color.Blue;
            this.lblMens.ForeColor = System.Drawing.Color.Blue;
            this.lblMens.Name = "lblMens";
            this.lblMens.Size = new System.Drawing.Size(22, 19);
            this.lblMens.Text = "     ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(76)))), ((int)(((byte)(172)))));
            this.label1.Location = new System.Drawing.Point(14, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 16);
            this.label1.TabIndex = 448;
            this.label1.Text = "Contas a pagar";
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.BackColor = System.Drawing.Color.SeaGreen;
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnCerrar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(182)))));
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatAppearance.CheckedBackColor = System.Drawing.Color.SteelBlue;
            this.btnCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CadetBlue;
            this.btnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.ForeColor = System.Drawing.Color.White;
            this.btnCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCerrar.Location = new System.Drawing.Point(503, 390);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(89, 30);
            this.btnCerrar.TabIndex = 447;
            this.btnCerrar.Text = "&Fechar";
            this.btnCerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // dataGridPesquisa
            // 
            this.dataGridPesquisa.AllowUserToAddRows = false;
            this.dataGridPesquisa.AllowUserToDeleteRows = false;
            this.dataGridPesquisa.AllowUserToResizeColumns = false;
            this.dataGridPesquisa.AllowUserToResizeRows = false;
            this.dataGridPesquisa.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridPesquisa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridPesquisa.BackgroundColor = System.Drawing.Color.White;
            this.dataGridPesquisa.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridPesquisa.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridPesquisa.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(51)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridPesquisa.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridPesquisa.ColumnHeadersHeight = 20;
            this.dataGridPesquisa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Column9,
            this.Column13,
            this.Column14,
            this.Column15,
            this.Column12,
            this.Column5,
            this.Column10,
            this.Column16,
            this.Column11,
            this.Column2,
            this.Column3,
            this.Column8,
            this.Column7,
            this.Column1,
            this.Column6,
            this.Column4});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(180)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(180)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridPesquisa.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridPesquisa.EnableHeadersVisualStyles = false;
            this.dataGridPesquisa.GridColor = System.Drawing.Color.SteelBlue;
            this.dataGridPesquisa.Location = new System.Drawing.Point(11, 80);
            this.dataGridPesquisa.Name = "dataGridPesquisa";
            this.dataGridPesquisa.ReadOnly = true;
            this.dataGridPesquisa.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(180)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(180)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridPesquisa.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridPesquisa.RowHeadersVisible = false;
            this.dataGridPesquisa.RowHeadersWidth = 20;
            this.dataGridPesquisa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridPesquisa.Size = new System.Drawing.Size(485, 305);
            this.dataGridPesquisa.TabIndex = 446;
            this.dataGridPesquisa.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridPesquisa_CellDoubleClick);
            this.dataGridPesquisa.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridPesquisa_CellFormatting);
            this.dataGridPesquisa.SelectionChanged += new System.EventHandler(this.dataGridPesquisa_SelectionChanged);
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPesquisa.BackColor = System.Drawing.Color.SteelBlue;
            this.txtPesquisa.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtPesquisa.Location = new System.Drawing.Point(230, 42);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(356, 23);
            this.txtPesquisa.TabIndex = 350;
            this.txtPesquisa.Click += new System.EventHandler(this.txtFornecedor_Click);
            this.txtPesquisa.TextChanged += new System.EventHandler(this.txtFornecedor_TextChanged);
            this.txtPesquisa.Enter += new System.EventHandler(this.txtFornecedor_Enter);
            this.txtPesquisa.Leave += new System.EventHandler(this.txtFornecedor_Leave);
            // 
            // btnNovo
            // 
            this.btnNovo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNovo.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnNovo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnNovo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(182)))));
            this.btnNovo.FlatAppearance.BorderSize = 0;
            this.btnNovo.FlatAppearance.CheckedBackColor = System.Drawing.Color.SteelBlue;
            this.btnNovo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CadetBlue;
            this.btnNovo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.btnNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnNovo.ForeColor = System.Drawing.Color.White;
            this.btnNovo.Location = new System.Drawing.Point(501, 118);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(91, 30);
            this.btnNovo.TabIndex = 436;
            this.btnNovo.Text = "&Novo";
            this.btnNovo.UseVisualStyleBackColor = false;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAlterar.BackColor = System.Drawing.Color.Orange;
            this.btnAlterar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAlterar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(182)))));
            this.btnAlterar.FlatAppearance.BorderSize = 0;
            this.btnAlterar.FlatAppearance.CheckedBackColor = System.Drawing.Color.SteelBlue;
            this.btnAlterar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CadetBlue;
            this.btnAlterar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.btnAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnAlterar.ForeColor = System.Drawing.Color.White;
            this.btnAlterar.Location = new System.Drawing.Point(501, 156);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(91, 30);
            this.btnAlterar.TabIndex = 437;
            this.btnAlterar.Text = "&Alterar";
            this.btnAlterar.UseVisualStyleBackColor = false;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExcluir.BackColor = System.Drawing.Color.Red;
            this.btnExcluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnExcluir.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(182)))));
            this.btnExcluir.FlatAppearance.BorderSize = 0;
            this.btnExcluir.FlatAppearance.CheckedBackColor = System.Drawing.Color.SteelBlue;
            this.btnExcluir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CadetBlue;
            this.btnExcluir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnExcluir.ForeColor = System.Drawing.Color.White;
            this.btnExcluir.Location = new System.Drawing.Point(501, 194);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(91, 30);
            this.btnExcluir.TabIndex = 438;
            this.btnExcluir.Text = "&Excluir";
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnLocalizar
            // 
            this.btnLocalizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLocalizar.BackColor = System.Drawing.Color.SteelBlue;
            this.btnLocalizar.BackgroundImage = global::Money.Properties.Resources.loupe;
            this.btnLocalizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLocalizar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnLocalizar.FlatAppearance.BorderSize = 0;
            this.btnLocalizar.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnLocalizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnLocalizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnLocalizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLocalizar.ForeColor = System.Drawing.Color.White;
            this.btnLocalizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLocalizar.Location = new System.Drawing.Point(565, 44);
            this.btnLocalizar.Name = "btnLocalizar";
            this.btnLocalizar.Size = new System.Drawing.Size(20, 19);
            this.btnLocalizar.TabIndex = 439;
            this.btnLocalizar.UseVisualStyleBackColor = false;
            this.btnLocalizar.Click += new System.EventHandler(this.btnLocalizar_Click);
            // 
            // btnPagar
            // 
            this.btnPagar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPagar.BackColor = System.Drawing.Color.Green;
            this.btnPagar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPagar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(182)))));
            this.btnPagar.FlatAppearance.BorderSize = 0;
            this.btnPagar.FlatAppearance.CheckedBackColor = System.Drawing.Color.SteelBlue;
            this.btnPagar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CadetBlue;
            this.btnPagar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.btnPagar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnPagar.ForeColor = System.Drawing.Color.White;
            this.btnPagar.Location = new System.Drawing.Point(501, 80);
            this.btnPagar.Name = "btnPagar";
            this.btnPagar.Size = new System.Drawing.Size(91, 30);
            this.btnPagar.TabIndex = 440;
            this.btnPagar.Text = "&Pagar";
            this.btnPagar.UseVisualStyleBackColor = false;
            this.btnPagar.Click += new System.EventHandler(this.btnPagar_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.lblTotalPesquisa);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.lblContaRegistros);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.lblTotalSelecionado);
            this.panel1.Controls.Add(this.lblMensagem);
            this.panel1.Location = new System.Drawing.Point(12, 391);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(486, 30);
            this.panel1.TabIndex = 444;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.label8.ForeColor = System.Drawing.Color.SeaGreen;
            this.label8.Location = new System.Drawing.Point(379, 6);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 17);
            this.label8.TabIndex = 392;
            this.label8.Text = "Total:";
            // 
            // lblTotalPesquisa
            // 
            this.lblTotalPesquisa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalPesquisa.AutoSize = true;
            this.lblTotalPesquisa.BackColor = System.Drawing.Color.White;
            this.lblTotalPesquisa.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.lblTotalPesquisa.ForeColor = System.Drawing.Color.SeaGreen;
            this.lblTotalPesquisa.Location = new System.Drawing.Point(422, 6);
            this.lblTotalPesquisa.Name = "lblTotalPesquisa";
            this.lblTotalPesquisa.Size = new System.Drawing.Size(32, 17);
            this.lblTotalPesquisa.TabIndex = 393;
            this.lblTotalPesquisa.Text = "0,00";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(76)))), ((int)(((byte)(172)))));
            this.label5.Location = new System.Drawing.Point(27, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 17);
            this.label5.TabIndex = 390;
            this.label5.Text = "Reg.:";
            // 
            // lblContaRegistros
            // 
            this.lblContaRegistros.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblContaRegistros.AutoSize = true;
            this.lblContaRegistros.BackColor = System.Drawing.Color.White;
            this.lblContaRegistros.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.lblContaRegistros.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(76)))), ((int)(((byte)(172)))));
            this.lblContaRegistros.Location = new System.Drawing.Point(3, 6);
            this.lblContaRegistros.Name = "lblContaRegistros";
            this.lblContaRegistros.Size = new System.Drawing.Size(15, 17);
            this.lblContaRegistros.TabIndex = 390;
            this.lblContaRegistros.Text = "0";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(76)))), ((int)(((byte)(172)))));
            this.label6.Location = new System.Drawing.Point(82, 6);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 17);
            this.label6.TabIndex = 390;
            this.label6.Text = "Select:";
            // 
            // lblTotalSelecionado
            // 
            this.lblTotalSelecionado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTotalSelecionado.AutoSize = true;
            this.lblTotalSelecionado.BackColor = System.Drawing.Color.White;
            this.lblTotalSelecionado.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.lblTotalSelecionado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(76)))), ((int)(((byte)(172)))));
            this.lblTotalSelecionado.Location = new System.Drawing.Point(128, 6);
            this.lblTotalSelecionado.Name = "lblTotalSelecionado";
            this.lblTotalSelecionado.Size = new System.Drawing.Size(38, 17);
            this.lblTotalSelecionado.TabIndex = 391;
            this.lblTotalSelecionado.Text = "  0,00";
            // 
            // lblMensagem
            // 
            this.lblMensagem.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblMensagem.AutoSize = true;
            this.lblMensagem.BackColor = System.Drawing.Color.White;
            this.lblMensagem.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.lblMensagem.ForeColor = System.Drawing.Color.Red;
            this.lblMensagem.Location = new System.Drawing.Point(218, 6);
            this.lblMensagem.Name = "lblMensagem";
            this.lblMensagem.Size = new System.Drawing.Size(12, 17);
            this.lblMensagem.TabIndex = 431;
            this.lblMensagem.Text = "-";
            // 
            // rbFornecedor
            // 
            this.rbFornecedor.AutoSize = true;
            this.rbFornecedor.Checked = true;
            this.rbFornecedor.Font = new System.Drawing.Font("Century Gothic", 8.75F);
            this.rbFornecedor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(76)))), ((int)(((byte)(172)))));
            this.rbFornecedor.Location = new System.Drawing.Point(131, 55);
            this.rbFornecedor.Name = "rbFornecedor";
            this.rbFornecedor.Size = new System.Drawing.Size(95, 21);
            this.rbFornecedor.TabIndex = 449;
            this.rbFornecedor.TabStop = true;
            this.rbFornecedor.Text = "Fornecedor";
            this.rbFornecedor.UseVisualStyleBackColor = true;
            this.rbFornecedor.CheckedChanged += new System.EventHandler(this.rbFornecedor_CheckedChanged);
            // 
            // rbFormapgto
            // 
            this.rbFormapgto.AutoSize = true;
            this.rbFormapgto.Font = new System.Drawing.Font("Century Gothic", 8.75F);
            this.rbFormapgto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(76)))), ((int)(((byte)(172)))));
            this.rbFormapgto.Location = new System.Drawing.Point(131, 35);
            this.rbFormapgto.Name = "rbFormapgto";
            this.rbFormapgto.Size = new System.Drawing.Size(95, 21);
            this.rbFormapgto.TabIndex = 450;
            this.rbFormapgto.Text = "Forma pgto";
            this.rbFormapgto.UseVisualStyleBackColor = true;
            this.rbFormapgto.CheckedChanged += new System.EventHandler(this.rbFormapgto_CheckedChanged);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "idconta";
            dataGridViewCellStyle2.Format = "00";
            this.ID.DefaultCellStyle = dataGridViewCellStyle2;
            this.ID.HeaderText = "ID CONTA";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            this.ID.Width = 84;
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "idparcela";
            dataGridViewCellStyle3.Format = "00";
            this.Column9.DefaultCellStyle = dataGridViewCellStyle3;
            this.Column9.HeaderText = "ID PARC";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            this.Column9.Visible = false;
            this.Column9.Width = 75;
            // 
            // Column13
            // 
            this.Column13.DataPropertyName = "idfornecedor";
            this.Column13.HeaderText = "IDFORNECEDOR";
            this.Column13.Name = "Column13";
            this.Column13.ReadOnly = true;
            this.Column13.Visible = false;
            this.Column13.Width = 118;
            // 
            // Column14
            // 
            this.Column14.DataPropertyName = "idcategoria";
            this.Column14.HeaderText = "ID CATEGORIA";
            this.Column14.Name = "Column14";
            this.Column14.ReadOnly = true;
            this.Column14.Visible = false;
            this.Column14.Width = 109;
            // 
            // Column15
            // 
            this.Column15.DataPropertyName = "idsubcategoria";
            this.Column15.HeaderText = "ID SUB CAT";
            this.Column15.Name = "Column15";
            this.Column15.ReadOnly = true;
            this.Column15.Visible = false;
            this.Column15.Width = 89;
            // 
            // Column12
            // 
            this.Column12.DataPropertyName = "idformapgto";
            this.Column12.HeaderText = "ID FORM PGTO";
            this.Column12.Name = "Column12";
            this.Column12.ReadOnly = true;
            this.Column12.Visible = false;
            this.Column12.Width = 113;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column5.DataPropertyName = "fornecedor";
            this.Column5.HeaderText = "FORNECEDOR";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column10
            // 
            this.Column10.DataPropertyName = "categoria";
            this.Column10.HeaderText = "CATEGORIA";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            this.Column10.Visible = false;
            this.Column10.Width = 95;
            // 
            // Column16
            // 
            this.Column16.DataPropertyName = "subcategoria";
            this.Column16.HeaderText = "SUB CATEGORIA";
            this.Column16.Name = "Column16";
            this.Column16.ReadOnly = true;
            this.Column16.Visible = false;
            this.Column16.Width = 118;
            // 
            // Column11
            // 
            this.Column11.DataPropertyName = "formapgto";
            this.Column11.HeaderText = "FORMAPGTO";
            this.Column11.Name = "Column11";
            this.Column11.ReadOnly = true;
            this.Column11.Width = 103;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "num_parcela";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Format = "00";
            this.Column2.DefaultCellStyle = dataGridViewCellStyle4;
            this.Column2.HeaderText = "PARCELA";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 79;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "valor_parc";
            dataGridViewCellStyle5.Format = "N";
            this.Column3.DefaultCellStyle = dataGridViewCellStyle5;
            this.Column3.HeaderText = "VALOR";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 67;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "datapgto";
            this.Column8.HeaderText = "DATA PGTO";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Visible = false;
            this.Column8.Width = 93;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "valorpago";
            this.Column7.HeaderText = "V.PAGO";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Visible = false;
            this.Column7.Width = 75;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.DataPropertyName = "datacadastro";
            this.Column1.HeaderText = "CADASTRO";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "descricao";
            this.Column6.HeaderText = "DESCRIÇÃO";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Visible = false;
            this.Column6.Width = 96;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "datavenc";
            this.Column4.HeaderText = "VENCTO";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 76;
            // 
            // FrmManutContasPagar
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(602, 434);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.rbFormapgto);
            this.Controls.Add(this.rbFornecedor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.dataGridPesquisa);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnLocalizar);
            this.Controls.Add(this.btnPagar);
            this.Controls.Add(this.txtPesquisa);
            this.Name = "FrmManutContasPagar";
            this.Text = "Money - Manutenção de contas a pagar";
            this.Load += new System.EventHandler(this.FrmManutContasPagar_Load);
            this.Controls.SetChildIndex(this.txtPesquisa, 0);
            this.Controls.SetChildIndex(this.btnPagar, 0);
            this.Controls.SetChildIndex(this.btnLocalizar, 0);
            this.Controls.SetChildIndex(this.btnExcluir, 0);
            this.Controls.SetChildIndex(this.btnAlterar, 0);
            this.Controls.SetChildIndex(this.btnNovo, 0);
            this.Controls.SetChildIndex(this.dataGridPesquisa, 0);
            this.Controls.SetChildIndex(this.btnCerrar, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.rbFornecedor, 0);
            this.Controls.SetChildIndex(this.rbFormapgto, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.panel5, 0);
            this.Controls.SetChildIndex(this.panel4, 0);
            this.Controls.SetChildIndex(this.panel3, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPesquisa)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timerAtualizaMetodo;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel lblMens;
        private System.Windows.Forms.Label lblTotalPesquisa;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblTotalSelecionado;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblContaRegistros;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblMensagem;
        public System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnLocalizar;
        private System.Windows.Forms.Button btnPagar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridPesquisa;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbFornecedor;
        private System.Windows.Forms.RadioButton rbFormapgto;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column13;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column14;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column15;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column16;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}
