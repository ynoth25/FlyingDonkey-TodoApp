using FlyingDonkey_TodoApp.Application.Common.Mappings;
using FlyingDonkey_TodoApp.Domain.Entities;

namespace FlyingDonkey_TodoApp.Application.TodoLists.Queries.GetTodos;

public class TodoListDto : IMapFrom<TodoList>
{
    public TodoListDto()
    {
        Items = Array.Empty<TodoItemDto>();
    }

    public int Id { get; init; }

    public string? Title { get; init; }

    public string? Colour { get; init; }

    public DateTime? DeletedAt { get; init; }

    public IReadOnlyCollection<TodoItemDto> Items { get; init; }
}
