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
    public partial class BuscaFornecedor : Form
    {
        public BuscaFornecedor()
        {
            InitializeComponent();
        }

        private void BuscaFornecedor_Load(object sender, EventArgs e)
        {
           
  
        }

        private void LblDescricaoBuscaFornecedor_Click(object sender, EventArgs e)
        {

        }

        private void btnPesquisarBuscaFornecedor_Click(object sender, EventArgs e)
        {
            CarregarDataGrid();

        }

        public void CarregarDataGrid()
        {
            ClnFornecedor objFornecedor = new ClnFornecedor();

            string campo_Sql = "cd_fornecedor";

            if (cboTipoPesquisa.SelectedIndex == 0)
            {
                campo_Sql = "cd_fornecedor";
            }
            else if (cboTipoPesquisa.SelectedIndex == 1)
            {
                campo_Sql = "Cnpj";
            }
            else if (cboTipoPesquisa.SelectedIndex == 2)
            {
                campo_Sql = "NomeFantasia";
            }
            else if (cboTipoPesquisa.SelectedIndex == 3)
            {
                campo_Sql = "RazaoSocial";
            }

            DataTable dados = objFornecedor.LocalizarPorCampo(txtBuscaFornecedor.Text, campo_Sql);
            if (dados.Rows.Count == 0)
            {
                MessageBox.Show("A pesquisa não retornou dados","PESQUISA",MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            //Método Listar que passa o parâmetro do texto digitado para o grid
            dgvBuscaFornecedor.DataSource = dados;
            //Cria os cabeçalhos de cada coluna 
            dgvBuscaFornecedor.Columns[0].HeaderText = ("CÓDICO"); //Nome do cabeçalho das colunas 
            dgvBuscaFornecedor.Columns[1].HeaderText = ("CNPJ");
            dgvBuscaFornecedor.Columns[2].HeaderText = ("NOME FANTASIA");
            dgvBuscaFornecedor.Columns[3].HeaderText = ("RAZÃO SOCIAL");
            dgvBuscaFornecedor.Columns[4].HeaderText = ("TELEFONE");
            dgvBuscaFornecedor.Columns[5].HeaderText = ("CELULAR");
            dgvBuscaFornecedor.Columns[6].HeaderText = ("E-MAIL");
            dgvBuscaFornecedor.AutoResizeColumns();
        }

        private void btnNovoBuscaFornecedor_Click(object sender, EventArgs e)
        {
            CadastroFornecedor objCadastroFornecedor = new CadastroFornecedor();
            objCadastroFornecedor.Text = ">>>Novo cadastro<<<";
            objCadastroFornecedor.ShowDialog();

            CarregarDataGrid();
        }

        private void btnSairBuscaFornecedor_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAlterarBuscaFornecedor_Click(object sender, EventArgs e)
        {
            CadastroFornecedor objCadastroFornecedor = new CadastroFornecedor();
            //Cria objeto do formulário frmCompleto
            

            //Alterar o nome na barra de título do frmCompleto:
            objCadastroFornecedor.Text = ">>>Alterar<<<";
            //Desativa o texto do código
            objCadastroFornecedor.txtCod.Enabled = false;
            //Alterar o texto do botão &Gravar
            //Envia para o campo Código: O valor do codigo marcado no Grid abaixo
            objCadastroFornecedor.btnGravarCadastroFornecedor.Text = "&Alterar";
            //Código atual
            objCadastroFornecedor.txtCod.Text = Convert.ToString(dgvBuscaFornecedor.CurrentRow.Cells[0].Value);
            //objCadastroFornecedor.txtNome.Focus();
            objCadastroFornecedor.ShowDialog();
            CarregarDataGrid();
        }

        private void cboTipoPesquisa_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnExcluirBuscaFornecedor_Click(object sender, EventArgs e)
        {
            ClnFornecedor objFornecedor = new ClnFornecedor();
            

            DialogResult result = MessageBox.Show("Deseja excluir o registro:" + Convert.ToString(dgvBuscaFornecedor.CurrentRow.Cells[0].Value + "?")
          , "Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            //Exclusão Logica, sera "escondido"no BD
            if (DialogResult.Yes == result)
            {
                //Enviar o código
                objFornecedor.Codigo = dgvBuscaFornecedor.CurrentRow.Cells[0].Value.ToString();
                //Alterar o estado para não mostar o codigo
                objFornecedor.ExcluirLogicamente();
                MessageBox.Show("Registro excluido com sucesso", "Exclusão", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("OPERAÇÃO CANCELADA", "CANCELADA EXCLUSÃO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            //Preencher/ atualizar os dados no grid
            CarregarDataGrid();
        }
    }
}
