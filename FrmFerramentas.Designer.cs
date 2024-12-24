namespace Money
{
    partial class FrmFerramentas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnCriarBD = new System.Windows.Forms.Button();
            this.btnApagarBanco = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.btnCarregarTabelas = new System.Windows.Forms.Button();
            this.dgvDados = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(2, 265);
            this.panel2.Size = new System.Drawing.Size(413, 2);
            // 
            // panel3
            // 
            this.panel3.Size = new System.Drawing.Size(413, 25);
            // 
            // panel4
            // 
            this.panel4.Size = new System.Drawing.Size(2, 267);
            // 
            // panel5
            // 
            this.panel5.Location = new System.Drawing.Point(415, 0);
            this.panel5.Size = new System.Drawing.Size(2, 267);
            // 
            // btnExit
            // 
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.Location = new System.Drawing.Point(380, 2);
            // 
            // btnCriarBD
            // 
            this.btnCriarBD.BackColor = System.Drawing.Color.Green;
            this.btnCriarBD.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCriarBD.Enabled = false;
            this.btnCriarBD.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnCriarBD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCriarBD.Font = new System.Drawing.Font("Century Gothic", 9.25F);
            this.btnCriarBD.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnCriarBD.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCriarBD.Location = new System.Drawing.Point(140, 234);
            this.btnCriarBD.Name = "btnCriarBD";
            this.btnCriarBD.Size = new System.Drawing.Size(137, 30);
            this.btnCriarBD.TabIndex = 5;
            this.btnCriarBD.Text = "Criar banco";
            this.btnCriarBD.UseVisualStyleBackColor = false;
            this.btnCriarBD.Click += new System.EventHandler(this.btnCriarBD_Click);
            // 
            // btnApagarBanco
            // 
            this.btnApagarBanco.BackColor = System.Drawing.Color.Red;
            this.btnApagarBanco.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnApagarBanco.Enabled = false;
            this.btnApagarBanco.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnApagarBanco.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApagarBanco.Font = new System.Drawing.Font("Century Gothic", 9.25F);
            this.btnApagarBanco.ForeColor = System.Drawing.Color.White;
            this.btnApagarBanco.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnApagarBanco.Location = new System.Drawing.Point(277, 234);
            this.btnApagarBanco.Name = "btnApagarBanco";
            this.btnApagarBanco.Size = new System.Drawing.Size(137, 30);
            this.btnApagarBanco.TabIndex = 9;
            this.btnApagarBanco.Text = "Excluir banco";
            this.btnApagarBanco.UseVisualStyleBackColor = false;
            this.btnApagarBanco.Click += new System.EventHandler(this.btnApagarBanco_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(10, 4);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(0, 16);
            this.lblResultado.TabIndex = 12;
            // 
            // btnCarregarTabelas
            // 
            this.btnCarregarTabelas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(182)))));
            this.btnCarregarTabelas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCarregarTabelas.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnCarregarTabelas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCarregarTabelas.Font = new System.Drawing.Font("Century Gothic", 9.25F);
            this.btnCarregarTabelas.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnCarregarTabelas.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCarregarTabelas.Location = new System.Drawing.Point(3, 234);
            this.btnCarregarTabelas.Name = "btnCarregarTabelas";
            this.btnCarregarTabelas.Size = new System.Drawing.Size(137, 30);
            this.btnCarregarTabelas.TabIndex = 13;
            this.btnCarregarTabelas.Text = "Carregar tabelas";
            this.btnCarregarTabelas.UseVisualStyleBackColor = false;
            this.btnCarregarTabelas.Click += new System.EventHandler(this.btnCarregarTabelas_Click);
            // 
            // dgvDados
            // 
            this.dgvDados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvDados.BackgroundColor = System.Drawing.Color.White;
            this.dgvDados.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDados.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvDados.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(51)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDados.ColumnHeadersHeight = 20;
            this.dgvDados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(76)))), ((int)(((byte)(172)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDados.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDados.EnableHeadersVisualStyles = false;
            this.dgvDados.GridColor = System.Drawing.Color.White;
            this.dgvDados.Location = new System.Drawing.Point(2, 25);
            this.dgvDados.Name = "dgvDados";
            this.dgvDados.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(51)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.PaleVioletRed;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDados.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvDados.RowHeadersWidth = 20;
            this.dgvDados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDados.Size = new System.Drawing.Size(413, 208);
            this.dgvDados.TabIndex = 427;
            // 
            // ID
            // 
            this.ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ID.DataPropertyName = "TABLE_NAME";
            dataGridViewCellStyle2.Format = "000";
            this.ID.DefaultCellStyle = dataGridViewCellStyle2;
            this.ID.HeaderText = "TABELA";
            this.ID.Name = "ID";
            // 
            // FrmFerramentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 267);
            this.Controls.Add(this.dgvDados);
            this.Controls.Add(this.btnCarregarTabelas);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.btnApagarBanco);
            this.Controls.Add(this.btnCriarBD);
            this.Name = "FrmFerramentas";
            this.Text = "Ferramentas";
            this.Load += new System.EventHandler(this.Frm_Ferramentas_Load);
            this.Controls.SetChildIndex(this.btnCriarBD, 0);
            this.Controls.SetChildIndex(this.btnApagarBanco, 0);
            this.Controls.SetChildIndex(this.lblResultado, 0);
            this.Controls.SetChildIndex(this.btnCarregarTabelas, 0);
            this.Controls.SetChildIndex(this.dgvDados, 0);
            this.Controls.SetChildIndex(this.panel5, 0);
            this.Controls.SetChildIndex(this.panel4, 0);
            this.Controls.SetChildIndex(this.panel3, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCriarBD;
        private System.Windows.Forms.Button btnApagarBanco;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Button btnCarregarTabelas;
        public System.Windows.Forms.DataGridView dgvDados;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
    }
}