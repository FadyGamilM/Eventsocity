using Microsoft.Extensions.DependencyInjection;
using Eventsocity.API.Controllers;
namespace Eventsocity.API.Extensions;

public static class ApiLayerExtensions
{
   public static void RegisterApiLayerServices(this IServiceCollection services)
   {
      services
         .AddControllers()
         .AddApplicationPart(typeof(EventsController).Assembly);
   }
}