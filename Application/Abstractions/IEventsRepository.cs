using Eventsocity.Domain.Entities;
using Eventsocity.Application.Abstractions.Common;

namespace Eventsocity.Application.Abstractions;

public interface IEventsRepository: IGenericRepository<Event>
{
}