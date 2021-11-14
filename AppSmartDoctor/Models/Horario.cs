using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AppSmartDoctor.Models
{
    public class Horario
    {
        [Key]
        public int horarioId { get; set; }
        public int medicoId { get; set; }
        [DataType(DataType.Date)]
        public DateTime fecha { get; set; }
        public DateTime hora_inicio { get; set; }
        public DateTime hora_fin { get; set; }
        public bool disponible { get; set; }
    }
}
