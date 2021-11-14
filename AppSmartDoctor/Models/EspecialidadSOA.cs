using AppSmartDoctor.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppSmartDoctor.Models
{
    public class EspecialidadSOA
    {

        public static IEnumerable<Especialidad> ListarEspecialidades() {
            var ctx = new DataContext();
            var especialidades = ctx.Especialidades.ToList();
            return especialidades;
        }

    }
}
