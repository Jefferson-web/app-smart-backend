using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AppSmartDoctor.Models.ViewModel
{
    public class PacienteDTO
    {
        public string nombres { get; set; }
        public string email { get; set; }
        public string contrasena { get; set; }
        public string DNI { get; set; }
        [DataType(DataType.Date)]
        public DateTime fecha_nacimiento { get; set; }
        public int edad { get; set; }
        public bool sexo { get; set; }
        public string distrito_colonia { get; set; }
    }
}
