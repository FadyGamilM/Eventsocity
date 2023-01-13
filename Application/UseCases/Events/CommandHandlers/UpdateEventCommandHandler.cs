using MediatR;
using AutoMapper;
using Eventsocity.Application.UseCases.Events.Commands;
using Eventsocity.Application.Abstractions;
using Eventsocity.Application.Core.DTOs.Event;
using Eventsocity.Domain.Entities;

namespace Eventsocity.Application.UseCases.Events.CommandHandlers;

public class UpdateEventCommandHandler : IRequestHandler<UpdateEventCommand>
{
   private readonly IEventsRepository _repo;
   public UpdateEventCommandHandler(IEventsRepository repo)
   {
      _repo = repo;
   }

   public async Task<Unit> Handle(UpdateEventCommand request, CancellationToken cancellationToken)
   {
      // check if this event even exists in database
      var foundEvent = await _repo.GetById(request.Id);
      if(foundEvent is null)
      {
         return Unit.Value;
      }
      // <To Type>(from filled value entity)
      // (From entity which has values, to entitiy which also has values)
      // _mapper.Map(request.updatedEvent, foundEvent);
      
      foundEvent.Title = request.updatedEvent.Title ?? foundEvent.Title;
      foundEvent.Description = request.updatedEvent.Description ?? foundEvent.Description;
      foundEvent.City = request.updatedEvent.City ?? foundEvent.City;
      foundEvent.Venue = request.updatedEvent.Venue ?? foundEvent.Venue;
      foundEvent.Category = request.updatedEvent.Category ?? foundEvent.Category;

      // save the event after update
      await _repo.Update(foundEvent, request.Id);

      return Unit.Value;
   }
}