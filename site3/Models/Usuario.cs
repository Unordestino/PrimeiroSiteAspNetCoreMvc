using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace site3.Models
{
    public class Usuario
    {
        [Required(ErrorMessage = "O cambo 'Email' é obrigatório")]
        [EmailAddress(ErrorMessage = "O cambo 'Email' é inválido")]
        public string Email { get; set; }
        [Required(ErrorMessage = "O cambo 'Senha' é obrigatório")]
        public string Senha { get; set; }
    }
}
