using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AppSmartDoctor.Models
{
    public class Especialidad
    {
        [Key]
        public int especialidadId { get; set; }
        public string nombre { get; set; }
        public string descripcion { get; set; }
    }
}
