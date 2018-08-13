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
    public partial class CadastroProduto : Form
    {
        public CadastroProduto()
        {
            InitializeComponent();
        }

        private void CadastroDeProduto_Load(object sender, EventArgs e)
        {
            ClnUtil clnUtil = new ClnUtil();
            cboFaixaEtariaCadastroProduto.ValueMember = "cd_FaixaEtaria";
            cboFaixaEtariaCadastroProduto.DisplayMember = "ds_FaixaEtaria";
            cboFaixaEtariaCadastroProduto.DataSource = clnUtil.PreencherFaixaEtaria();

            cboFabricanteCadastroProduto.ValueMember = "cd_Fabricante";
            cboFabricanteCadastroProduto.DisplayMember = "ds_Fabricante";
            cboFabricanteCadastroProduto.DataSource = clnUtil.PreencherFabricante();

            cboFornecedorCadastroProduto.ValueMember = "cd_fornecedor";
            cboFornecedorCadastroProduto.DisplayMember = "NomeFantasia";
            cboFornecedorCadastroProduto.DataSource = clnUtil.PreencherFornecedor();

            cboGeneroCadastroProduto.ValueMember = "cd_Genero";
            cboGeneroCadastroProduto.DisplayMember = "ds_Genero";
            cboGeneroCadastroProduto.DataSource = clnUtil.PreencherGenero();

            cboPlataformaCadastroProduto.ValueMember = "cd_Plataforma";
            cboPlataformaCadastroProduto.DisplayMember = "ds_Plataforma";
            cboPlataformaCadastroProduto.DataSource = clnUtil.PreencherPlataforma();

            cboTipoCadastroProduto.ValueMember = "Cd_TipoProduto";
            cboTipoCadastroProduto.DisplayMember = "ds_TipoProduto";
            cboTipoCadastroProduto.DataSource = clnUtil.PreencherTipo();

            if (!string.IsNullOrEmpty(txtCod.Text))
            {
                //Enviar todos os campos para as properties
                ClnProduto objClnProduto = new ClnProduto();

                objClnProduto.PesquisarPorTipo(txtCod.Text, "codigo");

            }

        }
        private void btnGravarCadastroDeProduto_Click(object sender, EventArgs e)
        {
            //valida campos em branco
            if ((cboTipoCadastroProduto.SelectedIndex == -1) || (txtNomeCadastroProduto.Text == "") ||
                (cboGeneroCadastroProduto.SelectedIndex == -1) || (cboFabricanteCadastroProduto.SelectedIndex == -1) ||
                (cboPlataformaCadastroProduto.SelectedIndex == -1) || (txtPrecoCadastroProduto.Text == "") ||
                (txtQuantidadeCadastroProduto.Text == "") || (cboFornecedorCadastroProduto.SelectedIndex == -1))
            {
                MessageBox.Show("Os campos com * são Obrigatórios", "item Novo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNomeCadastroProduto.Focus();
            }
            else
            {
                //Enviar todos os campos para as properties
                ClnProduto objClnProduto = new ClnProduto();

                objClnProduto.Cd_TipoProduto = cboTipoCadastroProduto.SelectedValue.ToString();
                objClnProduto.Nome = txtNomeCadastroProduto.Text;
                objClnProduto.Cd_Genero = cboGeneroCadastroProduto.SelectedValue.ToString(); 
                objClnProduto.Cd_Fabricante = cboFabricanteCadastroProduto.SelectedValue.ToString();
                objClnProduto.Cd_Plataforma = cboPlataformaCadastroProduto.SelectedValue.ToString();
                objClnProduto.Preco = txtPrecoCadastroProduto.Text.Replace(",", ".");
                objClnProduto.Codigo = txtCod.Text;
                objClnProduto.Cd_Fornecedor = cboFornecedorCadastroProduto.SelectedValue.ToString();
                objClnProduto.Quantidade = txtQuantidadeCadastroProduto.Text;
                objClnProduto.Cd_FaixaEtaria = cboFaixaEtariaCadastroProduto.SelectedValue.ToString();
                objClnProduto.Condicao = cboCondicaoCadastroProduto.Text;

                objClnProduto.Gravar();
                if (string.IsNullOrEmpty(txtCod.Text))
                {
                    MessageBox.Show("Registro Inserido com sucesso", "Novo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Registro Número "  +  txtCod.Text + " Alterado com sucesso", "Alteração", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }            
            }

        }

        private void btnSairCadastroProduto_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtCod_TextChanged(object sender, EventArgs e)
        {

        }
    }
}


