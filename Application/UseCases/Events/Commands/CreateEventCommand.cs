using MediatR;
using Eventsocity.Domain.Entities;
using Eventsocity.Application.Core.DTOs.Event;
using Eventsocity.Application.Core.ErrorHandling;

namespace Eventsocity.Application.UseCases.Events.Commands;

// not gonna return anything which is the difference between the command and the query
public class CreateEventCommand: IRequest
{
   // we need the Event entitiy 
   public EventToCreate newEvent {get; set;}
}