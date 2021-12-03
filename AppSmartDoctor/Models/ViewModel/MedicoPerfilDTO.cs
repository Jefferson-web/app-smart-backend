using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppSmartDoctor.Models.ViewModel
{
    public class MedicoPerfilDTO
    {
        public int medicoId { get; set; }
        public string nombres { get; set; }
        public string cmp { get; set; }
        public string correo { get; set; }
        public string celular { get; set; }
        public string descripcion { get; set; }
        public string especialidad { get; set; }
        public int tiempo_consulta { get; set; }
        public double importe_consulta { get; set; }
        public double promedio_calificacion { get; set; }
    }
}
