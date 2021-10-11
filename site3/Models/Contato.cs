using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace site3.Models
{
    public class Contato
    {
        [Required(ErrorMessage ="O cambo 'Nome' é obrigatório")]
        [MaxLength(50, ErrorMessage = "O cambo 'Nome' deve conver no máximo 50 caracteres!")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "O cambo 'Email' é obrigatório")]
        [MaxLength(70, ErrorMessage = "O cambo 'Email' deve conver no máximo 70 caracteres!")]
        [EmailAddress(ErrorMessage = "O cambo 'Email' é inválido")]
        public string Email { get; set; }
        [Required(ErrorMessage = "O cambo 'Assunto' é obrigatório")]
        [MaxLength(70, ErrorMessage = "O cambo 'Assunto' deve conver no máximo 70 caracteres!")]
        public string Assunto { get; set; }
        [Required(ErrorMessage = "O cambo 'Mensagem' é obrigatório")]
        [MaxLength(2000, ErrorMessage = "O cambo 'Mensagem' deve conver no máximo 2000 caracteres!")]
        public string Mensagem { get; set; }
    }
}
