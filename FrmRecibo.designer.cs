namespace Money
{
    partial class FrmRecibo
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
            this.label8 = new System.Windows.Forms.Label();
            this.txt_cpf = new System.Windows.Forms.MaskedTextBox();
            this.lbl_erro = new System.Windows.Forms.Label();
            this.txt_extenso = new System.Windows.Forms.TextBox();
            this.btn_Limpar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dtData = new System.Windows.Forms.DateTimePicker();
            this.txt_favorecido = new System.Windows.Forms.TextBox();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.txtReferente = new System.Windows.Forms.TextBox();
            this.txt_emissor = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGerarRecibo = new System.Windows.Forms.Button();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(2, 311);
            this.panel2.Size = new System.Drawing.Size(572, 2);
            // 
            // panel3
            // 
            this.panel3.Size = new System.Drawing.Size(572, 25);
            // 
            // panel4
            // 
            this.panel4.Size = new System.Drawing.Size(2, 313);
            // 
            // panel5
            // 
            this.panel5.Location = new System.Drawing.Point(574, 0);
            this.panel5.Size = new System.Drawing.Size(2, 313);
            // 
            // btnExit
            // 
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.Location = new System.Drawing.Point(538, 3);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(136, 92);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 17);
            this.label8.TabIndex = 22;
            this.label8.Text = "Valor Extenso:";
            // 
            // txt_cpf
            // 
            this.txt_cpf.Location = new System.Drawing.Point(440, 69);
            this.txt_cpf.Mask = "000.000.000-00";
            this.txt_cpf.Name = "txt_cpf";
            this.txt_cpf.Size = new System.Drawing.Size(100, 23);
            this.txt_cpf.TabIndex = 1;
            this.txt_cpf.Enter += new System.EventHandler(this.txt_cpf_Enter);
            this.txt_cpf.Leave += new System.EventHandler(this.txt_cpf_Leave);
            // 
            // lbl_erro
            // 
            this.lbl_erro.AutoSize = true;
            this.lbl_erro.ForeColor = System.Drawing.Color.Red;
            this.lbl_erro.Location = new System.Drawing.Point(190, 217);
            this.lbl_erro.Name = "lbl_erro";
            this.lbl_erro.Size = new System.Drawing.Size(0, 17);
            this.lbl_erro.TabIndex = 20;
            // 
            // txt_extenso
            // 
            this.txt_extenso.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_extenso.Location = new System.Drawing.Point(136, 110);
            this.txt_extenso.Name = "txt_extenso";
            this.txt_extenso.ReadOnly = true;
            this.txt_extenso.Size = new System.Drawing.Size(408, 20);
            this.txt_extenso.TabIndex = 19;
            this.txt_extenso.TabStop = false;
            // 
            // btn_Limpar
            // 
            this.btn_Limpar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(182)))));
            this.btn_Limpar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Limpar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_Limpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Limpar.ForeColor = System.Drawing.Color.White;
            this.btn_Limpar.Location = new System.Drawing.Point(440, 268);
            this.btn_Limpar.Name = "btn_Limpar";
            this.btn_Limpar.Size = new System.Drawing.Size(100, 35);
            this.btn_Limpar.TabIndex = 18;
            this.btn_Limpar.TabStop = false;
            this.btn_Limpar.Text = "&Limpar";
            this.btn_Limpar.UseVisualStyleBackColor = false;
            this.btn_Limpar.Click += new System.EventHandler(this.btn_Limpar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(440, 53);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 17);
            this.label7.TabIndex = 17;
            this.label7.Text = "CPF:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(33, 223);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 17);
            this.label6.TabIndex = 15;
            this.label6.Text = "Emissor";
            // 
            // dtData
            // 
            this.dtData.Location = new System.Drawing.Point(33, 194);
            this.dtData.Name = "dtData";
            this.dtData.Size = new System.Drawing.Size(507, 23);
            this.dtData.TabIndex = 4;
            // 
            // txt_favorecido
            // 
            this.txt_favorecido.Location = new System.Drawing.Point(33, 69);
            this.txt_favorecido.Name = "txt_favorecido";
            this.txt_favorecido.Size = new System.Drawing.Size(401, 23);
            this.txt_favorecido.TabIndex = 0;
            this.txt_favorecido.Enter += new System.EventHandler(this.txt_favorecido_Enter);
            this.txt_favorecido.Leave += new System.EventHandler(this.txt_favorecido_Leave);
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(33, 107);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(101, 23);
            this.txtValor.TabIndex = 2;
            this.txtValor.Click += new System.EventHandler(this.txtValor_Click);
            this.txtValor.Enter += new System.EventHandler(this.txtValor_Enter);
            this.txtValor.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtValor_KeyUp);
            this.txtValor.Leave += new System.EventHandler(this.txtValor_Leave);
            // 
            // txtReferente
            // 
            this.txtReferente.Location = new System.Drawing.Point(33, 149);
            this.txtReferente.Name = "txtReferente";
            this.txtReferente.Size = new System.Drawing.Size(507, 23);
            this.txtReferente.TabIndex = 3;
            this.txtReferente.Enter += new System.EventHandler(this.txtReferente_Enter);
            this.txtReferente.Leave += new System.EventHandler(this.txtReferente_Leave);
            // 
            // txt_emissor
            // 
            this.txt_emissor.Location = new System.Drawing.Point(33, 242);
            this.txt_emissor.Name = "txt_emissor";
            this.txt_emissor.Size = new System.Drawing.Size(507, 23);
            this.txt_emissor.TabIndex = 5;
            this.txt_emissor.Enter += new System.EventHandler(this.txt_emissor_Enter);
            this.txt_emissor.Leave += new System.EventHandler(this.txt_emissor_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Valor:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Referente a ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Data";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Favorecido:";
            // 
            // btnGerarRecibo
            // 
            this.btnGerarRecibo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(182)))));
            this.btnGerarRecibo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnGerarRecibo.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnGerarRecibo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGerarRecibo.ForeColor = System.Drawing.Color.White;
            this.btnGerarRecibo.Location = new System.Drawing.Point(335, 269);
            this.btnGerarRecibo.Name = "btnGerarRecibo";
            this.btnGerarRecibo.Size = new System.Drawing.Size(100, 35);
            this.btnGerarRecibo.TabIndex = 6;
            this.btnGerarRecibo.Text = "&Gerar Recibo";
            this.btnGerarRecibo.UseVisualStyleBackColor = false;
            this.btnGerarRecibo.Click += new System.EventHandler(this.btnGerarRecibo_Click);
            // 
            // FrmRecibo
            // 
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(576, 313);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_cpf);
            this.Controls.Add(this.lbl_erro);
            this.Controls.Add(this.txt_extenso);
            this.Controls.Add(this.btn_Limpar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dtData);
            this.Controls.Add(this.txt_favorecido);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.txtReferente);
            this.Controls.Add(this.txt_emissor);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnGerarRecibo);
            this.MaximizeBox = false;
            this.Name = "FrmRecibo";
            this.Text = "Recibo";
            this.Load += new System.EventHandler(this.frmRecibo_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FrmRecibo_KeyPress);
            this.Controls.SetChildIndex(this.btnGerarRecibo, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.txt_emissor, 0);
            this.Controls.SetChildIndex(this.txtReferente, 0);
            this.Controls.SetChildIndex(this.txtValor, 0);
            this.Controls.SetChildIndex(this.txt_favorecido, 0);
            this.Controls.SetChildIndex(this.dtData, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.btn_Limpar, 0);
            this.Controls.SetChildIndex(this.txt_extenso, 0);
            this.Controls.SetChildIndex(this.lbl_erro, 0);
            this.Controls.SetChildIndex(this.txt_cpf, 0);
            this.Controls.SetChildIndex(this.label8, 0);
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

        private System.Windows.Forms.Button btnGerarRecibo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_emissor;
        private System.Windows.Forms.TextBox txtReferente;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.TextBox txt_favorecido;
        private System.Windows.Forms.DateTimePicker dtData;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_Limpar;
        private System.Windows.Forms.TextBox txt_extenso;
        private System.Windows.Forms.Label lbl_erro;
        private System.Windows.Forms.MaskedTextBox txt_cpf;
        private System.Windows.Forms.Label label8;
    }
}
