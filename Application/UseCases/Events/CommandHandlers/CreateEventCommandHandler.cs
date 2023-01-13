using MediatR;
using Eventsocity.Application.UseCases.Events.Commands;
using Eventsocity.Domain.Entities;
using Eventsocity.Application.Abstractions;
namespace Eventsocity.Application.UseCases.Events.CommandHandlers;

public class CreateEventCommandHandler : IRequestHandler<CreateEventCommand>
{
   private readonly IEventsRepository _repo;
   public CreateEventCommandHandler(IEventsRepository repo)
   {
      _repo = repo;
   }
   public async Task<Unit> Handle(CreateEventCommand request, CancellationToken cancellationToken)
   {
      var Event = new Event{
         Title=request.newEvent.Title,
         Category=request.newEvent.Category,
         City=request.newEvent.City,
         Venue=request.newEvent.Venue,
         Date=request.newEvent.Date,
         Description=request.newEvent.Description
      };
      await _repo.Create(Event);
      // return Unit object to inform the .Send() method in the API layer that you have finished the processing
      return Unit.Value;
   }
}
