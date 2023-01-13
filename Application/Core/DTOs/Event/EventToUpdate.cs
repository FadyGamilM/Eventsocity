namespace Eventsocity.Application.Core.DTOs.Event;

public record EventToUpdate(
   string Title, 
   string Description,
   DateTime Date,
   string Category,
   string City,
   string Venue
);
