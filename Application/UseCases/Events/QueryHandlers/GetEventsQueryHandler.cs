using MediatR;
using Eventsocity.Domain.Entities;
using Eventsocity.Application.UseCases.Events.Queries;
using Eventsocity.Application.Abstractions;

namespace Eventsocity.Application.UseCases.Events.QueryHandlers;

public class GetEventsQueryHandler : IRequestHandler<GetEventsQuery, IEnumerable<Event>>
{
   private readonly IEventsRepository _repo;
   public GetEventsQueryHandler(IEventsRepository repo)
   {
      _repo = repo;
   }
   public async Task<IEnumerable<Event>> Handle(GetEventsQuery request, CancellationToken cancellationToken)
   {
      var allEvents = await _repo.GetAll();
      return allEvents;
   }
}
