namespace Eventsocity.Application.Core.DTOs.Event;

public class EventToRead
{

   public int Id {get; set;} 
   public string Title {get; set;}
   public string Description {get; set;}
   public DateTime Date {get; set;}
   public string Category { get; set;}
   public string City { get; set;}
   public string Venue {get; set;}
}
