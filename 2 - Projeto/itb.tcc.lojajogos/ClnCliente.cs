using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Itb.Tcc.LojaJogos
{
    class ClnCliente
    {
        private int _cd_Cliente;
        private string _Nome, _Nascimento, _Cpf, _Rg, _Genero, _Endereco, _Numero,_complemento,_Bairro, _Cidade, _Cep, _Estado, _UF, _Email, _telefone, _Celular, _codigo;
        private string comando;

        public string Nome { get => _Nome; set => _Nome = value; }
        public string Cpf { get => _Cpf; set => _Cpf = value; }
        public string Rg { get => _Rg; set => _Rg = value; }
        public string Genero { get => _Genero; set => _Genero = value; }
        public string Endereco { get => _Endereco; set => _Endereco = value; }
        public string Numero { get => _Numero; set => _Numero = value; }
        public string Cidade { get => _Cidade; set => _Cidade = value; }
        public string Cep { get => _Cep; set => _Cep = value; }
        public string Estado { get => _Estado; set => _Estado = value; }
        public string UF { get => _UF; set => _UF = value; }
        public string Email { get => _Email; set => _Email = value; }
        public string Telefone { get => _telefone; set => _telefone = value; }
        public string Celular { get => _Celular; set => _Celular = value; }
        public string Codigo { get => _codigo; set => _codigo = value; }
        public string Complemento { get => _complemento; set => _complemento = value; }
        public string Bairro { get => _Bairro; set => _Bairro = value; }
        public string Nascimento { get => _Nascimento; set => _Nascimento = value; }

        internal SqlDataReader localizarCodigo(string codigo)
        {
            cldBancoDados objBancoDados = new cldBancoDados();
            comando = " select * from Tb_cliente ";
            comando += " where cd_cliente = " + codigo;


            return objBancoDados.RetornaLinha(comando);
        }



        public DataTable LocalizarPorCampo(string strValorCampo, string strNomeCampo)
        {
            cldBancoDados objBancoDados = new cldBancoDados();

            comando = "select cd_cliente, Nome,Cpf, Rg,Genero, Endereco, Bairro, Numero, Complemento, Cidade, Cep, Estado, UF, Email, telefone, Celular from Tb_cliente  where " + strNomeCampo + " like '%" +
            strValorCampo + "%' and Ativo= 1 order by cd_cliente";

            return objBancoDados.RetornaTabela(comando);

        }

        public void ExcluirLogicamente()
        {
            cldBancoDados objBancoDados = new cldBancoDados();
            comando = (" UPDATE tb_Cliente ");
            comando += (" SET ");
            comando += (" ATIVO = '" + 0 + "' ");
            comando += (" WHERE ");
            comando += (" cd_Cliente = '" + Codigo + "' ");

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
            comando = ("delete from tb_cliente ");
            comando += ("where cd_cliente= '" + Codigo + "' ");
            objBancoDados.ExecutaComando(comando);
        }

        private void Atualizar()
        {

            cldBancoDados objBancoDados = new cldBancoDados();
            comando = "  " +
                " update tb_Cliente set " +
                " Nome = '" + Nome + "'," +
                "DtNasc = '" + Nascimento + "'," +
                " Cpf = '" + Cpf + "'," +
                " Rg = '" + Rg+ "'," +
                " Genero = '" + Genero+ "'," +
                " Telefone = '" + Telefone + "'," +
                " Celular ='" + Celular + "'," +
                " Email = '" + Email + "'," +
                " Cep = '" + Cep + "'," +
                " Endereco = '" + Endereco + "'," +
                " Complemento = '" + Complemento+ "'," +
                " Bairro = '" + Bairro+ "'," +
                " Numero ='" + Numero + "'," +
                " Cidade ='" + Cidade + "'," +
                " Estado ='" + Estado + "'," +
                " UF='" + UF + "'," +
                " where  cd_cliente= '" + Codigo + "'";


            objBancoDados.ExecutaComando(comando);
        }

        private void Inserir()
        {
            cldBancoDados objBancoDados = new cldBancoDados();
            comando = " Insert into tb_Cliente ( " +
                "Nome, DtNasc, cpf, rg, Genero, Telefone, Celular, Email, " +
                "Cep, Endereco, Numero, Complemento, Bairro, Cidade, Estado, UF" +
                ") values ( " +
                "'" + Nome + "'," +
                "'" + Nascimento + "'," +
                "'" + Cpf + "'," +
                "'" + Rg + "'," +
                 "'" + Genero + "'," +
                "'" + Telefone + "'," +
                "'" + Celular + "'," +
                "'" + Email + "'," +
                "'" + Cep + "'," +
                "'" + Endereco + "'," +
                "'" + Numero + "'," +
                "'" + Complemento + "'," +
                "'" + Bairro + "'," +
                "'" + Cidade + "'," +
                "'" + Estado + "'," +
                "'" + UF + "')";

            objBancoDados.ExecutaComando(comando);
        }
    }


}
