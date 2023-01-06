using Eventsocity.Persistence.Data;
using Eventsocity.Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Eventsocity.API.Controllers;

public class EventsController : BaseApiController
{
    private readonly DataContext _context;    
    public EventsController(DataContext context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Event>>> GetAllEvents()
    {
        var events = await _context.Events.ToListAsync();
        return Ok(events);
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Event>> GetEventById(int id)
    {
       var FoundEvent = await _context.Events.FindAsync(id);
       return Ok(FoundEvent);

    }
}