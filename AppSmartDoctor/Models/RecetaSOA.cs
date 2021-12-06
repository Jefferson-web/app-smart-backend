using AppSmartDoctor.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppSmartDoctor.Models
{
    public class RecetaSOA
    {

        public static Receta RegistrarReceta(Receta receta)
        {
            var ctx = new DataContext();
            ctx.Recetas.Add(receta);
            ctx.SaveChanges();
            return receta;
        }

        public static IEnumerable<Receta> ListarRecetas(int citaId) {
            var ctx = new DataContext();
            var recetas = ctx.Recetas.Where(r => r.citaId == citaId).ToList();
            return recetas;
        }

        public static Receta EliminarReceta(int recetaId) {
            var ctx = new DataContext();
            var receta = ctx.Recetas.Find(recetaId);
            if (receta != null)
            {
                ctx.Recetas.Remove(receta);
                ctx.SaveChanges();
                return receta;
            }
            else {
                return null;
            }
        }

    }
}
