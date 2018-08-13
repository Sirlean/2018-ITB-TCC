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
    public partial class BuscaFuncinario : Form
    {
        ClnFuncionario ObjFuncionario = new ClnFuncionario();
        ClnUtil ObjUtil = new ClnUtil();


        public BuscaFuncinario()
        {
            InitializeComponent();
        }

        private void BuscaFuncinario_Load(object sender, EventArgs e)
        {

        }

        private void btnPesquisarBuscaFuncionario_Click(object sender, EventArgs e)
        {
            CarregarDataGrid();
        }

        public void CarregarDataGrid()
        {
            ClnFuncionario ObjFuncionario = new ClnFuncionario();
            string campo_Sql = "cd_Funcionario";

            if (cboTipoPesquisa.SelectedIndex == 0)
            {
                campo_Sql = "cd_Funcionario";
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
            else if (cboTipoPesquisa.SelectedIndex == 4)
            {
                campo_Sql = "Telefone";
            }
            else if (cboTipoPesquisa.SelectedIndex == 5)
            {
                campo_Sql = "Celular";
            }
            DataTable dados = ObjFuncionario.LocalizarPorCampo(txtBuscaFuncionario.Text, campo_Sql);
            if (dados.Rows.Count == 0)
            {
                MessageBox.Show("A pesquisa não retornou dados", "PESQUISA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            //Método Listar que passa o parâmetro do texto digitado para o grid
            dgvBuscaFuncionario.DataSource = dados;
            //Cria os cabeçalhos de cada coluna 
            dgvBuscaFuncionario.Columns[1].HeaderText = ("Código"); //Nome do cabeçalho das colunas 
            dgvBuscaFuncionario.Columns[2].HeaderText = ("Nome");
            dgvBuscaFuncionario.Columns[3].HeaderText = ("Cpf");
            dgvBuscaFuncionario.Columns[4].HeaderText = ("Rg");
            dgvBuscaFuncionario.Columns[5].HeaderText = ("TELEFONE");
            dgvBuscaFuncionario.Columns[6].HeaderText = ("CELULAR");
            dgvBuscaFuncionario.Columns[7].HeaderText = ("E-MAIL");
            dgvBuscaFuncionario.AutoResizeColumns();
        }

        private void btnNovoBuscaFuncionario_Click(object sender, EventArgs e)
        {
            CadastroFuncionario ObjCadastroFuncionario = new CadastroFuncionario();
            ObjCadastroFuncionario.Text = ">>>Novo cadastro<<<";
            ObjCadastroFuncionario.ShowDialog();

            CarregarDataGrid();
        }

        private void btnAlterarBuscaFuncionario_Click(object sender, EventArgs e)
        {
            CadastroFuncionario ObjCadastroFuncionario = new CadastroFuncionario();
            //Alterar o nome na barra de título do frmCompleto:
            ObjCadastroFuncionario.Text = ">>>Alterar<<<";
            //Desativa o texto do código
            ObjCadastroFuncionario.txtCod.Enabled = false;
            //Alterar o texto do botão &Gravar
            //Envia para o campo Código: O valor do codigo marcado no Grid abaixo
            //ObjCadastroCliente.btnGravarCadastroCliente
            ObjCadastroFuncionario.btnGravarCadastroFuncionario.Text = "&Alterar";
            //Código atual
            ObjCadastroFuncionario.txtCod.Text = Convert.ToString(dgvBuscaFuncionario.CurrentRow.Cells[0].Value);
            //objCadastroFornecedor.txtNome.Focus();
            ObjCadastroFuncionario.ShowDialog();
            CarregarDataGrid();

        }

        private void btnExcluirBuscaFuncionario_Click(object sender, EventArgs e)
        {
            CadastroFuncionario ObjCadastroFuncionario = new CadastroFuncionario();

            DialogResult result = MessageBox.Show("Deseja excluir o registro:" + Convert.ToString(dgvBuscaFuncionario.CurrentRow.Cells[0].Value + "?")
          , "Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            //Exclusão Logica, sera "escondido"no BD
            if (DialogResult.Yes == result)
            {
                //Enviar o código
                ObjFuncionario.Codigo = dgvBuscaFuncionario.CurrentRow.Cells[0].Value.ToString();
                //Alterar o estado para não mostar o codigo
                ObjFuncionario.ExcluirLogicamente();
                MessageBox.Show("Registro excluido com sucesso", "Exclusão", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("OPERAÇÃO CANCELADA", "CANCELADA EXCLUSÃO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            //Preencher/ atualizar os dados no grid
            CarregarDataGrid();

        }

        private void btnSairBuscaFuncionario_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dgvBuscaFuncionario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

