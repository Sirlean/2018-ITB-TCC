namespace Itb.Tcc.LojaJogos
{
    partial class BuscaFuncinario
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
            this.dgvBuscaFuncionario = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnNovoBuscaFuncionario = new System.Windows.Forms.Button();
            this.btnAlterarBuscaFuncionario = new System.Windows.Forms.Button();
            this.btnExcluirBuscaFuncionario = new System.Windows.Forms.Button();
            this.btnSairBuscaFuncionario = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboTipoPesquisa = new System.Windows.Forms.ComboBox();
            this.txtBuscaFuncionario = new System.Windows.Forms.TextBox();
            this.btnPesquisarBuscaFuncionario = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuscaFuncionario)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvBuscaFuncionario
            // 
            this.dgvBuscaFuncionario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBuscaFuncionario.Location = new System.Drawing.Point(12, 96);
            this.dgvBuscaFuncionario.Name = "dgvBuscaFuncionario";
            this.dgvBuscaFuncionario.Size = new System.Drawing.Size(726, 160);
            this.dgvBuscaFuncionario.TabIndex = 28;
            this.dgvBuscaFuncionario.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBuscaFuncionario_CellContentClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnNovoBuscaFuncionario);
            this.groupBox2.Controls.Add(this.btnAlterarBuscaFuncionario);
            this.groupBox2.Controls.Add(this.btnExcluirBuscaFuncionario);
            this.groupBox2.Location = new System.Drawing.Point(12, 275);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(726, 63);
            this.groupBox2.TabIndex = 27;
            this.groupBox2.TabStop = false;
            // 
            // btnNovoBuscaFuncionario
            // 
            this.btnNovoBuscaFuncionario.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnNovoBuscaFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovoBuscaFuncionario.Location = new System.Drawing.Point(124, 19);
            this.btnNovoBuscaFuncionario.Name = "btnNovoBuscaFuncionario";
            this.btnNovoBuscaFuncionario.Size = new System.Drawing.Size(75, 23);
            this.btnNovoBuscaFuncionario.TabIndex = 3;
            this.btnNovoBuscaFuncionario.Text = "&Novo";
            this.btnNovoBuscaFuncionario.UseVisualStyleBackColor = false;
            this.btnNovoBuscaFuncionario.Click += new System.EventHandler(this.btnNovoBuscaFuncionario_Click);
            // 
            // btnAlterarBuscaFuncionario
            // 
            this.btnAlterarBuscaFuncionario.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAlterarBuscaFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterarBuscaFuncionario.Location = new System.Drawing.Point(345, 19);
            this.btnAlterarBuscaFuncionario.Name = "btnAlterarBuscaFuncionario";
            this.btnAlterarBuscaFuncionario.Size = new System.Drawing.Size(75, 23);
            this.btnAlterarBuscaFuncionario.TabIndex = 5;
            this.btnAlterarBuscaFuncionario.Text = "&Alterar";
            this.btnAlterarBuscaFuncionario.UseVisualStyleBackColor = false;
            this.btnAlterarBuscaFuncionario.Click += new System.EventHandler(this.btnAlterarBuscaFuncionario_Click);
            // 
            // btnExcluirBuscaFuncionario
            // 
            this.btnExcluirBuscaFuncionario.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnExcluirBuscaFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluirBuscaFuncionario.Location = new System.Drawing.Point(565, 19);
            this.btnExcluirBuscaFuncionario.Name = "btnExcluirBuscaFuncionario";
            this.btnExcluirBuscaFuncionario.Size = new System.Drawing.Size(75, 23);
            this.btnExcluirBuscaFuncionario.TabIndex = 6;
            this.btnExcluirBuscaFuncionario.Text = "&Excluir";
            this.btnExcluirBuscaFuncionario.UseVisualStyleBackColor = false;
            this.btnExcluirBuscaFuncionario.Click += new System.EventHandler(this.btnExcluirBuscaFuncionario_Click);
            // 
            // btnSairBuscaFuncionario
            // 
            this.btnSairBuscaFuncionario.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSairBuscaFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSairBuscaFuncionario.ForeColor = System.Drawing.Color.Black;
            this.btnSairBuscaFuncionario.Location = new System.Drawing.Point(692, 341);
            this.btnSairBuscaFuncionario.Name = "btnSairBuscaFuncionario";
            this.btnSairBuscaFuncionario.Size = new System.Drawing.Size(40, 27);
            this.btnSairBuscaFuncionario.TabIndex = 25;
            this.btnSairBuscaFuncionario.Text = "sair";
            this.btnSairBuscaFuncionario.UseVisualStyleBackColor = false;
            this.btnSairBuscaFuncionario.Click += new System.EventHandler(this.btnSairBuscaFuncionario_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboTipoPesquisa);
            this.groupBox1.Controls.Add(this.txtBuscaFuncionario);
            this.groupBox1.Controls.Add(this.btnPesquisarBuscaFuncionario);
            this.groupBox1.Location = new System.Drawing.Point(12, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(726, 236);
            this.groupBox1.TabIndex = 26;
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
            // 
            // txtBuscaFuncionario
            // 
            this.txtBuscaFuncionario.Location = new System.Drawing.Point(155, 22);
            this.txtBuscaFuncionario.Name = "txtBuscaFuncionario";
            this.txtBuscaFuncionario.Size = new System.Drawing.Size(432, 20);
            this.txtBuscaFuncionario.TabIndex = 2;
            // 
            // btnPesquisarBuscaFuncionario
            // 
            this.btnPesquisarBuscaFuncionario.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnPesquisarBuscaFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisarBuscaFuncionario.Location = new System.Drawing.Point(610, 19);
            this.btnPesquisarBuscaFuncionario.Name = "btnPesquisarBuscaFuncionario";
            this.btnPesquisarBuscaFuncionario.Size = new System.Drawing.Size(77, 25);
            this.btnPesquisarBuscaFuncionario.TabIndex = 7;
            this.btnPesquisarBuscaFuncionario.Text = "&Pesquisar";
            this.btnPesquisarBuscaFuncionario.UseVisualStyleBackColor = false;
            this.btnPesquisarBuscaFuncionario.Click += new System.EventHandler(this.btnPesquisarBuscaFuncionario_Click);
            // 
            // BuscaFuncinario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Itb.Tcc.LojaJogos.Properties.Resources.gods___myth_by_genzoman;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1004, 501);
            this.Controls.Add(this.dgvBuscaFuncionario);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnSairBuscaFuncionario);
            this.Controls.Add(this.groupBox1);
            this.Name = "BuscaFuncinario";
            this.Text = "BuscaFuncinario";
            this.Load += new System.EventHandler(this.BuscaFuncinario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuscaFuncionario)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBuscaFuncionario;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnNovoBuscaFuncionario;
        private System.Windows.Forms.Button btnAlterarBuscaFuncionario;
        private System.Windows.Forms.Button btnExcluirBuscaFuncionario;
        private System.Windows.Forms.Button btnSairBuscaFuncionario;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cboTipoPesquisa;
        private System.Windows.Forms.TextBox txtBuscaFuncionario;
        private System.Windows.Forms.Button btnPesquisarBuscaFuncionario;
    }
}