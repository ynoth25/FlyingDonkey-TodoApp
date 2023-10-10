using System.Globalization;
using FlyingDonkey_TodoApp.Application.TodoLists.Queries.ExportTodos;
using CsvHelper.Configuration;

namespace FlyingDonkey_TodoApp.Infrastructure.Files.Maps;

public class TodoItemRecordMap : ClassMap<TodoItemRecord>
{
    public TodoItemRecordMap()
    {
        AutoMap(CultureInfo.InvariantCulture);

        Map(m => m.Done).Convert(c => c.Value.Done ? "Yes" : "No");
    }
}
