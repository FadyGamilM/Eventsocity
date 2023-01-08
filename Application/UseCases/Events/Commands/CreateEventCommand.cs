using MediatR;
using Eventsocity.Domain.Entities;

namespace Eventsocity.Application.UseCases.Events.Commands;

// not gonna return anything which is the difference between the command and the query
public class CreateEventCommand: IRequest
{
   // we need the Event entitiy 
   public Event newEvent {get; set;}
}