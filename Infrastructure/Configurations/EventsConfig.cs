using Eventsocity.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Eventsocity.Infrastructure.Configurations;

public class EventsConfig : IEntityTypeConfiguration<Event>
{
   public void Configure(EntityTypeBuilder<Event> builder)
   {
      builder.HasData(
         new Event{
            Id=1,
            Title="Playing Padel",
            City="Egypt",
            Venue="Nasr City, Nady El Shams",
            Date = DateTime.UtcNow.AddDays(2),
            Description="Let's play a padel game from 9 to 10 after 2 days, who is comming ! .. ",
            Category="Sports"
         },
         new Event{
            Id=2,
            Title="Watching Avatar 2",
            City="Egypt",
            Venue="Cairo Festival",
            Date = DateTime.UtcNow.AddDays(1),
            Description="I need to watch avatar 2 at cairo festival tommowrow and, anyone interested..",
            Category="Fun"            
         },
         new Event{
            Id=3,
            Title="Playing Footbal",
            City="Egypt",
            Venue="Nady el Shams",
            Date = DateTime.UtcNow.AddDays(4),
            Description="lets play 2 hours of football, i need 9 people",
            Category="Sports"            
         },
         new Event{
            Id=4,
            Title="Having Launch",
            City="Egypt",
            Venue="Papa jones",
            Date = DateTime.UtcNow.AddHours(2.0),
            Description="I am having a break for 2 hours, anyone interested to have a lauch and a good talk, i need to eat in papa jones btw",
            Category="Social"            
         }
      );
   }
}