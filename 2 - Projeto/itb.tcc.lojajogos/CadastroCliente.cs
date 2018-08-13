using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Itb.Tcc.LojaJogos
{
    public partial class CadastroCliente : Form
    {
        public CadastroCliente()
        {
            InitializeComponent();
        }

        private void CadastroCliente_Load(object sender, EventArgs e)
        {
            // Ao Carregar o formulário
            cboUFCadastroCliente.DropDownStyle = ComboBoxStyle.DropDownList; // alterar o tipo da combo para somente a lista
            PreencherUF();
            txtCod.Enabled = false;
            lblUfCadastroCliente.Focus();
            if (txtCod.Text != "") // Se não há código no textbox código então não preenche
            {
                ClnCliente ObjCliente = new ClnCliente();
                SqlDataReader ObjDrDados;
                ObjDrDados = ObjCliente.localizarCodigo(txtCod.Text);
                if (ObjDrDados.Read())
                {
                    txtNomeCadastroCliente.Text = ObjDrDados["Nome"].ToString();
                    txtCPFCadastroCliente.Text = ObjDrDados["Cpf"].ToString();
                    txtRGCadastroCliente.Text = ObjDrDados["Rg"].ToString();
                    txtTelefoneCadastroCliente.Text = ObjDrDados["Telefone"].ToString();
                    txtCelularCadastroCliente.Text = ObjDrDados["Celular"].ToString();
                    txtEmailCadastroCliente.Text = ObjDrDados["email"].ToString();
                    txtMaskCepCadastroCliente.Text = ObjDrDados["cep"].ToString();
                    txtEnderecoCadastroCliente.Text = ObjDrDados["endereco"].ToString();
                    cboUFCadastroCliente.SelectedValue = ObjDrDados["UF"].ToString();
                    txtNumeroCadastroCliente.Text = ObjDrDados["Numero"].ToString();
                    txtComplementoCadastroCliente.Text = ObjDrDados["Complemento"].ToString();
                    txtBairroCadastroCliente.Text = ObjDrDados["bairro"].ToString();
                    txtCidadeCadastroCliente.Text = ObjDrDados["cidade"].ToString();
                }

            }
            lblNomeCadastroCliente.Focus();
        }

        private void PreencherUF()
        {
            ClnUtil objClnUtil = new ClnUtil();
            cboUFCadastroCliente.DataSource = objClnUtil.PreencherUF();
            cboUFCadastroCliente.ValueMember = "UF"; // valor que pode ou não ser guardado
            cboUFCadastroCliente.DisplayMember = "UF"; // valor apresentado
            cboUFCadastroCliente.SelectedIndex = 23;// Deixar sem valor a combo use -1 ou o 23 é SP
        }

        private void btnGravarCadastroCliente_Click(object sender, EventArgs e)
        {
            //valida campos em branco
            if ((txtNomeCadastroCliente.Text == "") || (txtCPFCadastroCliente.Text == "") ||
                (txtTelefoneCadastroCliente.Text == "") || (txtEnderecoCadastroCliente.Text == "") ||
               (txtCidadeCadastroCliente.Text == "") || (txtBairroCadastroCliente.Text == "") ||
               (txtMaskCepCadastroCliente.Text == "") || (cboUFCadastroCliente.Text == "") ||
                (txtCelularCadastroCliente.Text == "") || (txtEmailCadastroCliente.Text == ""))
            {
                MessageBox.Show("Os campos com * são Obrigatórios", "item Novo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNomeCadastroCliente.Focus();
            }
            else
            {


                ClnCliente ObjCliente = new ClnCliente();
                ObjCliente.Codigo = txtCod.Text;
                ObjCliente.Bairro = txtBairroCadastroCliente.Text;
                ObjCliente.Celular = txtCelularCadastroCliente.Text;
                ObjCliente.Cep = txtMaskCepCadastroCliente.Text;
                ObjCliente.Cidade = txtCidadeCadastroCliente.Text;
                ObjCliente.Cpf = txtCPFCadastroCliente.Text;
                ObjCliente.Email = txtEmailCadastroCliente.Text;
                ObjCliente.Complemento = txtComplementoCadastroCliente.Text;
                ObjCliente.Endereco = txtEnderecoCadastroCliente.Text;
                ObjCliente.Numero = txtNumeroCadastroCliente.Text;
                ObjCliente.Nome = txtNomeCadastroCliente.Text;
                ObjCliente.Rg = txtRGCadastroCliente.Text;
               
                ObjCliente.Telefone = txtTelefoneCadastroCliente.Text;
                ObjCliente.UF = cboUFCadastroCliente.SelectedValue.ToString();
                if (rbMasculino.Checked==true)
                {
                    ObjCliente.Genero = "M";
                }
               else if (rbFeminino.Checked == true)
                {
                    ObjCliente.Genero = "F";
                }

                ObjCliente.Gravar();

                /// else

                //    //alterar item
                ///ObjCliente.cd_Cliente = Convert.ToInt32(txtCod.Text);
                // ObjCliente.Atualizar();

                //}
                /// ObjCliente.Gravar();

                if (txtCod.Text == "")
                {
                    MessageBox.Show("Registro Inserido com sucesso", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Registro Alteredo com sucesso", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtMaskCepCadastroCliente_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void txtMasckCep_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ClnUtil ObjClnUtil = new ClnUtil();
                SqlDataReader drDados;
                string cep = txtMaskCepCadastroCliente.Text.Replace("-", "");
                drDados = ObjClnUtil.ProcurarCep(cep);

                if (drDados.Read())
                {
                    txtEnderecoCadastroCliente.Text = Convert.ToString(drDados["descricção"]);
                    cboUFCadastroCliente.Text = Convert.ToString(drDados["UF"]);
                    txtBairroCadastroCliente.Text = Convert.ToString(drDados["Bairro"]);
                    txtCidadeCadastroCliente.Text = Convert.ToString(drDados["cidade"]);
                    txtNumeroCadastroCliente.Focus();
                }
                else
                {
                    MessageBox.Show("cep não encontrado" + txtMaskCepCadastroCliente.Text, "cep", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtEnderecoCadastroCliente.Text = "";
                    cboUFCadastroCliente.Text = "";
                    cboUFCadastroCliente.Text = "";
                    txtBairroCadastroCliente.Text = "";
                    txtCidadeCadastroCliente.Text = "";


                    txtMaskCepCadastroCliente.Clear();
                    txtMaskCepCadastroCliente.Focus();
                    txtMaskCepCadastroCliente.Mask = "00000-999";
                    txtMaskCepCadastroCliente.SelectionStart = 0;
                }
            }
        }

        private void txtComplementoCadastroCliente_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
