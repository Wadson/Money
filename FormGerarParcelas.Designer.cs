namespace Money
{
    partial class FormGerarParcelas
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.kryptonPalette1 = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
            this.lvParcelas = new Krypton.Toolkit.KryptonListView();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel3 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel4 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.dtpPrimeiraParcela = new ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker();
            this.nudParcelas = new ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown();
            this.btnGerarParcelas = new System.Windows.Forms.Button();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblValorTotal = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lblDescricao = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.lblStatus = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // kryptonPalette1
            // 
            this.kryptonPalette1.ButtonSpecs.FormClose.Image = global::Money.Properties.Resources.Sair_24;
            this.kryptonPalette1.ButtonSpecs.FormClose.ImageStates.ImagePressed = global::Money.Properties.Resources.Sair24;
            this.kryptonPalette1.ButtonSpecs.FormClose.ImageStates.ImageTracking = global::Money.Properties.Resources.Sair24;
            this.kryptonPalette1.ButtonSpecs.FormMax.Image = global::Money.Properties.Resources.Maximize;
            this.kryptonPalette1.ButtonSpecs.FormMax.ImageStates.ImagePressed = global::Money.Properties.Resources.Minimiza24;
            this.kryptonPalette1.ButtonSpecs.FormMax.ImageStates.ImageTracking = global::Money.Properties.Resources.Minimiza24;
            this.kryptonPalette1.ButtonSpecs.FormMin.Image = global::Money.Properties.Resources.Minimize;
            this.kryptonPalette1.ButtonSpecs.FormMin.ImageStates.ImagePressed = global::Money.Properties.Resources.Minimizar24;
            this.kryptonPalette1.ButtonSpecs.FormMin.ImageStates.ImageTracking = global::Money.Properties.Resources.Minimizar24;
            this.kryptonPalette1.ButtonSpecs.FormRestore.Image = global::Money.Properties.Resources.Maximize;
            this.kryptonPalette1.ButtonSpecs.FormRestore.ImageStates.ImagePressed = global::Money.Properties.Resources.Minimiza24;
            this.kryptonPalette1.ButtonSpecs.FormRestore.ImageStates.ImageTracking = global::Money.Properties.Resources.Minimiza24;
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.None;
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Border.Rounding = 12;
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.ButtonEdgeInset = 10;
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, -1, -1, -1);
            // 
            // lvParcelas
            // 
            this.lvParcelas.HideSelection = false;
            this.lvParcelas.Location = new System.Drawing.Point(1, 131);
            this.lvParcelas.Name = "lvParcelas";
            this.lvParcelas.Size = new System.Drawing.Size(463, 177);
            this.lvParcelas.TabIndex = 9;
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(9, 58);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(75, 21);
            this.kryptonLabel1.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel1.TabIndex = 16;
            this.kryptonLabel1.Values.Text = "Descrição:";
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(3, 95);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(85, 21);
            this.kryptonLabel2.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel2.TabIndex = 17;
            this.kryptonLabel2.Values.Text = "Nº de Parc.:";
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.Location = new System.Drawing.Point(203, 95);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(132, 21);
            this.kryptonLabel3.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel3.TabIndex = 19;
            this.kryptonLabel3.Values.Text = "Dt.Primeira Parcela";
            // 
            // kryptonLabel4
            // 
            this.kryptonLabel4.Location = new System.Drawing.Point(0, 34);
            this.kryptonLabel4.Name = "kryptonLabel4";
            this.kryptonLabel4.Size = new System.Drawing.Size(84, 21);
            this.kryptonLabel4.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel4.TabIndex = 21;
            this.kryptonLabel4.Values.Text = "Valor Total:";
            // 
            // dtpPrimeiraParcela
            // 
            this.dtpPrimeiraParcela.CalendarDayStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Gallery;
            this.dtpPrimeiraParcela.CalendarDimensions = new System.Drawing.Size(2, 2);
            this.dtpPrimeiraParcela.CalendarHeaderStyle = ComponentFactory.Krypton.Toolkit.HeaderStyle.Form;
            this.dtpPrimeiraParcela.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpPrimeiraParcela.Location = new System.Drawing.Point(332, 88);
            this.dtpPrimeiraParcela.Name = "dtpPrimeiraParcela";
            this.dtpPrimeiraParcela.Palette = this.kryptonPalette1;
            this.dtpPrimeiraParcela.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.dtpPrimeiraParcela.Size = new System.Drawing.Size(131, 37);
            this.dtpPrimeiraParcela.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.dtpPrimeiraParcela.StateCommon.Border.Rounding = 20;
            this.dtpPrimeiraParcela.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F);
            this.dtpPrimeiraParcela.TabIndex = 265;
            this.dtpPrimeiraParcela.TabStop = false;
            // 
            // nudParcelas
            // 
            this.nudParcelas.Location = new System.Drawing.Point(82, 88);
            this.nudParcelas.Maximum = new decimal(new int[] {
            205,
            0,
            0,
            0});
            this.nudParcelas.Name = "nudParcelas";
            this.nudParcelas.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Blue;
            this.nudParcelas.Size = new System.Drawing.Size(120, 34);
            this.nudParcelas.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.nudParcelas.StateCommon.Border.Rounding = 20;
            this.nudParcelas.TabIndex = 266;
            this.nudParcelas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudParcelas.ValueChanged += new System.EventHandler(this.nudParcelas_ValueChanged);
            // 
            // btnGerarParcelas
            // 
            this.btnGerarParcelas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnGerarParcelas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnGerarParcelas.FlatAppearance.BorderColor = System.Drawing.Color.LightGreen;
            this.btnGerarParcelas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LimeGreen;
            this.btnGerarParcelas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.btnGerarParcelas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGerarParcelas.ForeColor = System.Drawing.Color.White;
            this.btnGerarParcelas.Location = new System.Drawing.Point(4, 314);
            this.btnGerarParcelas.Name = "btnGerarParcelas";
            this.btnGerarParcelas.Size = new System.Drawing.Size(110, 36);
            this.btnGerarParcelas.TabIndex = 303;
            this.btnGerarParcelas.Text = "Gerar Parcelas";
            this.btnGerarParcelas.UseVisualStyleBackColor = false;
            this.btnGerarParcelas.Click += new System.EventHandler(this.btnGerarParcelas_Click);
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConfirmar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnConfirmar.FlatAppearance.BorderColor = System.Drawing.Color.LightGreen;
            this.btnConfirmar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LimeGreen;
            this.btnConfirmar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.btnConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmar.ForeColor = System.Drawing.Color.White;
            this.btnConfirmar.Location = new System.Drawing.Point(346, 314);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(110, 36);
            this.btnConfirmar.TabIndex = 304;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = false;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCancelar.BackColor = System.Drawing.Color.LimeGreen;
            this.btnCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(120, 314);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(110, 36);
            this.btnCancelar.TabIndex = 305;
            this.btnCancelar.TabStop = false;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblValorTotal
            // 
            this.lblValorTotal.Location = new System.Drawing.Point(84, 34);
            this.lblValorTotal.Name = "lblValorTotal";
            this.lblValorTotal.Size = new System.Drawing.Size(75, 21);
            this.lblValorTotal.StateCommon.ShortText.Color1 = System.Drawing.Color.Red;
            this.lblValorTotal.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorTotal.TabIndex = 306;
            this.lblValorTotal.Values.Text = "Valor Total";
            // 
            // lblDescricao
            // 
            this.lblDescricao.Location = new System.Drawing.Point(84, 60);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(68, 21);
            this.lblDescricao.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescricao.TabIndex = 307;
            this.lblDescricao.Values.Text = "Descrição";
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.lblStatus);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Blue;
            this.kryptonPanel1.PanelBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.SeparatorHighProfile;
            this.kryptonPanel1.Size = new System.Drawing.Size(468, 30);
            this.kryptonPanel1.TabIndex = 308;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.BackColor = System.Drawing.Color.Transparent;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(76)))), ((int)(((byte)(172)))));
            this.lblStatus.Location = new System.Drawing.Point(171, 2);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(134, 24);
            this.lblStatus.TabIndex = 248;
            this.lblStatus.Text = "Gerar Parcelas";
            // 
            // FormGerarParcelas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(468, 358);
            this.Controls.Add(this.kryptonPanel1);
            this.Controls.Add(this.lblDescricao);
            this.Controls.Add(this.lblValorTotal);
            this.Controls.Add(this.btnGerarParcelas);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.nudParcelas);
            this.Controls.Add(this.dtpPrimeiraParcela);
            this.Controls.Add(this.kryptonLabel4);
            this.Controls.Add(this.kryptonLabel3);
            this.Controls.Add(this.kryptonLabel2);
            this.Controls.Add(this.kryptonLabel1);
            this.Controls.Add(this.lvParcelas);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormGerarParcelas";
            this.Palette = this.kryptonPalette1;
            this.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Gerar parcelas";
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonPalette kryptonPalette1;
        private Krypton.Toolkit.KryptonListView lvParcelas;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel4;
        public ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker dtpPrimeiraParcela;
        private ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown nudParcelas;
        public System.Windows.Forms.Button btnGerarParcelas;
        public System.Windows.Forms.Button btnConfirmar;
        public System.Windows.Forms.Button btnCancelar;
        public ComponentFactory.Krypton.Toolkit.KryptonLabel lblValorTotal;
        public ComponentFactory.Krypton.Toolkit.KryptonLabel lblDescricao;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
        public System.Windows.Forms.Label lblStatus;
    }
}

