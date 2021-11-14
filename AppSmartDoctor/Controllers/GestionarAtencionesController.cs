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
        [HttpGet("ListarCitas")]
        public IEnumerable<Cita> ListarCitas(int medicoId) {
            return CitaSOA.ListarCitas(medicoId);
        }

        [HttpPost("MarcarComoAtendido/{citaId:int}")]
        public Cita MarcarComoAtendido(int citaId) {
            return CitaSOA.MarcarComoAtendido(citaId);
        }

        [HttpGet("VerDetalles/{citaId}")]
        public dynamic VerDetalles(int citaId) {
            return CitaSOA.VerDetalle(citaId);
        }

    }
}
