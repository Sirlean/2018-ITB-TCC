using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Itb.Tcc.LojaJogos
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnEnterLongin_Click(object sender, EventArgs e)
        {
            bool logado = false;

            if (txtNomeLongin.Text.ToUpper() == "ADMIN")
            {
                if (txtSenhaLogin.Text == "12345")
                {
                    logado = true;
                }
            }
            else
            {
                ClnFuncionario clnFuncionario = new ClnFuncionario();
                logado = clnFuncionario.ValidarUsuario(txtNomeLongin.Text, txtSenhaLogin.Text);
            }
            if (logado == true)
            {
                Menu objMenu = new Menu();
                objMenu.ShowDialog();
            }
            else
            {
                MessageBox.Show("Usuário ou senha inválido!");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void txtNomeLongin_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
