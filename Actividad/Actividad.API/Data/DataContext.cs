using Microsoft.EntityFrameworkCore;
using MaxMind.GeoIP2.Model;
using Actividad.API.Controllers;

namespace Actividad.API.Data
{
    public class DataContext : DbContext
    {
        internal object Researcher;

#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public DataContext(DbContextOptions<DataContext> options) : base(options)
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        {
        }
        public DbSet<ResearcherController> Projects { get; set; }
        public object Investigator { get; internal set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}

