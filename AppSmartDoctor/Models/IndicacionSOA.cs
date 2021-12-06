using AppSmartDoctor.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppSmartDoctor.Models
{
    public class IndicacionSOA
    {

        public static Indicacion RegistrarIndicacion(Indicacion indicacion)
        {
            var ctx = new DataContext();
            ctx.Indicaciones.Add(indicacion);
            ctx.SaveChanges();
            return indicacion;
        }

        public static IEnumerable<Indicacion> ListarIndicaciones(int citaId)
        {
            var ctx = new DataContext();
            var indicaciones = ctx.Indicaciones.Where(i => i.citaId == citaId).ToList();
            return indicaciones;
        }

        public static Indicacion EliminarIndicacion(int indicacionId)
        {
            var ctx = new DataContext();
            var indicacion = ctx.Indicaciones.Find(indicacionId);
            if (indicacion != null)
            {
                ctx.Indicaciones.Remove(indicacion);
                ctx.SaveChanges();
                return indicacion;
            }
            else
            {
                return null;
            }
        }

    }
}
