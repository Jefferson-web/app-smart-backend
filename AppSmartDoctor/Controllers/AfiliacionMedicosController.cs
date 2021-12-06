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
    public class AfiliacionMedicosController : ControllerBase
    {
        [HttpPost("RegistrarMedico")]
        public Medico RegistrarMedico(Medico medico) {
            return MedicoSOA.RegistrarMedico(medico);
        }

        [HttpPut("EditarMedico/{medicoId}")]
        public Medico EditarMedico(int medicoId,int especialidadId,int residenciaId,string nombres,string CMP,string celular,string correo,string descripcion) {
            return MedicoSOA.EditarMedico(medicoId,especialidadId,residenciaId,nombres, CMP,celular,correo,descripcion);
        }

        [HttpGet("ListarTodasLasEspecialidades")]
        public IEnumerable<Especialidad> ListarTodasLasEspecialidades() {
            return MedicoSOA.ListarTodasLasEspecialidades();
        }

        [HttpGet("ListarResidencias")]
        public IEnumerable<Residencia> ListarResidencias() {
            return ResidenciaSOA.ListarResidencias();
        }
    }
}
