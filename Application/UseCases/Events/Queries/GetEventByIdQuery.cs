using MediatR;
using Eventsocity.Domain.Entities;
using Eventsocity.Application.Core.DTOs.Event;

namespace Eventsocity.Application.UseCases.Events.Queries;

public class GetEventByIdQuery : IRequest<EventToRead>
{
   // we need the id to get the entitiy 
   public int eventId { get; set; }
}