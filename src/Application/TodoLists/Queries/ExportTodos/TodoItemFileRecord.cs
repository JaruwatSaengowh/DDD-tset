using DDD_Test.Application.Common.Mappings;
using DDD_Test.Domain.Entities;

namespace DDD_Test.Application.TodoLists.Queries.ExportTodos;
public class TodoItemRecord : IMapFrom<TodoItem>
{
    public string? Title { get; set; }

    public bool Done { get; set; }
}
