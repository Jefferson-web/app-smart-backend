using AppSmartDoctor.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppSmartDoctor.DataAccess
{
    public class DataContextSeed
    {
        public static async Task SeedAsync(DataContext ctx) {
            if (!ctx.Especialidades.Any())
            {
                ctx.Especialidades.AddRange(getEspecialidades());
                await ctx.SaveChangesAsync();
            }
            if (!ctx.Residencias.Any())
            {
                ctx.Residencias.AddRange(getResidencias());
                await ctx.SaveChangesAsync();
            }
            if (!ctx.TipoPago.Any())
            {
                ctx.TipoPago.AddRange(getTipoPagos());
                await ctx.SaveChangesAsync();
            }
        }

        public static IEnumerable<TipoPago> getTipoPagos() {
            return new List<TipoPago>() {
                new TipoPago(){ tipo = "Pagar con Tarjeta" },
                new TipoPago(){ tipo = "Tengo un código de pago" },
                new TipoPago(){ tipo = "Otros medios de pago" }
            };
        }

        public static IEnumerable<Residencia> getResidencias()
        {
            return new List<Residencia>() {
                new Residencia() { pais = "Perú" },
                new Residencia() { pais = "México" },
                new Residencia() { pais = "Colombia" }
            };
        }

        private static IEnumerable<Especialidad> getEspecialidades()
        {
            return new List<Especialidad>()
            {
                new Especialidad(){ nombre = "Medicina General" },
                new Especialidad(){ nombre = "Psicología" },
                new Especialidad(){ nombre = "Psiquiatría" },
                new Especialidad(){ nombre = "Pediatría" },
                new Especialidad(){ nombre = "Endocrinología" },
                new Especialidad(){ nombre = "Nutrición" },
                new Especialidad(){ nombre = "Reumatología" },
                new Especialidad(){ nombre = "Cardiología" },
                new Especialidad(){ nombre = "Cirugia General" },
                new Especialidad(){ nombre = "Dermatología" },
                new Especialidad(){ nombre = "Endocrinologia Pediátrica" },
                new Especialidad(){ nombre = "Fisioterapia" },
                new Especialidad(){ nombre = "Gestroenterología" },
                new Especialidad(){ nombre = "Geriatría" },
                new Especialidad(){ nombre = "Ginecología" },
                new Especialidad(){ nombre = "Hermatología" },
                new Especialidad(){ nombre = "Medicina Familiar y Comunitaria" },
                new Especialidad(){ nombre = "Medicina Física y Rehabilitación" },
                new Especialidad(){ nombre = "Medicina Interna" },
                new Especialidad(){ nombre = "Neumología" },
                new Especialidad(){ nombre = "Neumologia Pediátrica" },
                new Especialidad(){ nombre = "Neurología" },
                new Especialidad(){ nombre = "Odontología" },
                new Especialidad(){ nombre = "Oftalmología" },
                new Especialidad(){ nombre = "Oncología" },
                new Especialidad(){ nombre = "Otorrinoraingología" },
                new Especialidad(){ nombre = "Urología" },
                new Especialidad(){ nombre = "Urologia Pediátrica" },
                new Especialidad(){ nombre = "Gestroenterologia Pediátrica" },
                new Especialidad(){ nombre = "Neurocirugía" }
            };
        }

    }
}
