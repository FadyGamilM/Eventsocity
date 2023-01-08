using MediatR;
using Eventsocity.Domain.Entities;
namespace Eventsocity.Application.UseCases.Events.Queries;

public class GetEventByIdQuery : IRequest<Event>
{
   // we need the id to get the entitiy 
   public int eventId { get; set; }
}