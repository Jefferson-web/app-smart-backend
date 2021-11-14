using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AppSmartDoctor.Models
{
    public class Consultorio
    {
        [Key]
        public int consultorioId { get; set; }
        public int medicoId { get; set; }
        public double importe { get; set; }
        public int duracion { get; set; }
    }
}
