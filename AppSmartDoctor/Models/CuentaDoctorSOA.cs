using AppSmartDoctor.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppSmartDoctor.Models
{
    public class CuentaDoctorSOA
    {

        public static CuentaDoctor RegistrarCuentaDoctor(int medicoId, string nombreBanco, string nroCuenta, string nroCuentaCCI)
        {
            var ctx = new DataContext();
            var cuenta = new CuentaDoctor();
            cuenta.medicoId = medicoId;
            cuenta.nombreBanco = nombreBanco;
            cuenta.nroCuenta = nroCuenta;
            cuenta.nroCuentaCCI = nroCuentaCCI;
            ctx.CuentaDoctor.Add(cuenta);
            ctx.SaveChanges();
            return cuenta;
        }

        public static CuentaDoctor EditarCuenta(int cuentaId, string nombreBanco, string nroCuenta, string nroCuentaCCI) {
            var ctx = new DataContext();
            var cuenta = ctx.CuentaDoctor.Find(cuentaId);
            if (cuenta != null)
            {
                cuenta.nombreBanco = nombreBanco;
                cuenta.nroCuenta = nroCuenta;
                cuenta.nroCuenta = nroCuentaCCI;
                ctx.CuentaDoctor.Update(cuenta);
                ctx.SaveChanges();
            }
            return cuenta;
        }

        public static CuentaDoctor EliminarCuenta(int medicoId) {
            var ctx = new DataContext();
            var cuenta = ctx.CuentaDoctor.Find(medicoId);
            if (cuenta != null)
            {
                ctx.CuentaDoctor.Remove(cuenta);
                ctx.SaveChanges();
                return cuenta;
            }
            else {
                return null;
            }
        }

    }
}
