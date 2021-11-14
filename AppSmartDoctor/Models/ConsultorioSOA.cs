using AppSmartDoctor.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppSmartDoctor.Models
{
    public class ConsultorioSOA
    {

        public static Consultorio RegistrarConsultorio(int medicoId, double importe, int duracion) {
            var ctx = new DataContext();
            var consultorio = new Consultorio();
            consultorio.medicoId = medicoId;
            consultorio.importe = importe;
            consultorio.duracion = duracion;
            ctx.Consultorios.Add(consultorio);
            ctx.SaveChanges();
            return consultorio;
        }

        public static Consultorio VerConsultorio(int medicoId) {
            var ctx = new DataContext();
            var consultorio = ctx.Consultorios
                            .Where(c => c.medicoId == medicoId)
                            .FirstOrDefault();
            return consultorio;
        }

    }
}
