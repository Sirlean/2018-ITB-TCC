namespace Itb.Tcc.LojaJogos
{
    partial class frmCompleto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCompleto));
            this.LblCod = new System.Windows.Forms.Label();
            this.txtCod = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbFeminino = new System.Windows.Forms.RadioButton();
            this.rbMasculino = new System.Windows.Forms.RadioButton();
            this.lblGeneroCadastroCliente = new System.Windows.Forms.Label();
            this.txtCelularCadastroCliente = new System.Windows.Forms.TextBox();
            this.lblCelularCadastroCliente = new System.Windows.Forms.Label();
            this.txtRGCadastroCliente = new System.Windows.Forms.TextBox();
            this.lblRGCadastroCliente = new System.Windows.Forms.Label();
            this.txtEmailCadastroCliente = new System.Windows.Forms.TextBox();
            this.lblEmailCadastroCliente = new System.Windows.Forms.Label();
            this.txtCPFCadastroCliente = new System.Windows.Forms.TextBox();
            this.lblCPFCadastroCliente = new System.Windows.Forms.Label();
            this.cboUFCadastroCliente = new System.Windows.Forms.ComboBox();
            this.txtNumeroCadastroCliente = new System.Windows.Forms.TextBox();
            this.lblNumeroCadastroCliente = new System.Windows.Forms.Label();
            this.txtMaskCepCadastroCliente = new System.Windows.Forms.MaskedTextBox();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.LblCidade = new System.Windows.Forms.Label();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.txtEnderecoCadastroCliente = new System.Windows.Forms.TextBox();
            this.LblBairro = new System.Windows.Forms.Label();
            this.lblUfCadastroCliente = new System.Windows.Forms.Label();
            this.lblEnderecoCadastroCliente = new System.Windows.Forms.Label();
            this.lblCepCadastroCliente = new System.Windows.Forms.Label();
            this.txtTelefoneCadastroCliente = new System.Windows.Forms.TextBox();
            this.lblTelefoneCadastroCliente = new System.Windows.Forms.Label();
            this.txtNomeCadastroCliente = new System.Windows.Forms.TextBox();
            this.lblNomeCadastroCliente = new System.Windows.Forms.Label();
            this.btnGravar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LblCod
            // 
            this.LblCod.AutoSize = true;
            this.LblCod.BackColor = System.Drawing.SystemColors.Control;
            this.LblCod.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCod.Location = new System.Drawing.Point(3, 20);
            this.LblCod.Name = "LblCod";
            this.LblCod.Size = new System.Drawing.Size(55, 16);
            this.LblCod.TabIndex = 0;
            this.LblCod.Text = "Código:";
            // 
            // txtCod
            // 
            this.txtCod.Location = new System.Drawing.Point(61, 20);
            this.txtCod.Multiline = true;
            this.txtCod.Name = "txtCod";
            this.txtCod.Size = new System.Drawing.Size(72, 20);
            this.txtCod.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbFeminino);
            this.groupBox1.Controls.Add(this.rbMasculino);
            this.groupBox1.Controls.Add(this.lblGeneroCadastroCliente);
            this.groupBox1.Controls.Add(this.txtCelularCadastroCliente);
            this.groupBox1.Controls.Add(this.lblCelularCadastroCliente);
            this.groupBox1.Controls.Add(this.txtRGCadastroCliente);
            this.groupBox1.Controls.Add(this.lblRGCadastroCliente);
            this.groupBox1.Controls.Add(this.txtEmailCadastroCliente);
            this.groupBox1.Controls.Add(this.lblEmailCadastroCliente);
            this.groupBox1.Controls.Add(this.txtCPFCadastroCliente);
            this.groupBox1.Controls.Add(this.lblCPFCadastroCliente);
            this.groupBox1.Controls.Add(this.cboUFCadastroCliente);
            this.groupBox1.Controls.Add(this.txtNumeroCadastroCliente);
            this.groupBox1.Controls.Add(this.lblNumeroCadastroCliente);
            this.groupBox1.Controls.Add(this.txtMaskCepCadastroCliente);
            this.groupBox1.Controls.Add(this.txtCidade);
            this.groupBox1.Controls.Add(this.LblCidade);
            this.groupBox1.Controls.Add(this.txtBairro);
            this.groupBox1.Controls.Add(this.txtEnderecoCadastroCliente);
            this.groupBox1.Controls.Add(this.LblBairro);
            this.groupBox1.Controls.Add(this.lblUfCadastroCliente);
            this.groupBox1.Controls.Add(this.lblEnderecoCadastroCliente);
            this.groupBox1.Controls.Add(this.lblCepCadastroCliente);
            this.groupBox1.Controls.Add(this.txtTelefoneCadastroCliente);
            this.groupBox1.Controls.Add(this.lblTelefoneCadastroCliente);
            this.groupBox1.Controls.Add(this.txtNomeCadastroCliente);
            this.groupBox1.Controls.Add(this.lblNomeCadastroCliente);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 70);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(775, 369);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cadastro Cliente";
            // 
            // rbFeminino
            // 
            this.rbFeminino.AutoSize = true;
            this.rbFeminino.Location = new System.Drawing.Point(629, 77);
            this.rbFeminino.Name = "rbFeminino";
            this.rbFeminino.Size = new System.Drawing.Size(89, 20);
            this.rbFeminino.TabIndex = 29;
            this.rbFeminino.TabStop = true;
            this.rbFeminino.Text = "Feminino";
            this.rbFeminino.UseVisualStyleBackColor = true;
            // 
            // rbMasculino
            // 
            this.rbMasculino.AutoSize = true;
            this.rbMasculino.Location = new System.Drawing.Point(516, 75);
            this.rbMasculino.Name = "rbMasculino";
            this.rbMasculino.Size = new System.Drawing.Size(96, 20);
            this.rbMasculino.TabIndex = 28;
            this.rbMasculino.TabStop = true;
            this.rbMasculino.Text = "Masculino";
            this.rbMasculino.UseVisualStyleBackColor = true;
            // 
            // lblGeneroCadastroCliente
            // 
            this.lblGeneroCadastroCliente.AutoSize = true;
            this.lblGeneroCadastroCliente.BackColor = System.Drawing.SystemColors.Control;
            this.lblGeneroCadastroCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGeneroCadastroCliente.Location = new System.Drawing.Point(583, 49);
            this.lblGeneroCadastroCliente.Name = "lblGeneroCadastroCliente";
            this.lblGeneroCadastroCliente.Size = new System.Drawing.Size(63, 16);
            this.lblGeneroCadastroCliente.TabIndex = 27;
            this.lblGeneroCadastroCliente.Text = "Genero:";
            // 
            // txtCelularCadastroCliente
            // 
            this.txtCelularCadastroCliente.Location = new System.Drawing.Point(329, 113);
            this.txtCelularCadastroCliente.Multiline = true;
            this.txtCelularCadastroCliente.Name = "txtCelularCadastroCliente";
            this.txtCelularCadastroCliente.Size = new System.Drawing.Size(149, 20);
            this.txtCelularCadastroCliente.TabIndex = 25;
            // 
            // lblCelularCadastroCliente
            // 
            this.lblCelularCadastroCliente.AutoSize = true;
            this.lblCelularCadastroCliente.BackColor = System.Drawing.SystemColors.Control;
            this.lblCelularCadastroCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCelularCadastroCliente.Location = new System.Drawing.Point(265, 115);
            this.lblCelularCadastroCliente.Name = "lblCelularCadastroCliente";
            this.lblCelularCadastroCliente.Size = new System.Drawing.Size(61, 16);
            this.lblCelularCadastroCliente.TabIndex = 24;
            this.lblCelularCadastroCliente.Text = "Celular:";
            // 
            // txtRGCadastroCliente
            // 
            this.txtRGCadastroCliente.Location = new System.Drawing.Point(326, 30);
            this.txtRGCadastroCliente.Multiline = true;
            this.txtRGCadastroCliente.Name = "txtRGCadastroCliente";
            this.txtRGCadastroCliente.Size = new System.Drawing.Size(201, 20);
            this.txtRGCadastroCliente.TabIndex = 23;
            // 
            // lblRGCadastroCliente
            // 
            this.lblRGCadastroCliente.AutoSize = true;
            this.lblRGCadastroCliente.BackColor = System.Drawing.SystemColors.Control;
            this.lblRGCadastroCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRGCadastroCliente.Location = new System.Drawing.Point(292, 32);
            this.lblRGCadastroCliente.Name = "lblRGCadastroCliente";
            this.lblRGCadastroCliente.Size = new System.Drawing.Size(34, 16);
            this.lblRGCadastroCliente.TabIndex = 22;
            this.lblRGCadastroCliente.Text = "RG:";
            // 
            // txtEmailCadastroCliente
            // 
            this.txtEmailCadastroCliente.Location = new System.Drawing.Point(67, 153);
            this.txtEmailCadastroCliente.Multiline = true;
            this.txtEmailCadastroCliente.Name = "txtEmailCadastroCliente";
            this.txtEmailCadastroCliente.Size = new System.Drawing.Size(301, 20);
            this.txtEmailCadastroCliente.TabIndex = 21;
            // 
            // lblEmailCadastroCliente
            // 
            this.lblEmailCadastroCliente.AutoSize = true;
            this.lblEmailCadastroCliente.BackColor = System.Drawing.SystemColors.Control;
            this.lblEmailCadastroCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmailCadastroCliente.Location = new System.Drawing.Point(14, 155);
            this.lblEmailCadastroCliente.Name = "lblEmailCadastroCliente";
            this.lblEmailCadastroCliente.Size = new System.Drawing.Size(51, 16);
            this.lblEmailCadastroCliente.TabIndex = 20;
            this.lblEmailCadastroCliente.Text = "Email:";
            // 
            // txtCPFCadastroCliente
            // 
            this.txtCPFCadastroCliente.Location = new System.Drawing.Point(62, 29);
            this.txtCPFCadastroCliente.Multiline = true;
            this.txtCPFCadastroCliente.Name = "txtCPFCadastroCliente";
            this.txtCPFCadastroCliente.Size = new System.Drawing.Size(201, 20);
            this.txtCPFCadastroCliente.TabIndex = 19;
            // 
            // lblCPFCadastroCliente
            // 
            this.lblCPFCadastroCliente.AutoSize = true;
            this.lblCPFCadastroCliente.BackColor = System.Drawing.SystemColors.Control;
            this.lblCPFCadastroCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCPFCadastroCliente.Location = new System.Drawing.Point(14, 31);
            this.lblCPFCadastroCliente.Name = "lblCPFCadastroCliente";
            this.lblCPFCadastroCliente.Size = new System.Drawing.Size(47, 16);
            this.lblCPFCadastroCliente.TabIndex = 18;
            this.lblCPFCadastroCliente.Text = "*CPF:";
            // 
            // cboUFCadastroCliente
            // 
            this.cboUFCadastroCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboUFCadastroCliente.FormattingEnabled = true;
            this.cboUFCadastroCliente.Location = new System.Drawing.Point(681, 194);
            this.cboUFCadastroCliente.Name = "cboUFCadastroCliente";
            this.cboUFCadastroCliente.Size = new System.Drawing.Size(53, 24);
            this.cboUFCadastroCliente.TabIndex = 17;
            // 
            // txtNumeroCadastroCliente
            // 
            this.txtNumeroCadastroCliente.Location = new System.Drawing.Point(584, 195);
            this.txtNumeroCadastroCliente.Multiline = true;
            this.txtNumeroCadastroCliente.Name = "txtNumeroCadastroCliente";
            this.txtNumeroCadastroCliente.Size = new System.Drawing.Size(46, 20);
            this.txtNumeroCadastroCliente.TabIndex = 17;
            // 
            // lblNumeroCadastroCliente
            // 
            this.lblNumeroCadastroCliente.AutoSize = true;
            this.lblNumeroCadastroCliente.BackColor = System.Drawing.SystemColors.Control;
            this.lblNumeroCadastroCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroCadastroCliente.Location = new System.Drawing.Point(547, 196);
            this.lblNumeroCadastroCliente.Name = "lblNumeroCadastroCliente";
            this.lblNumeroCadastroCliente.Size = new System.Drawing.Size(35, 16);
            this.lblNumeroCadastroCliente.TabIndex = 16;
            this.lblNumeroCadastroCliente.Text = "*Nº:";
            // 
            // txtMaskCepCadastroCliente
            // 
            this.txtMaskCepCadastroCliente.Location = new System.Drawing.Point(67, 192);
            this.txtMaskCepCadastroCliente.Mask = "00000-999";
            this.txtMaskCepCadastroCliente.Name = "txtMaskCepCadastroCliente";
            this.txtMaskCepCadastroCliente.Size = new System.Drawing.Size(83, 22);
            this.txtMaskCepCadastroCliente.TabIndex = 15;
            this.txtMaskCepCadastroCliente.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txtMaskCepCadastroCliente_MaskInputRejected);
            this.txtMaskCepCadastroCliente.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMaskCep_keyDown);
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(507, 239);
            this.txtCidade.Multiline = true;
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(197, 20);
            this.txtCidade.TabIndex = 13;
            // 
            // LblCidade
            // 
            this.LblCidade.AutoSize = true;
            this.LblCidade.BackColor = System.Drawing.SystemColors.Control;
            this.LblCidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCidade.Location = new System.Drawing.Point(438, 239);
            this.LblCidade.Name = "LblCidade";
            this.LblCidade.Size = new System.Drawing.Size(68, 16);
            this.LblCidade.TabIndex = 12;
            this.LblCidade.Text = "*Cidade:";
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(86, 235);
            this.txtBairro.Multiline = true;
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(346, 20);
            this.txtBairro.TabIndex = 11;
            // 
            // txtEnderecoCadastroCliente
            // 
            this.txtEnderecoCadastroCliente.Location = new System.Drawing.Point(243, 193);
            this.txtEnderecoCadastroCliente.Multiline = true;
            this.txtEnderecoCadastroCliente.Name = "txtEnderecoCadastroCliente";
            this.txtEnderecoCadastroCliente.Size = new System.Drawing.Size(294, 20);
            this.txtEnderecoCadastroCliente.TabIndex = 2;
            // 
            // LblBairro
            // 
            this.LblBairro.AutoSize = true;
            this.LblBairro.BackColor = System.Drawing.SystemColors.Control;
            this.LblBairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblBairro.Location = new System.Drawing.Point(14, 239);
            this.LblBairro.Name = "LblBairro";
            this.LblBairro.Size = new System.Drawing.Size(60, 16);
            this.LblBairro.TabIndex = 9;
            this.LblBairro.Text = "*Bairro:";
            // 
            // lblUfCadastroCliente
            // 
            this.lblUfCadastroCliente.AutoSize = true;
            this.lblUfCadastroCliente.BackColor = System.Drawing.SystemColors.Control;
            this.lblUfCadastroCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUfCadastroCliente.Location = new System.Drawing.Point(640, 197);
            this.lblUfCadastroCliente.Name = "lblUfCadastroCliente";
            this.lblUfCadastroCliente.Size = new System.Drawing.Size(38, 16);
            this.lblUfCadastroCliente.TabIndex = 8;
            this.lblUfCadastroCliente.Text = "*UF:";
            // 
            // lblEnderecoCadastroCliente
            // 
            this.lblEnderecoCadastroCliente.AutoSize = true;
            this.lblEnderecoCadastroCliente.BackColor = System.Drawing.SystemColors.Control;
            this.lblEnderecoCadastroCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnderecoCadastroCliente.Location = new System.Drawing.Point(156, 195);
            this.lblEnderecoCadastroCliente.Name = "lblEnderecoCadastroCliente";
            this.lblEnderecoCadastroCliente.Size = new System.Drawing.Size(85, 16);
            this.lblEnderecoCadastroCliente.TabIndex = 7;
            this.lblEnderecoCadastroCliente.Text = "*Endereço:";
            // 
            // lblCepCadastroCliente
            // 
            this.lblCepCadastroCliente.AutoSize = true;
            this.lblCepCadastroCliente.BackColor = System.Drawing.SystemColors.Control;
            this.lblCepCadastroCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCepCadastroCliente.Location = new System.Drawing.Point(17, 194);
            this.lblCepCadastroCliente.Name = "lblCepCadastroCliente";
            this.lblCepCadastroCliente.Size = new System.Drawing.Size(44, 16);
            this.lblCepCadastroCliente.TabIndex = 5;
            this.lblCepCadastroCliente.Text = "*cep:";
            // 
            // txtTelefoneCadastroCliente
            // 
            this.txtTelefoneCadastroCliente.Location = new System.Drawing.Point(82, 113);
            this.txtTelefoneCadastroCliente.Multiline = true;
            this.txtTelefoneCadastroCliente.Name = "txtTelefoneCadastroCliente";
            this.txtTelefoneCadastroCliente.Size = new System.Drawing.Size(149, 20);
            this.txtTelefoneCadastroCliente.TabIndex = 2;
            // 
            // lblTelefoneCadastroCliente
            // 
            this.lblTelefoneCadastroCliente.AutoSize = true;
            this.lblTelefoneCadastroCliente.BackColor = System.Drawing.SystemColors.Control;
            this.lblTelefoneCadastroCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefoneCadastroCliente.Location = new System.Drawing.Point(6, 115);
            this.lblTelefoneCadastroCliente.Name = "lblTelefoneCadastroCliente";
            this.lblTelefoneCadastroCliente.Size = new System.Drawing.Size(74, 16);
            this.lblTelefoneCadastroCliente.TabIndex = 3;
            this.lblTelefoneCadastroCliente.Text = "Telefone:";
            // 
            // txtNomeCadastroCliente
            // 
            this.txtNomeCadastroCliente.Location = new System.Drawing.Point(68, 73);
            this.txtNomeCadastroCliente.Multiline = true;
            this.txtNomeCadastroCliente.Name = "txtNomeCadastroCliente";
            this.txtNomeCadastroCliente.Size = new System.Drawing.Size(424, 20);
            this.txtNomeCadastroCliente.TabIndex = 2;
            // 
            // lblNomeCadastroCliente
            // 
            this.lblNomeCadastroCliente.AutoSize = true;
            this.lblNomeCadastroCliente.BackColor = System.Drawing.SystemColors.Control;
            this.lblNomeCadastroCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeCadastroCliente.Location = new System.Drawing.Point(6, 75);
            this.lblNomeCadastroCliente.Name = "lblNomeCadastroCliente";
            this.lblNomeCadastroCliente.Size = new System.Drawing.Size(59, 16);
            this.lblNomeCadastroCliente.TabIndex = 1;
            this.lblNomeCadastroCliente.Text = "*Nome:";
            // 
            // btnGravar
            // 
            this.btnGravar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGravar.Location = new System.Drawing.Point(363, 392);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(75, 23);
            this.btnGravar.TabIndex = 15;
            this.btnGravar.Text = "Gravar";
            this.btnGravar.UseVisualStyleBackColor = true;
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnSair.Location = new System.Drawing.Point(714, 450);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(54, 23);
            this.btnSair.TabIndex = 16;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            // 
            // frmCompleto
            // 
            this.ClientSize = new System.Drawing.Size(799, 485);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtCod);
            this.Controls.Add(this.LblCod);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCompleto";
            this.Text = "CadastroCliente";
            this.Load += new System.EventHandler(this.frmCompleto_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lblGeneroCadastroCliente;
        public System.Windows.Forms.TextBox txtCelularCadastroCliente;
        public System.Windows.Forms.Label lblCelularCadastroCliente;
        public System.Windows.Forms.TextBox txtRGCadastroCliente;
        public System.Windows.Forms.Label lblRGCadastroCliente;
        public System.Windows.Forms.TextBox txtEmailCadastroCliente;
        public System.Windows.Forms.Label lblEmailCadastroCliente;
        public System.Windows.Forms.TextBox txtCPFCadastroCliente;
        public System.Windows.Forms.Label lblCPFCadastroCliente;
        public System.Windows.Forms.RadioButton rbFeminino;
        public System.Windows.Forms.RadioButton rbMasculino;
        public System.Windows.Forms.Label LblCod;
        public System.Windows.Forms.TextBox txtCod;
        public System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.TextBox txtTelefoneCadastroCliente;
        public System.Windows.Forms.Label lblTelefoneCadastroCliente;
        public System.Windows.Forms.TextBox txtNomeCadastroCliente;
        public System.Windows.Forms.Label lblNomeCadastroCliente;
        public System.Windows.Forms.ComboBox cboUFCadastroCliente;
        public System.Windows.Forms.TextBox txtNumeroCadastroCliente;
        public System.Windows.Forms.Label lblNumeroCadastroCliente;
        public System.Windows.Forms.MaskedTextBox txtMaskCepCadastroCliente;
        public System.Windows.Forms.Label LblCidade;
        public System.Windows.Forms.TextBox txtBairro;
        public System.Windows.Forms.TextBox txtEnderecoCadastroCliente;
        public System.Windows.Forms.Label LblBairro;
        public System.Windows.Forms.Label lblUfCadastroCliente;
        public System.Windows.Forms.Label lblEnderecoCadastroCliente;
        public System.Windows.Forms.Label lblCepCadastroCliente;
        public System.Windows.Forms.Button btnGravar;
        public System.Windows.Forms.Button btnSair;
        public System.Windows.Forms.TextBox txtCidade;

    }
}

