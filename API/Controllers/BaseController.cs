using Eventsocity.Application.Core.ErrorHandling;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Eventsocity.API.Controllers;

[ApiController]
public class BaseController: ControllerBase
{
   protected readonly IMediator _mediator;
   public BaseController(IMediator mediator)
   {
      _mediator = mediator;
   }
   protected IActionResult HandleErrors<T>(Result<T> response) where T : class
   {
      if(response.IsSuccess ==true) return Ok(response.Value);
      else return BadRequest(response.Error);
   }
}