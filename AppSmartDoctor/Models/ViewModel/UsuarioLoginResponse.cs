using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppSmartDoctor.Models.ViewModel
{
    public class UsuarioLoginResponse
    {
        public Paciente paciente { get; set; }
        public string token { get; set; }
    }
}
