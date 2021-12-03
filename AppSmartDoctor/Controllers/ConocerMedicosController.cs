using AppSmartDoctor.Models;
using AppSmartDoctor.Models.ViewModel;
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
        public IEnumerable<dynamic> ListarEspecialidades(string filtro_nombre = null) {
            var especialidades = EspecialidadSOA.ListarEspecialidades();
            if (filtro_nombre != null) {
                especialidades = especialidades.Where(esp => esp.nombre.Contains(filtro_nombre));            
            }
            return especialidades;
        }

        [HttpGet("ListarMedicos")]
        public IEnumerable<Medico> ListarMedicos(string filtro_nombre = null, int? especialidadId = null) {
            var medicos = MedicoSOA.ListarMedicos();
            // Aplicando filtros
            if (filtro_nombre != null) {
                medicos = medicos.Where(medico => medico.nombres.Contains(filtro_nombre));
            }
            if (especialidadId != null) {
                medicos = medicos.Where(medico => medico.especialidadId == especialidadId);
            }
            return medicos;
        }

        [HttpGet("VerPerfil/{medicoId}")]
        public ActionResult<dynamic> VerPerfil(int medicoId) {
            return MedicoSOA.VerPerfil(medicoId);
        }

    }
}
