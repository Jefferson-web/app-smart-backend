using AppSmartDoctor.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppSmartDoctor.Models
{
    public class PacienteSOA
    {

        public static Paciente AdicionarPaciente(string nombres, string DNI, DateTime fecha_nacimiento, int edad, bool sexo, string distrito_colonia, string email, string contrasena) {
            var ctx = new DataContext();
            var paciente = new Paciente();
            paciente.nombres = nombres;
            paciente.DNI = DNI;
            paciente.fecha_nacimiento = fecha_nacimiento;
            paciente.edad = edad;
            paciente.sexo = sexo;
            paciente.distrito_colonia = distrito_colonia;
            paciente.email = email;
            paciente.contrasena = contrasena;
            ctx.Add(paciente);
            ctx.SaveChanges();
            return paciente;
        }

        public static Paciente EditarPaciente(int pacienteId, string nombres, string DNI, DateTime fecha_nacimiento, int edad, bool sexo, string distrito_colonia) {
            var ctx = new DataContext();
            var paciente_a_editar = ObtenerPaciente(pacienteId);
            if (paciente_a_editar != null)
            {
                paciente_a_editar.nombres = nombres;
                paciente_a_editar.DNI = DNI;
                paciente_a_editar.fecha_nacimiento = fecha_nacimiento;
                paciente_a_editar.edad = edad;
                paciente_a_editar.sexo = sexo;
                paciente_a_editar.distrito_colonia = distrito_colonia;
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
