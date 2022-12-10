using System.ComponentModel.DataAnnotations;


namespace Aplication.estudos.japagay.Models
{
    public class Usuario
    {
        [Required]
        [StringLength(11)]
        public string CPF { get; set; }

        [Required]
        
        public DateTime Nascimento { get; set; }

        //[RegularExpression(@"^[a-zA-Z''-'\s]{1,40}$", ErrorMessage =
        //   "Números e caracteres especiais não são permitidos no nome.")]
        [Required]
        public string? Nome { get; set; }

        [Required]
        //[RegularExpression(".+\\@.+\\..+", ErrorMessage = "Informe email válido...")]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
