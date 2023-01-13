using Eventsocity.Application.Core;
using Eventsocity.Application.UseCases.Events.QueryHandlers;
using MediatR;
using FluentValidation;
using FluentValidation.AspNetCore;
using Eventsocity.Application.Validation.Events.CommandsValidators;
using Microsoft.Extensions.DependencyInjection;

namespace Eventsocity.Application.Extensions;

public static class ApplicationLayerExtensions
{
   public static void RegisterApplicationLayerServices(this IServiceCollection services)
   {
      services.AddAutoMapper(typeof(MappingProfiles));
      services.AddMediatR(typeof(GetEventsQueryHandler).Assembly);
      services.AddFluentValidationAutoValidation();
      services.AddValidatorsFromAssemblyContaining<CreateEventCommandValidator>();
   }
}