using AppSmartDoctor.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppSmartDoctor.Interfaces
{
    public interface ITokenService
    {
        public String CreateToken(Paciente paciente);
    }
}
