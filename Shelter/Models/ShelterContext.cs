using Microsoft.EntityFrameworkCore;

namespace Shelter.Models
{
  public class ShelterContext : DbContext
  {
    public DbSet<Type> Type { get; set; }
    public DbSet<Details>  Details { get; set; }

    public ShelterContext(DbContextOptions options) : base(options) { }
  }
}
 