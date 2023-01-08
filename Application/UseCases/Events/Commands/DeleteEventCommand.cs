using MediatR;

namespace Eventsocity.Application.UseCases.Events.Commands;

public class DeleteEventCommand : IRequest
{
   public int Id { get; set; }
}