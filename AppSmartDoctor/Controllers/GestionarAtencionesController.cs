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
    public class GestionarAtencionesController : ControllerBase
    {
        [HttpGet("ListarCitas/{medicoId}")]
        public IEnumerable<dynamic> ListarCitasAgendadas(int medicoId) {
            return CitaSOA.ListarCitasAgendadas(medicoId);
        }

        [HttpGet("ListarCitasPaciente/{pacienteId}")]
        public IEnumerable<dynamic> ListarCitasPaciente(int pacienteId) {
            return CitaSOA.ListarCitasPaciente(pacienteId);
        }

        [HttpPost("MarcarComoAtendido/{citaId:int}")]
        public Cita MarcarComoAtendido(int citaId) {
            return CitaSOA.MarcarComoAtendido(citaId);
        }

        [HttpGet("RegistroPacientes/{medicoId}")]
        public IEnumerable<dynamic> RegistroPacientes(int medicoId) {
            return CitaSOA.RegistroPacientes(medicoId);
        }

        [HttpGet("VerDetalles/{citaId}")]
        public dynamic VerDetalles(int citaId) {
            return CitaSOA.VerDetalle(citaId);
        }

    }
}
