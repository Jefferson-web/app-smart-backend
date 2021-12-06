using AppSmartDoctor.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppSmartDoctor.Models
{
    public class CalificacionSOA
    {

        public static dynamic Calificar(Calificacion calificacion)
        {
            var ctx = new DataContext();
            calificacion.fecha_registro = DateTime.Now;
            ctx.Calificaciones.Add(calificacion);
            ctx.SaveChanges();
            var calificacionCreada = (from c in ctx.Calificaciones
                                 join paciente in ctx.Pacientes on calificacion.pacienteId equals paciente.pacienteId
                                 where c.calificacionId == calificacion.calificacionId
                                 select new
                                 {
                                     calificacionId = c.calificacionId,
                                     paciente = paciente.nombres,
                                     puntuacion = c.puntuacion,
                                     comentario = c.comentario,
                                     fecha = c.fecha_registro
                                 }).FirstOrDefault();
            return calificacionCreada;
        }

        public static Calificacion EditarComentario(int calificacionId, string comentario) {
            var ctx = new DataContext();
            var calificacion = ctx.Calificaciones.Find(calificacionId);
            if (calificacion != null)
            {
                calificacion.comentario = comentario;
                ctx.Calificaciones.Update(calificacion);
                ctx.SaveChanges();
            }
            return calificacion;
        }

        public static Calificacion EliminarCalificacion(int calificacionId) {
            var ctx = new DataContext();
            var calificacion = ctx.Calificaciones.Find(calificacionId);
            ctx.Calificaciones.Remove(calificacion);
            ctx.SaveChanges();
            return calificacion;
        }

        public static IEnumerable<dynamic> VerCalificaciones(int medicoId) {
            var ctx = new DataContext();
            var calificaciones = (from calificacion in ctx.Calificaciones
                                  join paciente in ctx.Pacientes on calificacion.pacienteId equals paciente.pacienteId
                                  where calificacion.medicoId == medicoId
                                  select new
                                  {
                                      calificacionId = calificacion.calificacionId,
                                      paciente = paciente.nombres,
                                      puntuacion = calificacion.puntuacion,
                                      comentario = calificacion.comentario,
                                      fecha = calificacion.fecha_registro
                                  }).ToList();
            return calificaciones;
        }

        public static double VerPromedioCalificacion(int medicoId) {
            var ctx = new DataContext();
            var calificaciones = from calificacion in ctx.Calificaciones
                                 where calificacion.medicoId == medicoId
                                 select calificacion;
            if (calificaciones.Count() > 0) {
                double promedio = calificaciones.ToList().Sum(c => c.puntuacion) / calificaciones.Count();
                return promedio;
            }
            return 0;
        }

        public static dynamic InfoMedico(int medicoId)
        {
            var ctx = new DataContext();
            var medico = (from m in ctx.Medicos
                          join e in ctx.Especialidades on m.especialidadId equals e.especialidadId
                          where m.medicoId == medicoId
                          select new
                          {
                              nombre_medico = m.nombres,
                              nombre_especialidad = e.nombre
                          }).SingleOrDefault();
            return medico;
        }

        public static Calificacion VerCalificacion(int calificacionId) {
            var ctx = new DataContext();
            var calificacion = ctx.Calificaciones.Find(calificacionId);
            return calificacion;
        }

    }
}
