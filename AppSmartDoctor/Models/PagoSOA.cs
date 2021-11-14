using AppSmartDoctor.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppSmartDoctor.Models
{
    public class PagoSOA
    {

        public static Pago RealizarPago(int tipoPagoId, int citaId, string nombreTarjeta, string numeroTarjeta, string expiracion, string cvv) {
            var ctx = new DataContext();
            var cita = ctx.Citas.Find(citaId);

            var pago = new Pago();
            pago.tipoPagoId = tipoPagoId;
            pago.citaId = citaId;
            pago.monto = cita.costo;
            pago.nombreTarjeta = nombreTarjeta;
            pago.numeroTarjeta = numeroTarjeta;
            pago.expiracion = expiracion;
            pago.cvv = cvv;
            pago.fecha_pago = DateTime.Now;
            ctx.Pagos.Add(pago);
            ctx.SaveChanges();
            
            cita.pagado = true;
            ctx.Citas.Update(cita);
            ctx.SaveChanges();
            return pago;
        }

        public static IEnumerable<Pago> ListarPagos(int pacienteId) {
            var ctx = new DataContext();
            var pagos = from pago in ctx.Pagos
                        join cita in ctx.Citas on pago.citaId equals cita.citaId
                        where cita.pacienteId == pacienteId
                        select pago;
            return pagos;
        }

    }
}
