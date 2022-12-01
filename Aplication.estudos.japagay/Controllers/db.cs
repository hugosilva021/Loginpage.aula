using System.Data.SqlClient;

namespace Aplication.estudos.japagay.Controllers
{
    public class db
    {
        public void Inserir(string nome, string senha)
        {
            using (SqlConnection conn = new SqlConnection("Server=./;DATABASE=Produto;trusted_connection=true"))
            {
                conn.Open();
                using (SqlCommand comando = new SqlCommand("INSERT INTO usuario VALUES(@nome,@senha)",conn))
                {
                    comando.Parameters.AddWithValue("@nome", senha);
                    comando.Parameters.AddWithValue("@senha", senha);
                }

            }
        }
    }
}
