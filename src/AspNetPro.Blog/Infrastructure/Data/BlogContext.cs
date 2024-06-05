using AspNetPro.Blog.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace AspNetPro.Blog.Infrastructure.Data;

public class BlogContext : DbContext
{
    public BlogContext(DbContextOptions<BlogContext> dbContextOptions)
        : base(dbContextOptions)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        var assembly = typeof(BlogContext).Assembly;
        modelBuilder.ApplyConfigurationsFromAssembly(assembly);

        base.OnModelCreating(modelBuilder);
    }

    public DbSet<Post> Posts { get; set; }
}
