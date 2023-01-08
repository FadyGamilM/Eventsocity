using Eventsocity.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Eventsocity.Infrastructure.Extensions;

public static class InfrastructureLayerExtensions
{
   private static string GetConnectionString(string connStringKey = "DefaultConnection")
   {
      // define the builder 
      var builder = new ConfigurationBuilder()
         .SetBasePath(Directory.GetCurrentDirectory())
         .AddJsonFile("appsettings.json");

      // define the config variable
      var config = builder.Build();

      // get the connection string from the json file and return the result
      var connStringValue = config.GetConnectionString(connStringKey);
      return connStringValue;  
   }
   public static void RegisterInfrastructureLayerServices(this IServiceCollection services)
   {
      services.AddDbContext<DataContext>(
         opts => {
            opts.UseSqlServer(GetConnectionString());
         }
      );
   }
}