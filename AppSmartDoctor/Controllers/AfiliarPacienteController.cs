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

        [HttpGet("ObtenerInfoPaciente/{pacienteId}")]
        public ActionResult<Paciente> ObtenerInfoPaciente(int pacienteId) {
            return PacienteSOA.ObtenerPaciente(pacienteId);
        }

        [HttpPut("EditarPaciente/{pacienteId}")]
        public Paciente EditarPaciente([FromBody] Paciente paciente, int pacienteId) {
            return PacienteSOA.EditarPaciente(paciente, pacienteId);
        }

    }
}
