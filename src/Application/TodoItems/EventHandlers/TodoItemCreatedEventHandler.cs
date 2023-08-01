using DDD_Test.Domain.Events;
using MediatR;
using Microsoft.Extensions.Logging;

namespace DDD_Test.Application.TodoItems.EventHandlers;
public class TodoItemCreatedEventHandler : INotificationHandler<TodoItemCreatedEvent>
{
    private readonly ILogger<TodoItemCreatedEventHandler> _logger;

    public TodoItemCreatedEventHandler(ILogger<TodoItemCreatedEventHandler> logger)
    {
        _logger = logger;
    }

    public Task Handle(TodoItemCreatedEvent notification, CancellationToken cancellationToken)
    {
        _logger.LogInformation("DDD_Test Domain Event: {DomainEvent}", notification.GetType().Name);

        return Task.CompletedTask;
    }
}
