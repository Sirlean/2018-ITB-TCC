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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void clienteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            BuscaCliente objBuscaCliente = new BuscaCliente();
            objBuscaCliente.ShowDialog();
        }

        private void fornecedorToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            BuscaFornecedor objBuscaFornecedor = new BuscaFornecedor();
            objBuscaFornecedor.ShowDialog();
        }

        private void produtoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            BuscaProduto objBuscaProduto = new BuscaProduto();
            objBuscaProduto.ShowDialog();
        }

        private void clienteToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            
        }

        private void fornecedorToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            CadastroFuncionario objCadastroFuncionario = new CadastroFuncionario();
            objCadastroFuncionario.ShowDialog();
        }

        private void produtoToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            CadastroProduto objCadastroDeProduto = new CadastroProduto();
            objCadastroDeProduto.ShowDialog();
        }

        private void ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmCompleto objfrmCompleto = new frmCompleto();
            objfrmCompleto.ShowDialog();
        }

        private void fornecedorToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            CadastroFornecedor objCadastroFornecedor = new CadastroFornecedor();
           objCadastroFornecedor.ShowDialog();
        }

        private void menuDeVendasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenuVendas objMenuVendas = new MenuVendas();
            objMenuVendas.ShowDialog();
        }
    }
}
