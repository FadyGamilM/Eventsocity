using Eventsocity.Domain.Entities;
using AutoMapper;
using Eventsocity.Application.Core.DTOs.Event;

namespace Eventsocity.Application.Core;

public class MappingProfiles: Profile
{
   public MappingProfiles()
   {
      //              <From, To>
      CreateMap<Event, EventToRead>();      
      CreateMap<EventToCreate, Event>();      
      CreateMap<EventToUpdate, Event>();      
   }
}