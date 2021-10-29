using Microsoft.EntityFrameworkCore;

namespace LocalBusiness.Models
{
  public class LocalBusinessContext : DbContext
  {
    public LocalBusinessContext(DbContextOptions<LocalBusinessContext> options) : base(options)
    {

    }

    public DbSet<Business> Businesses { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      modelBuilder.Entity<Business>()
        .Property(p => p.BusinessId)
        .ValueGeneratedOnAdd();
    }
  }
}