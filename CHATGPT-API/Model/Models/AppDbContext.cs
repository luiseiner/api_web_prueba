using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace Model.Models
{
    public class AppDbContext : DbContext
    {
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Pregunta> Preguntas { get; set; }
        public DbSet<Respuesta> Respuestas { get; set; }
        public DbSet<Pront> Pronts { get; set; }
        public DbSet<Detalle> Detalles { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    
    }
}
