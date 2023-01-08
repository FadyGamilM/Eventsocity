using Microsoft.EntityFrameworkCore;
using Eventsocity.Domain.Entities;
using Eventsocity.Infrastructure.Configurations;

namespace Eventsocity.Infrastructure.Data;

public class DataContext : DbContext
{
   public DataContext(DbContextOptions<DataContext> options) : base(options)
   {
      
   }
   protected override void OnModelCreating(ModelBuilder modelBuilder)
   {
      modelBuilder.ApplyConfiguration<Event>(new EventsConfig());
   }
   public DbSet<Event> Events {get; set;}
}