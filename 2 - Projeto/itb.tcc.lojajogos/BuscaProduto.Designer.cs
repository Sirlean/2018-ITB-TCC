namespace Itb.Tcc.LojaJogos
{
    partial class BuscaProduto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BuscaProduto));
            this.dgvBuscaProduto = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnNovoBuscaProduto = new System.Windows.Forms.Button();
            this.btnAlterarBuscaProduto = new System.Windows.Forms.Button();
            this.btnExcluirBuscaProduto = new System.Windows.Forms.Button();
            this.btnSairBuscaProduto = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboTipoPesquisa = new System.Windows.Forms.ComboBox();
            this.txtDescricaoBuscaProduto = new System.Windows.Forms.TextBox();
            this.btnPesquisarBuscaProduto = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuscaProduto)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvBuscaProduto
            // 
            this.dgvBuscaProduto.AllowUserToAddRows = false;
            this.dgvBuscaProduto.AllowUserToDeleteRows = false;
            this.dgvBuscaProduto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBuscaProduto.Location = new System.Drawing.Point(12, 161);
            this.dgvBuscaProduto.Name = "dgvBuscaProduto";
            this.dgvBuscaProduto.ReadOnly = true;
            this.dgvBuscaProduto.Size = new System.Drawing.Size(813, 160);
            this.dgvBuscaProduto.TabIndex = 20;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnNovoBuscaProduto);
            this.groupBox2.Controls.Add(this.btnAlterarBuscaProduto);
            this.groupBox2.Controls.Add(this.btnExcluirBuscaProduto);
            this.groupBox2.Location = new System.Drawing.Point(12, 346);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(813, 63);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "MENU";
            // 
            // btnNovoBuscaProduto
            // 
            this.btnNovoBuscaProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovoBuscaProduto.Location = new System.Drawing.Point(171, 19);
            this.btnNovoBuscaProduto.Name = "btnNovoBuscaProduto";
            this.btnNovoBuscaProduto.Size = new System.Drawing.Size(75, 23);
            this.btnNovoBuscaProduto.TabIndex = 3;
            this.btnNovoBuscaProduto.Text = "&Novo";
            this.btnNovoBuscaProduto.UseVisualStyleBackColor = true;
            this.btnNovoBuscaProduto.Click += new System.EventHandler(this.btnNovoBuscaProduto_Click);
            // 
            // btnAlterarBuscaProduto
            // 
            this.btnAlterarBuscaProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterarBuscaProduto.Location = new System.Drawing.Point(382, 19);
            this.btnAlterarBuscaProduto.Name = "btnAlterarBuscaProduto";
            this.btnAlterarBuscaProduto.Size = new System.Drawing.Size(86, 23);
            this.btnAlterarBuscaProduto.TabIndex = 5;
            this.btnAlterarBuscaProduto.Text = "&Alterar";
            this.btnAlterarBuscaProduto.UseVisualStyleBackColor = true;
            this.btnAlterarBuscaProduto.Click += new System.EventHandler(this.btnAlterarBuscaProduto_Click);
            // 
            // btnExcluirBuscaProduto
            // 
            this.btnExcluirBuscaProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluirBuscaProduto.Location = new System.Drawing.Point(600, 19);
            this.btnExcluirBuscaProduto.Name = "btnExcluirBuscaProduto";
            this.btnExcluirBuscaProduto.Size = new System.Drawing.Size(75, 23);
            this.btnExcluirBuscaProduto.TabIndex = 6;
            this.btnExcluirBuscaProduto.Text = "&Excluir";
            this.btnExcluirBuscaProduto.UseVisualStyleBackColor = true;
            this.btnExcluirBuscaProduto.Click += new System.EventHandler(this.btnExcluirBuscaProduto_Click);
            // 
            // btnSairBuscaProduto
            // 
            this.btnSairBuscaProduto.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnSairBuscaProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSairBuscaProduto.ForeColor = System.Drawing.Color.Black;
            this.btnSairBuscaProduto.Location = new System.Drawing.Point(731, 456);
            this.btnSairBuscaProduto.Name = "btnSairBuscaProduto";
            this.btnSairBuscaProduto.Size = new System.Drawing.Size(64, 29);
            this.btnSairBuscaProduto.TabIndex = 8;
            this.btnSairBuscaProduto.Text = "sair";
            this.btnSairBuscaProduto.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboTipoPesquisa);
            this.groupBox1.Controls.Add(this.txtDescricaoBuscaProduto);
            this.groupBox1.Controls.Add(this.btnPesquisarBuscaProduto);
            this.groupBox1.Location = new System.Drawing.Point(19, 76);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(813, 57);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "FILTROS";
            // 
            // cboTipoPesquisa
            // 
            this.cboTipoPesquisa.FormattingEnabled = true;
            this.cboTipoPesquisa.Items.AddRange(new object[] {
            "Código",
            "Tipo",
            "Nome ",
            "Faixa Etária",
            "Fornecedor",
            "Gênero"});
            this.cboTipoPesquisa.Location = new System.Drawing.Point(6, 19);
            this.cboTipoPesquisa.Name = "cboTipoPesquisa";
            this.cboTipoPesquisa.Size = new System.Drawing.Size(121, 21);
            this.cboTipoPesquisa.TabIndex = 9;
            // 
            // txtDescricaoBuscaProduto
            // 
            this.txtDescricaoBuscaProduto.Location = new System.Drawing.Point(164, 22);
            this.txtDescricaoBuscaProduto.Name = "txtDescricaoBuscaProduto";
            this.txtDescricaoBuscaProduto.Size = new System.Drawing.Size(549, 20);
            this.txtDescricaoBuscaProduto.TabIndex = 2;
            // 
            // btnPesquisarBuscaProduto
            // 
            this.btnPesquisarBuscaProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisarBuscaProduto.Location = new System.Drawing.Point(719, 19);
            this.btnPesquisarBuscaProduto.Name = "btnPesquisarBuscaProduto";
            this.btnPesquisarBuscaProduto.Size = new System.Drawing.Size(88, 25);
            this.btnPesquisarBuscaProduto.TabIndex = 7;
            this.btnPesquisarBuscaProduto.Text = "P&esquisar";
            this.btnPesquisarBuscaProduto.UseVisualStyleBackColor = true;
            this.btnPesquisarBuscaProduto.Click += new System.EventHandler(this.btnPesquisarBuscaProduto_Click);
            // 
            // BuscaProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Itb.Tcc.LojaJogos.Properties.Resources.gods___myth_by_genzoman;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1004, 501);
            this.Controls.Add(this.dgvBuscaProduto);
            this.Controls.Add(this.btnSairBuscaProduto);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BuscaProduto";
            this.Text = "BuscaProduto";
            this.Load += new System.EventHandler(this.BuscaProduto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuscaProduto)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBuscaProduto;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnNovoBuscaProduto;
        private System.Windows.Forms.Button btnSairBuscaProduto;
        private System.Windows.Forms.Button btnAlterarBuscaProduto;
        private System.Windows.Forms.Button btnExcluirBuscaProduto;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtDescricaoBuscaProduto;
        private System.Windows.Forms.Button btnPesquisarBuscaProduto;
        private System.Windows.Forms.ComboBox cboTipoPesquisa;
    }
}