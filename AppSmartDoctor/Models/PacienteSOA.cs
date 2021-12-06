using AppSmartDoctor.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppSmartDoctor.Models
{
    public class PacienteSOA
    {

        public static Paciente AdicionarPaciente(Paciente paciente) {
            var ctx = new DataContext();
            ctx.Add(paciente);
            ctx.SaveChanges();
            return paciente;
        }

        public static Paciente EditarPaciente(Paciente paciente, int pacienteId) {
            var ctx = new DataContext();
            var paciente_a_editar = ObtenerPaciente(pacienteId);
            if (paciente_a_editar != null)
            {
                paciente_a_editar.nombres = paciente.nombres;
                paciente_a_editar.DNI = paciente.DNI;
                paciente_a_editar.edad = paciente.edad;
                paciente_a_editar.distrito_colonia = paciente.distrito_colonia;
                paciente_a_editar.fecha_nacimiento = paciente.fecha_nacimiento;
                paciente_a_editar.sexo = paciente.sexo;
                ctx.Pacientes.Update(paciente_a_editar);
                ctx.SaveChanges();
                return paciente_a_editar;
            }
            else {
                return null;
            }
        }

        public static IEnumerable<Paciente> ListarPacientes() {
            var ctx = new DataContext();
            var pacientes = ctx.Pacientes.ToList();
            return pacientes;
        }

        public static Paciente ObtenerPaciente(int pacienteId) {
            var ctx = new DataContext();
            return ctx.Pacientes.Find(pacienteId);
        }

    }
}
