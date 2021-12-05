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
    public class GestionarConsultorioController : ControllerBase
    {

        [HttpPost("RegistrarConsultorio")]
        public Consultorio RegistrarConsultorio(int medicoId, double importe, int duracion) {
            return ConsultorioSOA.RegistrarConsultorio(medicoId,importe,duracion);
        }

        [HttpGet("VerConsultorio/{medicoId:int}")]
        public Consultorio VerConsultorio(int medicoId) {
            return ConsultorioSOA.VerConsultorio(medicoId);
        }

        [HttpPost("RegistrarHorario")]
        public Horario RegistrarHorario(int medicoId, DateTime fecha, DateTime hora_inicio) {
            return HorarioSOA.RegistrarHorario(medicoId,fecha,hora_inicio);
        }

        [HttpGet("MisHorarios/{medicoId:int}")]
        public IEnumerable<Horario> MisHorarios(int medicoId)
        {
            return HorarioSOA.MisHorarios(medicoId);
        }

        [HttpGet("VerHorario/{horarioId:int}")]
        public dynamic VerHorario(int horarioId) {
            return HorarioSOA.VerHorario(horarioId);
        }

    }
}
