using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AppSmartDoctor.Models
{
    public class Receta
    {
        [Key]
        public int recetaId { get; set; }
        public int citaId { get; set; }
        public string nombre_medicamento { get; set; }
        public int cantidad { get; set; }
        public string frecuencia { get; set; }
        public int horas { get; set; }
        public string observacion { get; set; }
    }
}
