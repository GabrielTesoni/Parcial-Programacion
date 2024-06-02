using Microsoft.EntityFrameworkCore;
using Parcial_Programacion.Models;
using System.Collections.Generic;


namespace Parcial_Programacion.Datos
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Curso> Curso { get; set; }
    }
}
