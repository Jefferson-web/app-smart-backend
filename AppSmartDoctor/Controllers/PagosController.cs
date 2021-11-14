using AppSmartDoctor.DataAccess;
using AppSmartDoctor.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppSmartDoctor.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PagosController : ControllerBase
    {
        [HttpGet("ListarTiposDePago")]
        public IEnumerable<TipoPago> ListarTiposDePago()
        {
            return TipoPagoSOA.ListarTiposDePago();
        }

        [HttpPost("RegistrarPago")]
        public Pago RegistrarPago(int tipoPagoId,int citaId, string nombreTarjeta, string numeroTarjeta, string expiracion, string cvv) {
            return PagoSOA.RealizarPago(tipoPagoId,citaId,nombreTarjeta,numeroTarjeta,expiracion,cvv);
        }

        [HttpGet("ListarPagos")]
        public IEnumerable<Pago> ListarPagos(int pacienteId) {
            return PagoSOA.ListarPagos(pacienteId);
        }

    }
}
