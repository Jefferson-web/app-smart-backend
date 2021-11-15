using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AppSmartDoctor.Models
{
    public class Diagnostico
    {
        [Key]
        public int diagnosticoId { get; set; }
        public int citaId { get; set; }
        public string descripcion { get; set; }
    }
}
