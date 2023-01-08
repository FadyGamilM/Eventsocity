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
   public async Task<IEnumerable<Event>> GetAll()
   {
      var res = await _context.Events.ToListAsync();
      return res;
   }
}