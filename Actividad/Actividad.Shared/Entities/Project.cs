using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad.Shared.Entities
{
    internal class Project
    {
        public int Id { get; set; }

        [Display(Name = "Nombre del projecto")]
        [MaxLength(100, ErrorMessage = "El campo {0} debe tener máximo {1} caractéres.")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public string Name { get; set; } = null!;

        [Display(Name = "Fecha Inicial")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public DateTime InitialDate { get; set; }

        [Display(Name = "Fecha Final")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public DateTime FinalDate { get; set; }

        [Display(Name = "Descripción")]
        [MaxLength(100, ErrorMessage = "El campo {0} debe tener máximo {1} caractéres.")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public string Description { get; set; } = null!;

        [Display(Name = "Lider del proyecto")]
        [MaxLength(100, ErrorMessage = "El campo {0} debe tener máximo {1} caractéres.")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public string Leader { get; set; } = null!;

        [Display(Name = "Área de Investigación")]
        [MaxLength(100, ErrorMessage = "El campo {0} debe tener máximo {1} caractéres.")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public string ReseachArea { get; set; } = null!;
    }
    
}

