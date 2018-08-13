using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data; //para uso do DataTable (tabela de Dados)
using System.Data.SqlClient; // Para uso do DataReader (Dados para Leitura)
using System.Windows.Forms;

namespace Itb.Tcc.LojaJogos
{
    class ClnUtil
    {
        string comando = "";

        cldBancoDados objBancoDados = new cldBancoDados();
        
        public static string Cifrar(string valor)
        {
            var buffer = System.Text.Encoding.UTF8.GetBytes(valor);
            return Convert.ToBase64String(buffer);
        }
        public static string Decifrar(string valor)
        {
            var buffer = Convert.FromBase64String(valor);
            return System.Text.Encoding.UTF8.GetString(buffer);
        }
        
        public DataTable PreencherUF()
        {
            //comando = "select UF from T_UF";
            //return objBancoDados.RetornaTabela(comando);

            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("UF");

            dataTable.Rows.Add("SP");
            dataTable.Rows.Add("AC");
            dataTable.Rows.Add("AL");
            dataTable.Rows.Add("AM");
            dataTable.Rows.Add("AP");
            dataTable.Rows.Add("BA");
            dataTable.Rows.Add("CE");
            dataTable.Rows.Add("DF");
            dataTable.Rows.Add("ES");
            dataTable.Rows.Add("GO");
            dataTable.Rows.Add("MA");
            dataTable.Rows.Add("MG");
            dataTable.Rows.Add("MS");
            dataTable.Rows.Add("MT");
            dataTable.Rows.Add("PA");
            dataTable.Rows.Add("PB");
            dataTable.Rows.Add("PE");
            dataTable.Rows.Add("PI");
            dataTable.Rows.Add("PR");
            dataTable.Rows.Add("RJ");
            dataTable.Rows.Add("RN");
            dataTable.Rows.Add("RO");
            dataTable.Rows.Add("RR");
            dataTable.Rows.Add("RS");
            dataTable.Rows.Add("SC");
            dataTable.Rows.Add("SE");
            dataTable.Rows.Add("TO");

            return dataTable;

        }

        public DataTable PreencherTipo()
        {
            comando = " select Cd_TipoProduto,ds_TipoProduto from Tb_TipoProduto where Ativo=1;";
            return objBancoDados.RetornaTabela(comando);

        }

        public DataTable PreencherPlataforma()
        {
            comando = "Select cd_Plataforma, ds_Plataforma from tb_Plataforma where Ativo = 1;";
            return objBancoDados.RetornaTabela(comando);

        }

          public DataTable  PreencherGenero()
        {
            comando = "Select cd_Genero, ds_Genero from tb_Genero where Ativo = 1;";
            return objBancoDados.RetornaTabela(comando);
        }

        public DataTable PreencherFaixaEtaria()
        {
            comando = "Select cd_FaixaEtaria, ds_FaixaEtaria from tb_FaixaEtaria where Ativo = 1;";
            return objBancoDados.RetornaTabela(comando);
        }

        public DataTable PreencherFornecedor()
        {
            comando = "select cd_fornecedor, NomeFantasia from Tb_fornecedor where Ativo = 1;";
            return objBancoDados.RetornaTabela(comando);
        }

        public DataTable PreencherFabricante()
        {
            comando = "Select cd_Fabricante, ds_Fabricante from tb_Fabricante where Ativo = 1;";
            return objBancoDados.RetornaTabela(comando);
        }

        public SqlDataReader ProcurarCep(string cep)
        {
            comando = "select * from CepFiltradas$ where Cep='" + cep + "'";
            return objBancoDados.RetornaLinha(comando);
        }
    }
}

