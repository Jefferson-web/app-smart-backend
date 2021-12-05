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
    public class AfiliarPacienteController : ControllerBase
    {

        [HttpGet("ListarPacientes")]
        public IEnumerable<Paciente> ListarPacientes() {
            return PacienteSOA.ListarPacientes();
        }

        [HttpPost("AdicionarPaciente")]
        public Paciente AdicionarPaciente(string nombres,string DNI,DateTime fecha_nacimiento,int edad,bool sexo,string distrito_colonia, string email,string contrasena) {
            return PacienteSOA.AdicionarPaciente(nombres,DNI,fecha_nacimiento,edad,sexo,distrito_colonia, email, contrasena);
        }

        [HttpPut("EditarPaciente/{pacienteId}")]
        public Paciente EditarPaciente(int pacienteId, string nombres, string DNI, DateTime fecha_nacimiento, int edad, bool sexo, string distrito_colonia) {
            return PacienteSOA.EditarPaciente(pacienteId, nombres, DNI, fecha_nacimiento, edad, sexo, distrito_colonia);
        }

    }
}
