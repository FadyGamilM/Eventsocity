using MediatR;
using Eventsocity.Application.UseCases.Events.Commands;
using Eventsocity.Application.Abstractions;

namespace Eventsocity.Application.UseCases.Events.CommandHandlers;

public class DeleteEventCommandHandler : IRequestHandler<DeleteEventCommand>
{
   private readonly IEventsRepository _repo;
   public DeleteEventCommandHandler(IEventsRepository repo)
   {
      _repo = repo;
   }
   public async Task<Unit> Handle(DeleteEventCommand request, CancellationToken cancellationToken)
   {
      await _repo.Delete(request.Id);
      return Unit.Value;
   }
}