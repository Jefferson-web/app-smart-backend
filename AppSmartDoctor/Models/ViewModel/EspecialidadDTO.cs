using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppSmartDoctor.Models.ViewModel
{
    public class EspecialidadDTO
    {
        public int especialidadId { get; set; }
        public string nombre { get; set; }
        public string descripcion { get; set; }
        public int cantidad_medicos { get; set; }
    }
}
