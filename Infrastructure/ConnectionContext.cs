using CSharpApi.Model;
using Microsoft.EntityFrameworkCore;

namespace CSharpApi.Infrastructure
{
  public class ConnectionContext : DbContext
  {
    public DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    => optionsBuilder.UseNpgsql("Server=localhost;Port=5432;Database=escola;User Id=admin;Password=123456");
  }
}