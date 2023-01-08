namespace Eventsocity.Application.Core.DTOs.Event;

public record EventToCreate(
   string Title, 
   string Description,
   DateTime Date,
   string Category,
   string City,
   string Venue
);
