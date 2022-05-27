using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace BankMillenniumTask.Models
{
    [BindProperties]
    public class FormDto
    {
        [Display(Name = "Nickname")]
        [Required(ErrorMessage = "Nickname Required")]
        [RegularExpression("^[a-zA-Z]*$", ErrorMessage = "Only Alphabet")]
        [StringLength(30, ErrorMessage = "Max 30 characters")]
        public string Nickname { get; set; }

        [Display(Name = "Email"), Required(ErrorMessage = "Email Required"), DataType(DataType.EmailAddress)]
        public string Email { get; set; }
    }
}
