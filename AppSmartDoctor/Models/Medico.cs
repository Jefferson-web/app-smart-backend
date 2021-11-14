using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AppSmartDoctor.Models
{
    public class Medico
    {
        [Key]
        public int medicoId { get; set; }
        public int especialidadId { get; set; }
        public int residenciaId { get; set; }
        public string nombres { get; set; }
        public string CMP { get; set; }
        public string celular { get; set; }
        public string correo { get; set; }
        public string descripcion { get; set; }
    }
}
