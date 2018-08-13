namespace Itb.Tcc.LojaJogos
{
    partial class BuscaFornecedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BuscaFornecedor));
            this.dgvBuscaFornecedor = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnNovoBuscaFornecedor = new System.Windows.Forms.Button();
            this.btnAlterarBuscaFornecedor = new System.Windows.Forms.Button();
            this.btnExcluirBuscaFornecedor = new System.Windows.Forms.Button();
            this.btnSairBuscaFornecedor = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboTipoPesquisa = new System.Windows.Forms.ComboBox();
            this.txtBuscaFornecedor = new System.Windows.Forms.TextBox();
            this.btnPesquisarBuscaFornecedor = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuscaFornecedor)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvBuscaFornecedor
            // 
            this.dgvBuscaFornecedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBuscaFornecedor.Location = new System.Drawing.Point(12, 75);
            this.dgvBuscaFornecedor.Name = "dgvBuscaFornecedor";
            this.dgvBuscaFornecedor.Size = new System.Drawing.Size(726, 160);
            this.dgvBuscaFornecedor.TabIndex = 20;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.btnNovoBuscaFornecedor);
            this.groupBox2.Controls.Add(this.btnAlterarBuscaFornecedor);
            this.groupBox2.Controls.Add(this.btnExcluirBuscaFornecedor);
            this.groupBox2.Location = new System.Drawing.Point(12, 254);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(726, 63);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            // 
            // btnNovoBuscaFornecedor
            // 
            this.btnNovoBuscaFornecedor.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnNovoBuscaFornecedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovoBuscaFornecedor.Location = new System.Drawing.Point(124, 19);
            this.btnNovoBuscaFornecedor.Name = "btnNovoBuscaFornecedor";
            this.btnNovoBuscaFornecedor.Size = new System.Drawing.Size(75, 23);
            this.btnNovoBuscaFornecedor.TabIndex = 3;
            this.btnNovoBuscaFornecedor.Text = "&Novo";
            this.btnNovoBuscaFornecedor.UseVisualStyleBackColor = false;
            this.btnNovoBuscaFornecedor.Click += new System.EventHandler(this.btnNovoBuscaFornecedor_Click);
            // 
            // btnAlterarBuscaFornecedor
            // 
            this.btnAlterarBuscaFornecedor.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAlterarBuscaFornecedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterarBuscaFornecedor.Location = new System.Drawing.Point(345, 19);
            this.btnAlterarBuscaFornecedor.Name = "btnAlterarBuscaFornecedor";
            this.btnAlterarBuscaFornecedor.Size = new System.Drawing.Size(75, 23);
            this.btnAlterarBuscaFornecedor.TabIndex = 5;
            this.btnAlterarBuscaFornecedor.Text = "&Alterar";
            this.btnAlterarBuscaFornecedor.UseVisualStyleBackColor = false;
            this.btnAlterarBuscaFornecedor.Click += new System.EventHandler(this.btnAlterarBuscaFornecedor_Click);
            // 
            // btnExcluirBuscaFornecedor
            // 
            this.btnExcluirBuscaFornecedor.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnExcluirBuscaFornecedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluirBuscaFornecedor.Location = new System.Drawing.Point(565, 19);
            this.btnExcluirBuscaFornecedor.Name = "btnExcluirBuscaFornecedor";
            this.btnExcluirBuscaFornecedor.Size = new System.Drawing.Size(75, 23);
            this.btnExcluirBuscaFornecedor.TabIndex = 6;
            this.btnExcluirBuscaFornecedor.Text = "&Excluir";
            this.btnExcluirBuscaFornecedor.UseVisualStyleBackColor = false;
            this.btnExcluirBuscaFornecedor.Click += new System.EventHandler(this.btnExcluirBuscaFornecedor_Click);
            // 
            // btnSairBuscaFornecedor
            // 
            this.btnSairBuscaFornecedor.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSairBuscaFornecedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSairBuscaFornecedor.ForeColor = System.Drawing.Color.Black;
            this.btnSairBuscaFornecedor.Location = new System.Drawing.Point(692, 320);
            this.btnSairBuscaFornecedor.Name = "btnSairBuscaFornecedor";
            this.btnSairBuscaFornecedor.Size = new System.Drawing.Size(40, 27);
            this.btnSairBuscaFornecedor.TabIndex = 8;
            this.btnSairBuscaFornecedor.Text = "sair";
            this.btnSairBuscaFornecedor.UseVisualStyleBackColor = false;
            this.btnSairBuscaFornecedor.Click += new System.EventHandler(this.btnSairBuscaFornecedor_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.cboTipoPesquisa);
            this.groupBox1.Controls.Add(this.txtBuscaFornecedor);
            this.groupBox1.Controls.Add(this.btnPesquisarBuscaFornecedor);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(726, 236);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "FILTROS";
            // 
            // cboTipoPesquisa
            // 
            this.cboTipoPesquisa.FormattingEnabled = true;
            this.cboTipoPesquisa.Items.AddRange(new object[] {
            "Código",
            "Cnpj",
            "Nome Fantasia",
            "Razão Social"});
            this.cboTipoPesquisa.Location = new System.Drawing.Point(6, 22);
            this.cboTipoPesquisa.Name = "cboTipoPesquisa";
            this.cboTipoPesquisa.Size = new System.Drawing.Size(121, 21);
            this.cboTipoPesquisa.TabIndex = 8;
            this.cboTipoPesquisa.SelectedIndexChanged += new System.EventHandler(this.cboTipoPesquisa_SelectedIndexChanged);
            // 
            // txtBuscaFornecedor
            // 
            this.txtBuscaFornecedor.Location = new System.Drawing.Point(155, 22);
            this.txtBuscaFornecedor.Name = "txtBuscaFornecedor";
            this.txtBuscaFornecedor.Size = new System.Drawing.Size(432, 20);
            this.txtBuscaFornecedor.TabIndex = 2;
            // 
            // btnPesquisarBuscaFornecedor
            // 
            this.btnPesquisarBuscaFornecedor.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnPesquisarBuscaFornecedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisarBuscaFornecedor.Location = new System.Drawing.Point(610, 19);
            this.btnPesquisarBuscaFornecedor.Name = "btnPesquisarBuscaFornecedor";
            this.btnPesquisarBuscaFornecedor.Size = new System.Drawing.Size(77, 25);
            this.btnPesquisarBuscaFornecedor.TabIndex = 7;
            this.btnPesquisarBuscaFornecedor.Text = "&Pesquisar";
            this.btnPesquisarBuscaFornecedor.UseVisualStyleBackColor = false;
            this.btnPesquisarBuscaFornecedor.Click += new System.EventHandler(this.btnPesquisarBuscaFornecedor_Click);
            // 
            // BuscaFornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Itb.Tcc.LojaJogos.Properties.Resources.gods___myth_by_genzoman;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1004, 501);
            this.Controls.Add(this.dgvBuscaFornecedor);
            this.Controls.Add(this.btnSairBuscaFornecedor);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BuscaFornecedor";
            this.Text = "BuscaFornecedor";
            this.Load += new System.EventHandler(this.BuscaFornecedor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuscaFornecedor)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBuscaFornecedor;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnNovoBuscaFornecedor;
        private System.Windows.Forms.Button btnSairBuscaFornecedor;
        private System.Windows.Forms.Button btnAlterarBuscaFornecedor;
        private System.Windows.Forms.Button btnExcluirBuscaFornecedor;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnPesquisarBuscaFornecedor;
        private System.Windows.Forms.TextBox txtBuscaFornecedor;
        private System.Windows.Forms.ComboBox cboTipoPesquisa;
    }
}