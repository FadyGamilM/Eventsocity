using MediatR;
using Eventsocity.Domain.Entities;
using Eventsocity.Application.UseCases.Events.Queries;
using Eventsocity.Application.Abstractions;
using Eventsocity.Application.Core.DTOs.Event;
using Eventsocity.Application.Core.ErrorHandling;

namespace Eventsocity.Application.UseCases.Events.QueryHandlers;

public class GetEventByIdQueryHandler : IRequestHandler<GetEventByIdQuery, Result<EventToRead>>
{
   private readonly IEventsRepository _repo;
   public GetEventByIdQueryHandler(IEventsRepository repo)
   {
      _repo = repo;
   }
   public async Task<Result<EventToRead>> Handle(GetEventByIdQuery request, CancellationToken cancellationToken)
   {
      var existingEvent = await _repo.GetById(request.eventId);
      if(existingEvent==null)
      {
         System.Console.WriteLine("Not Found");
         return Result<EventToRead>.Faliure("No Event found with this id");
      }
      var response = new EventToRead{
         Id = existingEvent.Id,
         Title = existingEvent.Title,
         Description = existingEvent.Description,
         Date = existingEvent.Date,
         City  = existingEvent.City,
         Venue = existingEvent.Venue,
         Category = existingEvent.Category
      };

      return Result<EventToRead>.Success(response);
   }
}