using AppSmartDoctor.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppSmartDoctor.Interfaces
{
    public interface ITokenService
    {
        public string CreateToken(Paciente paciente);
        public string CreateTokenMedico(dynamic medico);
    }
}
