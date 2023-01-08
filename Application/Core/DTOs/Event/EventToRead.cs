namespace Eventsocity.Application.Core.DTOs.Event;

public record EventToRead(
   int Id, 
   string Title, 
   string Description,
   DateTime Date,
   string Category,
   string City,
   string Venue
);
