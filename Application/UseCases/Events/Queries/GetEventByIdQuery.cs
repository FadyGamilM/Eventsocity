using MediatR;
using Eventsocity.Domain.Entities;
using Eventsocity.Application.Core.DTOs.Event;
using Eventsocity.Application.Core.ErrorHandling;

namespace Eventsocity.Application.UseCases.Events.Queries;

public class GetEventByIdQuery : IRequest<Result<EventToRead>>
{
   // we need the id to get the entitiy 
   public int eventId { get; set; }
}