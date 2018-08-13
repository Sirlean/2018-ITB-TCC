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
    public partial class BuscaProduto : Form
       
    {
      ClnProduto ObjProduto = new ClnProduto();
        ClnUtil ObjUtil = new ClnUtil();
       
        

        public BuscaProduto()
        {
            InitializeComponent();
        }

        private void BuscaProduto_Load(object sender, EventArgs e)
        {

        }

        private void btnPesquisarBuscaProduto_Click(object sender, EventArgs e)
        {
            //chama o metodo preencher a grid
            CarregarDataGrid();

        }

        private void CarregarDataGrid()
        {
            string campo_Sql = "nome";

            if (cboTipoPesquisa.SelectedIndex == 0)
            {
                campo_Sql = "codigo";
            }
            else if (cboTipoPesquisa.SelectedIndex == 1)
            {  
                campo_Sql = "tipo";
            }
            else if (cboTipoPesquisa.SelectedIndex == 2)
            { campo_Sql = "nome";
            }
            else if (cboTipoPesquisa.SelectedIndex == 3)
            {
                campo_Sql = "faixaEtaria";
            }
            else if (cboTipoPesquisa.SelectedIndex == 4)
            {
                campo_Sql = "fornecedor";
            }
            else if (cboTipoPesquisa.SelectedIndex == 5)
            {
                campo_Sql = "genero";
            }

            //Método Listar que passa o parâmetro do texto digitado para o grid
            dgvBuscaProduto.DataSource = ObjProduto.PesquisarPorTipo(txtDescricaoBuscaProduto.Text, campo_Sql);
            //Cria os cabeçalhos de cada coluna 
            dgvBuscaProduto.Columns[0].HeaderText = ("CODIGO"); //Nome do cabeçalho das colunas 
            dgvBuscaProduto.Columns[1].HeaderText = ("TIPO"); //Nome do cabeçalho das colunas 
            dgvBuscaProduto.Columns[2].HeaderText = ("NOME");
            dgvBuscaProduto.Columns[3].HeaderText = ("GÊNERO");
            dgvBuscaProduto.Columns[4].HeaderText = ("FAIXA ETÁRIA");
            dgvBuscaProduto.Columns[5].HeaderText = ("FORNECEDOR");
            //dgvBuscaProduto.Columns[6].HeaderText = ("FABRICANTE");

            dgvBuscaProduto.AutoResizeColumns();
        }

        private void btnNovoBuscaProduto_Click(object sender, EventArgs e)
        {
            CadastroProduto objCadastroProduto = new CadastroProduto();
            objCadastroProduto.Text = ">>>Novo cadastro<<<";
            objCadastroProduto.ShowDialog();
            CarregarDataGrid();


            ////Cria objeto do outro frmulário
            //BuscaProduto  ObjCadastroDeProduto = new BuscaProduto();

            ////Alterar as propriedades do outro form:

            //objCadastroProduto.txtCod.Enabled = false;

            ////Apresenta o formulário
            objCadastroProduto.ShowDialog();
            ////No fechamento do frmCompleto:preencher a grid
            
        }

        private void btnConsultarBuscaProduto_Click(object sender, EventArgs e)
        {

            //BuscaProduto ObjCadastroDeProduto = new BuscaProduto();
            //ObjCadastroDeProduto.Text = ">>> Consultar<<<";
            //ObjCadastroDeProduto.btnGravar.Visible = false;
            //ObjCadastroDeProduto.txtTipoCadastrodeProduto.Enabled = false;
            //ObjCadastroDeProduto.txtNomeCadastrodeProduto.Enabled = false;
            //ObjCadastroDeProduto.txtGeneroCadastrodeProduto.Enabled = false;
            //ObjCadastroDeProduto.txtMaskCepCadastroFornecedor.Enabled = false;
            //ObjCadastroDeProduto.txtNomeCadastroCliente.Enabled = false;
            //ObjCadastroDeProduto.txtNumeroCadastroFornecedor.Enabled = false;
            //ObjCadastroDeProduto.txtTelefoneCadastroFornecedor.Enabled = false;
            //ObjCadastroDeProduto.cboUFCadastroCliente.Enabled = false;

            ////================================================
            //ObjCadastroAgenda.cboUFCadastroCliente.DropDownStyle = ComboBoxStyle.DropDownList;
            //ObjCadastroAgenda.txtCod.Enabled = false;
            //ObjCadastroAgenda.ShowDialog();
            //CarregaDataGrid();
        }

        private void btnAlterarBuscaProduto_Click(object sender, EventArgs e)
        {


            //Cria objeto do formulário frmCompleto
            CadastroProduto ObjCadastroProduto = new CadastroProduto();

            //Alterar o nome na barra de título do frmCompleto:
            ObjCadastroProduto.Text = ">>>Alterar<<<";
            //Desativa o texto do código
            ObjCadastroProduto.txtCod.Enabled = false;
            //Alterar o texto do botão &Gravar
            //Envia para o campo Código: O valor do codigo marcado no Grid abaixo
            ObjCadastroProduto.btnGravarCadastroProduto.Text = "&Alterar";
            //Código atual
            ObjCadastroProduto.txtCod.Text = Convert.ToString(dgvBuscaProduto.CurrentRow.Cells[0].Value);
            //ObjCadastroProduto.txtNomeCadastroProduto.Focus();
            ObjCadastroProduto.ShowDialog();
            CarregarDataGrid();
        }
        
        private void btnExcluirBuscaProduto_Click(object sender, EventArgs e)
        {
            ClnProduto objFornecedor = new ClnProduto();


            DialogResult result = MessageBox.Show("Deseja excluir o registro:" + Convert.ToString(dgvBuscaProduto.CurrentRow.Cells[0].Value + "?")
          , "Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            //Exclusão Logica, sera "escondido"no BD
            if (DialogResult.Yes == result)
            {
                //Enviar o código
                objFornecedor.Codigo = dgvBuscaProduto.CurrentRow.Cells[0].Value.ToString();
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
