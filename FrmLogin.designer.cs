﻿namespace Money
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btn_Logar = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.txt_SenhaLog = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.PaneLinhaSenha = new System.Windows.Forms.FlowLayoutPanel();
            this.penelLinhaUsuario = new System.Windows.Forms.FlowLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.lblProvisorio = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblSenha = new System.Windows.Forms.Label();
            this.lblEsqueciSenha = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.barraTitulo = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.userControlData1 = new Money.UserControlData();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.barraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
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
            this.btn_Logar.Location = new System.Drawing.Point(32, 306);
            this.btn_Logar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Logar.Name = "btn_Logar";
            this.btn_Logar.Size = new System.Drawing.Size(278, 28);
            this.btn_Logar.TabIndex = 2;
            this.btn_Logar.Text = "&Logar";
            this.toolTip1.SetToolTip(this.btn_Logar, "Logar no sistema");
            this.btn_Logar.UseVisualStyleBackColor = false;
            this.btn_Logar.Click += new System.EventHandler(this.btn_Logar_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(5, 198);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(20, 20);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 256;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(5, 263);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(20, 20);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 255;
            this.pictureBox2.TabStop = false;
            // 
            // txt_SenhaLog
            // 
            this.txt_SenhaLog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(182)))));
            this.txt_SenhaLog.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_SenhaLog.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SenhaLog.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txt_SenhaLog.Location = new System.Drawing.Point(32, 262);
            this.txt_SenhaLog.Margin = new System.Windows.Forms.Padding(2);
            this.txt_SenhaLog.Name = "txt_SenhaLog";
            this.txt_SenhaLog.PasswordChar = '*';
            this.txt_SenhaLog.Size = new System.Drawing.Size(275, 16);
            this.txt_SenhaLog.TabIndex = 1;
            this.txt_SenhaLog.Enter += new System.EventHandler(this.txt_SenhaLog_Enter);
            this.txt_SenhaLog.Leave += new System.EventHandler(this.txt_SenhaLog_Leave);
            // 
            // txtUsuario
            // 
            this.txtUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(182)))));
            this.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsuario.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtUsuario.Location = new System.Drawing.Point(32, 197);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(275, 16);
            this.txtUsuario.TabIndex = 0;
            this.txtUsuario.Enter += new System.EventHandler(this.txtUsuario_Enter);
            this.txtUsuario.Leave += new System.EventHandler(this.txtUsuario_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Italic);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(39, 247);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "PASSWORD";
            // 
            // PaneLinhaSenha
            // 
            this.PaneLinhaSenha.BackColor = System.Drawing.Color.DimGray;
            this.PaneLinhaSenha.Location = new System.Drawing.Point(32, 282);
            this.PaneLinhaSenha.Margin = new System.Windows.Forms.Padding(2);
            this.PaneLinhaSenha.Name = "PaneLinhaSenha";
            this.PaneLinhaSenha.Size = new System.Drawing.Size(275, 2);
            this.PaneLinhaSenha.TabIndex = 5;
            // 
            // penelLinhaUsuario
            // 
            this.penelLinhaUsuario.BackColor = System.Drawing.Color.DimGray;
            this.penelLinhaUsuario.Location = new System.Drawing.Point(32, 217);
            this.penelLinhaUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.penelLinhaUsuario.Name = "penelLinhaUsuario";
            this.penelLinhaUsuario.Size = new System.Drawing.Size(275, 2);
            this.penelLinhaUsuario.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(133, 148);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "LOGIN";
            // 
            // lblProvisorio
            // 
            this.lblProvisorio.AutoSize = true;
            this.lblProvisorio.ForeColor = System.Drawing.Color.Yellow;
            this.lblProvisorio.Location = new System.Drawing.Point(121, 244);
            this.lblProvisorio.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProvisorio.Name = "lblProvisorio";
            this.lblProvisorio.Size = new System.Drawing.Size(0, 13);
            this.lblProvisorio.TabIndex = 8;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblUsuario.Location = new System.Drawing.Point(231, 179);
            this.lblUsuario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(10, 13);
            this.lblUsuario.TabIndex = 10;
            this.lblUsuario.Text = " ";
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblSenha.Location = new System.Drawing.Point(231, 240);
            this.lblSenha.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(10, 13);
            this.lblSenha.TabIndex = 9;
            this.lblSenha.Text = " ";
            // 
            // lblEsqueciSenha
            // 
            this.lblEsqueciSenha.AutoSize = true;
            this.lblEsqueciSenha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblEsqueciSenha.Location = new System.Drawing.Point(224, 290);
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
            this.label1.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Italic);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(43, 181);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 15);
            this.label1.TabIndex = 12;
            this.label1.Text = "USUÁRIO";
            // 
            // barraTitulo
            // 
            this.barraTitulo.Controls.Add(this.btnExit);
            this.barraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.barraTitulo.Location = new System.Drawing.Point(0, 0);
            this.barraTitulo.Name = "barraTitulo";
            this.barraTitulo.Size = new System.Drawing.Size(321, 23);
            this.barraTitulo.TabIndex = 257;
            this.barraTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.barraTitulo_MouseDown_1);
            // 
            // btnExit
            // 
            this.btnExit.BackgroundImage = global::Money.Properties.Resources.Close;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Location = new System.Drawing.Point(297, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(22, 20);
            this.btnExit.TabIndex = 258;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // userControlData1
            // 
            this.userControlData1.BackColor = System.Drawing.Color.Transparent;
            this.userControlData1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.25F);
            this.userControlData1.ForeColor = System.Drawing.Color.White;
            this.userControlData1.Location = new System.Drawing.Point(46, 365);
            this.userControlData1.Margin = new System.Windows.Forms.Padding(2);
            this.userControlData1.Name = "userControlData1";
            this.userControlData1.Size = new System.Drawing.Size(212, 15);
            this.userControlData1.TabIndex = 3;
            this.userControlData1.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox4.Image = global::Money.Properties.Resources.LogWR;
            this.pictureBox4.Location = new System.Drawing.Point(100, 26);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(119, 73);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 258;
            this.pictureBox4.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.label4.Location = new System.Drawing.Point(100, 101);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 33);
            this.label4.TabIndex = 259;
            this.label4.Text = "MONEY";
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Firebrick;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(321, 389);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.barraTitulo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.txt_SenhaLog);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PaneLinhaSenha);
            this.Controls.Add(this.penelLinhaUsuario);
            this.Controls.Add(this.userControlData1);
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
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmLogin_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FrmLogin_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.barraTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
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
        private UserControlData userControlData1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.FlowLayoutPanel PaneLinhaSenha;
        private System.Windows.Forms.FlowLayoutPanel penelLinhaUsuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_SenhaLog;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel barraTitulo;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox4;

        //public System.EventHandler frmLogin_Load { get; set; }

        //public System.EventHandler frmLogin_Enter { get; set; }

        //public System.Windows.Forms.KeyEventHandler frmLogin_KeyDown { get; set; }

        //public System.Windows.Forms.KeyPressEventHandler frmLogin_KeyPress { get; set; }

        //public System.Windows.Forms.PaintEventHandler panel1_Paint { get; set; }
    }
}