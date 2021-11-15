using AppSmartDoctor.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppSmartDoctor.Models
{
    public class DiagnosticoSOA
    {

        public static Diagnostico RegistrarDiagnostico(int citaId, string descripcion) {
            var ctx = new DataContext();
            var diagnostico = new Diagnostico();
            diagnostico.citaId = citaId;
            diagnostico.descripcion = descripcion;
            ctx.Diagnosticos.Add(diagnostico);
            ctx.SaveChanges();
            return diagnostico;
        }

        public static IEnumerable<Diagnostico> ListarDiagnosticos(int citaId) {
            var ctx = new DataContext();
            var diagnosticos = ctx.Diagnosticos.Where(d => d.citaId == citaId).ToList();
            return diagnosticos;
        }

        public static Diagnostico EliminarDiagnostico(int diagnosticoId) {
            var ctx = new DataContext();
            var diagnostico = ctx.Diagnosticos.Find(diagnosticoId);
            if (diagnostico != null)
            {
                ctx.Diagnosticos.Remove(diagnostico);
                ctx.SaveChanges();
                return diagnostico;
            }
            else {
                return null;
            }
        }

    }
}
