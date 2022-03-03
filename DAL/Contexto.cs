using Microsoft.EntityFrameworkCore;
using ProductosDetalles_2.Models;

namespace ProductosDetalles_2.DAL
{
    public class Contexto : DbContext
    {
        public DbSet<Productos> Productos { get; set; }

        public Contexto(DbContextOptions<Contexto> options) : base(options){}
    }
}