using System;
using site3.Models;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using site3.DataBase;

namespace site3.Library.Validation
{
    public class UnicoNomePalavraAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            Palavra palavra = validationContext.ObjectInstance as Palavra;

            var _db = (DataBaseContext)validationContext.GetService(typeof(DataBaseContext));

            var palavraBanco = _db.Palavras.Where(a => a.Nome == palavra.Nome && a.Id != palavra.Id).FirstOrDefault();

            if (palavraBanco == null)
            {
                return ValidationResult.Success;
            }
            else
            {
                return new ValidationResult("A palavra " + palavra.Nome + " Já está sendo utilizada.");
            }
        }


    }
}
