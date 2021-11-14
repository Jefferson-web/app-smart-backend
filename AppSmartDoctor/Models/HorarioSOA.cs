using AppSmartDoctor.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppSmartDoctor.Models
{
    public class HorarioSOA
    {

        public static Horario RegistrarHorario(int medicoId, DateTime fecha, DateTime hora_inicio) {

            var ctx = new DataContext();

            var consultorio = ctx.Consultorios.FirstOrDefault(c => c.medicoId == medicoId);

            var horario = new Horario();
            horario.medicoId = medicoId;
            horario.fecha = fecha;
            horario.hora_inicio = hora_inicio;
            horario.hora_fin = horario.hora_inicio.AddMinutes(consultorio.duracion);
            horario.disponible = true;
            ctx.Horarios.Add(horario);
            ctx.SaveChanges();
            return horario;
        }

        public static IEnumerable<Horario> ListarHorariosDisponibles(int medicoId, DateTime fecha) {
            var ctx = new DataContext();
            var horarios = ctx.Horarios
                .Where(horario => horario.medicoId == medicoId 
                                  && horario.fecha == fecha 
                                  && horario.disponible == true)
                .ToList();
            return horarios;
        }

        public static IEnumerable<Horario> MisHorarios(int medicoId) {
            var ctx = new DataContext();
            var horarios = ctx.Horarios
                    .Where(horario => horario.medicoId == medicoId)
                    .ToList();
            return horarios;
        }

    }
}
