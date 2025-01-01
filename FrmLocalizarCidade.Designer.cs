namespace Money
{
    partial class FrmLocalizarCidade
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridPesquisa2 = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Expr1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Expr2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPesquisa2)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.TextChanged += new System.EventHandler(this.txtPesquisa_TextChanged);
            // 
            // btnSair
            // 
            this.btnSair.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(182)))));
            this.btnSair.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnSair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(80)))));
            this.btnSair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(80)))));
            // 
            // dataGridPesquisa2
            // 
            this.dataGridPesquisa2.AllowUserToAddRows = false;
            this.dataGridPesquisa2.AllowUserToDeleteRows = false;
            this.dataGridPesquisa2.AllowUserToResizeColumns = false;
            this.dataGridPesquisa2.AllowUserToResizeRows = false;
            this.dataGridPesquisa2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridPesquisa2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridPesquisa2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridPesquisa2.BackgroundColor = System.Drawing.Color.White;
            this.dataGridPesquisa2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridPesquisa2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridPesquisa2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(76)))), ((int)(((byte)(172)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridPesquisa2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridPesquisa2.ColumnHeadersHeight = 20;
            this.dataGridPesquisa2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.nome,
            this.Expr1,
            this.Expr2});
            this.dataGridPesquisa2.EnableHeadersVisualStyles = false;
            this.dataGridPesquisa2.Location = new System.Drawing.Point(14, 82);
            this.dataGridPesquisa2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridPesquisa2.MultiSelect = false;
            this.dataGridPesquisa2.Name = "dataGridPesquisa2";
            this.dataGridPesquisa2.ReadOnly = true;
            this.dataGridPesquisa2.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridPesquisa2.RowHeadersVisible = false;
            this.dataGridPesquisa2.RowHeadersWidth = 20;
            this.dataGridPesquisa2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridPesquisa2.Size = new System.Drawing.Size(504, 203);
            this.dataGridPesquisa2.TabIndex = 425;
            // 
            // id
            // 
            this.id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.id.DataPropertyName = "id";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.id.DefaultCellStyle = dataGridViewCellStyle2;
            this.id.DividerWidth = 1;
            this.id.HeaderText = "Código";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.id.Width = 60;
            // 
            // nome
            // 
            this.nome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.nome.DataPropertyName = "nome";
            this.nome.DividerWidth = 1;
            this.nome.HeaderText = "Cidade";
            this.nome.Name = "nome";
            this.nome.ReadOnly = true;
            this.nome.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.nome.Width = 280;
            // 
            // Expr1
            // 
            this.Expr1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Expr1.DataPropertyName = "Expr1";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.Expr1.DefaultCellStyle = dataGridViewCellStyle3;
            this.Expr1.DividerWidth = 1;
            this.Expr1.HeaderText = "Estado";
            this.Expr1.Name = "Expr1";
            this.Expr1.ReadOnly = true;
            this.Expr1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Expr1.Width = 150;
            // 
            // Expr2
            // 
            this.Expr2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Expr2.DataPropertyName = "Expr2";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.Expr2.DefaultCellStyle = dataGridViewCellStyle4;
            this.Expr2.DividerWidth = 1;
            this.Expr2.HeaderText = "Cód. Estado";
            this.Expr2.Name = "Expr2";
            this.Expr2.ReadOnly = true;
            this.Expr2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Expr2.Width = 80;
            // 
            // FrmLocalizarCidade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.ClientSize = new System.Drawing.Size(533, 324);
            this.Controls.Add(this.dataGridPesquisa2);
            this.Name = "FrmLocalizarCidade";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmLocalizarCidade_FormClosing);
            this.Load += new System.EventHandler(this.FrmLocalizarCidade_Load);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.txtPesquisa, 0);
            this.Controls.SetChildIndex(this.btnSair, 0);
            this.Controls.SetChildIndex(this.panel5, 0);
            this.Controls.SetChildIndex(this.panel4, 0);
            this.Controls.SetChildIndex(this.panel3, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.Controls.SetChildIndex(this.dataGridPesquisa2, 0);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPesquisa2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView dataGridPesquisa2;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Expr1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Expr2;
    }
}
