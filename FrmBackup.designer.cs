namespace Money
{
    partial class FrmBackup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBackup));
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.txt_destino = new System.Windows.Forms.TextBox();
            this.txt_origem = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_ver_pastas = new System.Windows.Forms.Button();
            this.btn_inicia_copia = new System.Windows.Forms.Button();
            this.btn_caminho_destino = new System.Windows.Forms.Button();
            this.btn_caminho_origem = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
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
            this.panel5.Location = new System.Drawing.Point(461, 0);
            this.panel5.Size = new System.Drawing.Size(2, 207);
            // 
            // btnExit
            // 
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.Location = new System.Drawing.Point(425, 3);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileName = "bdfinance.db";
            this.saveFileDialog1.Filter = "\"Backup System Transf (*.db)|*.db|All files (*.*)|*.*\"";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "bkp";
            this.openFileDialog1.FileName = "bdfinance.db";
            this.openFileDialog1.Filter = "\"Backup System Transf (*.db)|*.db|All files (*.*)|*.*\"";
            // 
            // txt_destino
            // 
            this.txt_destino.ForeColor = System.Drawing.Color.Red;
            this.txt_destino.Location = new System.Drawing.Point(57, 76);
            this.txt_destino.Multiline = true;
            this.txt_destino.Name = "txt_destino";
            this.txt_destino.Size = new System.Drawing.Size(211, 20);
            this.txt_destino.TabIndex = 4;
            // 
            // txt_origem
            // 
            this.txt_origem.ForeColor = System.Drawing.Color.Blue;
            this.txt_origem.Location = new System.Drawing.Point(57, 56);
            this.txt_origem.Multiline = true;
            this.txt_origem.Name = "txt_origem";
            this.txt_origem.Size = new System.Drawing.Size(211, 20);
            this.txt_origem.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(76)))), ((int)(((byte)(172)))));
            this.label1.Location = new System.Drawing.Point(6, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Destino:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(76)))), ((int)(((byte)(172)))));
            this.label2.Location = new System.Drawing.Point(6, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Origem:";
            // 
            // btn_ver_pastas
            // 
            this.btn_ver_pastas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(182)))));
            this.btn_ver_pastas.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_ver_pastas.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_ver_pastas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_ver_pastas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(80)))));
            this.btn_ver_pastas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ver_pastas.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_ver_pastas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ver_pastas.Location = new System.Drawing.Point(184, 131);
            this.btn_ver_pastas.Name = "btn_ver_pastas";
            this.btn_ver_pastas.Size = new System.Drawing.Size(120, 35);
            this.btn_ver_pastas.TabIndex = 9;
            this.btn_ver_pastas.Text = "      Ver pastas";
            this.btn_ver_pastas.UseVisualStyleBackColor = false;
            this.btn_ver_pastas.Click += new System.EventHandler(this.btn_ver_pastas_Click);
            // 
            // btn_inicia_copia
            // 
            this.btn_inicia_copia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(182)))));
            this.btn_inicia_copia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_inicia_copia.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_inicia_copia.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_inicia_copia.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_inicia_copia.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(80)))));
            this.btn_inicia_copia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_inicia_copia.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_inicia_copia.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_inicia_copia.Location = new System.Drawing.Point(57, 131);
            this.btn_inicia_copia.Name = "btn_inicia_copia";
            this.btn_inicia_copia.Size = new System.Drawing.Size(120, 35);
            this.btn_inicia_copia.TabIndex = 8;
            this.btn_inicia_copia.Text = "&OK";
            this.btn_inicia_copia.UseVisualStyleBackColor = false;
            this.btn_inicia_copia.Click += new System.EventHandler(this.btn_inicia_copia_Click);
            // 
            // btn_caminho_destino
            // 
            this.btn_caminho_destino.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_caminho_destino.BackgroundImage")));
            this.btn_caminho_destino.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_caminho_destino.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btn_caminho_destino.FlatAppearance.BorderSize = 0;
            this.btn_caminho_destino.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_caminho_destino.Location = new System.Drawing.Point(274, 72);
            this.btn_caminho_destino.Name = "btn_caminho_destino";
            this.btn_caminho_destino.Size = new System.Drawing.Size(20, 20);
            this.btn_caminho_destino.TabIndex = 11;
            this.btn_caminho_destino.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_caminho_destino.UseVisualStyleBackColor = false;
            this.btn_caminho_destino.Click += new System.EventHandler(this.btn_caminho_destino_Click);
            // 
            // btn_caminho_origem
            // 
            this.btn_caminho_origem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_caminho_origem.BackgroundImage")));
            this.btn_caminho_origem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_caminho_origem.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btn_caminho_origem.FlatAppearance.BorderSize = 0;
            this.btn_caminho_origem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_caminho_origem.Location = new System.Drawing.Point(274, 52);
            this.btn_caminho_origem.Name = "btn_caminho_origem";
            this.btn_caminho_origem.Size = new System.Drawing.Size(20, 20);
            this.btn_caminho_origem.TabIndex = 10;
            this.btn_caminho_origem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_caminho_origem.UseVisualStyleBackColor = false;
            this.btn_caminho_origem.Click += new System.EventHandler(this.btn_caminho_origem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Money.Properties.Resources.backup;
            this.pictureBox1.Location = new System.Drawing.Point(307, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(144, 168);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // FrmBackup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 207);
            this.Controls.Add(this.btn_caminho_destino);
            this.Controls.Add(this.btn_caminho_origem);
            this.Controls.Add(this.btn_inicia_copia);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_origem);
            this.Controls.Add(this.txt_destino);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_ver_pastas);
            this.MaximizeBox = false;
            this.Name = "FrmBackup";
            this.Text = "Gerar Backup";
            this.Load += new System.EventHandler(this.Frm_Backup_Load);
            this.Controls.SetChildIndex(this.btn_ver_pastas, 0);
            this.Controls.SetChildIndex(this.pictureBox1, 0);
            this.Controls.SetChildIndex(this.txt_destino, 0);
            this.Controls.SetChildIndex(this.txt_origem, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.btn_inicia_copia, 0);
            this.Controls.SetChildIndex(this.btn_caminho_origem, 0);
            this.Controls.SetChildIndex(this.btn_caminho_destino, 0);
            this.Controls.SetChildIndex(this.panel5, 0);
            this.Controls.SetChildIndex(this.panel4, 0);
            this.Controls.SetChildIndex(this.panel3, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox txt_destino;
        private System.Windows.Forms.TextBox txt_origem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Button btn_ver_pastas;
        public System.Windows.Forms.Button btn_inicia_copia;
        public System.Windows.Forms.Button btn_caminho_destino;
        public System.Windows.Forms.Button btn_caminho_origem;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}