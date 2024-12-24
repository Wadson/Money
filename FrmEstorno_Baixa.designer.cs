namespace Money
{
    partial class FrmEstorno_Baixa
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.datagrid_Pesquisa = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblFiltro = new System.Windows.Forms.Label();
            this.btn_EstornarLancamento = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lbl_Status_Null = new System.Windows.Forms.ToolStripStatusLabel();
            this.txt_Fornecedor = new System.Windows.Forms.TextBox();
            this.btnPesquiar = new System.Windows.Forms.Button();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_Pesquisa)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(2, 255);
            this.panel2.Size = new System.Drawing.Size(538, 2);
            // 
            // panel3
            // 
            this.panel3.Size = new System.Drawing.Size(538, 25);
            // 
            // panel4
            // 
            this.panel4.Size = new System.Drawing.Size(2, 257);
            // 
            // panel5
            // 
            this.panel5.Location = new System.Drawing.Point(540, 0);
            this.panel5.Size = new System.Drawing.Size(2, 257);
            // 
            // btnExit
            // 
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.Location = new System.Drawing.Point(504, 3);
            // 
            // datagrid_Pesquisa
            // 
            this.datagrid_Pesquisa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.datagrid_Pesquisa.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(68)))), ((int)(((byte)(96)))));
            this.datagrid_Pesquisa.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.datagrid_Pesquisa.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.datagrid_Pesquisa.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(51)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagrid_Pesquisa.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.datagrid_Pesquisa.ColumnHeadersHeight = 30;
            this.datagrid_Pesquisa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(68)))), ((int)(((byte)(96)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.datagrid_Pesquisa.DefaultCellStyle = dataGridViewCellStyle5;
            this.datagrid_Pesquisa.EnableHeadersVisualStyles = false;
            this.datagrid_Pesquisa.GridColor = System.Drawing.Color.SteelBlue;
            this.datagrid_Pesquisa.Location = new System.Drawing.Point(3, 61);
            this.datagrid_Pesquisa.Name = "datagrid_Pesquisa";
            this.datagrid_Pesquisa.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(51)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.PaleVioletRed;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagrid_Pesquisa.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.datagrid_Pesquisa.RowHeadersWidth = 20;
            this.datagrid_Pesquisa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagrid_Pesquisa.Size = new System.Drawing.Size(536, 191);
            this.datagrid_Pesquisa.TabIndex = 426;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "idconta";
            dataGridViewCellStyle2.Format = "000";
            this.ID.DefaultCellStyle = dataGridViewCellStyle2;
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.Visible = false;
            this.ID.Width = 44;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.DataPropertyName = "datacadastro";
            this.Column1.HeaderText = "CADASTRO";
            this.Column1.Name = "Column1";
            this.Column1.Visible = false;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.DataPropertyName = "fornecedor";
            this.Column2.HeaderText = "FORNECEDOR";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "descricao";
            this.Column3.HeaderText = "DESCRIÇÃO";
            this.Column3.Name = "Column3";
            this.Column3.Visible = false;
            this.Column3.Width = 101;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "num_parcela";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Column4.DefaultCellStyle = dataGridViewCellStyle3;
            this.Column4.HeaderText = "PARCELA";
            this.Column4.Name = "Column4";
            this.Column4.Width = 79;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "valor_parc";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Format = "N";
            this.Column5.DefaultCellStyle = dataGridViewCellStyle4;
            this.Column5.HeaderText = "VALOR";
            this.Column5.Name = "Column5";
            this.Column5.Width = 67;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "datavenc";
            this.Column6.HeaderText = "VENCTO";
            this.Column6.Name = "Column6";
            this.Column6.Width = 76;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "datapgto";
            this.Column7.HeaderText = "PAGAMENTO";
            this.Column7.Name = "Column7";
            this.Column7.Visible = false;
            this.Column7.Width = 107;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "idparcela";
            this.Column8.HeaderText = "ID PARC";
            this.Column8.Name = "Column8";
            this.Column8.Visible = false;
            this.Column8.Width = 79;
            // 
            // lblFiltro
            // 
            this.lblFiltro.AutoSize = true;
            this.lblFiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltro.ForeColor = System.Drawing.Color.Black;
            this.lblFiltro.Location = new System.Drawing.Point(4, 39);
            this.lblFiltro.Name = "lblFiltro";
            this.lblFiltro.Size = new System.Drawing.Size(61, 13);
            this.lblFiltro.TabIndex = 241;
            this.lblFiltro.Text = "Fornecedor";
            // 
            // btn_EstornarLancamento
            // 
            this.btn_EstornarLancamento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(182)))));
            this.btn_EstornarLancamento.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_EstornarLancamento.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_EstornarLancamento.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_EstornarLancamento.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btn_EstornarLancamento.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_EstornarLancamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_EstornarLancamento.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_EstornarLancamento.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_EstornarLancamento.Location = new System.Drawing.Point(441, 33);
            this.btn_EstornarLancamento.Name = "btn_EstornarLancamento";
            this.btn_EstornarLancamento.Size = new System.Drawing.Size(96, 25);
            this.btn_EstornarLancamento.TabIndex = 273;
            this.btn_EstornarLancamento.Text = "&Estornar";
            this.btn_EstornarLancamento.UseVisualStyleBackColor = false;
            this.btn_EstornarLancamento.Click += new System.EventHandler(this.btn_EstornarLancamento_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lbl_Status_Null});
            this.statusStrip1.Location = new System.Drawing.Point(0, 257);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(542, 22);
            this.statusStrip1.TabIndex = 274;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lbl_Status_Null
            // 
            this.lbl_Status_Null.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_Status_Null.Name = "lbl_Status_Null";
            this.lbl_Status_Null.Size = new System.Drawing.Size(19, 17);
            this.lbl_Status_Null.Text = "    ";
            // 
            // txt_Fornecedor
            // 
            this.txt_Fornecedor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_Fornecedor.ForeColor = System.Drawing.Color.Black;
            this.txt_Fornecedor.Location = new System.Drawing.Point(67, 35);
            this.txt_Fornecedor.Name = "txt_Fornecedor";
            this.txt_Fornecedor.Size = new System.Drawing.Size(329, 21);
            this.txt_Fornecedor.TabIndex = 0;
            this.txt_Fornecedor.TextChanged += new System.EventHandler(this.txt_fornecedor_TextChanged);
            this.txt_Fornecedor.Enter += new System.EventHandler(this.txt_fornecedor_Enter);
            this.txt_Fornecedor.Leave += new System.EventHandler(this.txt_fornecedor_Leave);
            // 
            // btnPesquiar
            // 
            this.btnPesquiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(182)))));
            this.btnPesquiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPesquiar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnPesquiar.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnPesquiar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnPesquiar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnPesquiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquiar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnPesquiar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPesquiar.Location = new System.Drawing.Point(402, 33);
            this.btnPesquiar.Name = "btnPesquiar";
            this.btnPesquiar.Size = new System.Drawing.Size(39, 25);
            this.btnPesquiar.TabIndex = 427;
            this.btnPesquiar.Text = "...";
            this.btnPesquiar.UseVisualStyleBackColor = false;
            this.btnPesquiar.Click += new System.EventHandler(this.btnPesquiar_Click);
            // 
            // FrmEstorno_Baixa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(542, 279);
            this.Controls.Add(this.btnPesquiar);
            this.Controls.Add(this.datagrid_Pesquisa);
            this.Controls.Add(this.lblFiltro);
            this.Controls.Add(this.btn_EstornarLancamento);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.txt_Fornecedor);
            this.Name = "FrmEstorno_Baixa";
            this.Text = "Estorno de baixas";
            this.Load += new System.EventHandler(this.frmManutencao_Dois_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmManutencao_Dois_KeyPress);
            this.Controls.SetChildIndex(this.txt_Fornecedor, 0);
            this.Controls.SetChildIndex(this.statusStrip1, 0);
            this.Controls.SetChildIndex(this.btn_EstornarLancamento, 0);
            this.Controls.SetChildIndex(this.lblFiltro, 0);
            this.Controls.SetChildIndex(this.datagrid_Pesquisa, 0);
            this.Controls.SetChildIndex(this.btnPesquiar, 0);
            this.Controls.SetChildIndex(this.panel5, 0);
            this.Controls.SetChildIndex(this.panel4, 0);
            this.Controls.SetChildIndex(this.panel3, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_Pesquisa)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Fornecedor;
        public System.Windows.Forms.Button btn_EstornarLancamento;
        private System.Windows.Forms.Label lblFiltro;
        private System.Windows.Forms.ToolStripStatusLabel lbl_Status_Null;
        private System.Windows.Forms.StatusStrip statusStrip1;
        public System.Windows.Forms.DataGridView datagrid_Pesquisa;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        public System.Windows.Forms.Button btnPesquiar;
    }
}