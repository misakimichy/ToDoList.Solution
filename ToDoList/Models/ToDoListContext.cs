using Microsoft.EntityFrameworkCore;

namespace ToDoList.Models
{
    // Inherits the Entity Framework class
  public class ToDoListContext : DbContext
  {
    public DbSet<Item> Items { get; set; }

    public ToDoListContext(DbContextOptions options) : base(options) { }
  }
}