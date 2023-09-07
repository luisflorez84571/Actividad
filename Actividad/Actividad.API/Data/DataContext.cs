using Microsoft.EntityFrameworkCore;
using MaxMind.GeoIP2.Model;
using Actividad.API.Controllers;

namespace Actividad.API.Data
{
    public class DataContext : DbContext
    {

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }
        public DbSet<ProjectController> Projects { get; set; }
        public object Project { get; internal set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}

