using AppSmartDoctor.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppSmartDoctor.Models
{
    public class ExperienciaSOA
    {
        public static Experiencia RegistrarExperiencia(int medicoId, string descripcion, int anio)
        {
            var ctx = new DataContext();
            var experiencia = new Experiencia();
            experiencia.medicoId = medicoId;
            experiencia.descripcion = descripcion;
            experiencia.anio = anio;
            ctx.Experiencias.Add(experiencia);
            ctx.SaveChanges();
            return experiencia;
        }

        public static IEnumerable<Experiencia> ListarExperiencias(int medicoId)
        {
            var ctx = new DataContext();
            var experiencias = ctx.Experiencias.Where(m => m.medicoId == medicoId).ToList();
            return experiencias;
        }

    }
}
