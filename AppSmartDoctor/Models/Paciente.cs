using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AppSmartDoctor.Models
{
    public class Paciente
    {
        [Key]
        public int pacienteId { get; set; }
        public string nombres { get; set; }
        public string DNI { get; set; }
        [DataType(DataType.Date)]
        public DateTime fecha_nacimiento { get; set; }
        public int edad { get; set; }
        public bool sexo { get; set; }
        public string distrito_colonia { get; set; }
    }
}
