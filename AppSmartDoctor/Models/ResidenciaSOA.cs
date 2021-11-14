using AppSmartDoctor.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppSmartDoctor.Models
{
    public class ResidenciaSOA
    {

        public static IEnumerable<Residencia> ListarResidencias() {
            var ctx = new DataContext();
            var residencias = ctx.Residencias.ToList();
            return residencias;
        }

    }
}
