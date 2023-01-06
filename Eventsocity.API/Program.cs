using Eventsocity.Persistence.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//! [1]=> register the DbContext service
builder.Services.AddDbContext<DataContext>(opt => opt.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

//! [2]=> before running the application, lets update our database inside a safe scope 
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
