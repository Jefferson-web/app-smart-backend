using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AppSmartDoctor.Models
{
    public class FichaClinica
    {
        [Key]
        public int fichaClinicaId { get; set; }
        public int  pacienteId { get; set; }
        public double peso { get; set; }
        public double talla { get; set; }
        public DateTime fecha_registro { get; set; }
    }
}
