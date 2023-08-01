using System.Globalization;
using CsvHelper.Configuration;
using DDD_Test.Application.TodoLists.Queries.ExportTodos;

namespace DDD_Test.Infrastructure.Files.Maps;
public class TodoItemRecordMap : ClassMap<TodoItemRecord>
{
    public TodoItemRecordMap()
    {
        AutoMap(CultureInfo.InvariantCulture);

        Map(m => m.Done).Convert(c => c.Value.Done ? "Yes" : "No");
    }
}
