using AppSmartDoctor.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppSmartDoctor.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CuentaDoctorController : ControllerBase
    {
        [HttpPost("RegistrarCuenta")]
        public CuentaDoctor RegistrarCuenta(int medicoId, string nombreBanco, string nroCuenta, string nroCuentaCCI) {
            return CuentaDoctorSOA.RegistrarCuentaDoctor(medicoId,nombreBanco,nroCuenta,nroCuentaCCI);
        }

        [HttpPut("EditarCuenta")]
        public CuentaDoctor EditarCuenta(int cuentaId, string nombreBanco, string nroCuenta, string nroCuentaCCI)
        {
            return CuentaDoctorSOA.EditarCuenta(cuentaId, nombreBanco, nroCuenta, nroCuentaCCI);
        }

        [HttpDelete("EliminarCuenta")]
        public CuentaDoctor EliminarCuenta(int cuentaId)
        {
            return CuentaDoctorSOA.EliminarCuenta(cuentaId);
        }

    }
}
