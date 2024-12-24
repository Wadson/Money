namespace Money
{
    partial class TexBoxMoeda
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtValorMoeda = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtValorMoeda
            // 
            this.txtValorMoeda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorMoeda.ForeColor = System.Drawing.Color.Red;
            this.txtValorMoeda.Location = new System.Drawing.Point(2, 2);
            this.txtValorMoeda.Name = "txtValorMoeda";
            this.txtValorMoeda.Size = new System.Drawing.Size(113, 22);
            this.txtValorMoeda.TabIndex = 0;
            this.txtValorMoeda.TextChanged += new System.EventHandler(this.txtValorMoeda_TextChanged);
            this.txtValorMoeda.Enter += new System.EventHandler(this.txtValorMoeda_Enter);
            this.txtValorMoeda.Leave += new System.EventHandler(this.txtValorMoeda_Leave);
            // 
            // TexBoxMoeda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtValorMoeda);
            this.Name = "TexBoxMoeda";
            this.Size = new System.Drawing.Size(116, 26);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox txtValorMoeda;

    }
}
