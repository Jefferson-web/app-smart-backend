using AppSmartDoctor.Models;
using AppSmartDoctor.Models.ViewModel;
using AutoMapper;
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

        private readonly IMapper _mapper;

        [HttpGet("ListarPacientes")]
        public IEnumerable<Paciente> ListarPacientes() {
            return PacienteSOA.ListarPacientes();
        }

        [HttpPost("AdicionarPaciente")]
        public ActionResult<Paciente> AdicionarPaciente(Paciente paciente) {
            try
            {
                return PacienteSOA.AdicionarPaciente(paciente);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut("EditarPaciente/{pacienteId}")]
        public Paciente EditarPaciente(int pacienteId, string nombres, string DNI, DateTime fecha_nacimiento, int edad, bool sexo, string distrito_colonia) {
            return PacienteSOA.EditarPaciente(pacienteId, nombres, DNI, fecha_nacimiento, edad, sexo, distrito_colonia);
        }

    }
}
