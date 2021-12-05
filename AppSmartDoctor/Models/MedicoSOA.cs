using AppSmartDoctor.DataAccess;
using AppSmartDoctor.Models.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppSmartDoctor.Models
{
    public class MedicoSOA
    {

        public static Medico RegistrarMedico(int especialidadId,int residenciaId,string nombres,string CMP,string celular,string correo,string descripcion) {
            var ctx = new DataContext();
            var medico = new Medico();
            medico.especialidadId = especialidadId;
            medico.residenciaId = residenciaId;
            medico.nombres = nombres;
            medico.CMP = CMP;
            medico.celular = celular;
            medico.correo = correo;
            medico.descripcion = descripcion;
            ctx.Medicos.Add(medico);
            ctx.SaveChanges();
            return medico;
        }

        public static Medico EditarMedico(int medicoId, int especialidadId, int residenciaId, string nombres, string CMP, string celular, string correo, string descripcion) {
            var ctx = new DataContext();
            var medico_a_actualizar = ctx.Medicos.Find(medicoId);
            if (medico_a_actualizar != null)
            {
                medico_a_actualizar.nombres = nombres;
                medico_a_actualizar.especialidadId = especialidadId;
                medico_a_actualizar.residenciaId = residenciaId;
                medico_a_actualizar.CMP = CMP;
                medico_a_actualizar.celular = celular;
                medico_a_actualizar.correo = correo;
                medico_a_actualizar.descripcion = descripcion;
                ctx.Medicos.Update(medico_a_actualizar);
                ctx.SaveChanges();
                return medico_a_actualizar;
            }
            else {
                return null;
            }
        }



        //from especialidad in ctx.Especialidades
        //join medico in ctx.Medicos on especialidad.especialidadId equals medico.especialidadId
        //group especialidad by new { especialidad.especialidadId, especialidad.nombre, especialidad.descripcion } into grupo
        //select new { 
        //especialidadId = grupo.Key.especialidadId,
        //nombre = grupo.Key.nombre,
        //descripcion = grupo.Key.descripcion,
        //cantidad_medicos = grupo.Count()
        //};

        public static IEnumerable<dynamic> ListarMedicos() {
            var ctx = new DataContext();
            var medicos = from m in ctx.Medicos
                          join e in ctx.Especialidades on m.especialidadId equals e.especialidadId
                          select new {
                              celular = m.celular,
                              cmp = m.CMP,
                              correo = m.correo,
                              descripcion = m.descripcion,
                              especialidadId = m.especialidadId,
                              especialidad = e.nombre,
                              medicoId = m.medicoId,
                              nombres = m.nombres,
                              residenciaId = m.residenciaId
                          };
            return medicos;
        }

        public static dynamic VerPerfil(int medicoId) {
            var ctx = new DataContext();
            var medico = (from m in ctx.Medicos
                         join c in ctx.Consultorios on m.medicoId equals c.medicoId
                         join e in ctx.Especialidades on m.especialidadId equals e.especialidadId
                         where m.medicoId == medicoId
                         select new MedicoPerfilDTO()
                         {
                             medicoId = m.medicoId,
                             nombres = m.nombres,
                             cmp = m.CMP,
                             correo = m.correo,
                             celular = m.celular,
                             descripcion = m.descripcion,
                             especialidad = e.nombre,
                             especialidadId = e.especialidadId,
                             tiempo_consulta = c.duracion,
                             importe_consulta = c.importe
                         }).SingleOrDefault();
            var experiencias = ctx.Experiencias.Where(exp => exp.medicoId == medicoId).ToList();
            var estudios = ctx.Estudios.Where(est => est.medicoId == medicoId).ToList();
            double calificacion = CalificacionSOA.VerPromedioCalificacion(medicoId);
            return new
            {
                medico,
                experiencias,
                estudios,
                calificacion
            };
        }

    }
}
