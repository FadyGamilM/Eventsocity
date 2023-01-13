using MediatR;
using Microsoft.AspNetCore.Mvc;
using Eventsocity.Domain.Entities;
using Eventsocity.Application.UseCases.Events.Queries;
using Eventsocity.Application.UseCases.Events.Commands;
using Eventsocity.Application.Core.DTOs.Event;

namespace Eventsocity.API.Controllers;

[ApiController]
[Route("api/events")]
public class EventsController : ControllerBase
{
   private readonly IMediator _mediator;
   public EventsController(IMediator mediator)
   {
      _mediator = mediator;
   }

   [HttpGet]
   public async Task<ActionResult<IEnumerable<Event>>> GetEvents()
   {
      var query = new GetEventsQuery{};
      var response = await _mediator.Send(query);
      return Ok(response);
   }

   [HttpGet("{id:int}")]
   public async Task<ActionResult<Event>> GetEventById(int id)
   {
      var query = new GetEventByIdQuery{ eventId = (int) id };
      var response = await _mediator.Send(query);
      return Ok(response);
   }

   [HttpPost]
   public async Task<IActionResult> CreateNewEvent([FromBody] EventToCreate eventEntity)
   {
      var command = new CreateEventCommand { newEvent = eventEntity };
      await _mediator.Send(command);
      return Ok("Created");
   }

   [HttpPut("{id:int}")]
   public async Task<IActionResult> UpdateEvent(int id, [FromBody] EventToUpdate UpdatedEvent)
   {
      var command = new UpdateEventCommand{Id=id, updatedEvent=UpdatedEvent};
      await _mediator.Send(command);
      return Ok("Updated");
   }

   [HttpDelete("{id:int}")]
   public async Task<IActionResult> DeleteEvent(int id)
   {
      var command = new DeleteEventCommand{Id = id};
      await _mediator.Send(command);
      return NoContent();
   }
}