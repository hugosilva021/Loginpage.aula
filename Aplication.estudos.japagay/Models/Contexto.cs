using System;
using System.Data;
using System.Data.SqlClient;


namespace Aplication.estudos.japagay.Models
{
	class Contexto:IDisposable
	{
		private readonly SqlConnection minhaConexao;

        public Contexto()
        {
            minhaConexao = new SqlConnection(@"data source=.\SQLEXPRESS;Integrated Security=SSPI;Initial Catalog=CadastroUser");
            minhaConexao.Open();    
        }

        public void ExecutaComando(string strQuery)
        {
            var cmdComando = new SqlCommand(strQuery)
            {
                CommandText = strQuery,
                CommandType = CommandType.Text,
                Connection = minhaConexao
            };
        }

        public SqlDataReader ExecutaComandoComRetorno(string strQuery)
        {
            var cmdComando = new SqlCommand(strQuery, minhaConexao);
            return cmdComando.ExecuteReader();
        }



        public void Dispose()
        {
            if (minhaConexao.State == ConnectionState.Open)
            {
                minhaConexao.Close();
            }
        }
    }
}
