namespace Money
{
    partial class FrmResent_Senha
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
            this.label9 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lblSenha = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.dtNascimento = new System.Windows.Forms.DateTimePicker();
            this.btnLocalizarFornecedor = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.penelLinhaUsuario = new System.Windows.Forms.FlowLayoutPanel();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.Location = new System.Drawing.Point(102, 5);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(2, 387);
            this.panel2.Size = new System.Drawing.Size(317, 2);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(182)))));
            this.panel3.Size = new System.Drawing.Size(317, 25);
            // 
            // panel4
            // 
            this.panel4.Size = new System.Drawing.Size(2, 389);
            // 
            // panel5
            // 
            this.panel5.Location = new System.Drawing.Point(319, 0);
            this.panel5.Size = new System.Drawing.Size(2, 389);
            // 
            // btnExit
            // 
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.Location = new System.Drawing.Point(73, 2);
            // 
            // lblTitulo2
            // 
            this.lblTitulo2.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(12, 208);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 16);
            this.label9.TabIndex = 47;
            this.label9.Text = "Dt.Nascmto";
            // 
            // txtNome
            // 
            this.txtNome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(182)))));
            this.txtNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNome.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Italic);
            this.txtNome.ForeColor = System.Drawing.Color.White;
            this.txtNome.Location = new System.Drawing.Point(12, 176);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(302, 24);
            this.txtNome.TabIndex = 0;
            this.txtNome.Enter += new System.EventHandler(this.txtNome_Enter);
            this.txtNome.Leave += new System.EventHandler(this.txtNome_Leave);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(12, 160);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 16);
            this.label8.TabIndex = 48;
            this.label8.Text = "Nome Completo";
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenha.ForeColor = System.Drawing.Color.Yellow;
            this.lblSenha.Location = new System.Drawing.Point(65, 284);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(12, 15);
            this.lblSenha.TabIndex = 49;
            this.lblSenha.Text = "-";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 284);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 16);
            this.label2.TabIndex = 50;
            this.label2.Text = "Senha:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 261);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 16);
            this.label1.TabIndex = 55;
            this.label1.Text = "Usuário:";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.ForeColor = System.Drawing.Color.Yellow;
            this.lblUsuario.Location = new System.Drawing.Point(65, 262);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(12, 15);
            this.lblUsuario.TabIndex = 54;
            this.lblUsuario.Text = "-";
            // 
            // dtNascimento
            // 
            this.dtNascimento.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.dtNascimento.CalendarTitleBackColor = System.Drawing.Color.LimeGreen;
            this.dtNascimento.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNascimento.Location = new System.Drawing.Point(12, 227);
            this.dtNascimento.Name = "dtNascimento";
            this.dtNascimento.Size = new System.Drawing.Size(302, 21);
            this.dtNascimento.TabIndex = 1;
            // 
            // btnLocalizarFornecedor
            // 
            this.btnLocalizarFornecedor.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnLocalizarFornecedor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLocalizarFornecedor.FlatAppearance.BorderColor = System.Drawing.Color.PaleTurquoise;
            this.btnLocalizarFornecedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLocalizarFornecedor.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLocalizarFornecedor.ForeColor = System.Drawing.Color.LightGray;
            this.btnLocalizarFornecedor.Location = new System.Drawing.Point(12, 332);
            this.btnLocalizarFornecedor.Name = "btnLocalizarFornecedor";
            this.btnLocalizarFornecedor.Size = new System.Drawing.Size(297, 31);
            this.btnLocalizarFornecedor.TabIndex = 2;
            this.btnLocalizarFornecedor.Text = "&OK";
            this.btnLocalizarFornecedor.UseVisualStyleBackColor = false;
            this.btnLocalizarFornecedor.Click += new System.EventHandler(this.btnLocalizarFornecedor_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Money.Properties.Resources.ResetSenha;
            this.pictureBox1.Location = new System.Drawing.Point(94, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(131, 117);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 58;
            this.pictureBox1.TabStop = false;
            // 
            // penelLinhaUsuario
            // 
            this.penelLinhaUsuario.BackColor = System.Drawing.Color.DimGray;
            this.penelLinhaUsuario.Location = new System.Drawing.Point(12, 202);
            this.penelLinhaUsuario.Name = "penelLinhaUsuario";
            this.penelLinhaUsuario.Size = new System.Drawing.Size(302, 2);
            this.penelLinhaUsuario.TabIndex = 59;
            // 
            // FrmResent_Senha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(182)))));
            this.ClientSize = new System.Drawing.Size(321, 389);
            this.Controls.Add(this.penelLinhaUsuario);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnLocalizarFornecedor);
            this.Controls.Add(this.dtNascimento);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtNome);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmResent_Senha";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Esqueci a senha";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FrmResentSenha_KeyPress);
            this.Controls.SetChildIndex(this.txtNome, 0);
            this.Controls.SetChildIndex(this.label9, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            this.Controls.SetChildIndex(this.lblSenha, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.lblUsuario, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.dtNascimento, 0);
            this.Controls.SetChildIndex(this.btnLocalizarFornecedor, 0);
            this.Controls.SetChildIndex(this.pictureBox1, 0);
            this.Controls.SetChildIndex(this.penelLinhaUsuario, 0);
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
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.DateTimePicker dtNascimento;
        private System.Windows.Forms.Button btnLocalizarFornecedor;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.FlowLayoutPanel penelLinhaUsuario;
    }
}