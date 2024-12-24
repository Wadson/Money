namespace Money
{
    partial class FrmManutUsuario
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.dataGridPesquisa2 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.id_usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome_usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.user_usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dt_nascimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nivelacesso_usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.senha_usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email_usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPesquisa2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExcluir
            // 
            this.btnExcluir.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(182)))));
            this.btnExcluir.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnExcluir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnExcluir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(182)))));
            this.btnExcluir.Location = new System.Drawing.Point(789, 187);
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(182)))));
            this.btnNovo.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnNovo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnNovo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(182)))));
            this.btnNovo.Location = new System.Drawing.Point(789, 68);
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(182)))));
            this.btnAlterar.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnAlterar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnAlterar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(182)))));
            this.btnAlterar.Location = new System.Drawing.Point(789, 129);
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Location = new System.Drawing.Point(148, 29);
            this.txtPesquisa.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtPesquisa.Size = new System.Drawing.Size(632, 21);
            this.txtPesquisa.TextChanged += new System.EventHandler(this.txtPesquisa_TextChanged);
            // 
            // btnSair
            // 
            this.btnSair.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(182)))));
            this.btnSair.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnSair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnSair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnSair.Location = new System.Drawing.Point(789, 391);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // dataGridPesquisa2
            // 
            this.dataGridPesquisa2.AllowUserToAddRows = false;
            this.dataGridPesquisa2.AllowUserToDeleteRows = false;
            this.dataGridPesquisa2.AllowUserToResizeColumns = false;
            this.dataGridPesquisa2.AllowUserToResizeRows = false;
            this.dataGridPesquisa2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridPesquisa2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridPesquisa2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridPesquisa2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(68)))), ((int)(((byte)(96)))));
            this.dataGridPesquisa2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridPesquisa2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridPesquisa2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(51)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridPesquisa2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridPesquisa2.ColumnHeadersHeight = 20;
            this.dataGridPesquisa2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_usuario,
            this.nome_usuario,
            this.user_usuario,
            this.dt_nascimento,
            this.nivelacesso_usuario,
            this.senha_usuario,
            this.email_usuario});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(68)))), ((int)(((byte)(96)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridPesquisa2.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridPesquisa2.EnableHeadersVisualStyles = false;
            this.dataGridPesquisa2.GridColor = System.Drawing.Color.SteelBlue;
            this.dataGridPesquisa2.Location = new System.Drawing.Point(1, 68);
            this.dataGridPesquisa2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridPesquisa2.MultiSelect = false;
            this.dataGridPesquisa2.Name = "dataGridPesquisa2";
            this.dataGridPesquisa2.ReadOnly = true;
            this.dataGridPesquisa2.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(51)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.PaleVioletRed;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridPesquisa2.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridPesquisa2.RowHeadersVisible = false;
            this.dataGridPesquisa2.RowHeadersWidth = 20;
            this.dataGridPesquisa2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridPesquisa2.Size = new System.Drawing.Size(779, 370);
            this.dataGridPesquisa2.TabIndex = 424;
            this.dataGridPesquisa2.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridPesquisa2_CellDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Orange;
            this.label1.Location = new System.Drawing.Point(2, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 20);
            this.label1.TabIndex = 426;
            this.label1.Text = "Lista de usuários";
            // 
            // id_usuario
            // 
            this.id_usuario.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.id_usuario.DataPropertyName = "id_usuario";
            this.id_usuario.DividerWidth = 1;
            this.id_usuario.HeaderText = "Código";
            this.id_usuario.Name = "id_usuario";
            this.id_usuario.ReadOnly = true;
            this.id_usuario.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.id_usuario.Width = 60;
            // 
            // nome_usuario
            // 
            this.nome_usuario.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.nome_usuario.DataPropertyName = "nome_usuario";
            this.nome_usuario.DividerWidth = 1;
            this.nome_usuario.HeaderText = "Nome do Usuário";
            this.nome_usuario.Name = "nome_usuario";
            this.nome_usuario.ReadOnly = true;
            this.nome_usuario.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.nome_usuario.Width = 250;
            // 
            // user_usuario
            // 
            this.user_usuario.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.user_usuario.DataPropertyName = "user_usuario";
            this.user_usuario.DividerWidth = 1;
            this.user_usuario.HeaderText = "Usuário";
            this.user_usuario.Name = "user_usuario";
            this.user_usuario.ReadOnly = true;
            this.user_usuario.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.user_usuario.Width = 150;
            // 
            // dt_nascimento
            // 
            this.dt_nascimento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dt_nascimento.DataPropertyName = "dt_nascimento";
            this.dt_nascimento.DividerWidth = 1;
            this.dt_nascimento.HeaderText = "Data Nasc";
            this.dt_nascimento.Name = "dt_nascimento";
            this.dt_nascimento.ReadOnly = true;
            this.dt_nascimento.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dt_nascimento.Width = 80;
            // 
            // nivelacesso_usuario
            // 
            this.nivelacesso_usuario.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.nivelacesso_usuario.DataPropertyName = "nivelacesso_usuario";
            this.nivelacesso_usuario.DividerWidth = 1;
            this.nivelacesso_usuario.HeaderText = "Nivel de Acesso";
            this.nivelacesso_usuario.Name = "nivelacesso_usuario";
            this.nivelacesso_usuario.ReadOnly = true;
            this.nivelacesso_usuario.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.nivelacesso_usuario.Width = 150;
            // 
            // senha_usuario
            // 
            this.senha_usuario.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.senha_usuario.DataPropertyName = "senha_usuario";
            this.senha_usuario.DividerWidth = 1;
            this.senha_usuario.HeaderText = "Pass";
            this.senha_usuario.Name = "senha_usuario";
            this.senha_usuario.ReadOnly = true;
            this.senha_usuario.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.senha_usuario.Visible = false;
            this.senha_usuario.Width = 54;
            // 
            // email_usuario
            // 
            this.email_usuario.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.email_usuario.DataPropertyName = "email_usuario";
            this.email_usuario.DividerWidth = 1;
            this.email_usuario.HeaderText = "Email";
            this.email_usuario.Name = "email_usuario";
            this.email_usuario.ReadOnly = true;
            this.email_usuario.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.email_usuario.Width = 150;
            // 
            // FrmManutUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.ClientSize = new System.Drawing.Size(909, 442);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridPesquisa2);
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "FrmManutUsuario";
            this.Text = "Manutenção de usuário";
            this.Load += new System.EventHandler(this.FrmPesquisaUsuario_Load);
            this.Controls.SetChildIndex(this.btnAlterar, 0);
            this.Controls.SetChildIndex(this.btnNovo, 0);
            this.Controls.SetChildIndex(this.btnExcluir, 0);
            this.Controls.SetChildIndex(this.txtPesquisa, 0);
            this.Controls.SetChildIndex(this.btnSair, 0);
            this.Controls.SetChildIndex(this.dataGridPesquisa2, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPesquisa2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Timer timer1;
        public System.Windows.Forms.DataGridView dataGridPesquisa2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome_usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn user_usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn dt_nascimento;
        private System.Windows.Forms.DataGridViewTextBoxColumn nivelacesso_usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn senha_usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn email_usuario;
    }
}
