using System.Globalization;
using FlyingDonkey_TodoApp.Application.Common.Interfaces;
using FlyingDonkey_TodoApp.Application.TodoLists.Queries.ExportTodos;
using FlyingDonkey_TodoApp.Infrastructure.Files.Maps;
using CsvHelper;

namespace FlyingDonkey_TodoApp.Infrastructure.Files;

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
