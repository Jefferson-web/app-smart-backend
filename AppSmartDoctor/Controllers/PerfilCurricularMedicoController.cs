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
    public class PerfilCurricularMedicoController : ControllerBase
    {

        [HttpPost("RegistrarEstudio")]
        public Estudio RegistrarEstudio(int medicoId, string descripcion, int anio)
        {
            return EstudioSOA.RegistrarEstudio(medicoId,descripcion,anio);            
        }

        [HttpGet("ListarEstudios/{medicoId:int}")]
        public IEnumerable<Estudio> ListarEstudios( int medicoId) {
            return EstudioSOA.ListarEstudios(medicoId);
        }

        [HttpPost("RegistrarExperiencia")]
        public Experiencia RegistrarExperiencia(int medicoId, string descripcion, int anio) {
            return ExperienciaSOA.RegistrarExperiencia(medicoId,descripcion,anio);
        }

        [HttpGet("ListarExperiencias/{medicoId:int}")]
        public IEnumerable<Experiencia> ListarExperiencias(int medicoId) {
            return ExperienciaSOA.ListarExperiencias(medicoId);
        }

    }
}
