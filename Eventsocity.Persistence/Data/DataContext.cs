using Microsoft.EntityFrameworkCore;
using Eventsocity.Domain.Entities;
using Eventsocity.Persistence.Configurations;

namespace Eventsocity.Persistence.Data;
public class DataContext : DbContext
{
   public DataContext(DbContextOptions<DataContext> options) : base(options)
   { }

   protected override void OnModelCreating(ModelBuilder modelBuilder)
   {
      modelBuilder.ApplyConfiguration(new EventsConfigurations());
   }

   public DbSet<Event> Events {get; set;}
}