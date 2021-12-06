using AppSmartDoctor.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppSmartDoctor.Models
{
    public class CitaSOA
    {

        public static IEnumerable<dynamic> ListarCitasPaciente(int pacienteId) {
            var ctx = new DataContext();
            var citas = from c in ctx.Citas
                        join p in ctx.Pacientes
                        on c.pacienteId equals p.pacienteId
                        join m in ctx.Medicos
                        on c.medicoId equals m.medicoId
                        where p.pacienteId == pacienteId
                        select new
                        {
                            medico = m.nombres,
                            sexo = m.sexo,
                            edad = m.edad,
                            fecha = c.fecha,
                            hora_inicio = c.hora_inicio,
                            atendido = c.atendido
                        };
            return citas;
        }

        public static Cita ProgramarCita(Cita cita, int horarioId) {
            var ctx = new DataContext();

            var consulta = ctx.Consultorios.FirstOrDefault(c => c.medicoId == cita.medicoId);
            var horario = ctx.Horarios.FirstOrDefault(horario => horario.horarioId == horarioId);

            cita.fecha = horario.fecha;
            cita.hora_inicio = horario.hora_inicio;
            cita.hora_fin = horario.hora_fin;
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

        public static IEnumerable<dynamic> ListarCitasAgendadas(int medicoId) {
            var ctx = new DataContext();
            var citas = from c in ctx.Citas
                                    join p in ctx.Pacientes
                                    on c.pacienteId equals p.pacienteId
                                    join m in ctx.Medicos
                                    on c.medicoId equals m.medicoId
                                    where m.medicoId == medicoId && c.atendido == false
                                    select new
                                    {
                                        citaId = c.citaId,
                                        medico = m.nombres,
                                        sexo = p.sexo,
                                        edad = p.edad,
                                        fecha = c.fecha,
                                        hora_inicio = c.hora_inicio,
                                        atendido = c.atendido,
                                        paciente = p.nombres
                                    };
            return citas;
        }

        public static IEnumerable<dynamic> RegistroPacientes(int medicoId)
        {
            var ctx = new DataContext();
            var citas = from c in ctx.Citas
                        join p in ctx.Pacientes
                        on c.pacienteId equals p.pacienteId
                        join m in ctx.Medicos
                        on c.medicoId equals m.medicoId
                        where m.medicoId == medicoId && c.atendido == true
                        select new
                        {
                            citaId = c.citaId,
                            medico = m.nombres,
                            sexo = p.sexo,
                            edad = p.edad,
                            fecha = c.fecha,
                            hora_inicio = c.hora_inicio,
                            atendido = c.atendido,
                            paciente = p.nombres
                        };
            return citas;
        }

        public static dynamic VerDetalle(int citaId) {
            var ctx = new DataContext();
            var detalle = (from cita in ctx.Citas
                           join medico in ctx.Medicos on cita.medicoId equals medico.medicoId
                           join especialidad in ctx.Especialidades on medico.especialidadId equals especialidad.especialidadId
                           join paciente in ctx.Pacientes on cita.pacienteId equals paciente.pacienteId
                           where cita.citaId == citaId
                           select new
                           {
                               medico = medico.nombres,
                               especialidad = especialidad.nombre,
                               descripcion = medico.descripcion,
                               fecha = cita.hora_inicio,
                               tiempo = (cita.hora_fin - cita.hora_inicio).Minutes,
                               paciente = paciente.nombres,
                               motivo = cita.motivo,
                               precio = cita.costo,
                               sexo = paciente.sexo,
                               edad = paciente.edad
                           }).FirstOrDefault();
            return detalle;
        }

    }
}
