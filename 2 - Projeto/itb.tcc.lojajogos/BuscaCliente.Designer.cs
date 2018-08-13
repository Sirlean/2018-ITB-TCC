namespace Itb.Tcc.LojaJogos
{
    partial class BuscaCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BuscaCliente));
            this.dgvBuscaCliente = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnNovoBuscaCliente = new System.Windows.Forms.Button();
            this.btnAlterarBuscaCliente = new System.Windows.Forms.Button();
            this.btnExcluirBuscaCliente = new System.Windows.Forms.Button();
            this.btnSairBuscaCliente = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboTipoPesquisa = new System.Windows.Forms.ComboBox();
            this.txtBuscaCliente = new System.Windows.Forms.TextBox();
            this.btnPesquisarBuscaCliente = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuscaCliente)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvBuscaCliente
            // 
            this.dgvBuscaCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBuscaCliente.Location = new System.Drawing.Point(12, 85);
            this.dgvBuscaCliente.Name = "dgvBuscaCliente";
            this.dgvBuscaCliente.Size = new System.Drawing.Size(726, 160);
            this.dgvBuscaCliente.TabIndex = 24;
            this.dgvBuscaCliente.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBuscaCliente_CellContentClick);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.btnNovoBuscaCliente);
            this.groupBox2.Controls.Add(this.btnAlterarBuscaCliente);
            this.groupBox2.Controls.Add(this.btnExcluirBuscaCliente);
            this.groupBox2.Location = new System.Drawing.Point(12, 264);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(726, 63);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            // 
            // btnNovoBuscaCliente
            // 
            this.btnNovoBuscaCliente.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnNovoBuscaCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovoBuscaCliente.Location = new System.Drawing.Point(124, 19);
            this.btnNovoBuscaCliente.Name = "btnNovoBuscaCliente";
            this.btnNovoBuscaCliente.Size = new System.Drawing.Size(75, 23);
            this.btnNovoBuscaCliente.TabIndex = 3;
            this.btnNovoBuscaCliente.Text = "&Novo";
            this.btnNovoBuscaCliente.UseVisualStyleBackColor = false;
            this.btnNovoBuscaCliente.Click += new System.EventHandler(this.btnNovoBuscaCliente_Click);
            // 
            // btnAlterarBuscaCliente
            // 
            this.btnAlterarBuscaCliente.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAlterarBuscaCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterarBuscaCliente.Location = new System.Drawing.Point(345, 19);
            this.btnAlterarBuscaCliente.Name = "btnAlterarBuscaCliente";
            this.btnAlterarBuscaCliente.Size = new System.Drawing.Size(75, 23);
            this.btnAlterarBuscaCliente.TabIndex = 5;
            this.btnAlterarBuscaCliente.Text = "&Alterar";
            this.btnAlterarBuscaCliente.UseVisualStyleBackColor = false;
            this.btnAlterarBuscaCliente.Click += new System.EventHandler(this.btnAlterarBuscaCliente_Click_1);
            // 
            // btnExcluirBuscaCliente
            // 
            this.btnExcluirBuscaCliente.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnExcluirBuscaCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluirBuscaCliente.Location = new System.Drawing.Point(565, 19);
            this.btnExcluirBuscaCliente.Name = "btnExcluirBuscaCliente";
            this.btnExcluirBuscaCliente.Size = new System.Drawing.Size(75, 23);
            this.btnExcluirBuscaCliente.TabIndex = 6;
            this.btnExcluirBuscaCliente.Text = "&Excluir";
            this.btnExcluirBuscaCliente.UseVisualStyleBackColor = false;
            this.btnExcluirBuscaCliente.Click += new System.EventHandler(this.btnExcluirBuscaCliente_Click);
            // 
            // btnSairBuscaCliente
            // 
            this.btnSairBuscaCliente.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSairBuscaCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSairBuscaCliente.ForeColor = System.Drawing.Color.Black;
            this.btnSairBuscaCliente.Location = new System.Drawing.Point(692, 330);
            this.btnSairBuscaCliente.Name = "btnSairBuscaCliente";
            this.btnSairBuscaCliente.Size = new System.Drawing.Size(40, 27);
            this.btnSairBuscaCliente.TabIndex = 21;
            this.btnSairBuscaCliente.Text = "sair";
            this.btnSairBuscaCliente.UseVisualStyleBackColor = false;
            this.btnSairBuscaCliente.Click += new System.EventHandler(this.btnSairBuscaCliente_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.groupBox1.Controls.Add(this.cboTipoPesquisa);
            this.groupBox1.Controls.Add(this.txtBuscaCliente);
            this.groupBox1.Controls.Add(this.btnPesquisarBuscaCliente);
            this.groupBox1.Location = new System.Drawing.Point(12, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(726, 236);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "FILTROS";
            // 
            // cboTipoPesquisa
            // 
            this.cboTipoPesquisa.FormattingEnabled = true;
            this.cboTipoPesquisa.Items.AddRange(new object[] {
            "Código",
            "Nome ",
            "Cpf",
            "Rg",
            "Telefone",
            "Celular"});
            this.cboTipoPesquisa.Location = new System.Drawing.Point(6, 22);
            this.cboTipoPesquisa.Name = "cboTipoPesquisa";
            this.cboTipoPesquisa.Size = new System.Drawing.Size(121, 21);
            this.cboTipoPesquisa.TabIndex = 8;
            this.cboTipoPesquisa.SelectedIndexChanged += new System.EventHandler(this.cboTipoPesquisa_SelectedIndexChanged);
            // 
            // txtBuscaCliente
            // 
            this.txtBuscaCliente.Location = new System.Drawing.Point(155, 22);
            this.txtBuscaCliente.Name = "txtBuscaCliente";
            this.txtBuscaCliente.Size = new System.Drawing.Size(432, 20);
            this.txtBuscaCliente.TabIndex = 2;
            // 
            // btnPesquisarBuscaCliente
            // 
            this.btnPesquisarBuscaCliente.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnPesquisarBuscaCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisarBuscaCliente.Location = new System.Drawing.Point(610, 19);
            this.btnPesquisarBuscaCliente.Name = "btnPesquisarBuscaCliente";
            this.btnPesquisarBuscaCliente.Size = new System.Drawing.Size(77, 25);
            this.btnPesquisarBuscaCliente.TabIndex = 7;
            this.btnPesquisarBuscaCliente.Text = "&Pesquisar";
            this.btnPesquisarBuscaCliente.UseVisualStyleBackColor = false;
            this.btnPesquisarBuscaCliente.Click += new System.EventHandler(this.btnPesquisarBuscaCliente_Click_1);
            // 
            // BuscaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Itb.Tcc.LojaJogos.Properties.Resources.gods___myth_by_genzoman;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1004, 501);
            this.Controls.Add(this.dgvBuscaCliente);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnSairBuscaCliente);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BuscaCliente";
            this.Text = "BuscaCliente";
            this.Load += new System.EventHandler(this.BuscaCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuscaCliente)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBuscaCliente;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnNovoBuscaCliente;
        private System.Windows.Forms.Button btnAlterarBuscaCliente;
        private System.Windows.Forms.Button btnExcluirBuscaCliente;
        private System.Windows.Forms.Button btnSairBuscaCliente;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cboTipoPesquisa;
        private System.Windows.Forms.TextBox txtBuscaCliente;
        private System.Windows.Forms.Button btnPesquisarBuscaCliente;
    }
}