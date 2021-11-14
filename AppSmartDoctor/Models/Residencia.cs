using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AppSmartDoctor.Models
{
    public class Residencia
    {
        [Key]
        public int residenciaId { get; set; }
        public string pais { get; set; }
    }
}
