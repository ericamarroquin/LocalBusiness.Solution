using Microsoft.EntityFrameworkCore;

namespace LocalBusiness.Models
{
  public class LocalBusinessContext : DbContext
  {
    public LocalBusinessContext(DbContextOptions<LocalBusinessContext> options) : base(options)
    {

    }
    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Business>()
        .HasData(
          new Business { BusinessId = 1, Name = "Viva", BusinessType = "Restaurant", Phone = "111-1111" },
          new Business { BusinessId = 2, Name = "Panda Tea House", BusinessType = "Coffee/Tea", Phone = "222-2222" },
          new Business { BusinessId = 3, Name = "Saigon", BusinessType = "Restaurant", Phone = "333-3333" },
          new Business { BusinessId = 4, Name = "Fontanas", BusinessType = "Clothing", Phone = "444-4444" }
        );
    }
    public DbSet<Business> Businesses { get; set; }
  }
}