using Eventsocity.Application.Core;
using Eventsocity.Application.UseCases.Events.QueryHandlers;
using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace Eventsocity.Application.Extensions;

public static class ApplicationLayerExtensions
{
   public static void RegisterApplicationLayerServices(this IServiceCollection services)
   {
      services.AddAutoMapper(typeof(MappingProfiles));
      services.AddMediatR(typeof(GetEventsQueryHandler).Assembly);

   }
}