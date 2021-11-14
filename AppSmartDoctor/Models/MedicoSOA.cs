using AppSmartDoctor.DataAccess;
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

        public static IEnumerable<Medico> ListarMedicos() {
            var ctx = new DataContext();
            var medicos = ctx.Medicos.ToList();
            return medicos;
        }

        public static dynamic VerPerfil(int medicoId) {
            var ctx = new DataContext();
            var medico = ctx.Medicos.Find(medicoId);
            var experiencias = ctx.Experiencias.Where(exp => exp.medicoId == medicoId).ToList();
            var estudios = ctx.Estudios.Where(est => est.medicoId == medicoId).ToList();
            return new
            {
                medico,
                experiencias,
                estudios
            };
        }

    }
}
