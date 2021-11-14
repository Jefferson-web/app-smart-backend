using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AppSmartDoctor.Models
{
    public class Cita
    {
        [Key]
        public int citaId { get; set; }
        public int medicoId { get; set; }
        public int pacienteId { get; set; }
        [DataType(DataType.Date)]
        public DateTime fecha { get; set; }
        public DateTime hora_inicio { get; set; }
        public DateTime hora_fin { get; set; }
        public string motivo { get; set; }
        public double costo { get; set; }
        public bool pagado { get; set; }
        public bool atendido { get; set; }
        public DateTime fecha_registro { get; set; }
    }
}
