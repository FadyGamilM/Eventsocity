using MediatR;
using Eventsocity.Domain.Entities;
using Eventsocity.Application.UseCases.Events.Queries;
using Eventsocity.Application.Abstractions;
namespace Eventsocity.Application.UseCases.Events.QueryHandlers;

public class GetEventByIdQueryHandler : IRequestHandler<GetEventByIdQuery, Event>
{
   private readonly IEventsRepository _repo;
   public GetEventByIdQueryHandler(IEventsRepository repo)
   {
      _repo = repo;
   }
   public async Task<Event> Handle(GetEventByIdQuery request, CancellationToken cancellationToken)
   {
      var existingEvent = await _repo.GetById(request.eventId);
      return existingEvent;
   }
}