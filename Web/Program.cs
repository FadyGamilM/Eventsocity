using Eventsocity.API.Extensions;
using Eventsocity.Application.UseCases.Events.QueryHandlers;
using Eventsocity.Infrastructure.Extensions;
using Eventsocity.Application.Extensions;
using Eventsocity.Application.Abstractions;
using Eventsocity.Infrastructure.Repositories;
using MediatR;
using Eventsocity.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();
builder.Services.RegisterApiLayerServices();
builder.Services.RegisterApplicationLayerServices();
builder.Services.RegisterInfrastructureLayerServices();
builder.Services.AddScoped<IEventsRepository, EventsRepository>();
builder.Services.AddCors(opts => {
   opts.AddPolicy("CorsPolicy", policy => {
      policy
         .AllowAnyHeader()
         .AllowAnyMethod()
         .WithOrigins("http://localhost:3000");
   });
});


var app = builder.Build();

app.UseHttpsRedirection();

app.UseCors("CorsPolicy");

app.UseAuthorization();

app.MapControllers();

using var scope = app.Services.CreateScope();
var services = scope.ServiceProvider;

try
{
    // get the database context service withing the defined scope
    var context = services.GetRequiredService<DataContext>();
    // apply the pending migrations to our database
    context.Database.Migrate();
}
catch (Exception ex)
{
    // utilize the logger service within our scope
    // we will use the ILogger service agains the class "Program" 
    var logger = services.GetRequiredService<ILogger<Program>>();
    // log the error to invistigate any problem in this class 
    logger.LogError(ex, "Error ocurred during migrations");
}


app.Run();
