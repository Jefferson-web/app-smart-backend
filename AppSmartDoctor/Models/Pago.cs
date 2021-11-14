using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AppSmartDoctor.Models
{
    public class Pago
    {
        [Key]
        public int pagoId { get; set; }
        public int tipoPagoId { get; set; }
        public int citaId { get; set; }
        public double monto { get; set; }

        public string nombreTarjeta { get; set; }
        public string numeroTarjeta { get; set; }
        public string expiracion { get; set; }
        public string cvv { get; set; }

        public DateTime fecha_pago { get; set; }
    }
}
