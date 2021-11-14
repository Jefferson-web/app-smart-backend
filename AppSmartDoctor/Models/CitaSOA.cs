using AppSmartDoctor.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppSmartDoctor.Models
{
    public class CitaSOA
    {

        public static Cita ProgramarCita(int medicoId, int pacienteId, int horarioId, string motivo) {
            var ctx = new DataContext();

            var consulta = ctx.Consultorios.FirstOrDefault(c => c.medicoId == medicoId);
            var horario = ctx.Horarios.FirstOrDefault(horario => horario.horarioId == horarioId);

            var cita = new Cita();
            cita.medicoId = medicoId;
            cita.pacienteId = pacienteId;
            cita.fecha = horario.fecha;
            cita.hora_inicio = horario.hora_inicio;
            cita.hora_fin = horario.hora_fin;
            cita.motivo = motivo;
            cita.costo = consulta.importe;
            cita.pagado = false;
            cita.atendido = false;
            cita.fecha_registro = DateTime.Now;
            ctx.Citas.Add(cita);
            ctx.SaveChanges();

            horario.disponible = false;
            ctx.Horarios.Update(horario);
            ctx.SaveChanges();

            return cita;
        }

        public static Cita MarcarComoAtendido(int citaId) {
            var ctx = new DataContext();
            var cita = ctx.Citas.Find(citaId);
            cita.atendido = true;
            ctx.Citas.Update(cita);
            ctx.SaveChanges();
            return cita;
        }

        public static IEnumerable<Cita> ListarCitas(int medicoId) {
            var ctx = new DataContext();
            var citas = ctx.Citas.Where(m => m.medicoId == medicoId).ToList();
            return citas;
        }

        public static dynamic VerDetalle(int citaId) {
            var ctx = new DataContext();
            var detalle = from cita in ctx.Citas
                join medico in ctx.Medicos on cita.medicoId equals medico.medicoId
                join especialidad in ctx.Especialidades on medico.especialidadId equals especialidad.especialidadId
                join paciente in ctx.Pacientes on cita.pacienteId equals paciente.pacienteId
                where cita.citaId  == citaId
                select new { 
                    medico = medico.nombres, 
                    especialidad = especialidad.nombre,
                    descripcion = medico.descripcion, 
                    fecha = cita.hora_inicio,
                    tiempo = (cita.hora_fin - cita.hora_inicio).Minutes,
                    paciente = paciente.nombres,
                    motivo = cita.motivo
                };
            return detalle;
        }

    }
}
