namespace Money
{
    partial class frmPesquisaContatosLista
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
            this.dataGridAgenda = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAgenda)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.TextChanged += new System.EventHandler(this.txtPesquisa_TextChanged);
            // 
            // dataGridAgenda
            // 
            this.dataGridAgenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridAgenda.Location = new System.Drawing.Point(5, 66);
            this.dataGridAgenda.Name = "dataGridAgenda";
            this.dataGridAgenda.Size = new System.Drawing.Size(529, 336);
            this.dataGridAgenda.TabIndex = 29;
            this.dataGridAgenda.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridAgenda_CellClick);
            this.dataGridAgenda.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridAgenda_CellDoubleClick);
            this.dataGridAgenda.SelectionChanged += new System.EventHandler(this.dataGridAgenda_SelectionChanged);
            // 
            // frmPesquisaContatosLista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(542, 456);
            this.Controls.Add(this.dataGridAgenda);
            this.Name = "frmPesquisaContatosLista";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPesquisaContatosLista_FormClosing);
            this.Load += new System.EventHandler(this.frmPesquisaContatosLista_Load);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.txtPesquisa, 0);
            this.Controls.SetChildIndex(this.btnOK, 0);
            this.Controls.SetChildIndex(this.btnFechar, 0);
            this.Controls.SetChildIndex(this.dataGridAgenda, 0);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAgenda)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridAgenda;
    }
}
