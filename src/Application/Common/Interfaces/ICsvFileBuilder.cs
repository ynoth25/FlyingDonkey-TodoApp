using FlyingDonkey_TodoApp.Application.TodoLists.Queries.ExportTodos;

namespace FlyingDonkey_TodoApp.Application.Common.Interfaces;

public interface ICsvFileBuilder
{
    byte[] BuildTodoItemsFile(IEnumerable<TodoItemRecord> records);
}
