using BulkyWeb.Models;
using Microsoft.EntityFrameworkCore;

namespace BulkyWeb.Data {
    public class ApplicationDbContext : DbContext {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) {

        }
        public DbSet<Category> Categories { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Mammals" },
                new Category { Id = 2, Name = "Birds" },
                new Category { Id = 3, Name = "Fish" },
                new Category { Id = 4, Name = "Reptiles" },
                new Category { Id = 5, Name = "Amphibians" }
                );
        }
    }
}
