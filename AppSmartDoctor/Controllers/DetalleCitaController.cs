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
    public class DetalleCitaController : ControllerBase
    {
        [HttpPost("RegistrarReceta")]
        public Receta RegistrarReceta(Receta receta)
        {
            return RecetaSOA.RegistrarReceta(receta);
        }

        [HttpGet("ListarRecetas/{citaId}")]
        public IEnumerable<Receta> ListarRecetas(int citaId) {
            return RecetaSOA.ListarRecetas(citaId);
        }

        [HttpDelete("EliminarReceta/{recetaId}")]
        public Receta EliminarReceta(int recetaId)
        {
            return RecetaSOA.EliminarReceta(recetaId);
        }

        // DIAGNOSTICOS

        [HttpPost("RegistrarDiagnostico")]
        public Diagnostico RegistrarDiagnostico(Diagnostico diagnostico) {
            return DiagnosticoSOA.RegistrarDiagnostico(diagnostico);
        }

        [HttpGet("ListarDiagnosticos/{citaId}")]
        public IEnumerable<Diagnostico> ListarDiagnosticos(int citaId) {
            return DiagnosticoSOA.ListarDiagnosticos(citaId);
        }

        [HttpDelete("EliminarDiagnostico/{diagnosticoId}")]
        public Diagnostico EliminarDiagnostico(int diagnosticoId) {
            return DiagnosticoSOA.EliminarDiagnostico(diagnosticoId);
        }

        // INDICACIONES

        [HttpPost("RegistrarIndicacion")]
        public Indicacion RegistrarIndicacion(Indicacion indicacion)
        {
            return IndicacionSOA.RegistrarIndicacion(indicacion);
        }

        [HttpGet("ListarIndicaciones/{citaId}")]
        public IEnumerable<Indicacion> ListarIndicaciones(int citaId)
        {
            return IndicacionSOA.ListarIndicaciones(citaId);
        }

        [HttpDelete("EliminarIndicacion/{indicacionId}")]
        public Indicacion EliminarIndicacion(int indicacionId)
        {
            return IndicacionSOA.EliminarIndicacion(indicacionId);
        }

    }
}
