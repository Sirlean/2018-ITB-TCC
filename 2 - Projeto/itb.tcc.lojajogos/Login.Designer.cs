namespace Itb.Tcc.LojaJogos
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.btnLimparLongin = new System.Windows.Forms.Button();
            this.lblNomeLogin = new System.Windows.Forms.Label();
            this.lblSenhLogin = new System.Windows.Forms.Label();
            this.txtNomeLongin = new System.Windows.Forms.TextBox();
            this.txtSenhaLogin = new System.Windows.Forms.TextBox();
            this.btnEnterLongin = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLimparLongin
            // 
            this.btnLimparLongin.Location = new System.Drawing.Point(180, 229);
            this.btnLimparLongin.Name = "btnLimparLongin";
            this.btnLimparLongin.Size = new System.Drawing.Size(75, 23);
            this.btnLimparLongin.TabIndex = 0;
            this.btnLimparLongin.Text = "Limpar";
            this.btnLimparLongin.UseVisualStyleBackColor = true;
            // 
            // lblNomeLogin
            // 
            this.lblNomeLogin.AutoSize = true;
            this.lblNomeLogin.Location = new System.Drawing.Point(37, 162);
            this.lblNomeLogin.Name = "lblNomeLogin";
            this.lblNomeLogin.Size = new System.Drawing.Size(38, 13);
            this.lblNomeLogin.TabIndex = 1;
            this.lblNomeLogin.Text = "Nome:";
            // 
            // lblSenhLogin
            // 
            this.lblSenhLogin.AutoSize = true;
            this.lblSenhLogin.Location = new System.Drawing.Point(34, 192);
            this.lblSenhLogin.Name = "lblSenhLogin";
            this.lblSenhLogin.Size = new System.Drawing.Size(41, 13);
            this.lblSenhLogin.TabIndex = 2;
            this.lblSenhLogin.Text = "Senha:";
            // 
            // txtNomeLongin
            // 
            this.txtNomeLongin.Location = new System.Drawing.Point(79, 159);
            this.txtNomeLongin.Name = "txtNomeLongin";
            this.txtNomeLongin.Size = new System.Drawing.Size(195, 20);
            this.txtNomeLongin.TabIndex = 3;
            this.txtNomeLongin.TextChanged += new System.EventHandler(this.txtNomeLongin_TextChanged);
            // 
            // txtSenhaLogin
            // 
            this.txtSenhaLogin.Location = new System.Drawing.Point(79, 188);
            this.txtSenhaLogin.Name = "txtSenhaLogin";
            this.txtSenhaLogin.Size = new System.Drawing.Size(195, 20);
            this.txtSenhaLogin.TabIndex = 4;
            // 
            // btnEnterLongin
            // 
            this.btnEnterLongin.Location = new System.Drawing.Point(78, 229);
            this.btnEnterLongin.Name = "btnEnterLongin";
            this.btnEnterLongin.Size = new System.Drawing.Size(75, 23);
            this.btnEnterLongin.TabIndex = 5;
            this.btnEnterLongin.Text = "Enter";
            this.btnEnterLongin.UseVisualStyleBackColor = true;
            this.btnEnterLongin.Click += new System.EventHandler(this.btnEnterLongin_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(79, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(176, 136);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(342, 280);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnEnterLongin);
            this.Controls.Add(this.txtSenhaLogin);
            this.Controls.Add(this.txtNomeLongin);
            this.Controls.Add(this.lblSenhLogin);
            this.Controls.Add(this.lblNomeLogin);
            this.Controls.Add(this.btnLimparLongin);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLimparLongin;
        private System.Windows.Forms.Label lblNomeLogin;
        private System.Windows.Forms.Label lblSenhLogin;
        private System.Windows.Forms.TextBox txtNomeLongin;
        private System.Windows.Forms.TextBox txtSenhaLogin;
        private System.Windows.Forms.Button btnEnterLongin;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}