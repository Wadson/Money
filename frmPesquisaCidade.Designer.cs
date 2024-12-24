namespace Money
{
    partial class frmPesquisaCidade
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
            this.dataGridCidade = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCidade)).BeginInit();
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
            // dataGridCidade
            // 
            this.dataGridCidade.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridCidade.Location = new System.Drawing.Point(5, 66);
            this.dataGridCidade.Name = "dataGridCidade";
            this.dataGridCidade.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridCidade.Size = new System.Drawing.Size(525, 336);
            this.dataGridCidade.TabIndex = 29;
            this.dataGridCidade.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridCidade_CellClick);
            this.dataGridCidade.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridCidade_CellDoubleClick);
            this.dataGridCidade.SelectionChanged += new System.EventHandler(this.dataGridCidade_SelectionChanged);
            // 
            // frmPesquisaCidade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(542, 456);
            this.Controls.Add(this.dataGridCidade);
            this.Name = "frmPesquisaCidade";
            this.Text = "Money -Localizar Cidade";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPesquisaCidade_FormClosing);
            this.Load += new System.EventHandler(this.frmPesquisaCidade_Load);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.txtPesquisa, 0);
            this.Controls.SetChildIndex(this.btnOK, 0);
            this.Controls.SetChildIndex(this.btnFechar, 0);
            this.Controls.SetChildIndex(this.dataGridCidade, 0);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCidade)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridCidade;
    }
}
