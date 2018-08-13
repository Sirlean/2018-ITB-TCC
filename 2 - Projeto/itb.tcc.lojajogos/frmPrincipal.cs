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
    public partial class frmPrincipal : Form
    {
        ClnAgenda objAgenda = new ClnAgenda();
        ClnUtil objClnUtil = new ClnUtil();

        public frmPrincipal()
        {
            InitializeComponent();
        }
        private void btnNovo_Click(object sender, EventArgs e)
        {
            //Cria objeto do outro frmulário
            frmCompleto ObjCadastroAgenda = new frmCompleto();

            //Alterar as propriedades do outro form:
            ObjCadastroAgenda.Text = ">>>Novo cadastro<<<";
            ObjCadastroAgenda.txtCod.Enabled = false;

            //Apresenta o formulário
            ObjCadastroAgenda.ShowDialog();
            //No fechamento do frmCompleto:preencher a grid
            CarregaDataGrid();
        }
        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            //chama o metodo preencher a grid
            CarregaDataGrid();
        }

        public void CarregaDataGrid()
        {
            //Método Listar que passa o parâmetro do texto digitado para o grid
            dgv.DataSource = objAgenda.LocalizarPorNome(LblDescricao.Text);
            //Cria os cabeçalhos de cada coluna 
            dgv.Columns[0].HeaderText = ("CÓDICO"); //Nome do cabeçalho das colunas 
            dgv.Columns[1].HeaderText = ("CLIENTE");
            dgv.Columns[2].HeaderText = ("CONTATO");
            dgv.AutoResizeColumns();

            if (dgv.RowCount == 0)
            {
                // Se não houver dados no DGV, os botões serão desativados
                btnRelatorio.Enabled = false; //Desativar os botões
                btnConsultar.Enabled = false;
                btnAlterar.Enabled = false;
                btnExcluir.Enabled = false;
                MessageBox.Show("Não foram encontrados dados com informação: " + LblDescricao.Text, "Verificar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgv.DataSource = null; //limpa o cabeçalho
                LblDescricao.Text = "";
                LblDescricao.Focus();

            }
            else
            {
                btnRelatorio.Enabled = true;
                btnConsultar.Enabled = true;
                btnAlterar.Enabled = true;
                btnExcluir.Enabled = true;
            }

        }
        // Preencher Form_Load
        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            btnRelatorio.Enabled = false;
            btnConsultar.Enabled = false;
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
            dgv.RowHeadersVisible = false;
        }
        //========================================================
        //private void btnSair_click(object sender, EventArgs e)
        private void btnSair_Click_1(object sender, EventArgs e)
        { Close(); }



        //private void btnConsultar_Click(object sender, EventArgs e)
        //Preencher o botão consultar
        private void btnConsultar_Click_1(object sender, EventArgs e)
        {
            frmCompleto ObjCadastroAgenda = new frmCompleto();
            ObjCadastroAgenda.Text = ">>> Consultar<<<";
            ObjCadastroAgenda.btnGravar.Visible = false;
            ObjCadastroAgenda.txtBairro.Enabled = false;
            ObjCadastroAgenda.txtCidade.Enabled = false;
            ObjCadastroAgenda.txtEnderecoCadastroCliente.Enabled = false;
            ObjCadastroAgenda.txtMaskCepCadastroCliente.Enabled = false;
            ObjCadastroAgenda.txtNomeCadastroCliente.Enabled = false;
            ObjCadastroAgenda.txtNumeroCadastroCliente.Enabled = false;
            ObjCadastroAgenda.txtTelefoneCadastroCliente.Enabled = false;
            ObjCadastroAgenda.cboUFCadastroCliente.Enabled = false;

            //================================================
            ObjCadastroAgenda.cboUFCadastroCliente.DropDownStyle = ComboBoxStyle.DropDownList;
            ObjCadastroAgenda.txtCod.Enabled = false;
            ObjCadastroAgenda.ShowDialog();
            CarregaDataGrid();


        }




        private void btnAlterar_Click(object sender, EventArgs e)
        {
            //Cria objeto do formulário frmCompleto
            frmCompleto ObjCadastroAgenda = new frmCompleto();

            //Alterar o nome na barra de título do frmCompleto:
            ObjCadastroAgenda.Text = ">>>Alterar<<<";
            //Desativa o texto do código
            ObjCadastroAgenda.txtCod.Enabled = false;
            //Alterar o texto do botão &Gravar
            //Envia para o campo Código: O valor do codigo marcado no Grid abaixo
            ObjCadastroAgenda.btnGravar.Text = "&Alterar";
            //Código atual
            ObjCadastroAgenda.txtCod.Text = Convert.ToString(dgv.CurrentRow.Cells[0].Value);
            ObjCadastroAgenda.txtNomeCadastroCliente.Focus();
            ObjCadastroAgenda.ShowDialog();
            CarregaDataGrid();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Deseja excluir o registro:" + Convert.ToString(dgv.CurrentRow.Cells[0].Value + "?")
           , "Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            //Exclusão Logica, sera "escondido"no BD
            if (DialogResult.Yes == result)
            {
                //Enviar o código
                objAgenda.Cod = dgv.CurrentRow.Cells[0].Value.ToString();
                //Alterar o estado para não mostar o codigo
                objAgenda.ExcluirLogicamente();
                MessageBox.Show("Registro excluido com sucesso", "Exclusão", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("OPERAÇÃO CANCELADA", "CANCELADA EXCLUSÃO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            //Preencher/ atualizar os dados no grid
            CarregaDataGrid();
        }

        private void txtDescricao_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }

}

//frmCompleto ObjCadastroAgenda = new frmCompleto();
//ObjCadastroAgenda.Text = ">>> Consultar<<<";
//ObjCadastroAgenda.btnGravar.Visible = false;
//ObjCadastroAgenda.txtBairro.Enabled = false;
//ObjCadastroAgenda.txtCidade.Enabled = false;
//ObjCadastroAgenda.txtEnd.Enabled = false;
//ObjCadastroAgenda.txtMaskCep.Enabled = false;
//ObjCadastroAgenda.txtNome.Enabled = false;
//ObjCadastroAgenda.txtNum.Enabled = false;
//ObjCadastroAgenda.txtTel.Enabled = false;
//ObjCadastroAgenda.cboUF.Enabled = false;

//================================================
//ObjCadastroAgenda.cboUF.DropDownStyle = ComboBoxStyle.DropDownList;
//ObjCadastroAgenda.txtCod.Enabled = false;
//ObjCadastroAgenda.ShowDialog();
//CarregaDataGrid();