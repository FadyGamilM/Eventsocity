using MediatR;
using Microsoft.AspNetCore.Mvc;
using Eventsocity.Domain.Entities;
using Eventsocity.Application.UseCases.Events.Queries;

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
   public async Task<ActionResult<IEnumerable<Event>>> SayHello()
   {
      var query = new GetEventsQuery{};
      var response = await _mediator.Send(query);
      return Ok(response);
   }
}