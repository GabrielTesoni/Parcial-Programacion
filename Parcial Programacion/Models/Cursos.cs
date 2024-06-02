using System;
using System.ComponentModel.DataAnnotations;

namespace Parcial_Programacion.Models
{
    public class Curso
    {
        [Key]
        public int ID { get; set; }

        [Required]
        [StringLength(100)]
        public string Nombre { get; set; }

        [Required]
        public DateTime Fecha { get; set; }

        [Required]
        [StringLength(50)]
        public string Clave { get; set; }

        [StringLength(500)]
        public string Descripcion { get; set; }

        public int DuracionEnHoras { get; set; }

        [StringLength(100)]
        public string Instructor { get; set; }
    }
}

