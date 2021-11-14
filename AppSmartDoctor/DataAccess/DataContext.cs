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
