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
    public partial class frmCompleto : Form
    {

        public frmCompleto()
        {
            InitializeComponent();

        }

        private void frmCompleto_Load(object sender, EventArgs e)
        {
            // Ao Carregar o formulário
            //cboUFCadastroCliente.DropDownStyle = ComboBoxStyle.DropDownList; // alterar o tipo da combo para somente a lista
            //PreencherUF();
            //lblNomeCadastroCliente.Focus();
            //if (LblCod.Text != "") // Se não há código no textbox código então não preenche
            //{
            //    ClnAgenda objClnAgenda = new ClnAgenda();
            //    SqlDataReader ObjDrDados;
            //    ObjDrDados = objClnAgenda.localizarCodigo(LblCod.Text);
            //    if (ObjDrDados.Read())
            //    {
            //        lblNomeCadastroCliente.Text = ObjDrDados["nome"].ToString();
            //        lblTelefoneCadastroFornecedor.Text = ObjDrDados["tel"].ToString();
            //        txtMaskCepCadastroFornecedor.Text = ObjDrDados["cep"].ToString();
            //        lblEnderecoCadastroCliente.Text = ObjDrDados["endereco"].ToString();
            //        lblUfCadastroFornecedor.Text = ObjDrDados["UF"].ToString();
            //        lblNumeroCadastroCliente.Text = ObjDrDados["nº"].ToString();
            //        LblBairro.Text = ObjDrDados["bairro"].ToString();
            //        LblCidade.Text = ObjDrDados["cidade"].ToString();
            //    }

            //}
            //lblNomeCadastroCliente.Focus();
        }

        public void PreencherUF()
        {
            ClnUtil objClnUtil = new ClnUtil();
            cboUFCadastroCliente.DataSource = objClnUtil.PreencherUF();
            cboUFCadastroCliente.ValueMember = "UF"; // valor que pode ou não ser guardado
            cboUFCadastroCliente.DisplayMember = "UF"; // valor apresentado
            cboUFCadastroCliente.SelectedIndex = 23;// Deixar sem valor a combo use -1 ou o 23 é SP
        }
        //=================================================================================
        // BOTÃO SAIR
        private void btnSair_Click(object sender, EventArgs e)
        { Close(); }


        private void txtMaskCep_keyDown(object sender, KeyEventArgs e)
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
                    txtBairro.Text = Convert.ToString(drDados["Bairro"]);
                    txtCidade.Text = Convert.ToString(drDados["cidade"]);
                    txtNumeroCadastroCliente.Focus();
                }
                else
                {
                    MessageBox.Show("cep não encontrado" + txtMaskCepCadastroCliente.Text, "cep", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtEnderecoCadastroCliente.Text = "";
                    cboUFCadastroCliente.Text = "";
                    cboUFCadastroCliente.Text = "";
                    txtBairro.Text = "";
                    txtCidade.Text = "";

                    txtMaskCepCadastroCliente.Clear();
                    txtMaskCepCadastroCliente.Focus();
                    txtMaskCepCadastroCliente.Mask = "00000-999";
                    txtMaskCepCadastroCliente.SelectionStart = 0;
                }
            }
        }

        private void txtMaskCepCadastroCliente_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
