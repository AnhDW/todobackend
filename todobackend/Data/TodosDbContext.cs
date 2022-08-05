using Microsoft.EntityFrameworkCore;
using todobackend.Configuration;
using todobackend.Model;
using todobackend.Seeders;

namespace todobackend.Data
{
    public class TodosDbContext : DbContext
    {
        public TodosDbContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            modelBuilder.ApplyConfiguration(new TodoConfiguration());
            modelBuilder.Seed();
        }

        public DbSet<Todo>Todos{ get; set; }
    }
}
