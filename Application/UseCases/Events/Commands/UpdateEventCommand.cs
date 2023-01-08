using Eventsocity.Application.Abstractions;
using Eventsocity.Application.Core.DTOs.Event;
using MediatR;
namespace Eventsocity.Application.UseCases.Events.Commands;

public class UpdateEventCommand : IRequest
{
   public int Id {get; set;}
   public EventToUpdate updatedEvent { get; set;}
}