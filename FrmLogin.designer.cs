namespace Money
{
    partial class FrmLogin
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
            this.components = new System.ComponentModel.Container();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btn_Logar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.txt_SenhaLog = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.PaneLinhaSenha = new System.Windows.Forms.FlowLayoutPanel();
            this.penelLinhaUsuario = new System.Windows.Forms.FlowLayoutPanel();
            this.lblProvisorio = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblSenha = new System.Windows.Forms.Label();
            this.lblEsqueciSenha = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.barraTitulo = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.lblData = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.barraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Logar
            // 
            this.btn_Logar.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_Logar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Logar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_Logar.FlatAppearance.CheckedBackColor = System.Drawing.Color.Red;
            this.btn_Logar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btn_Logar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_Logar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Logar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.btn_Logar.ForeColor = System.Drawing.Color.White;
            this.btn_Logar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Logar.Location = new System.Drawing.Point(136, 153);
            this.btn_Logar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Logar.Name = "btn_Logar";
            this.btn_Logar.Size = new System.Drawing.Size(110, 28);
            this.btn_Logar.TabIndex = 2;
            this.btn_Logar.Text = "&Logar";
            this.toolTip1.SetToolTip(this.btn_Logar, "Logar no sistema");
            this.btn_Logar.UseVisualStyleBackColor = false;
            this.btn_Logar.Click += new System.EventHandler(this.btn_Logar_Click);
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.SteelBlue;
            this.btnSair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSair.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSair.FlatAppearance.CheckedBackColor = System.Drawing.Color.Red;
            this.btnSair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnSair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.btnSair.ForeColor = System.Drawing.Color.White;
            this.btnSair.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSair.Location = new System.Drawing.Point(265, 153);
            this.btnSair.Margin = new System.Windows.Forms.Padding(2);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(110, 28);
            this.btnSair.TabIndex = 259;
            this.btnSair.Text = "&Sair";
            this.toolTip1.SetToolTip(this.btnSair, "Logar no sistema");
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // txt_SenhaLog
            // 
            this.txt_SenhaLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SenhaLog.Location = new System.Drawing.Point(136, 110);
            this.txt_SenhaLog.Margin = new System.Windows.Forms.Padding(2);
            this.txt_SenhaLog.Name = "txt_SenhaLog";
            this.txt_SenhaLog.PasswordChar = '*';
            this.txt_SenhaLog.Size = new System.Drawing.Size(239, 21);
            this.txt_SenhaLog.TabIndex = 1;
            this.txt_SenhaLog.Enter += new System.EventHandler(this.txt_SenhaLog_Enter);
            this.txt_SenhaLog.Leave += new System.EventHandler(this.txt_SenhaLog_Leave);
            // 
            // txtUsuario
            // 
            this.txtUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.Location = new System.Drawing.Point(136, 63);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(239, 21);
            this.txtUsuario.TabIndex = 0;
            this.txtUsuario.Enter += new System.EventHandler(this.txtUsuario_Enter);
            this.txtUsuario.Leave += new System.EventHandler(this.txtUsuario_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(136, 90);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Senha de Usuário";
            // 
            // PaneLinhaSenha
            // 
            this.PaneLinhaSenha.BackColor = System.Drawing.Color.CadetBlue;
            this.PaneLinhaSenha.Location = new System.Drawing.Point(136, 132);
            this.PaneLinhaSenha.Margin = new System.Windows.Forms.Padding(2);
            this.PaneLinhaSenha.Name = "PaneLinhaSenha";
            this.PaneLinhaSenha.Size = new System.Drawing.Size(239, 2);
            this.PaneLinhaSenha.TabIndex = 5;
            // 
            // penelLinhaUsuario
            // 
            this.penelLinhaUsuario.BackColor = System.Drawing.Color.CadetBlue;
            this.penelLinhaUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.penelLinhaUsuario.Location = new System.Drawing.Point(136, 85);
            this.penelLinhaUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.penelLinhaUsuario.Name = "penelLinhaUsuario";
            this.penelLinhaUsuario.Size = new System.Drawing.Size(239, 2);
            this.penelLinhaUsuario.TabIndex = 7;
            // 
            // lblProvisorio
            // 
            this.lblProvisorio.AutoSize = true;
            this.lblProvisorio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProvisorio.ForeColor = System.Drawing.Color.Yellow;
            this.lblProvisorio.Location = new System.Drawing.Point(142, 92);
            this.lblProvisorio.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProvisorio.Name = "lblProvisorio";
            this.lblProvisorio.Size = new System.Drawing.Size(0, 15);
            this.lblProvisorio.TabIndex = 8;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblUsuario.Location = new System.Drawing.Point(324, 45);
            this.lblUsuario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(10, 13);
            this.lblUsuario.TabIndex = 10;
            this.lblUsuario.Text = " ";
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblSenha.Location = new System.Drawing.Point(324, 92);
            this.lblSenha.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(10, 15);
            this.lblSenha.TabIndex = 9;
            this.lblSenha.Text = " ";
            // 
            // lblEsqueciSenha
            // 
            this.lblEsqueciSenha.AutoSize = true;
            this.lblEsqueciSenha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblEsqueciSenha.Location = new System.Drawing.Point(286, 137);
            this.lblEsqueciSenha.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEsqueciSenha.Name = "lblEsqueciSenha";
            this.lblEsqueciSenha.Size = new System.Drawing.Size(86, 13);
            this.lblEsqueciSenha.TabIndex = 4;
            this.lblEsqueciSenha.Text = "Esqueci a senha";
            this.lblEsqueciSenha.Click += new System.EventHandler(this.lblEsqueciSenha_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(135, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "Digite o Nome de Usuário";
            // 
            // barraTitulo
            // 
            this.barraTitulo.Controls.Add(this.label4);
            this.barraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.barraTitulo.Location = new System.Drawing.Point(0, 0);
            this.barraTitulo.Name = "barraTitulo";
            this.barraTitulo.Size = new System.Drawing.Size(482, 23);
            this.barraTitulo.TabIndex = 257;
            this.barraTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.barraTitulo_MouseDown_1);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Money.Properties.Resources.usuario_Login1;
            this.pictureBox4.Location = new System.Drawing.Point(382, 76);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(89, 89);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 258;
            this.pictureBox4.TabStop = false;
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lblData.ForeColor = System.Drawing.Color.White;
            this.lblData.Location = new System.Drawing.Point(88, 261);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(13, 17);
            this.lblData.TabIndex = 262;
            this.lblData.Text = "-";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Money.Properties.Resources.quadra;
            this.pictureBox1.Location = new System.Drawing.Point(11, 57);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(121, 126);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 263;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(4, 3);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(164, 16);
            this.label4.TabIndex = 264;
            this.label4.Text = "Login do Sistema Money...";
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(482, 213);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.barraTitulo);
            this.Controls.Add(this.txt_SenhaLog);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PaneLinhaSenha);
            this.Controls.Add(this.penelLinhaUsuario);
            this.Controls.Add(this.lblProvisorio);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.lblEsqueciSenha);
            this.Controls.Add(this.btn_Logar);
            this.ForeColor = System.Drawing.Color.Blue;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.HelpButton = true;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmLogin";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Acesso ao Sistema";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmLogin_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FrmLogin_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.barraTitulo.ResumeLayout(false);
            this.barraTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Logar;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label lblEsqueciSenha;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.Label lblProvisorio;
        private System.Windows.Forms.FlowLayoutPanel PaneLinhaSenha;
        private System.Windows.Forms.FlowLayoutPanel penelLinhaUsuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_SenhaLog;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel barraTitulo;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;

        //public System.EventHandler frmLogin_Load { get; set; }

        //public System.EventHandler frmLogin_Enter { get; set; }

        //public System.Windows.Forms.KeyEventHandler frmLogin_KeyDown { get; set; }

        //public System.Windows.Forms.KeyPressEventHandler frmLogin_KeyPress { get; set; }

        //public System.Windows.Forms.PaintEventHandler panel1_Paint { get; set; }
    }
}