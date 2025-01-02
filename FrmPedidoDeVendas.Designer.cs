namespace Money
{
    partial class FrmPedidoDeVendas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle91 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle92 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle104 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle105 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle93 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle94 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle95 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle96 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle97 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle98 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle99 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle100 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle101 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle102 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle103 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDesconto = new System.Windows.Forms.TextBox();
            this.txtQtdItens = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnLocalizarCliente = new System.Windows.Forms.Button();
            this.txtNomeCliente = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.btnExcluirProduto = new System.Windows.Forms.Button();
            this.dataGridVendas = new System.Windows.Forms.DataGridView();
            this.id_itensvenda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome_produto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtd_produto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valor_parcela = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dt_vcto_parcela = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_produto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_venda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_parcela = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valor_produto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.num_parcela = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status_conta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_contasreceber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAlterarProduto = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dtDataVenda = new System.Windows.Forms.DateTimePicker();
            this.txtIdVenda = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtSubTotal = new System.Windows.Forms.TextBox();
            this.btnIncluirProduto = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnImprimirPedido = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridVendas)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(2, 543);
            this.panel2.Size = new System.Drawing.Size(950, 2);
            // 
            // panel3
            // 
            this.panel3.Size = new System.Drawing.Size(950, 25);
            // 
            // panel4
            // 
            this.panel4.Size = new System.Drawing.Size(2, 545);
            // 
            // panel5
            // 
            this.panel5.Location = new System.Drawing.Point(952, 0);
            this.panel5.Size = new System.Drawing.Size(2, 545);
            // 
            // btnExit
            // 
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.Location = new System.Drawing.Point(5547, 3);
            // 
            // txtTotal
            // 
            this.txtTotal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.txtTotal.Location = new System.Drawing.Point(227, 147);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(129, 38);
            this.txtTotal.TabIndex = 585;
            this.txtTotal.TabStop = false;
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label11.Location = new System.Drawing.Point(119, 152);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(102, 31);
            this.label11.TabIndex = 586;
            this.label11.Text = "TOTAL";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.75F);
            this.label6.Location = new System.Drawing.Point(93, 113);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 18);
            this.label6.TabIndex = 583;
            this.label6.Text = " - DESCONTO R$";
            // 
            // txtDesconto
            // 
            this.txtDesconto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDesconto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.txtDesconto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtDesconto.Location = new System.Drawing.Point(227, 107);
            this.txtDesconto.Name = "txtDesconto";
            this.txtDesconto.ReadOnly = true;
            this.txtDesconto.Size = new System.Drawing.Size(129, 26);
            this.txtDesconto.TabIndex = 584;
            this.txtDesconto.TabStop = false;
            this.txtDesconto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtQtdItens
            // 
            this.txtQtdItens.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtQtdItens.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQtdItens.Location = new System.Drawing.Point(227, 27);
            this.txtQtdItens.Name = "txtQtdItens";
            this.txtQtdItens.ReadOnly = true;
            this.txtQtdItens.Size = new System.Drawing.Size(129, 26);
            this.txtQtdItens.TabIndex = 568;
            this.txtQtdItens.TabStop = false;
            this.txtQtdItens.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(137, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 17);
            this.label4.TabIndex = 569;
            this.label4.Text = "QTD. ITENS";
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox4.Controls.Add(this.btnLocalizarCliente);
            this.groupBox4.Controls.Add(this.txtNomeCliente);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Location = new System.Drawing.Point(391, 35);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(551, 66);
            this.groupBox4.TabIndex = 582;
            this.groupBox4.TabStop = false;
            // 
            // btnLocalizarCliente
            // 
            this.btnLocalizarCliente.BackColor = System.Drawing.Color.AntiqueWhite;
            this.btnLocalizarCliente.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(182)))));
            this.btnLocalizarCliente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnLocalizarCliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue;
            this.btnLocalizarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLocalizarCliente.Image = global::Money.Properties.Resources.Localizar;
            this.btnLocalizarCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLocalizarCliente.Location = new System.Drawing.Point(406, 20);
            this.btnLocalizarCliente.Name = "btnLocalizarCliente";
            this.btnLocalizarCliente.Size = new System.Drawing.Size(139, 37);
            this.btnLocalizarCliente.TabIndex = 541;
            this.btnLocalizarCliente.TabStop = false;
            this.btnLocalizarCliente.Text = "&Localizar...";
            this.btnLocalizarCliente.UseVisualStyleBackColor = false;
            this.btnLocalizarCliente.Click += new System.EventHandler(this.btnLocalizarCliente_Click);
            // 
            // txtNomeCliente
            // 
            this.txtNomeCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNomeCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtNomeCliente.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtNomeCliente.Location = new System.Drawing.Point(9, 33);
            this.txtNomeCliente.Name = "txtNomeCliente";
            this.txtNomeCliente.ReadOnly = true;
            this.txtNomeCliente.Size = new System.Drawing.Size(391, 23);
            this.txtNomeCliente.TabIndex = 0;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label14.Location = new System.Drawing.Point(11, 13);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(135, 17);
            this.label14.TabIndex = 296;
            this.label14.Text = "NOME DO CLIENTE";
            // 
            // btnExcluirProduto
            // 
            this.btnExcluirProduto.BackColor = System.Drawing.Color.AntiqueWhite;
            this.btnExcluirProduto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnExcluirProduto.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(182)))));
            this.btnExcluirProduto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Moccasin;
            this.btnExcluirProduto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue;
            this.btnExcluirProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluirProduto.Image = global::Money.Properties.Resources.Excluir;
            this.btnExcluirProduto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExcluirProduto.Location = new System.Drawing.Point(67, 138);
            this.btnExcluirProduto.Name = "btnExcluirProduto";
            this.btnExcluirProduto.Size = new System.Drawing.Size(200, 50);
            this.btnExcluirProduto.TabIndex = 581;
            this.btnExcluirProduto.Text = "&Excluir Produto";
            this.btnExcluirProduto.UseVisualStyleBackColor = false;
            this.btnExcluirProduto.Click += new System.EventHandler(this.btnExcluirProduto_Click);
            // 
            // dataGridVendas
            // 
            this.dataGridVendas.AllowUserToAddRows = false;
            this.dataGridVendas.AllowUserToDeleteRows = false;
            this.dataGridVendas.AllowUserToResizeColumns = false;
            this.dataGridVendas.AllowUserToResizeRows = false;
            dataGridViewCellStyle91.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle91.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle91.ForeColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle91.SelectionBackColor = System.Drawing.Color.Brown;
            dataGridViewCellStyle91.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridVendas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle91;
            this.dataGridVendas.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dataGridVendas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridVendas.BackgroundColor = System.Drawing.Color.White;
            this.dataGridVendas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridVendas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridVendas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle92.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle92.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(76)))), ((int)(((byte)(172)))));
            dataGridViewCellStyle92.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            dataGridViewCellStyle92.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle92.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle92.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle92.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridVendas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle92;
            this.dataGridVendas.ColumnHeadersHeight = 20;
            this.dataGridVendas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridVendas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_itensvenda,
            this.nome_produto,
            this.qtd_produto,
            this.valor_parcela,
            this.total,
            this.dt_vcto_parcela,
            this.id_produto,
            this.id_venda,
            this.id_parcela,
            this.valor_produto,
            this.num_parcela,
            this.status_conta,
            this.id_contasreceber});
            this.dataGridVendas.EnableHeadersVisualStyles = false;
            this.dataGridVendas.GridColor = System.Drawing.Color.SteelBlue;
            this.dataGridVendas.Location = new System.Drawing.Point(17, 107);
            this.dataGridVendas.MultiSelect = false;
            this.dataGridVendas.Name = "dataGridVendas";
            this.dataGridVendas.ReadOnly = true;
            this.dataGridVendas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle104.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle104.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle104.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            dataGridViewCellStyle104.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(76)))), ((int)(((byte)(172)))));
            dataGridViewCellStyle104.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle104.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle104.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridVendas.RowHeadersDefaultCellStyle = dataGridViewCellStyle104;
            this.dataGridVendas.RowHeadersWidth = 20;
            dataGridViewCellStyle105.BackColor = System.Drawing.Color.Beige;
            dataGridViewCellStyle105.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            dataGridViewCellStyle105.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridVendas.RowsDefaultCellStyle = dataGridViewCellStyle105;
            this.dataGridVendas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridVendas.Size = new System.Drawing.Size(920, 197);
            this.dataGridVendas.TabIndex = 562;
            // 
            // id_itensvenda
            // 
            this.id_itensvenda.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.id_itensvenda.DataPropertyName = "id_itensvenda";
            dataGridViewCellStyle93.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.id_itensvenda.DefaultCellStyle = dataGridViewCellStyle93;
            this.id_itensvenda.DividerWidth = 1;
            this.id_itensvenda.HeaderText = "Cód. Itens";
            this.id_itensvenda.Name = "id_itensvenda";
            this.id_itensvenda.ReadOnly = true;
            // 
            // nome_produto
            // 
            this.nome_produto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.nome_produto.DataPropertyName = "nome_produto";
            this.nome_produto.DividerWidth = 1;
            this.nome_produto.HeaderText = "Descrição do Produto";
            this.nome_produto.Name = "nome_produto";
            this.nome_produto.ReadOnly = true;
            this.nome_produto.Width = 300;
            // 
            // qtd_produto
            // 
            this.qtd_produto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.qtd_produto.DataPropertyName = "qtd_produto";
            dataGridViewCellStyle94.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle94.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.qtd_produto.DefaultCellStyle = dataGridViewCellStyle94;
            this.qtd_produto.DividerWidth = 1;
            this.qtd_produto.HeaderText = "Qtd.";
            this.qtd_produto.Name = "qtd_produto";
            this.qtd_produto.ReadOnly = true;
            this.qtd_produto.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.qtd_produto.Width = 50;
            // 
            // valor_parcela
            // 
            this.valor_parcela.DataPropertyName = "valor_parcela";
            dataGridViewCellStyle95.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.valor_parcela.DefaultCellStyle = dataGridViewCellStyle95;
            this.valor_parcela.DividerWidth = 1;
            this.valor_parcela.HeaderText = "Valor Parcela";
            this.valor_parcela.Name = "valor_parcela";
            this.valor_parcela.ReadOnly = true;
            this.valor_parcela.Width = 103;
            // 
            // total
            // 
            this.total.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.total.DataPropertyName = "total";
            dataGridViewCellStyle96.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle96.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total.DefaultCellStyle = dataGridViewCellStyle96;
            this.total.DividerWidth = 1;
            this.total.HeaderText = "ValorTotal";
            this.total.Name = "total";
            this.total.ReadOnly = true;
            this.total.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // dt_vcto_parcela
            // 
            this.dt_vcto_parcela.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dt_vcto_parcela.DataPropertyName = "dt_vcto_parcela";
            dataGridViewCellStyle97.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.dt_vcto_parcela.DefaultCellStyle = dataGridViewCellStyle97;
            this.dt_vcto_parcela.DividerWidth = 1;
            this.dt_vcto_parcela.HeaderText = "Data Vencto";
            this.dt_vcto_parcela.Name = "dt_vcto_parcela";
            this.dt_vcto_parcela.ReadOnly = true;
            // 
            // id_produto
            // 
            this.id_produto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.id_produto.DataPropertyName = "id_produto";
            dataGridViewCellStyle98.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.id_produto.DefaultCellStyle = dataGridViewCellStyle98;
            this.id_produto.DividerWidth = 1;
            this.id_produto.HeaderText = "Código Produto";
            this.id_produto.Name = "id_produto";
            this.id_produto.ReadOnly = true;
            // 
            // id_venda
            // 
            this.id_venda.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.id_venda.DataPropertyName = "id_venda";
            dataGridViewCellStyle99.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.id_venda.DefaultCellStyle = dataGridViewCellStyle99;
            this.id_venda.DividerWidth = 1;
            this.id_venda.HeaderText = "Cód.Venda";
            this.id_venda.Name = "id_venda";
            this.id_venda.ReadOnly = true;
            this.id_venda.Width = 91;
            // 
            // id_parcela
            // 
            this.id_parcela.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.id_parcela.DataPropertyName = "id_parcela";
            dataGridViewCellStyle100.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.id_parcela.DefaultCellStyle = dataGridViewCellStyle100;
            this.id_parcela.DividerWidth = 1;
            this.id_parcela.HeaderText = "Cód. Parc";
            this.id_parcela.Name = "id_parcela";
            this.id_parcela.ReadOnly = true;
            this.id_parcela.Width = 84;
            // 
            // valor_produto
            // 
            this.valor_produto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.valor_produto.DataPropertyName = "valor_produto";
            dataGridViewCellStyle101.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle101.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.valor_produto.DefaultCellStyle = dataGridViewCellStyle101;
            this.valor_produto.DividerWidth = 1;
            this.valor_produto.HeaderText = "Valor Produto";
            this.valor_produto.Name = "valor_produto";
            this.valor_produto.ReadOnly = true;
            // 
            // num_parcela
            // 
            this.num_parcela.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.num_parcela.DataPropertyName = "num_parcela";
            dataGridViewCellStyle102.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.num_parcela.DefaultCellStyle = dataGridViewCellStyle102;
            this.num_parcela.DividerWidth = 1;
            this.num_parcela.HeaderText = "Núm Parc";
            this.num_parcela.Name = "num_parcela";
            this.num_parcela.ReadOnly = true;
            this.num_parcela.Width = 85;
            // 
            // status_conta
            // 
            this.status_conta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.status_conta.DataPropertyName = "status_conta";
            dataGridViewCellStyle103.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.status_conta.DefaultCellStyle = dataGridViewCellStyle103;
            this.status_conta.DividerWidth = 1;
            this.status_conta.HeaderText = "Status";
            this.status_conta.Name = "status_conta";
            this.status_conta.ReadOnly = true;
            this.status_conta.Width = 64;
            // 
            // id_contasreceber
            // 
            this.id_contasreceber.DataPropertyName = "id_contasreceber";
            this.id_contasreceber.HeaderText = "Cód. Cont.R";
            this.id_contasreceber.Name = "id_contasreceber";
            this.id_contasreceber.ReadOnly = true;
            this.id_contasreceber.Width = 97;
            // 
            // btnAlterarProduto
            // 
            this.btnAlterarProduto.BackColor = System.Drawing.Color.AntiqueWhite;
            this.btnAlterarProduto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAlterarProduto.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(182)))));
            this.btnAlterarProduto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Moccasin;
            this.btnAlterarProduto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue;
            this.btnAlterarProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlterarProduto.Image = global::Money.Properties.Resources.Alterar;
            this.btnAlterarProduto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAlterarProduto.Location = new System.Drawing.Point(67, 78);
            this.btnAlterarProduto.Name = "btnAlterarProduto";
            this.btnAlterarProduto.Size = new System.Drawing.Size(200, 50);
            this.btnAlterarProduto.TabIndex = 580;
            this.btnAlterarProduto.Text = "&Alterar Produto";
            this.btnAlterarProduto.UseVisualStyleBackColor = false;
            this.btnAlterarProduto.Click += new System.EventHandler(this.btnAlterarProduto_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox3.Controls.Add(this.dtDataVenda);
            this.groupBox3.Controls.Add(this.txtIdVenda);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Location = new System.Drawing.Point(17, 35);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(243, 66);
            this.groupBox3.TabIndex = 579;
            this.groupBox3.TabStop = false;
            // 
            // dtDataVenda
            // 
            this.dtDataVenda.CalendarForeColor = System.Drawing.Color.Blue;
            this.dtDataVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtDataVenda.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDataVenda.Location = new System.Drawing.Point(110, 34);
            this.dtDataVenda.Name = "dtDataVenda";
            this.dtDataVenda.Size = new System.Drawing.Size(117, 22);
            this.dtDataVenda.TabIndex = 19;
            this.dtDataVenda.TabStop = false;
            // 
            // txtIdVenda
            // 
            this.txtIdVenda.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtIdVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdVenda.Location = new System.Drawing.Point(6, 32);
            this.txtIdVenda.Name = "txtIdVenda";
            this.txtIdVenda.ReadOnly = true;
            this.txtIdVenda.Size = new System.Drawing.Size(92, 26);
            this.txtIdVenda.TabIndex = 463;
            this.txtIdVenda.TabStop = false;
            this.txtIdVenda.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(108, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 17);
            this.label1.TabIndex = 465;
            this.label1.Text = "DATA DA VENDA";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label9.Location = new System.Drawing.Point(5, 13);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 17);
            this.label9.TabIndex = 498;
            this.label9.Text = "Nº DA VENDA";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.75F);
            this.label10.Location = new System.Drawing.Point(59, 74);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(164, 18);
            this.label10.TabIndex = 576;
            this.label10.Text = "VALOR DOS ITENS R$";
            // 
            // txtSubTotal
            // 
            this.txtSubTotal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSubTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.txtSubTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtSubTotal.Location = new System.Drawing.Point(227, 67);
            this.txtSubTotal.Name = "txtSubTotal";
            this.txtSubTotal.ReadOnly = true;
            this.txtSubTotal.Size = new System.Drawing.Size(129, 26);
            this.txtSubTotal.TabIndex = 577;
            this.txtSubTotal.TabStop = false;
            this.txtSubTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnIncluirProduto
            // 
            this.btnIncluirProduto.BackColor = System.Drawing.Color.AntiqueWhite;
            this.btnIncluirProduto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnIncluirProduto.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(182)))));
            this.btnIncluirProduto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Moccasin;
            this.btnIncluirProduto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue;
            this.btnIncluirProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIncluirProduto.Image = global::Money.Properties.Resources.Incluir;
            this.btnIncluirProduto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIncluirProduto.Location = new System.Drawing.Point(67, 18);
            this.btnIncluirProduto.Name = "btnIncluirProduto";
            this.btnIncluirProduto.Size = new System.Drawing.Size(200, 50);
            this.btnIncluirProduto.TabIndex = 578;
            this.btnIncluirProduto.Text = "&Incluir Produto";
            this.btnIncluirProduto.UseVisualStyleBackColor = false;
            this.btnIncluirProduto.Click += new System.EventHandler(this.btnIncluirProduto_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.BackColor = System.Drawing.Color.AntiqueWhite;
            this.btnFechar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnFechar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(182)))));
            this.btnFechar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Moccasin;
            this.btnFechar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.Image = global::Money.Properties.Resources.sair;
            this.btnFechar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFechar.Location = new System.Drawing.Point(285, 139);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(200, 50);
            this.btnFechar.TabIndex = 571;
            this.btnFechar.Text = "&Sair";
            this.btnFechar.UseVisualStyleBackColor = false;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox2.Controls.Add(this.btnSalvar);
            this.groupBox2.Controls.Add(this.btnImprimirPedido);
            this.groupBox2.Controls.Add(this.btnIncluirProduto);
            this.groupBox2.Controls.Add(this.btnAlterarProduto);
            this.groupBox2.Controls.Add(this.btnExcluirProduto);
            this.groupBox2.Controls.Add(this.btnFechar);
            this.groupBox2.Location = new System.Drawing.Point(17, 325);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(539, 198);
            this.groupBox2.TabIndex = 587;
            this.groupBox2.TabStop = false;
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.AntiqueWhite;
            this.btnSalvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSalvar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(182)))));
            this.btnSalvar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Moccasin;
            this.btnSalvar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Image = global::Money.Properties.Resources.salve_;
            this.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalvar.Location = new System.Drawing.Point(285, 19);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(200, 50);
            this.btnSalvar.TabIndex = 583;
            this.btnSalvar.Text = "&Salvar Pedido";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnImprimirPedido
            // 
            this.btnImprimirPedido.BackColor = System.Drawing.Color.AntiqueWhite;
            this.btnImprimirPedido.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnImprimirPedido.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(182)))));
            this.btnImprimirPedido.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Moccasin;
            this.btnImprimirPedido.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue;
            this.btnImprimirPedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImprimirPedido.Image = global::Money.Properties.Resources.Imprimir;
            this.btnImprimirPedido.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnImprimirPedido.Location = new System.Drawing.Point(285, 79);
            this.btnImprimirPedido.Name = "btnImprimirPedido";
            this.btnImprimirPedido.Size = new System.Drawing.Size(200, 50);
            this.btnImprimirPedido.TabIndex = 582;
            this.btnImprimirPedido.Text = "&Imprimir Pedido";
            this.btnImprimirPedido.UseVisualStyleBackColor = false;
            this.btnImprimirPedido.Click += new System.EventHandler(this.btnImprimirPedido_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox1.Controls.Add(this.txtTotal);
            this.groupBox1.Controls.Add(this.txtSubTotal);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtQtdItens);
            this.groupBox1.Controls.Add(this.txtDesconto);
            this.groupBox1.Location = new System.Drawing.Point(562, 325);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(374, 198);
            this.groupBox1.TabIndex = 588;
            this.groupBox1.TabStop = false;
            // 
            // FrmPedidoDeVendas
            // 
            this.ClientSize = new System.Drawing.Size(954, 545);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.dataGridVendas);
            this.Controls.Add(this.groupBox3);
            this.Name = "FrmPedidoDeVendas";
            this.Load += new System.EventHandler(this.FrmPedidoDeVendas_Load);
            this.Controls.SetChildIndex(this.panel5, 0);
            this.Controls.SetChildIndex(this.panel4, 0);
            this.Controls.SetChildIndex(this.panel3, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.Controls.SetChildIndex(this.groupBox3, 0);
            this.Controls.SetChildIndex(this.dataGridVendas, 0);
            this.Controls.SetChildIndex(this.groupBox4, 0);
            this.Controls.SetChildIndex(this.groupBox2, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridVendas)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox txtDesconto;
        public System.Windows.Forms.TextBox txtQtdItens;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnLocalizarCliente;
        public System.Windows.Forms.TextBox txtNomeCliente;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnExcluirProduto;
        private System.Windows.Forms.DataGridView dataGridVendas;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_itensvenda;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome_produto;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtd_produto;
        private System.Windows.Forms.DataGridViewTextBoxColumn valor_parcela;
        private System.Windows.Forms.DataGridViewTextBoxColumn total;
        private System.Windows.Forms.DataGridViewTextBoxColumn dt_vcto_parcela;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_produto;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_venda;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_parcela;
        private System.Windows.Forms.DataGridViewTextBoxColumn valor_produto;
        private System.Windows.Forms.DataGridViewTextBoxColumn num_parcela;
        private System.Windows.Forms.DataGridViewTextBoxColumn status_conta;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_contasreceber;
        private System.Windows.Forms.Button btnAlterarProduto;
        private System.Windows.Forms.GroupBox groupBox3;
        public System.Windows.Forms.DateTimePicker dtDataVenda;
        public System.Windows.Forms.TextBox txtIdVenda;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.TextBox txtSubTotal;
        private System.Windows.Forms.Button btnIncluirProduto;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnImprimirPedido;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}
