using Eventsocity.Domain.Entities;
using Eventsocity.Infrastructure.Data;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Eventsocity.API.Extensions;

public static class IdentityServiceExtension
{
   public static void RegisterIdentityServiceExtension (this IServiceCollection services, IConfiguration config)
   {
      services
         .AddIdentityCore<User>(
            opts => {
               opts.Password.RequireNonAlphanumeric = false;
            }
         )
         // allow us to query the User and identity user tables through our EF Core configs
         .AddEntityFrameworkStores<DataContext>();

      services.AddAuthentication();
   }
}