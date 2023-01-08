using Eventsocity.Domain.Entities;
using MediatR;
namespace Eventsocity.Application.UseCases.Events.Queries;

public class GetEventsQuery : IRequest<IEnumerable<Event>>
{
   
}