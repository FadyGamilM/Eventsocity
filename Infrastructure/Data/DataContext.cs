using Microsoft.EntityFrameworkCore;
using Eventsocity.Domain.Entities;
using Eventsocity.Infrastructure.Configurations;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace Eventsocity.Infrastructure.Data;

public class DataContext : IdentityDbContext<User>
{
   public DataContext(DbContextOptions<DataContext> options) : base(options)
   {
      
   }
   protected override void OnModelCreating(ModelBuilder modelBuilder)
   {
      // we have to call the OnModelCreating of the base class which is here the `IdentityDbContext` because there are essential methods that are called in the 
      // IdentityDbContext's OnModelCreating method and here we overriden it 
      base.OnModelCreating(modelBuilder);
      modelBuilder.ApplyConfiguration<Event>(new EventsConfig());
   }
   public DbSet<Event> Events {get; set;}
}