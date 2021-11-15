using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AppSmartDoctor.Models
{
    public class CuentaDoctor
    {
        [Key]
        public int cuentaDoctorId { get; set; }
        public int medicoId { get; set; }
        public string nombreBanco { get; set; }
        public string nroCuenta { get; set; }
        public string nroCuentaCCI { get; set; }
    }
}
