using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Itb.Tcc.LojaJogos
{
    public partial class CadastroFornecedor : Form
    {




        public CadastroFornecedor()
        {
            InitializeComponent();
        }



        private void btnGravarCadastroFornecedor_Click(object sender, EventArgs e)
        {
            //valida campos em branco
            if ((txtFantasiaCadastroFornecedor.Text == "") || (txtRazaoCadastroFornecedor.Text == "") ||
                (txtTelefoneCadastroFornecedor.Text == "") || (txtEnderecoCadastroFornecedor.Text == "") ||
               (txtCidadeCadastroFornecedor.Text == "") || (txtBairroCadastroFornecedor.Text == "") ||
               (txtMaskCepCadastroFornecedor.Text == "") || (cboUFCadastroFornecedor.Text == "") ||
                (txtCelularCadastroFornecedor.Text == "") || (txtCNPJCadastroFornecedor.Text == ""))
            {
                MessageBox.Show("Os campos com * são Obrigatórios", "item Novo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtFantasiaCadastroFornecedor.Focus();
            }
            else
            {


                ClnFornecedor objFornecedor = new ClnFornecedor();
                objFornecedor.Bairro = txtBairroCadastroFornecedor.Text;
                objFornecedor.Celular = txtCelularCadastroFornecedor.Text;
                objFornecedor.Cep = txtMaskCepCadastroFornecedor.Text;
                objFornecedor.Cidade = txtCidadeCadastroFornecedor.Text;
                objFornecedor.Cnpj = txtCNPJCadastroFornecedor.Text;
                objFornecedor.Email = txtEmailCadastroFornecedor.Text;
                objFornecedor.EndComplemento = txtComplementoCadastroFornecedor.Text;
                objFornecedor.Endereco = txtEnderecoCadastroFornecedor.Text;
                objFornecedor.EndNumero = txtNumeroCadastroFornecedor.Text;
                objFornecedor.NomeFantasia = txtFantasiaCadastroFornecedor.Text;
                objFornecedor.RazaoSocial = txtRazaoCadastroFornecedor.Text;
                objFornecedor.Telefone = txtTelefoneCadastroFornecedor.Text;
                objFornecedor.UF = cboUFCadastroFornecedor.SelectedValue.ToString();

                //if (string.IsNullOrEmpty(txtCod.Text))// ira devolver se for nulo ou vazio
                //{
                //    //Item novo
                //    objFornecedor.Inserir();

                //}
                //else
                //{
                //    //alterar item
                //    objFornecedor.Cd_Fornecedor = Convert.ToInt32(txtCod.Text);
                //    objFornecedor.Atualizar();

                //}
                objFornecedor.Gravar();

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

        private void btnSairCadastroFornecedor_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CadastroFornecedor_Load(object sender, EventArgs e)
        {


            // Ao Carregar o formulário
            cboUFCadastroFornecedor.DropDownStyle = ComboBoxStyle.DropDownList; // alterar o tipo da combo para somente a lista
            PreencherUF();
            lblUfCadastroFornecedor.Focus();
            if (txtCod.Text != "") // Se não há código no textbox código então não preenche
            {
                ClnFornecedor objClnFornecedor = new ClnFornecedor();
                SqlDataReader ObjDrDados;
                ObjDrDados = objClnFornecedor.localizarCodigo(txtCod.Text);
                if (ObjDrDados.Read())
                {
                    txtRazaoCadastroFornecedor.Text = ObjDrDados["RazaoSocial"].ToString();
                    txtCNPJCadastroFornecedor.Text = ObjDrDados["CNPJ"].ToString();
                    txtFantasiaCadastroFornecedor.Text = ObjDrDados["NomeFantasia"].ToString();
                    txtTelefoneCadastroFornecedor.Text = ObjDrDados["Telefone"].ToString();
                    txtCelularCadastroFornecedor.Text = ObjDrDados["Celular"].ToString();
                    txtEmailCadastroFornecedor.Text = ObjDrDados["email"].ToString();
                    txtMaskCepCadastroFornecedor.Text = ObjDrDados["cep"].ToString();
                    txtEnderecoCadastroFornecedor.Text = ObjDrDados["endereco"].ToString();
                    cboUFCadastroFornecedor.SelectedValue = ObjDrDados["UF"].ToString();
                    txtNumeroCadastroFornecedor.Text = ObjDrDados["EndNumero"].ToString();
                    txtComplementoCadastroFornecedor.Text = ObjDrDados["EndComplemento"].ToString();
                    txtBairroCadastroFornecedor.Text = ObjDrDados["bairro"].ToString();
                    txtCidadeCadastroFornecedor.Text = ObjDrDados["cidade"].ToString();
                }

            }
            lblNomeCadastroFornecedor.Focus();


        }

        public void PreencherUF()
        {
            ClnUtil objClnUtil = new ClnUtil();
            cboUFCadastroFornecedor.DataSource = objClnUtil.PreencherUF();
            cboUFCadastroFornecedor.ValueMember = "UF"; // valor que pode ou não ser guardado
            cboUFCadastroFornecedor.DisplayMember = "UF"; // valor apresentado
            cboUFCadastroFornecedor.SelectedIndex = 23;// Deixar sem valor a combo use -1 ou o 23 é SP
        }
        //=================================================================================
        // BOTÃO SAIR
        private void txtMaskCep_keyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ClnUtil ObjClnUtil = new ClnUtil();
                SqlDataReader drDados;
                string cep = txtMaskCepCadastroFornecedor.Text.Replace("-", "");
                drDados = ObjClnUtil.ProcurarCep(cep);

                if (drDados.Read())
                {
                    txtEnderecoCadastroFornecedor.Text = Convert.ToString(drDados["descricção"]);
                    cboUFCadastroFornecedor.Text = Convert.ToString(drDados["UF"]);
                    txtBairroCadastroFornecedor.Text = Convert.ToString(drDados["Bairro"]);
                    txtCidadeCadastroFornecedor.Text = Convert.ToString(drDados["cidade"]);
                    txtNumeroCadastroFornecedor.Focus();
                }
                else
                {
                    MessageBox.Show("cep não encontrado" + txtMaskCepCadastroFornecedor.Text, "cep", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtEnderecoCadastroFornecedor.Text = "";
                    cboUFCadastroFornecedor.Text = "";
                    cboUFCadastroFornecedor.Text = "";
                    txtBairroCadastroFornecedor.Text = "";
                    txtCidadeCadastroFornecedor.Text = "";


                    txtMaskCepCadastroFornecedor.Clear();
                    txtMaskCepCadastroFornecedor.Focus();
                    txtMaskCepCadastroFornecedor.Mask = "00000-999";
                    txtMaskCepCadastroFornecedor.SelectionStart = 0;
                }

            }
        }
    }

}
