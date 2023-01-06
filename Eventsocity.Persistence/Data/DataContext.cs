using Microsoft.EntityFrameworkCore;
using Eventsocity.Domain.Entities;

namespace Eventsocity.Persistence.Data;
public class DataContext : DbContext
{
   public DataContext(DbContextOptions<DataContext> options) : base(options)
   { }

   public DbSet<Event> Events {get; set;}
}