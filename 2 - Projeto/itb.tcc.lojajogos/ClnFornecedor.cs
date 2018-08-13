using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Itb.Tcc.LojaJogos
{
    class ClnFornecedor
    {
        private int _cd_Fornecedor;
        private string _Cnpj, _NomeFantasia, _RazaoSocial, _Telefone, _Celular, _Email, _Cep, _Endereco, _EndNumero, _EndComplemento, _Bairro, _Cidade, _UF;
        private string comando;

        public int Cd_Fornecedor { get => _cd_Fornecedor; set => _cd_Fornecedor = value; }
        public string Cnpj { get => _Cnpj; set => _Cnpj = value; }
        public string NomeFantasia { get => _NomeFantasia; set => _NomeFantasia = value; }
        public string RazaoSocial { get => _RazaoSocial; set => _RazaoSocial = value; }
        public string Telefone { get => _Telefone; set => _Telefone = value; }


        public string Celular { get => _Celular; set => _Celular = value; }
        public string Email { get => _Email; set => _Email = value; }
        public string Cep { get => _Cep; set => _Cep = value; }
        public string Endereco { get => _Endereco; set => _Endereco = value; }
        public string EndNumero { get => _EndNumero; set => _EndNumero = value; }
        public string EndComplemento { get => _EndComplemento; set => _EndComplemento = value; }

        public SqlDataReader localizarCodigo(string codigo)
        {
            cldBancoDados objBancoDados = new cldBancoDados();

            comando = " select * from Tb_fornecedor ";
            comando += " where cd_fornecedor = " + codigo;


            return objBancoDados.RetornaLinha(comando);
        }

        public string Bairro { get => _Bairro; set => _Bairro = value; }
        public string Cidade { get => _Cidade; set => _Cidade = value; }
        public string UF { get => _UF; set => _UF = value; }
        public string Codigo { get; set; }

        public DataTable LocalizarPorCampo(string strValorCampo, string strNomeCampo)
        {
            cldBancoDados objBancoDados = new cldBancoDados();

            comando = "select cd_fornecedor, Cnpj, NomeFantasia, RazaoSocial, Telefone, Celular, Email from Tb_fornecedor where " + strNomeCampo + " like '%" +
            strValorCampo + "%' and Ativo= 1 order by cd_fornecedor";

            return objBancoDados.RetornaTabela(comando);
        }



        public void ExcluirLogicamente()
        {
            cldBancoDados objBancoDados = new cldBancoDados();
            comando = (" UPDATE tb_fornecedor ");
            comando += (" SET ");
            comando += (" ATIVO = '" + 0 + "' ");
            comando += (" WHERE ");
            comando += (" cd_fornecedor = '" + Codigo + "' ");

            objBancoDados.ExecutaComando(comando);
        }

       public void Gravar()
        {
            if (string.IsNullOrEmpty(Codigo))
            {
                Inserir();
            }
            else
            {
                Atualizar();
            }
        }

        public void Excluir()
        {
            cldBancoDados objBancoDados = new cldBancoDados();
            comando = ("delete from tb_fornecedor ");
            comando += ("where cd_fornecedor= '" + Codigo + "' ");
            objBancoDados.ExecutaComando(comando);
        }

        public void Inserir()
        {
            cldBancoDados objBancoDados = new cldBancoDados();
            comando = " Insert into tb_Fornecedor ( " +
                "Cnpj, NomeFantasia, RazaoSocial, Telefone, Celular, Email, " +
                "Cep, Endereco, EndNumero, EndComplemento, Bairro, Cidade, UF" +
                ") values ( " +
                "'" + Cnpj + "'," +
                "'" + NomeFantasia + "'," +
                "'" + RazaoSocial + "'," +
                "'" + Telefone + "'," +
                "'" + Celular + "'," +
                "'" + Email + "'," +
                "'" + Cep+ "'," +
                "'" + Endereco + "'," +
                "'" + EndNumero + "'," +
                "'" + EndComplemento + "'," +
                "'" + Bairro + "'," +
                "'" + Cidade + "'," +
                "'" + UF + "')";

            objBancoDados.ExecutaComando(comando);
        }
        public void Atualizar()
        {

             cldBancoDados objBancoDados = new cldBancoDados();
            comando = "  " +
                "update tb_Fornecedor set" +
                "NomeFantasia = '" + NomeFantasia + "'," +
                "Cnpj = '" + Cnpj + "'," +
                "RazaoSocial = '" + RazaoSocial + "'," +
                "Telefone = '" + Telefone + "'," +
                "Celular ='" + Celular + "'," +
                "Email= '" + Email + "'," +
                "Cep= '" + Cep+ "'," +
                "Endereco= '" + Endereco + "'," +
                "EndNumero='" + EndNumero + "'," +
                "EndComplemento='" + EndComplemento + "'," +
                "Bairro='" + Bairro + "'," +
                "Cidade='" + Cidade + "'," +
                "UF='" + UF + "'," +
                "where  cd_fornecedor= '" + Codigo + "'";
              

            objBancoDados.ExecutaComando(comando);
        }


    }

}
