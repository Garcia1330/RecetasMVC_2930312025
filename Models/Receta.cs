using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RecetasMVC_Project.Models
{
    public class Receta
    {
        [Key]
        [Required(ErrorMessage = "El nombre es obligatorio")]
        [StringLength(100)]
        public string Nombre { get; set; } // PK as required

        [Required(ErrorMessage = "Las instrucciones son obligatorias")]
        [DataType(DataType.MultilineText)]
        public string Instrucciones { get; set; }

        [Required(ErrorMessage = "El tiempo de preparación es obligatorio")]
        [Display(Name = "Tiempo de Preparación (minutos)")]
        public int TiempoPreparacion { get; set; }
    }
}
