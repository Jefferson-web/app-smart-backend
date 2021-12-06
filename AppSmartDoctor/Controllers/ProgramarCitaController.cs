using AppSmartDoctor.DataAccess;
using AppSmartDoctor.Models;
using AppSmartDoctor.Models.ViewModel;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace AppSmartDoctor.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProgramarCitaController : ControllerBase
    {
        private readonly IMapper _mapper;
        public ProgramarCitaController(IMapper mapper)
        {
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        [HttpPost("Programar")]
        public Cita Programar(CitaDTO citaDto)
        {
            var cita = _mapper.Map<Cita>(citaDto);
            return CitaSOA.ProgramarCita(cita, citaDto.horarioId);
        }

        [HttpGet("ListarHorariosDisponibles")]
        public IEnumerable<Horario> ListarHorariosDisponibles(int medicoId, DateTime fecha)
        {
            return HorarioSOA.ListarHorariosDisponibles(medicoId, fecha);
        }

        [HttpPost("SubirArchivos/{citaId}")]
        public IActionResult SubirArchivos(int citaId) {
            var files = Request.Form.Files;
            var ctx = new DataContext();
            var cita = ctx.Citas.Find(citaId);
            if (cita == null)
                return NotFound();
            foreach (var file in files)
            {
                using var memory = new MemoryStream();
                file.CopyTo(memory);
                Archivo archivo = new Archivo();
                archivo.citaId = citaId;
                archivo.nombre = Path.GetFileNameWithoutExtension(file.FileName);
                archivo.extension = Path.GetExtension(file.FileName);
                archivo.tamano = file.Length;
                archivo.content_type = file.ContentType;
                archivo.data = memory.ToArray();
                ctx.Archivos.Add(archivo);
                ctx.SaveChanges();
            }
            return Ok("Archivo subidos correctamente.");
        }

    }
}
