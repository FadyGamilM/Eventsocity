using Eventsocity.Application.Core.DTOs.Event;
using Eventsocity.Application.Core.ErrorHandling;
using Eventsocity.Domain.Entities;
using MediatR;
namespace Eventsocity.Application.UseCases.Events.Queries;

public class GetEventsQuery : IRequest<Result<IEnumerable<EventToRead>>>
{
   
}