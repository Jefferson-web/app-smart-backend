using AppSmartDoctor.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppSmartDoctor.DataAccess
{
    public class DataContext : DbContext
    {
        public DataContext() { }
        public DataContext(DbContextOptions options) : base(options) { }

        public DbSet<Medico> Medicos { get; set; }
        public DbSet<Especialidad> Especialidades { get; set; }
        public DbSet<Paciente> Pacientes { get; set; }
        public DbSet<Residencia> Residencias { get; set; }
        public DbSet<Cita> Citas { get; set; }
        public DbSet<Consultorio> Consultorios { get; set; }
        public DbSet<Archivo> Archivos { get; set; }
        public DbSet<Estudio> Estudios { get; set; }
        public DbSet<Experiencia> Experiencias { get; set; }
        public DbSet<Pago> Pagos { get; set; }
        public DbSet<TipoPago> TipoPago {get; set;}
        public DbSet<Horario> Horarios { get; set; }
        public DbSet<CuentaDoctor> CuentaDoctor { get; set; }
        public DbSet<Receta> Recetas { get; set; }
        public DbSet<Indicacion> Indicaciones { get; set; }
        public DbSet<Diagnostico> Diagnosticos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            modelBuilder
                .Entity<Medico>()
                .HasOne<Especialidad>()
                .WithMany()
                .HasForeignKey(prop => prop.especialidadId);
            modelBuilder
                .Entity<Medico>()
                .HasOne<Residencia>()
                .WithMany()
                .HasForeignKey(prop => prop.residenciaId);
            modelBuilder
                .Entity<Medico>()
                .HasMany<Cita>()
                .WithOne()
                .HasForeignKey(prop => prop.medicoId);
            modelBuilder
                .Entity<Paciente>()
                .HasMany<Cita>()
                .WithOne()
                .HasForeignKey(prop => prop.pacienteId);
            modelBuilder
                .Entity<Medico>()
                .HasMany<Estudio>()
                .WithOne()
                .HasForeignKey(prop => prop.medicoId);
            modelBuilder
                .Entity<Medico>()
                .HasMany<Experiencia>()
                .WithOne()
                .HasForeignKey(prop => prop.medicoId);
            modelBuilder
                .Entity<TipoPago>()
                .HasMany<Pago>()
                .WithOne()
                .HasForeignKey(prop => prop.tipoPagoId);
            modelBuilder
                .Entity<Cita>()
                .HasMany<Pago>()
                .WithOne()
                .HasForeignKey(prop => prop.citaId);
            modelBuilder
                .Entity<Cita>()
                .HasMany<Archivo>()
                .WithOne()
                .HasForeignKey(prop => prop.citaId);
            modelBuilder
                .Entity<Medico>()
                .HasOne<Consultorio>()
                .WithOne()
                .HasForeignKey<Consultorio>(c => c.medicoId);
            modelBuilder
                .Entity<Medico>()
                .HasMany<Horario>()
                .WithOne()
                .HasForeignKey(prop => prop.medicoId);
            modelBuilder
                .Entity<Medico>()
                .HasOne<CuentaDoctor>()
                .WithOne()
                .HasForeignKey<CuentaDoctor>(c => c.medicoId);
            modelBuilder
                .Entity<Paciente>()
                .HasOne<FichaClinica>()
                .WithOne()
                .HasForeignKey<FichaClinica>(f => f.pacienteId);
            modelBuilder
                .Entity<Cita>()
                .HasMany<Receta>()
                .WithOne()
                .HasForeignKey(r => r.citaId);
            modelBuilder
                .Entity<Cita>()
                .HasMany<Diagnostico>()
                .WithOne()
                .HasForeignKey(d => d.citaId);
            modelBuilder
                .Entity<Cita>()
                .HasMany<Indicacion>()
                .WithOne()
                .HasForeignKey(i => i.citaId);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=localhost;Database=db_smartdoctor;User Id=sa;Password=12345");
            }
        }

    }
}
