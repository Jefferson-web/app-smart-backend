using AppSmartDoctor.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppSmartDoctor.Models
{
    public class TipoPagoSOA
    {

        public static IEnumerable<TipoPago> ListarTiposDePago()
        {
            var ctx = new DataContext();
            var tiposDePago = ctx.TipoPago.ToList();
            return tiposDePago;
        }

    }
}
