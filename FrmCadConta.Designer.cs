namespace Money
{
    partial class FrmCadConta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCadConta));
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblMens = new System.Windows.Forms.ToolStripStatusLabel();
            this.txtFormapgto = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtIdFormapgto = new System.Windows.Forms.TextBox();
            this.txtIdSubCat = new System.Windows.Forms.TextBox();
            this.txtIdFornecdor = new System.Windows.Forms.TextBox();
            this.txtIdCategoria = new System.Windows.Forms.TextBox();
            this.btnLocalizarSubCat = new System.Windows.Forms.Button();
            this.txtSubCategoria = new System.Windows.Forms.TextBox();
            this.btnLocalizarCategoria = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnParcelar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.txtValorTotal = new System.Windows.Forms.TextBox();
            this.dtVencimento = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dtDataEmissao = new System.Windows.Forms.DateTimePicker();
            this.label16 = new System.Windows.Forms.Label();
            this.btnLocalizarFornecedor = new System.Windows.Forms.Button();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.txtFornecedor = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCategoria = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnLocalizarFormaPgto = new System.Windows.Forms.Button();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(2, 322);
            // 
            // panel4
            // 
            this.panel4.Size = new System.Drawing.Size(2, 324);
            // 
            // panel5
            // 
            this.panel5.Size = new System.Drawing.Size(2, 324);
            // 
            // btnExit
            // 
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.Location = new System.Drawing.Point(497, 3);
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
            // txtFormapgto
            // 
            this.txtFormapgto.BackColor = System.Drawing.Color.SteelBlue;
            this.txtFormapgto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtFormapgto.ForeColor = System.Drawing.Color.White;
            this.txtFormapgto.Location = new System.Drawing.Point(125, 138);
            this.txtFormapgto.Name = "txtFormapgto";
            this.txtFormapgto.Size = new System.Drawing.Size(308, 21);
            this.txtFormapgto.TabIndex = 6;
            this.txtFormapgto.Enter += new System.EventHandler(this.TxtFormapgto_Enter);
            this.txtFormapgto.Leave += new System.EventHandler(this.TxtFormapgto_Leave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Money.Properties.Resources.payment;
            this.pictureBox1.Location = new System.Drawing.Point(435, 65);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(94, 226);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 461;
            this.pictureBox1.TabStop = false;
            // 
            // txtIdFormapgto
            // 
            this.txtIdFormapgto.BackColor = System.Drawing.Color.SteelBlue;
            this.txtIdFormapgto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtIdFormapgto.ForeColor = System.Drawing.Color.White;
            this.txtIdFormapgto.Location = new System.Drawing.Point(89, 138);
            this.txtIdFormapgto.Name = "txtIdFormapgto";
            this.txtIdFormapgto.ReadOnly = true;
            this.txtIdFormapgto.Size = new System.Drawing.Size(36, 21);
            this.txtIdFormapgto.TabIndex = 460;
            this.txtIdFormapgto.TabStop = false;
            this.txtIdFormapgto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtIdSubCat
            // 
            this.txtIdSubCat.BackColor = System.Drawing.Color.SteelBlue;
            this.txtIdSubCat.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtIdSubCat.ForeColor = System.Drawing.Color.White;
            this.txtIdSubCat.Location = new System.Drawing.Point(89, 114);
            this.txtIdSubCat.Name = "txtIdSubCat";
            this.txtIdSubCat.ReadOnly = true;
            this.txtIdSubCat.Size = new System.Drawing.Size(36, 21);
            this.txtIdSubCat.TabIndex = 458;
            this.txtIdSubCat.TabStop = false;
            this.txtIdSubCat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtIdFornecdor
            // 
            this.txtIdFornecdor.BackColor = System.Drawing.Color.SteelBlue;
            this.txtIdFornecdor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtIdFornecdor.ForeColor = System.Drawing.Color.White;
            this.txtIdFornecdor.Location = new System.Drawing.Point(89, 65);
            this.txtIdFornecdor.Name = "txtIdFornecdor";
            this.txtIdFornecdor.ReadOnly = true;
            this.txtIdFornecdor.Size = new System.Drawing.Size(36, 21);
            this.txtIdFornecdor.TabIndex = 457;
            this.txtIdFornecdor.TabStop = false;
            this.txtIdFornecdor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtIdCategoria
            // 
            this.txtIdCategoria.BackColor = System.Drawing.Color.SteelBlue;
            this.txtIdCategoria.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtIdCategoria.ForeColor = System.Drawing.Color.White;
            this.txtIdCategoria.Location = new System.Drawing.Point(89, 89);
            this.txtIdCategoria.Name = "txtIdCategoria";
            this.txtIdCategoria.ReadOnly = true;
            this.txtIdCategoria.Size = new System.Drawing.Size(36, 21);
            this.txtIdCategoria.TabIndex = 459;
            this.txtIdCategoria.TabStop = false;
            this.txtIdCategoria.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnLocalizarSubCat
            // 
            this.btnLocalizarSubCat.BackColor = System.Drawing.Color.SteelBlue;
            this.btnLocalizarSubCat.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLocalizarSubCat.BackgroundImage")));
            this.btnLocalizarSubCat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLocalizarSubCat.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnLocalizarSubCat.FlatAppearance.BorderSize = 0;
            this.btnLocalizarSubCat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(80)))));
            this.btnLocalizarSubCat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLocalizarSubCat.ForeColor = System.Drawing.Color.White;
            this.btnLocalizarSubCat.Location = new System.Drawing.Point(409, 116);
            this.btnLocalizarSubCat.Name = "btnLocalizarSubCat";
            this.btnLocalizarSubCat.Size = new System.Drawing.Size(20, 17);
            this.btnLocalizarSubCat.TabIndex = 5;
            this.btnLocalizarSubCat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLocalizarSubCat.UseVisualStyleBackColor = false;
            this.btnLocalizarSubCat.Click += new System.EventHandler(this.btnLocalizarSubCat_Click);
            // 
            // txtSubCategoria
            // 
            this.txtSubCategoria.BackColor = System.Drawing.Color.SteelBlue;
            this.txtSubCategoria.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSubCategoria.ForeColor = System.Drawing.Color.White;
            this.txtSubCategoria.Location = new System.Drawing.Point(126, 114);
            this.txtSubCategoria.Name = "txtSubCategoria";
            this.txtSubCategoria.Size = new System.Drawing.Size(308, 21);
            this.txtSubCategoria.TabIndex = 4;
            this.txtSubCategoria.Enter += new System.EventHandler(this.txtSubCategoria_Enter);
            this.txtSubCategoria.Leave += new System.EventHandler(this.txtSubCategoria_Leave);
            // 
            // btnLocalizarCategoria
            // 
            this.btnLocalizarCategoria.BackColor = System.Drawing.Color.SteelBlue;
            this.btnLocalizarCategoria.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLocalizarCategoria.BackgroundImage")));
            this.btnLocalizarCategoria.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLocalizarCategoria.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnLocalizarCategoria.FlatAppearance.BorderSize = 0;
            this.btnLocalizarCategoria.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(80)))));
            this.btnLocalizarCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLocalizarCategoria.ForeColor = System.Drawing.Color.White;
            this.btnLocalizarCategoria.Location = new System.Drawing.Point(411, 91);
            this.btnLocalizarCategoria.Name = "btnLocalizarCategoria";
            this.btnLocalizarCategoria.Size = new System.Drawing.Size(20, 17);
            this.btnLocalizarCategoria.TabIndex = 3;
            this.btnLocalizarCategoria.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLocalizarCategoria.UseVisualStyleBackColor = false;
            this.btnLocalizarCategoria.Click += new System.EventHandler(this.btnLocalizarCategoria_Click_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(76)))), ((int)(((byte)(172)))));
            this.label6.Location = new System.Drawing.Point(4, 214);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 16);
            this.label6.TabIndex = 450;
            this.label6.Text = "Valor";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(76)))), ((int)(((byte)(172)))));
            this.label4.Location = new System.Drawing.Point(4, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 16);
            this.label4.TabIndex = 446;
            this.label4.Text = "Sub Categoria";
            // 
            // btnParcelar
            // 
            this.btnParcelar.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnParcelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnParcelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(80)))));
            this.btnParcelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnParcelar.ForeColor = System.Drawing.Color.White;
            this.btnParcelar.Location = new System.Drawing.Point(88, 261);
            this.btnParcelar.Name = "btnParcelar";
            this.btnParcelar.Size = new System.Drawing.Size(115, 30);
            this.btnParcelar.TabIndex = 12;
            this.btnParcelar.Text = "&Parcelar";
            this.btnParcelar.UseVisualStyleBackColor = false;
            this.btnParcelar.Click += new System.EventHandler(this.btnParcelar_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.BackColor = System.Drawing.Color.SeaGreen;
            this.btnNovo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnNovo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(80)))));
            this.btnNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovo.ForeColor = System.Drawing.Color.White;
            this.btnNovo.Location = new System.Drawing.Point(318, 261);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(115, 30);
            this.btnNovo.TabIndex = 13;
            this.btnNovo.Text = "&Novo";
            this.btnNovo.UseVisualStyleBackColor = false;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.Orange;
            this.btnSalvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSalvar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(80)))));
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.ForeColor = System.Drawing.Color.White;
            this.btnSalvar.Location = new System.Drawing.Point(203, 261);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(115, 30);
            this.btnSalvar.TabIndex = 11;
            this.btnSalvar.Text = "&Salvar";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click_1);
            // 
            // txtValorTotal
            // 
            this.txtValorTotal.BackColor = System.Drawing.Color.SteelBlue;
            this.txtValorTotal.ForeColor = System.Drawing.Color.White;
            this.txtValorTotal.Location = new System.Drawing.Point(89, 211);
            this.txtValorTotal.Name = "txtValorTotal";
            this.txtValorTotal.Size = new System.Drawing.Size(343, 21);
            this.txtValorTotal.TabIndex = 10;
            this.txtValorTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtValorTotal.Click += new System.EventHandler(this.txtValorTotal_Click);
            this.txtValorTotal.Enter += new System.EventHandler(this.txtValorTotal_Enter);
            this.txtValorTotal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValorTotal_KeyPress);
            this.txtValorTotal.Leave += new System.EventHandler(this.txtValorTotal_Leave);
            this.txtValorTotal.Validating += new System.ComponentModel.CancelEventHandler(this.txtValorTotal_Validating);
            // 
            // dtVencimento
            // 
            this.dtVencimento.CalendarForeColor = System.Drawing.Color.Blue;
            this.dtVencimento.CustomFormat = "dd/MM/yyyy";
            this.dtVencimento.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtVencimento.Location = new System.Drawing.Point(89, 188);
            this.dtVencimento.Name = "dtVencimento";
            this.dtVencimento.Size = new System.Drawing.Size(343, 21);
            this.dtVencimento.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(76)))), ((int)(((byte)(172)))));
            this.label3.Location = new System.Drawing.Point(4, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 16);
            this.label3.TabIndex = 353;
            this.label3.Text = "Forma Pgo";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(76)))), ((int)(((byte)(172)))));
            this.label9.Location = new System.Drawing.Point(4, 191);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 16);
            this.label9.TabIndex = 297;
            this.label9.Text = "1º Parc";
            // 
            // dtDataEmissao
            // 
            this.dtDataEmissao.CalendarForeColor = System.Drawing.Color.Blue;
            this.dtDataEmissao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDataEmissao.Location = new System.Drawing.Point(329, 36);
            this.dtDataEmissao.Name = "dtDataEmissao";
            this.dtDataEmissao.Size = new System.Drawing.Size(99, 21);
            this.dtDataEmissao.TabIndex = 19;
            this.dtDataEmissao.TabStop = false;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(76)))), ((int)(((byte)(172)))));
            this.label16.Location = new System.Drawing.Point(4, 168);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(61, 16);
            this.label16.TabIndex = 299;
            this.label16.Text = "Descrição";
            // 
            // btnLocalizarFornecedor
            // 
            this.btnLocalizarFornecedor.BackColor = System.Drawing.Color.SteelBlue;
            this.btnLocalizarFornecedor.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLocalizarFornecedor.BackgroundImage")));
            this.btnLocalizarFornecedor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLocalizarFornecedor.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnLocalizarFornecedor.FlatAppearance.BorderSize = 0;
            this.btnLocalizarFornecedor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(80)))));
            this.btnLocalizarFornecedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLocalizarFornecedor.ForeColor = System.Drawing.Color.White;
            this.btnLocalizarFornecedor.Location = new System.Drawing.Point(411, 67);
            this.btnLocalizarFornecedor.Name = "btnLocalizarFornecedor";
            this.btnLocalizarFornecedor.Size = new System.Drawing.Size(20, 17);
            this.btnLocalizarFornecedor.TabIndex = 1;
            this.btnLocalizarFornecedor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLocalizarFornecedor.UseVisualStyleBackColor = false;
            this.btnLocalizarFornecedor.Click += new System.EventHandler(this.btnLocalizarFornecedor_Click);
            // 
            // txtDescricao
            // 
            this.txtDescricao.BackColor = System.Drawing.Color.SteelBlue;
            this.txtDescricao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDescricao.ForeColor = System.Drawing.Color.White;
            this.txtDescricao.Location = new System.Drawing.Point(89, 164);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(344, 21);
            this.txtDescricao.TabIndex = 8;
            this.txtDescricao.Enter += new System.EventHandler(this.txtDescricao_Enter);
            this.txtDescricao.Leave += new System.EventHandler(this.txtDescricao_Leave);
            // 
            // txtFornecedor
            // 
            this.txtFornecedor.BackColor = System.Drawing.Color.SteelBlue;
            this.txtFornecedor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtFornecedor.ForeColor = System.Drawing.Color.White;
            this.txtFornecedor.Location = new System.Drawing.Point(125, 65);
            this.txtFornecedor.Name = "txtFornecedor";
            this.txtFornecedor.Size = new System.Drawing.Size(308, 21);
            this.txtFornecedor.TabIndex = 0;
            this.txtFornecedor.Enter += new System.EventHandler(this.txtFornecedorCad_Enter);
            this.txtFornecedor.Leave += new System.EventHandler(this.txtFornecedorCad_Leave);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(76)))), ((int)(((byte)(172)))));
            this.label14.Location = new System.Drawing.Point(4, 68);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(69, 16);
            this.label14.TabIndex = 296;
            this.label14.Text = "Fornecedor";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(76)))), ((int)(((byte)(172)))));
            this.label1.Location = new System.Drawing.Point(4, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 16);
            this.label1.TabIndex = 351;
            this.label1.Text = "Categoria";
            // 
            // txtCategoria
            // 
            this.txtCategoria.BackColor = System.Drawing.Color.SteelBlue;
            this.txtCategoria.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCategoria.ForeColor = System.Drawing.Color.White;
            this.txtCategoria.Location = new System.Drawing.Point(125, 89);
            this.txtCategoria.Name = "txtCategoria";
            this.txtCategoria.Size = new System.Drawing.Size(308, 21);
            this.txtCategoria.TabIndex = 2;
            this.txtCategoria.Enter += new System.EventHandler(this.txtCategoria_Enter);
            this.txtCategoria.Leave += new System.EventHandler(this.txtCategoria_Leave);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btnLocalizarFormaPgto
            // 
            this.btnLocalizarFormaPgto.BackColor = System.Drawing.Color.SteelBlue;
            this.btnLocalizarFormaPgto.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLocalizarFormaPgto.BackgroundImage")));
            this.btnLocalizarFormaPgto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLocalizarFormaPgto.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnLocalizarFormaPgto.FlatAppearance.BorderSize = 0;
            this.btnLocalizarFormaPgto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(80)))));
            this.btnLocalizarFormaPgto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLocalizarFormaPgto.ForeColor = System.Drawing.Color.White;
            this.btnLocalizarFormaPgto.Location = new System.Drawing.Point(409, 140);
            this.btnLocalizarFormaPgto.Name = "btnLocalizarFormaPgto";
            this.btnLocalizarFormaPgto.Size = new System.Drawing.Size(20, 17);
            this.btnLocalizarFormaPgto.TabIndex = 7;
            this.btnLocalizarFormaPgto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLocalizarFormaPgto.UseVisualStyleBackColor = false;
            this.btnLocalizarFormaPgto.Click += new System.EventHandler(this.btnLocalizarFormaPgto_Click);
            // 
            // FrmCadConta
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(533, 324);
            this.Controls.Add(this.dtDataEmissao);
            this.Controls.Add(this.btnLocalizarFormaPgto);
            this.Controls.Add(this.txtFormapgto);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtIdFormapgto);
            this.Controls.Add(this.txtIdSubCat);
            this.Controls.Add(this.txtIdFornecdor);
            this.Controls.Add(this.txtIdCategoria);
            this.Controls.Add(this.btnLocalizarSubCat);
            this.Controls.Add(this.txtSubCategoria);
            this.Controls.Add(this.btnLocalizarCategoria);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnParcelar);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.txtValorTotal);
            this.Controls.Add(this.dtVencimento);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.btnLocalizarFornecedor);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.txtFornecedor);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCategoria);
            this.Name = "FrmCadConta";
            this.Text = "Money - Cadastro de conta";
            this.Load += new System.EventHandler(this.FrmCadastroContas_Load);
            this.Controls.SetChildIndex(this.panel5, 0);
            this.Controls.SetChildIndex(this.panel4, 0);
            this.Controls.SetChildIndex(this.panel3, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.Controls.SetChildIndex(this.txtCategoria, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label14, 0);
            this.Controls.SetChildIndex(this.txtFornecedor, 0);
            this.Controls.SetChildIndex(this.txtDescricao, 0);
            this.Controls.SetChildIndex(this.btnLocalizarFornecedor, 0);
            this.Controls.SetChildIndex(this.label16, 0);
            this.Controls.SetChildIndex(this.label9, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.dtVencimento, 0);
            this.Controls.SetChildIndex(this.txtValorTotal, 0);
            this.Controls.SetChildIndex(this.btnSalvar, 0);
            this.Controls.SetChildIndex(this.btnNovo, 0);
            this.Controls.SetChildIndex(this.btnParcelar, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.btnLocalizarCategoria, 0);
            this.Controls.SetChildIndex(this.txtSubCategoria, 0);
            this.Controls.SetChildIndex(this.btnLocalizarSubCat, 0);
            this.Controls.SetChildIndex(this.txtIdCategoria, 0);
            this.Controls.SetChildIndex(this.txtIdFornecdor, 0);
            this.Controls.SetChildIndex(this.txtIdSubCat, 0);
            this.Controls.SetChildIndex(this.txtIdFormapgto, 0);
            this.Controls.SetChildIndex(this.pictureBox1, 0);
            this.Controls.SetChildIndex(this.txtFormapgto, 0);
            this.Controls.SetChildIndex(this.btnLocalizarFormaPgto, 0);
            this.Controls.SetChildIndex(this.dtDataEmissao, 0);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox txtValorTotal;
        public System.Windows.Forms.DateTimePicker dtVencimento;
        public System.Windows.Forms.DateTimePicker dtDataEmissao;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnLocalizarFornecedor;
        public System.Windows.Forms.TextBox txtFornecedor;
        private System.Windows.Forms.Label label14;
        public System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel lblMens;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Button btnNovo;
        public System.Windows.Forms.Button btnSalvar;
        public System.Windows.Forms.Button btnParcelar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        public System.Windows.Forms.TextBox txtSubCategoria;
        private System.Windows.Forms.Button btnLocalizarCategoria;
        private System.Windows.Forms.Button btnLocalizarSubCat;
        public System.Windows.Forms.TextBox txtCategoria;
        public System.Windows.Forms.TextBox txtIdFormapgto;
        public System.Windows.Forms.TextBox txtIdSubCat;
        public System.Windows.Forms.TextBox txtIdFornecdor;
        public System.Windows.Forms.TextBox txtIdCategoria;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.TextBox txtFormapgto;
        private System.Windows.Forms.Button btnLocalizarFormaPgto;
    }
}
