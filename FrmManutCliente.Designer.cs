﻿namespace Money
{
    partial class FrmManutCliente
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridPesquisa = new System.Windows.Forms.DataGridView();
            this.id_cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome_cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtcadastro_cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fone_cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endereco_cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bairro_cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cidade_cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado_cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPesquisa)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExcluir
            // 
            this.btnExcluir.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(182)))));
            this.btnExcluir.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnExcluir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnExcluir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(182)))));
            this.btnExcluir.Location = new System.Drawing.Point(713, 187);
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(182)))));
            this.btnNovo.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnNovo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnNovo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(182)))));
            this.btnNovo.Location = new System.Drawing.Point(713, 68);
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(182)))));
            this.btnAlterar.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnAlterar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnAlterar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(182)))));
            this.btnAlterar.Location = new System.Drawing.Point(713, 129);
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Location = new System.Drawing.Point(176, 39);
            this.txtPesquisa.Size = new System.Drawing.Size(531, 21);
            this.txtPesquisa.TextChanged += new System.EventHandler(this.txtPesquisa_TextChanged);
            // 
            // btnSair
            // 
            this.btnSair.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(182)))));
            this.btnSair.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnSair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnSair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(182)))));
            this.btnSair.Location = new System.Drawing.Point(713, 396);
            // 
            // dataGridPesquisa
            // 
            this.dataGridPesquisa.AllowUserToAddRows = false;
            this.dataGridPesquisa.AllowUserToDeleteRows = false;
            this.dataGridPesquisa.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridPesquisa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridPesquisa.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(68)))), ((int)(((byte)(96)))));
            this.dataGridPesquisa.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridPesquisa.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridPesquisa.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(51)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridPesquisa.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridPesquisa.ColumnHeadersHeight = 30;
            this.dataGridPesquisa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_cliente,
            this.nome_cliente,
            this.dtcadastro_cliente,
            this.fone_cliente,
            this.endereco_cliente,
            this.bairro_cliente,
            this.cidade_cliente,
            this.estado_cliente});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(68)))), ((int)(((byte)(96)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridPesquisa.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridPesquisa.EnableHeadersVisualStyles = false;
            this.dataGridPesquisa.GridColor = System.Drawing.Color.SteelBlue;
            this.dataGridPesquisa.Location = new System.Drawing.Point(12, 68);
            this.dataGridPesquisa.Name = "dataGridPesquisa";
            this.dataGridPesquisa.ReadOnly = true;
            this.dataGridPesquisa.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(51)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.PaleVioletRed;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridPesquisa.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridPesquisa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridPesquisa.Size = new System.Drawing.Size(695, 366);
            this.dataGridPesquisa.TabIndex = 422;
            // 
            // id_cliente
            // 
            this.id_cliente.DataPropertyName = "id_cliente";
            this.id_cliente.DividerWidth = 1;
            this.id_cliente.HeaderText = "Código";
            this.id_cliente.Name = "id_cliente";
            this.id_cliente.ReadOnly = true;
            this.id_cliente.Visible = false;
            this.id_cliente.Width = 73;
            // 
            // nome_cliente
            // 
            this.nome_cliente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.nome_cliente.DataPropertyName = "nome_cliente";
            this.nome_cliente.DividerWidth = 1;
            this.nome_cliente.HeaderText = "Cliente";
            this.nome_cliente.Name = "nome_cliente";
            this.nome_cliente.ReadOnly = true;
            this.nome_cliente.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.nome_cliente.Width = 200;
            // 
            // dtcadastro_cliente
            // 
            this.dtcadastro_cliente.DataPropertyName = "dtcadastro_cliente";
            this.dtcadastro_cliente.DividerWidth = 1;
            this.dtcadastro_cliente.HeaderText = "Data Cad";
            this.dtcadastro_cliente.Name = "dtcadastro_cliente";
            this.dtcadastro_cliente.ReadOnly = true;
            this.dtcadastro_cliente.Visible = false;
            this.dtcadastro_cliente.Width = 89;
            // 
            // fone_cliente
            // 
            this.fone_cliente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.fone_cliente.DataPropertyName = "fone_cliente";
            this.fone_cliente.DividerWidth = 1;
            this.fone_cliente.HeaderText = "Telefone";
            this.fone_cliente.Name = "fone_cliente";
            this.fone_cliente.ReadOnly = true;
            this.fone_cliente.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // endereco_cliente
            // 
            this.endereco_cliente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.endereco_cliente.DataPropertyName = "endereco_cliente";
            this.endereco_cliente.DividerWidth = 1;
            this.endereco_cliente.HeaderText = "Endereço";
            this.endereco_cliente.Name = "endereco_cliente";
            this.endereco_cliente.ReadOnly = true;
            this.endereco_cliente.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.endereco_cliente.Width = 200;
            // 
            // bairro_cliente
            // 
            this.bairro_cliente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.bairro_cliente.DataPropertyName = "bairro_cliente";
            this.bairro_cliente.DividerWidth = 1;
            this.bairro_cliente.HeaderText = "Bairro";
            this.bairro_cliente.Name = "bairro_cliente";
            this.bairro_cliente.ReadOnly = true;
            this.bairro_cliente.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.bairro_cliente.Width = 200;
            // 
            // cidade_cliente
            // 
            this.cidade_cliente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.cidade_cliente.DataPropertyName = "cidade_cliente";
            this.cidade_cliente.DividerWidth = 1;
            this.cidade_cliente.HeaderText = "Cidade";
            this.cidade_cliente.Name = "cidade_cliente";
            this.cidade_cliente.ReadOnly = true;
            this.cidade_cliente.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.cidade_cliente.Width = 200;
            // 
            // estado_cliente
            // 
            this.estado_cliente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.estado_cliente.DataPropertyName = "estado_cliente";
            this.estado_cliente.DividerWidth = 1;
            this.estado_cliente.HeaderText = "Estado";
            this.estado_cliente.Name = "estado_cliente";
            this.estado_cliente.ReadOnly = true;
            this.estado_cliente.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.estado_cliente.Width = 80;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(16, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 20);
            this.label1.TabIndex = 423;
            this.label1.Text = "Localizar Clientes";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(304, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(221, 20);
            this.label2.TabIndex = 424;
            this.label2.Text = "----Manutenção de Clientes----";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FrmManutCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.ClientSize = new System.Drawing.Size(833, 446);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridPesquisa);
            this.Name = "FrmManutCliente";
            this.Load += new System.EventHandler(this.FrmManutCliente_Load);
            this.Controls.SetChildIndex(this.btnAlterar, 0);
            this.Controls.SetChildIndex(this.btnNovo, 0);
            this.Controls.SetChildIndex(this.btnExcluir, 0);
            this.Controls.SetChildIndex(this.txtPesquisa, 0);
            this.Controls.SetChildIndex(this.btnSair, 0);
            this.Controls.SetChildIndex(this.dataGridPesquisa, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPesquisa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridPesquisa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome_cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtcadastro_cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn fone_cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn endereco_cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn bairro_cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn cidade_cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado_cliente;
    }
}