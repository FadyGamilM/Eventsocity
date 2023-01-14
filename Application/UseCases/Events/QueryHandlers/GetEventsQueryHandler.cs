using MediatR;
using Eventsocity.Domain.Entities;
using Eventsocity.Application.UseCases.Events.Queries;
using Eventsocity.Application.Abstractions;
using Eventsocity.Application.Core.DTOs.Event;
using Eventsocity.Application.Core.ErrorHandling;

namespace Eventsocity.Application.UseCases.Events.QueryHandlers;

public class GetEventsQueryHandler : IRequestHandler<GetEventsQuery, Result<IEnumerable<EventToRead>>>
{
   private readonly IEventsRepository _repo;
   public GetEventsQueryHandler(IEventsRepository repo)
   {
      _repo = repo;
   }
   public async Task<Result<IEnumerable<EventToRead>>> Handle(GetEventsQuery request, CancellationToken cancellationToken)
   {
      var allEvents = await _repo.GetAll();
      var events = new List<EventToRead>();
      foreach (var Event in allEvents)
      {
         events.Add(
            new EventToRead{
               Id=Event.Id,
               Title = Event.Title,
               Description=Event.Description,
               City=Event.City,
               Venue=Event.Venue,
               Category=Event.Category,
               Date=Event.Date
            }
         );
      }
      var result = Result<IEnumerable<EventToRead>>.Success(events);
      return result;
   }
}
