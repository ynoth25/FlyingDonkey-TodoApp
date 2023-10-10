using FlyingDonkey_TodoApp.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace FlyingDonkey_TodoApp.Application.Common.Interfaces;

public interface IApplicationDbContext
{
    DbSet<TodoList> TodoLists { get; }

    DbSet<TodoItem> TodoItems { get; }

    Task<int> SaveChangesAsync(CancellationToken cancellationToken);
}
