using gymtime_citrino_app.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace gymtime_citrino_app.Infrastructure.Context
{
    public class GymTimeDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public GymTimeDbContext(DbContextOptions<GymTimeDbContext> options) : base(options) {}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
