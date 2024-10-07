using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using MSADBMigrations.Models;

namespace MSADBMigrations.Context
{
    public class MSAContext: DbContext
    {
        private IConfiguration configuration;

        public MSAContext()
        {
            configuration = Program.BuilderConfiguration();
        }

        public MSAContext(DbContextOptions<MSAContext> options): base(options)
        {
            configuration = Program.BuilderConfiguration();
        }

        public DbSet<UserDetails> Users { get; set; }
        public DbSet<LocationDetails> Locations { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(configuration["ConnectionString:db_string"]);
        }
    }
}
