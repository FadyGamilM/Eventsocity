using Eventsocity.Application.UseCases.Events.Commands;
using FluentValidation;

namespace Eventsocity.Application.Validation.Events.CommandsValidators;

public class UpdateEventCommandValidator : AbstractValidator<UpdateEventCommand>
{
   public UpdateEventCommandValidator()
   {
      RuleFor(x => x.updatedEvent).SetValidator(new EventToUpdateValidator());
   }
}