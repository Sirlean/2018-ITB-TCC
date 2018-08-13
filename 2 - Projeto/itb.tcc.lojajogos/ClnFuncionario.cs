using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Itb.Tcc.LojaJogos
{
    class ClnFuncionario
    {
        private int _cd_Funcionario;
        private string _Nome, _Cpf, _Rg, _Genero, _Endereco, _Numero, _Complemento, _Bairro, _Cidade, _Cep, _Estado, _UF, _Email, _telefone, _Celular, _codigo, _usuario, _senha;
        private string comando;

        public string Nome { get => _Nome; set => _Nome = value; }
        public string Cpf { get => _Cpf; set => _Cpf = value; }
        public string Rg { get => _Rg; set => _Rg = value; }
        public string Genero { get => _Genero; set => _Genero = value; }
        public string Endereco { get => _Endereco; set => _Endereco = value; }
        public string Numero { get => _Numero; set => _Numero = value; }
        public string Complemento { get => _Complemento; set => _Complemento = value; }
        public string Bairro { get => _Bairro; set => _Bairro = value; }
        public string Cidade { get => _Cidade; set => _Cidade = value; }
        public string Cep { get => _Cep; set => _Cep = value; }
        public string Estado { get => _Estado; set => _Estado = value; }
        public string UF { get => _UF; set => _UF = value; }
        public string Email { get => _Email; set => _Email = value; }
        public string Telefone { get => _telefone; set => _telefone = value; }
        public string Celular { get => _Celular; set => _Celular = value; }
        public string Codigo { get => _codigo; set => _codigo = value; }
        public string Usuario { get => _usuario; set => _usuario = value; }
        public string Senha { get => _senha; set => _senha = value; }

        internal SqlDataReader localizarCodigo(string codigo)
        {
            cldBancoDados objBancoDados = new cldBancoDados();
            comando = " select * from Tb_Funcionario ";
            comando += " where cd_Funcionario = " + codigo;
            
            return objBancoDados.RetornaLinha(comando);
        }
        public bool ValidarUsuario(string usuario, string senha)
        {
            cldBancoDados objBancoDados = new cldBancoDados();
            comando = " select * from Tb_Funcionario ";
            comando += " where Usuario = '" + usuario + "' and senha = '" + 
                ClnUtil.Cifrar(senha)
                + "'";
            SqlDataReader dataReader = objBancoDados.RetornaLinha(comando);

            return dataReader.Read();
        }

        public DataTable LocalizarPorCampo(string strValorCampo, string strNomeCampo)
        {
            cldBancoDados objBancoDados = new cldBancoDados();

            comando = "select cd_Funcionario, Nome, Cpf, Rg,Genero, Endereco, Numero, Complemento, Bairro, Cidade, Cep, Estado, UF, Email, telefone, Celular, usuario from Tb_Funcionario  where " + strNomeCampo + " like '%" +
            strValorCampo + "%' and Ativo= 1 order by cd_Funcionario";

            return objBancoDados.RetornaTabela(comando);

        }
        public void ExcluirLogicamente()
        {
            cldBancoDados objBancoDados = new cldBancoDados();
            comando = (" UPDATE tb_Funcionario ");
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

        private void Atualizar()
        {
            cldBancoDados objBancoDados = new cldBancoDados();
            comando = "  " +
                " update tb_Funcionario set" +
                " Nome = '" + Nome + "'," +
                " Cpf = '" + Cpf + "'," +
                " Rg = '" + Rg + "'," +
                " Genero = '" + Genero + "'," +
                " Telefone = '" + Telefone + "'," +
                " Celular ='" + Celular + "'," +
                " Email= '" + Email + "'," +
                " Cep= '" + Cep + "'," +
                " Endereco= '" + Endereco + "'," +
                " Complemento= '" + Complemento + "'," +
                " Bairro= '" + Bairro + "'," +
                " Numero='" + Numero + "'," +
                " Cidade='" + Cidade + "'," +
                " UF='" + UF + "'," +
                " USUARIO='" + Usuario + "'," +
                " Senha='" + ClnUtil.Cifrar(Senha) + "'" +

                " where  cd_Funcionario= '" + Codigo + "'";

            objBancoDados.ExecutaComando(comando);
        }

        private void Inserir()
        {
            cldBancoDados objBancoDados = new cldBancoDados();
            comando = " Insert into tb_Funcionario ( " +
                "Nome, cpf, rg, Telefone, Celular, Email, " +
                "Cep, Endereco, Numero, Complemento, Bairro, Cidade, UF, Usuario, Senha" +
                ") values ( " +
                "'" + Nome + "'," +
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
                "'" + UF + "'," +
                "'" + Usuario + "'," +
                "'" + ClnUtil.Cifrar(Senha) + "')";

            objBancoDados.ExecutaComando(comando);
        }

        public void Excluir()
        {
            cldBancoDados objBancoDados = new cldBancoDados();
            comando = ("delete from tb_Funcionario ");
            comando += ("where cd_Funcionario= '" + Codigo + "' ");
            objBancoDados.ExecutaComando(comando);
        }
    }
}
