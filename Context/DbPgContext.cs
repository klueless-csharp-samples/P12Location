namespace P12Location.Context
{
  using Microsoft.EntityFrameworkCore;
  using P12Location.Models;

  public class DbPgContext : DbContext
  {
    public DbPgContext(DbContextOptions<DbPgContext> options) : base(options)
    {
    }
    public DbSet<Location> Locations { get; set; }

  
    // protected override void OnConfiguring(DbContextOptionsBuilder options)
    //         => options.UseNpgsql("Host=127.0.0.1;Port=5432;Database=P12;Username=postgres;Password=Hambaro3");
  }
}
