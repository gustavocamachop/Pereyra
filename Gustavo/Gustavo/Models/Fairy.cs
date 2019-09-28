using System;
using System.ComponentModel.DataAnnotations;

namespace Gustavo.Models
{
    public enum TypeList
    {Granadas,
        Galletas,
        Gasolina

    }
    public class Fairy
    {
        [Key]
        public int FairyID { get; set; }

        [Required] [Display(Description="Nombre Completo")]
        [StringLength(24, MinimumLength = 2)]
        public string NickName { get; set; }

        [Required]
        public TypeList Wishes { get; set; }

        [Required(ErrorMessage = "Email id is required")]
        [RegularExpression(@"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z",
                            ErrorMessage = "Please enter a valid email address")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Ingrese una fecha valida")]
        [Display(Description = "Cumpleanos")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime Birthday { get; set; }

  
    }
}