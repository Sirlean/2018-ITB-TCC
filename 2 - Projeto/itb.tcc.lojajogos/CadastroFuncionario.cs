using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Itb.Tcc.LojaJogos
{
    public partial class CadastroFuncionario : Form
    {
        ClnFuncionario ObjFuncionario = new ClnFuncionario();
        ClnUtil ObjClnUtil = new ClnUtil();
        public CadastroFuncionario()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void cboGeneroCadastroCliente_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CadastroFuncionario_Load(object sender, EventArgs e)
        {
            // Ao Carregar o formulário
            cboUFCadastroFuncionario.DropDownStyle = ComboBoxStyle.DropDownList; // alterar o tipo da combo para somente a lista
            PreencherUF();
            lblUfCadastroFuncionario.Focus();
            if (txtCod.Text != "") // Se não há código no textbox código então não preenche
            {
                ClnCliente ObjCliente = new ClnCliente();
                SqlDataReader ObjDrDados;
                ObjDrDados = ObjCliente.localizarCodigo(txtCod.Text);
                if (ObjDrDados.Read())
                {
                    txtNomeCadastroFuncionario.Text = ObjDrDados["Nome"].ToString();
                    txtCPFCadastroFuncionario.Text = ObjDrDados["Cpf"].ToString();
                    txtRGCadastroFuncionario.Text = ObjDrDados["Rg"].ToString();
                    txtTelefoneCadastroFuncionario.Text = ObjDrDados["Telefone"].ToString();
                    txtCelularCadastroFuncionario.Text = ObjDrDados["Celular"].ToString();
                    txtEmailCadastroFuncionario.Text = ObjDrDados["email"].ToString();
                    txtMaskCepCadastroFuncionario.Text = ObjDrDados["cep"].ToString();
                    txtEnderecoCadastroFuncionario.Text = ObjDrDados["endereco"].ToString();
                    cboUFCadastroFuncionario.SelectedValue = ObjDrDados["UF"].ToString();
                    txtNumeroCadastroFuncionario.Text = ObjDrDados["Numero"].ToString();
                    txtComplementoCadastroFuncionario.Text = ObjDrDados["Complemento"].ToString();
                    txtBairroCadastroFuncionario.Text = ObjDrDados["bairro"].ToString();
                    txtCidadeCadastroFuncionario.Text = ObjDrDados["cidade"].ToString();

                    txtUsuario.Text = ObjDrDados["Usuario"].ToString();
                    txtSenha.Text = ClnUtil.Decifrar(ObjDrDados["senha"].ToString());
                }

            }
            lblNomeCadastroFuncionario.Focus();
        }
        private void PreencherUF()
        {
            ClnUtil objClnUtil = new ClnUtil();
            cboUFCadastroFuncionario.DataSource = objClnUtil.PreencherUF();
            cboUFCadastroFuncionario.ValueMember = "UF"; // valor que pode ou não ser guardado
            cboUFCadastroFuncionario.DisplayMember = "UF"; // valor apresentado
            cboUFCadastroFuncionario.SelectedIndex = 23;// Deixar sem valor a combo use -1 ou o 23 é SP
        }

        private void btnGravarCadastroFuncionario_Click(object sender, EventArgs e)
        {
            //valida campos em branco
            if ((txtNomeCadastroFuncionario.Text == "") || (txtCPFCadastroFuncionario.Text == "") ||
                (txtTelefoneCadastroFuncionario.Text == "") || (txtEnderecoCadastroFuncionario.Text == "") ||
               (txtCidadeCadastroFuncionario.Text == "") || (txtBairroCadastroFuncionario.Text == "") ||
               (txtMaskCepCadastroFuncionario.Text == "") || (cboUFCadastroFuncionario.Text == "") ||
                (txtUsuario.Text == "") || (txtSenha.Text == "") ||
                (txtCelularCadastroFuncionario.Text == "") || (txtEmailCadastroFuncionario.Text == ""))
            {
                MessageBox.Show("Os campos com * são Obrigatórios", "item Novo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNomeCadastroFuncionario.Focus();
            }
            else
            {
                ClnFuncionario ObjFuncionario = new ClnFuncionario();
                ObjFuncionario.Bairro = txtBairroCadastroFuncionario.Text;
                ObjFuncionario.Celular = txtCelularCadastroFuncionario.Text;
                ObjFuncionario.Cep = txtMaskCepCadastroFuncionario.Text;
                ObjFuncionario.Cidade = txtCidadeCadastroFuncionario.Text;
                ObjFuncionario.Cpf = txtCPFCadastroFuncionario.Text;
                ObjFuncionario.Email = txtEmailCadastroFuncionario.Text;
                ObjFuncionario.Complemento = txtComplementoCadastroFuncionario.Text;
                ObjFuncionario.Endereco = txtEnderecoCadastroFuncionario.Text;
                ObjFuncionario.Numero = txtNumeroCadastroFuncionario.Text;
                ObjFuncionario.Nome = txtNomeCadastroFuncionario.Text;
                ObjFuncionario.Rg = txtRGCadastroFuncionario.Text;
              //  ObjFuncionario.Genero = lblGeneroCadastroFuncionario.Text;
                ObjFuncionario.Telefone = txtTelefoneCadastroFuncionario.Text;
                ObjFuncionario.UF = cboUFCadastroFuncionario.SelectedValue.ToString();
                ObjFuncionario.Usuario = txtUsuario.Text;
                ObjFuncionario.Senha = txtSenha.Text;

               

                if (rbMasculinoCadastroFuncionario.Checked == true)
                {
                    ObjFuncionario.Genero = "M";
                }
                else if (rbCadastroFuncionario.Checked == true)
                {
                    ObjFuncionario.Genero = "F";
                }

                ObjFuncionario.Gravar();

                if (string.IsNullOrEmpty(txtCod.Text))
                {
                    MessageBox.Show("Registro Inserido com sucesso", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Registro Alteredo com sucesso", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnSairCadastroFuncionario_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtMaskCepCadastroFuncionario_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void txtMaskCep_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ClnUtil ObjClnUtil = new ClnUtil();
                SqlDataReader drDados;
                string cep = txtMaskCepCadastroFuncionario.Text.Replace("-", "");
                drDados = ObjClnUtil.ProcurarCep(cep);

                if (drDados.Read())
                {
                    txtEnderecoCadastroFuncionario.Text = Convert.ToString(drDados["descricção"]);
                    cboUFCadastroFuncionario.Text = Convert.ToString(drDados["UF"]);
                    txtBairroCadastroFuncionario.Text = Convert.ToString(drDados["Bairro"]);
                    txtCidadeCadastroFuncionario.Text = Convert.ToString(drDados["cidade"]);
                    txtNumeroCadastroFuncionario.Focus();
                }
                else
                {
                    MessageBox.Show("cep não encontrado" + txtMaskCepCadastroFuncionario.Text, "cep", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtEnderecoCadastroFuncionario.Text = "";
                    cboUFCadastroFuncionario.Text = "";
                    cboUFCadastroFuncionario.Text = "";
                    txtBairroCadastroFuncionario.Text = "";
                    txtCidadeCadastroFuncionario.Text = "";


                    txtMaskCepCadastroFuncionario.Clear();
                    txtMaskCepCadastroFuncionario.Focus();
                    txtMaskCepCadastroFuncionario.Mask = "00000-999";
                    txtMaskCepCadastroFuncionario.SelectionStart = 0;
                }
            }
        }
    }
}
