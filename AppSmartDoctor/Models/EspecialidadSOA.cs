using AppSmartDoctor.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppSmartDoctor.Models
{
    public class EspecialidadSOA
    {

        public static IEnumerable<dynamic> ListarEspecialidades() {
            var ctx = new DataContext();
            var especialidades = from especialidad in ctx.Especialidades
                                 join medico in ctx.Medicos on especialidad.especialidadId equals medico.especialidadId
                                 group especialidad by new { especialidad.especialidadId, especialidad.nombre, especialidad.descripcion, especialidad.imagen } into grupo
                                 select new { 
                                    especialidadId = grupo.Key.especialidadId,
                                    nombre = grupo.Key.nombre,
                                    descripcion = grupo.Key.descripcion,
                                    imagen = grupo.Key.imagen,
                                    cantidad_medicos = grupo.Count()
                                 };
            return especialidades;
        }

    }
}
