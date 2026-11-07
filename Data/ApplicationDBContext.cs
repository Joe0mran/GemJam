using System;
using GemJam.Models;
using Microsoft.EntityFrameworkCore;

namespace GemJam.Data;

public class ApplicationDBContext : DbContext{
    public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options){}
    public DbSet<Category> Categories { get; set; }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<Category>().HasData(
            new Category {CategoryId = 1, Name = "Rings"},
            new Category {CategoryId = 2, Name = "Earings"},
            new Category {CategoryId = 3, Name = "Bracelets"},
            new Category {CategoryId = 4, Name = "Necklaces"},
            new Category {CategoryId = 5, Name = "Bangles"},
            new Category {CategoryId = 6, Name = "Piercings"},
            new Category {CategoryId = 7, Name = "Colliers"}
        );
    }
}
