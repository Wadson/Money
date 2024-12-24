namespace Money
{
    partial class FormAgrupadoCentroCusto
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.datagridAgrupadoCentroCusto = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.datagridAgrupadoCentroCusto)).BeginInit();
            this.SuspendLayout();
            // 
            // datagridAgrupadoCentroCusto
            // 
            this.datagridAgrupadoCentroCusto.AllowUserToAddRows = false;
            this.datagridAgrupadoCentroCusto.AllowUserToDeleteRows = false;
            this.datagridAgrupadoCentroCusto.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.datagridAgrupadoCentroCusto.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.datagridAgrupadoCentroCusto.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.datagridAgrupadoCentroCusto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.datagridAgrupadoCentroCusto.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagridAgrupadoCentroCusto.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.datagridAgrupadoCentroCusto.ColumnHeadersHeight = 25;
            this.datagridAgrupadoCentroCusto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.datagridAgrupadoCentroCusto.DefaultCellStyle = dataGridViewCellStyle5;
            this.datagridAgrupadoCentroCusto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.datagridAgrupadoCentroCusto.EnableHeadersVisualStyles = false;
            this.datagridAgrupadoCentroCusto.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.datagridAgrupadoCentroCusto.Location = new System.Drawing.Point(0, 0);
            this.datagridAgrupadoCentroCusto.Name = "datagridAgrupadoCentroCusto";
            this.datagridAgrupadoCentroCusto.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.PowderBlue;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagridAgrupadoCentroCusto.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.datagridAgrupadoCentroCusto.RowHeadersWidth = 20;
            this.datagridAgrupadoCentroCusto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagridAgrupadoCentroCusto.Size = new System.Drawing.Size(673, 542);
            this.datagridAgrupadoCentroCusto.TabIndex = 14;
            this.datagridAgrupadoCentroCusto.TabStop = false;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "centrocusto";
            this.Column1.HeaderText = "CENTRO DE CUSTO";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 350;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "QTD_PARCELAS";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.Column2.DefaultCellStyle = dataGridViewCellStyle3;
            this.Column2.HeaderText = "QTD. PARCELAS";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 120;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "VALOR_TOTAL";
            dataGridViewCellStyle4.Format = "N";
            dataGridViewCellStyle4.NullValue = null;
            this.Column3.DefaultCellStyle = dataGridViewCellStyle4;
            this.Column3.HeaderText = "VALOR TOTAL";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 150;
            // 
            // FormAgrupadoCentroCusto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 542);
            this.Controls.Add(this.datagridAgrupadoCentroCusto);
            this.Name = "FormAgrupadoCentroCusto";
            this.Text = "FormAgrupadoCentroCusto";
            this.Load += new System.EventHandler(this.FormAgrupadoCentroCusto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datagridAgrupadoCentroCusto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView datagridAgrupadoCentroCusto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}