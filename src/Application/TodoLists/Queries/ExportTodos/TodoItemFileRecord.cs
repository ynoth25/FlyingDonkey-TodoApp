using FlyingDonkey_TodoApp.Application.Common.Mappings;
using FlyingDonkey_TodoApp.Domain.Entities;

namespace FlyingDonkey_TodoApp.Application.TodoLists.Queries.ExportTodos;

public class TodoItemRecord : IMapFrom<TodoItem>
{
    public string? Title { get; init; }

    public bool Done { get; init; }
}
