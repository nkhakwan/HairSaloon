using Microsoft.EntityFrameworkCore;


namespace HairSaloon.Models
{
  public class ToDoListContext : DbContext
  {
    public DbSet<Employee> Employees { get; set; }
    public DbSet<Client> Clients { get; set; }
    
    public ToDoListContext(DbContextOptions options) : base(options) { }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      optionsBuilder.UseLazyLoadingProxies();
    }
  }
}