using AppSmartDoctor.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppSmartDoctor.Models
{
    public class CalificacionSOA
    {

        public static Calificacion Calificar(int pacienteId, int medicoId, double puntuacion, string comentario)
        {
            var ctx = new DataContext();
            var calificacion = new Calificacion();
            calificacion.pacienteId = pacienteId;
            calificacion.medicoId = medicoId;
            calificacion.puntuacion = puntuacion;
            calificacion.comentario = comentario;
            calificacion.fecha_registro = DateTime.Now;
            ctx.Calificaciones.Add(calificacion);
            ctx.SaveChanges();
            return calificacion;
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
                                      paciente = paciente.nombres,
                                      calificacion = calificacion.puntuacion,
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
            var promedio = calificaciones.ToList().Sum(c => c.puntuacion) / calificaciones.Count();
            return promedio;
        }

        public static Calificacion VerCalificacion(int calificacionId) {
            var ctx = new DataContext();
            var calificacion = ctx.Calificaciones.Find(calificacionId);
            return calificacion;
        }

    }
}
