using DDD_Test.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace DDD_Test.Application.Common.Interfaces;
public interface IApplicationDbContext
{
    DbSet<TodoList> TodoLists { get; }

    DbSet<TodoItem> TodoItems { get; }

    Task<int> SaveChangesAsync(CancellationToken cancellationToken);
}
