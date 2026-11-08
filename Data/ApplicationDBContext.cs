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
            new Category {CategoryId = 1, Name = "Rings", DisplayOrder = 1},
            new Category {CategoryId = 3, Name = "Bracelets", DisplayOrder = 2},
            new Category {CategoryId = 2, Name = "Earings", DisplayOrder = 3},
            new Category {CategoryId = 4, Name = "Necklaces", DisplayOrder = 4},
            new Category {CategoryId = 5, Name = "Bangles", DisplayOrder = 5},
            new Category {CategoryId = 6, Name = "Colliers", DisplayOrder = 6},
            new Category {CategoryId = 7, Name = "Piercings", DisplayOrder = 7},
            new Category {CategoryId = 8, Name = "Bundles", DisplayOrder = 8}
        );
    }
}
