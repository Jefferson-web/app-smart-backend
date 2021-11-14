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
    public class ConocerMedicosController : ControllerBase
    {

        [HttpGet("ListarEspecialidades")]
        public IEnumerable<Especialidad> ListarEspecialidades() {
            return EspecialidadSOA.ListarEspecialidades();
        }

        [HttpGet("ListarMedicos")]
        public IEnumerable<Medico> ListarMedicos(string q = null, int? especialidadId = null) {
            var medicos = MedicoSOA.ListarMedicos();
            // Aplicando filtros
            if (q != null)
                medicos = medicos.Where(medico => medico.nombres.Contains(q));
            if (especialidadId != null)
                medicos = medicos.Where(medico => medico.especialidadId == especialidadId);
            return medicos;
        }

        [HttpGet("VerPerfil/{medicoId}")]
        public ActionResult<dynamic> VerPerfil(int medicoId) {
            return MedicoSOA.VerPerfil(medicoId);
        }

    }
}
