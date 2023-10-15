using FlyingDonkey_TodoApp.Application.Common.Mappings;
using FlyingDonkey_TodoApp.Domain.Entities;

namespace FlyingDonkey_TodoApp.Application.TodoItems.Queries.GetTodoItemsWithPagination;

public class TodoItemBriefDto : IMapFrom<TodoItem>
{
    public int Id { get; init; }

    public int ListId { get; init; }

    public string? Title { get; init; }

    public string? Color { get; init; }

    public bool Done { get; init; }

    public DateTime? DeletedAt { get; set; }
}
