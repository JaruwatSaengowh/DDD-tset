using DDD_Test.Application.TodoLists.Queries.ExportTodos;

namespace DDD_Test.Application.Common.Interfaces;
public interface ICsvFileBuilder
{
    byte[] BuildTodoItemsFile(IEnumerable<TodoItemRecord> records);
}
