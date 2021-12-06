using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppSmartDoctor.Models.ViewModel
{
    public class CitaDTO
    {
        public int medicoId { get; set; }
        public int pacienteId { get; set; }
        public int horarioId { get; set; }
        public string motivo { get; set; }
    }
}
