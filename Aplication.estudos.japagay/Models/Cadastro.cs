using System.ComponentModel.DataAnnotations;

namespace Aplication.estudos.japagay.Models
{
    public class Cadastro
    {
        [Required]
        [StringLength(11)]
        public string numero { get; set; }
        [Required]
        public DateTime Nascimento { get; set; }
        //[RegularExpression(@"^[a-zA-Z''-'\s]{1,40}$", ErrorMessage =
        //   "Números e caracteres especiais não são permitidos no nome.")]
        public string? Nome { get; set; }
        [Required(ErrorMessage = "Informe o seu email")]
        [EmailAddress(ErrorMessage ="email invalido")]
        //[RegularExpression(".+\\@.+\\..+", ErrorMessage = "Informe email válido...")]
        public string? Email { get; set; }
    }
}
