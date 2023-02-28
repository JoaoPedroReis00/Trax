using Microsoft.EntityFrameworkCore;
using Trax.API.Models;

namespace Trax.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) {}
        public DbSet<Carro> Carros { get; set; }
    }
}
