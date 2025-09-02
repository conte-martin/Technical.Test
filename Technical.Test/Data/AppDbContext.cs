using Microsoft.EntityFrameworkCore;
using Technical.Test.Entities;

namespace Technical.Test.Data;

/// <summary>
/// Represents the application's database context for Entity Framework Core.
/// </summary>
/// <remarks>
/// Initializes a new instance of the <see cref="AppDbContext"/> class using the specified options.
/// </remarks>
/// <param name="options">The options to be used by the DbContext.</param>
public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
{
    public DbSet<Category> Categories => Set<Category>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
    }
}
