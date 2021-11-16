using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AppSmartDoctor.Models
{

    public class Calificacion
    {
        [Key]
        public int calificacionId { get; set; }
        public int medicoId { get; set; }
        public int pacienteId { get; set; }
        public double puntuacion { get; set; }
        public string comentario { get; set; }
        public DateTime fecha_registro { get; set; }
    }
}
