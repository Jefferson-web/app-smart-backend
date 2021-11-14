using AppSmartDoctor.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppSmartDoctor.Models
{
    public class EstudioSOA
    {

        public static Estudio RegistrarEstudio(int medicoId, string descripcion, int anio) {
            var ctx = new DataContext();
            var estudio = new Estudio();
            estudio.medicoId = medicoId;
            estudio.descripcion = descripcion;
            estudio.anio = anio;
            ctx.Estudios.Add(estudio);
            ctx.SaveChanges();
            return estudio;
        }

        public static IEnumerable<Estudio> ListarEstudios(int medicoId) {
            var ctx = new DataContext();
            var estudios = ctx.Estudios.Where(m => m.medicoId == medicoId).ToList();
            return estudios;
        }

    }
}
