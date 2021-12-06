using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AppSmartDoctor.Models
{
    public class TipoPago
    {
        [Key]
        public int tipoPagoId { get; set; }
        public string tipo { get; set; }
        public string icono { get; set; }
    }
}
