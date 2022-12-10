using Aplication.estudos.japagay.Models;


namespace Aplication.estudos.japagay.Models
{
    public class AppCadastro
    {
        private Contexto? contexto;

        public void Inserir(Usuario usuario)
        {
            var strQuery = "";
            strQuery += "INSERT INTO Users (CPF, Nascimento, Nome, Email, Password)";
            strQuery += string.Format(" VALUES ('{0}','{1}','{2}','{3}', '{4}')", usuario.CPF, usuario.Nascimento, usuario.Nome, usuario.Email, usuario.Password);

            using (contexto = new Contexto())
            {
                contexto.ExecutaComando(strQuery);
            }
            
        }
    }
}
