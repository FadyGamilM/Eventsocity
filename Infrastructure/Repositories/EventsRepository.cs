using Eventsocity.Application.Abstractions;
using Eventsocity.Domain.Entities;
using Eventsocity.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Eventsocity.Infrastructure.Repositories;

public class EventsRepository : IEventsRepository
{
   private readonly DataContext _context;
   public EventsRepository(DataContext context)
   {
      _context = context;
   }

   public async Task Create(Event entity)
   {
      // we will not touch the database while we adding an entitiy, we will work in-memory so we don't have to use the AddAsync method
      _context.Events.Add(entity);
      await _context.SaveChangesAsync();
   }

   public async Task Delete(int Id)
   {
      var foundEvent = await _context.Events.FindAsync(Id);
      if(foundEvent != null)
      {
         _context.Remove(foundEvent);
      }
      await _context.SaveChangesAsync();
   }

   public async Task<IEnumerable<Event>> GetAll()
   {
      var res = await _context.Events.ToListAsync();
      return res;
   }

   public async Task<Event> GetById(int id)
   {
      var existingEvent = await _context.Events.FindAsync(id);
      return existingEvent;
   }

   public async Task Update(Event entity, int id)
   {
      await _context.SaveChangesAsync();
   }
}