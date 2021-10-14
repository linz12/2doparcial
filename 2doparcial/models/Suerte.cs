using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace _2doparcial.models
{
    public class Suerte
    {
        [Key]

        [Required(AllowEmptyStrings = false, ErrorMessage = "{0} es requerido")]
        [StringLength(2, MinimumLength = 1, ErrorMessage = "Debe poner un numero ")]
        public string FuturoId { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "{0} es requerido")]
        public string Vision { get; set; }
        [Url]
        [StringLength(1000, MinimumLength = 10, ErrorMessage = "La longitud de {0} debe estar entre {2} y {1}")]
        public string Imagen { get; set; }
    }
}

