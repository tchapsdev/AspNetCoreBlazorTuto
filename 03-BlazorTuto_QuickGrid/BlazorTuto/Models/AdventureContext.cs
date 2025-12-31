using Microsoft.EntityFrameworkCore;

namespace BlazorTuto.Models
{
    public class AdventureContext : DbContext
    {
        public AdventureContext()
        {

        }
        public AdventureContext(DbContextOptions<AdventureContext> options)
            : base(options)
        {
        }

        public DbSet<Person> People { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Person>().ToTable("Person");
        }
    }
}
