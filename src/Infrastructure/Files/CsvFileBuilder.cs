using System.Globalization;
using CsvHelper;
using DDD_Test.Application.Common.Interfaces;
using DDD_Test.Application.TodoLists.Queries.ExportTodos;
using DDD_Test.Infrastructure.Files.Maps;

namespace DDD_Test.Infrastructure.Files;
public class CsvFileBuilder : ICsvFileBuilder
{
    public byte[] BuildTodoItemsFile(IEnumerable<TodoItemRecord> records)
    {
        using var memoryStream = new MemoryStream();
        using (var streamWriter = new StreamWriter(memoryStream))
        {
            using var csvWriter = new CsvWriter(streamWriter, CultureInfo.InvariantCulture);

            csvWriter.Context.RegisterClassMap<TodoItemRecordMap>();
            csvWriter.WriteRecords(records);
        }

        return memoryStream.ToArray();
    }
}
