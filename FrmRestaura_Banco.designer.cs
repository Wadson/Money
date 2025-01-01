namespace Money
{
    partial class FrmRestaura_Banco
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
            this.btn_caminho_origem = new System.Windows.Forms.Button();
            this.btn_inicia_copia = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_origem = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Location = new System.Drawing.Point(2, 205);
            this.panel2.Size = new System.Drawing.Size(459, 2);
            // 
            // panel3
            // 
            this.panel3.Size = new System.Drawing.Size(459, 25);
            // 
            // panel4
            // 
            this.panel4.Size = new System.Drawing.Size(2, 207);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.Control;
            this.panel5.Location = new System.Drawing.Point(461, 0);
            this.panel5.Size = new System.Drawing.Size(2, 207);
            // 
            // btnExit
            // 
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.Location = new System.Drawing.Point(355, 2);
            // 
            // btn_caminho_origem
            // 
            this.btn_caminho_origem.BackColor = System.Drawing.Color.Transparent;
            this.btn_caminho_origem.BackgroundImage = global::Money.Properties.Resources.pasta;
            this.btn_caminho_origem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_caminho_origem.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btn_caminho_origem.FlatAppearance.BorderSize = 0;
            this.btn_caminho_origem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_caminho_origem.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_caminho_origem.Location = new System.Drawing.Point(308, 65);
            this.btn_caminho_origem.Name = "btn_caminho_origem";
            this.btn_caminho_origem.Size = new System.Drawing.Size(25, 25);
            this.btn_caminho_origem.TabIndex = 23;
            this.btn_caminho_origem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_caminho_origem.UseVisualStyleBackColor = false;
            this.btn_caminho_origem.Click += new System.EventHandler(this.btn_caminho_origem_Click);
            // 
            // btn_inicia_copia
            // 
            this.btn_inicia_copia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(182)))));
            this.btn_inicia_copia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_inicia_copia.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_inicia_copia.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_inicia_copia.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_inicia_copia.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(80)))));
            this.btn_inicia_copia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_inicia_copia.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_inicia_copia.Location = new System.Drawing.Point(184, 123);
            this.btn_inicia_copia.Name = "btn_inicia_copia";
            this.btn_inicia_copia.Size = new System.Drawing.Size(120, 35);
            this.btn_inicia_copia.TabIndex = 21;
            this.btn_inicia_copia.Text = "&OK";
            this.btn_inicia_copia.UseVisualStyleBackColor = false;
            this.btn_inicia_copia.Click += new System.EventHandler(this.btn_inicia_copia_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(76)))), ((int)(((byte)(172)))));
            this.label2.Location = new System.Drawing.Point(6, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 16);
            this.label2.TabIndex = 20;
            this.label2.Text = "Origem:";
            // 
            // txt_origem
            // 
            this.txt_origem.ForeColor = System.Drawing.Color.Blue;
            this.txt_origem.Location = new System.Drawing.Point(72, 62);
            this.txt_origem.Multiline = true;
            this.txt_origem.Name = "txt_origem";
            this.txt_origem.Size = new System.Drawing.Size(232, 41);
            this.txt_origem.TabIndex = 18;
            // 
            // FrmRestaura_Banco
            // 
            this.ClientSize = new System.Drawing.Size(463, 207);
            this.Controls.Add(this.btn_caminho_origem);
            this.Controls.Add(this.btn_inicia_copia);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_origem);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmRestaura_Banco";
            this.Text = "Restaurar Banco de dados";
            this.Load += new System.EventHandler(this.Frm_Restaura_Banco_Load);
            this.Controls.SetChildIndex(this.txt_origem, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.btn_inicia_copia, 0);
            this.Controls.SetChildIndex(this.btn_caminho_origem, 0);
            this.Controls.SetChildIndex(this.panel5, 0);
            this.Controls.SetChildIndex(this.panel4, 0);
            this.Controls.SetChildIndex(this.panel3, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button btn_caminho_origem;
        public System.Windows.Forms.Button btn_inicia_copia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_origem;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}
