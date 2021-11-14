using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AppSmartDoctor.Models
{
    public class Estudio
    {
        [Key]
        public int estudioId { get; set; }
        public int medicoId { get; set; }
        public string descripcion { get; set; }
        public int anio { get; set; }
    }
}
