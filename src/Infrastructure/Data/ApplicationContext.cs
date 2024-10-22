using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Profesor> Profesors { get; set; }
        public DbSet<Clase> Clases { get; set; } 
        public DbSet<Administrador> Administradores { get; set; }


        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Usuario>()
                .HasMany(u => u.Clases)
                .WithMany(c => c.UsuariosInscriptos)
                .UsingEntity(j => j.ToTable("UsuarioClase")); 

            modelBuilder.Entity<Clase>()
                .HasOne(c => c.ProfesorClase )
                .WithMany()
                .HasForeignKey("ProfesorId"); 
        }
    }
}

