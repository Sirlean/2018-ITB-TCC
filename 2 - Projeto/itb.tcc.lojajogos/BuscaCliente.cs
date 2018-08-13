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
    public partial class BuscaCliente : Form


    {
        ClnCliente ObjCliente = new ClnCliente();
        ClnUtil ObjUtil = new ClnUtil();

        private object buscaCliente;
        private object dados;

        public BuscaCliente()
        {
            InitializeComponent();
        }

        public void CarregarDataGrid()
        {
            ClnCliente ObjCliente = new ClnCliente();

            string campo_Sql = "cd_cliente";

            if (cboTipoPesquisa.SelectedIndex == 0)
            {
                campo_Sql = "cd_cliente";
            }
            else if (cboTipoPesquisa.SelectedIndex == 1)
            {
                campo_Sql = "Nome";
            }
            else if (cboTipoPesquisa.SelectedIndex == 2)
            {
                campo_Sql = "Cpf";
            }
            else if (cboTipoPesquisa.SelectedIndex == 3)
            {
                campo_Sql = "Rg";
            }
            else if (cboTipoPesquisa.SelectedIndex == 3)
            {
                campo_Sql = "Telefone";
            }
            else if (cboTipoPesquisa.SelectedIndex == 3)
            {
                campo_Sql = "Celular";
            }
            DataTable dados = ObjCliente.LocalizarPorCampo(txtBuscaCliente.Text, campo_Sql);
            if (dados.Rows.Count == 0)
            {
                MessageBox.Show("A pesquisa não retornou dados", "PESQUISA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }


            //Método Listar que passa o parâmetro do texto digitado para o grid
            dgvBuscaCliente.DataSource = dados;
            //Cria os cabeçalhos de cada coluna 
            dgvBuscaCliente.Columns[1].HeaderText = ("Código"); //Nome do cabeçalho das colunas 
            dgvBuscaCliente.Columns[2].HeaderText = ("Nome");
            dgvBuscaCliente.Columns[3].HeaderText = ("Cpf");
            dgvBuscaCliente.Columns[4].HeaderText = ("Rg");
            dgvBuscaCliente.Columns[5].HeaderText = ("TELEFONE");
            dgvBuscaCliente.Columns[6].HeaderText = ("CELULAR");
            dgvBuscaCliente.Columns[7].HeaderText = ("E-MAIL");
            dgvBuscaCliente.AutoResizeColumns();
        }
        private void cboTipoPesquisa_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnNovoBuscaCliente_Click(object sender, EventArgs e)
        {
            CadastroCliente ObjCadastroCliente = new CadastroCliente();
            ObjCadastroCliente.Text = ">>>Novo cadastro<<<";
            ObjCadastroCliente.ShowDialog();

            CarregarDataGrid();
        }
        private void btnAlterarBuscaCliente_Click_1(object sender, EventArgs e)
        {
            CadastroCliente ObjCadastroCliente = new CadastroCliente();
            //Cria objeto do formulário frmCompleto


            //Alterar o nome na barra de título do frmCompleto:
            ObjCadastroCliente.Text = ">>>Alterar<<<";
            //Desativa o texto do código
            ObjCadastroCliente.txtCod.Enabled = false;
            //Alterar o texto do botão &Gravar
            //Envia para o campo Código: O valor do codigo marcado no Grid abaixo
           //ObjCadastroCliente.btnGravarCadastroCliente
            ObjCadastroCliente.btnGravarCadastroCliente.Text = "&Alterar";
            //Código atual
            ObjCadastroCliente.txtCod.Text = Convert.ToString(dgvBuscaCliente.CurrentRow.Cells[0].Value);
            //objCadastroFornecedor.txtNome.Focus();
            ObjCadastroCliente.ShowDialog();
            CarregarDataGrid();
        }

        private void btnExcluirBuscaCliente_Click(object sender, EventArgs e)
        {
            ClnCliente ObjCliente = new ClnCliente();


            DialogResult result = MessageBox.Show("Deseja excluir o registro:" + Convert.ToString(dgvBuscaCliente.CurrentRow.Cells[0].Value + "?")
          , "Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            //Exclusão Logica, sera "escondido"no BD
            if (DialogResult.Yes == result)
            {
                //Enviar o código
                ObjCliente.Codigo = dgvBuscaCliente.CurrentRow.Cells[0].Value.ToString();
                //Alterar o estado para não mostar o codigo
                ObjCliente.ExcluirLogicamente();
                MessageBox.Show("Registro excluido com sucesso", "Exclusão", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("OPERAÇÃO CANCELADA", "CANCELADA EXCLUSÃO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            //Preencher/ atualizar os dados no grid
            CarregarDataGrid();
        }
        private void BuscaCliente_Load(object sender, EventArgs e)
        {

        }

        private void btnSairBuscaCliente_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnPesquisarBuscaCliente_Click_1(object sender, EventArgs e)
        {
            // CadastroCliente ObjCadastroCliente = new CadastroCliente();
            //ObjCadastroCliente.ShowDialog();
            CarregarDataGrid();
        }

        private void dgvBuscaCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

