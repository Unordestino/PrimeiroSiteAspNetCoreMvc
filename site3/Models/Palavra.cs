using site3.Library.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace site3.Models
{
    public class Palavra
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "O cambo 'Nome' é obrigatório")]
        [MaxLength(70, ErrorMessage = "O cambo 'Nome' deve conver no máximo 70 caracteres!")]
        [UnicoNomePalavra]
        public string Nome { get; set; }
        public byte? Nivel { get; set; }

    }
}
