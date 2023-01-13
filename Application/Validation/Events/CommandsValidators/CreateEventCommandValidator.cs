using System.Data;
using Eventsocity.Application.UseCases.Events.Commands;
using FluentValidation;

namespace Eventsocity.Application.Validation.Events.CommandsValidators;

public class CreateEventCommandValidator : AbstractValidator<CreateEventCommand>
{
   public CreateEventCommandValidator()
   {
      RuleFor(x => x.newEvent).SetValidator(new EventToCreateValidator());
   }
}