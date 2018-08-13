using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data; //Para uso DataTable (tabela de Dados)
using System.Data.SqlClient; //Para uso DataReader (Dados para leitura)

namespace Itb.Tcc.LojaJogos
{
    class cldBancoDados
    {

        public static SqlConnection AbreBanco()
        {
            //     string StringConexao = @"Data source=\sqlexpress catalog=lojajogo;";
            string StringConexao = @"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=LojaJogos_01;Data Source=.\SQLEXPRESS";
            //string StringConexao = @"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=LojaJogos_01;Data Source=.\SQLEXPRESS01";
            try
            {
                SqlConnection conn = new SqlConnection(StringConexao);
                conn.Open();
                return conn;
            }


            catch (Exception ex)

            {
                throw ex;
            }
        }

        //==========================================
        public void FechaBanco(SqlConnection conn)
        {
            try
            {
                if (conn.State == ConnectionState.Open)
                { conn.Close(); }
            }
            catch (Exception e)
            { throw e; }
        }
        public DataTable RetornaTabela(String strQuery)
        {
            try
            {
                DataTable dt = new DataTable();
                SqlCommand cmdComando = new SqlCommand(strQuery, AbreBanco());
                SqlDataAdapter da = new SqlDataAdapter(cmdComando);
                da.Fill(dt);
                return dt;
            }
            catch (Exception erro)
            {
                throw new Exception("Erro na pesquisa da tabela" + erro.Message);
            }
            finally
            {
                FechaBanco(AbreBanco());
            }
        }
        public SqlDataReader RetornaLinha(string strQuery)
        {
            try
            {
                SqlDataReader dr;
                SqlCommand sqlComando = new SqlCommand(strQuery, AbreBanco());
                dr = sqlComando.ExecuteReader();
                return dr;
            }
            catch (Exception e)
            {
                //or MessageBox (e. Message);
                throw e;
                throw new Exception("Mensagem");
            }

            //finally
            //{
            // //FechadoBanco(conn);
            //}
        }
        public void ExecutaComando(string StrQuery)
        {
            try
            {
                SqlCommand sqlComm = new SqlCommand(StrQuery, AbreBanco());
                sqlComm.ExecuteNonQuery();

            }
            catch (Exception e)
            {
                throw e;
            }
            //Em caso de erro ou não, o finally é executado para fechar a conexão bd
            finally { FechaBanco(AbreBanco()); }
        }

    }
}

