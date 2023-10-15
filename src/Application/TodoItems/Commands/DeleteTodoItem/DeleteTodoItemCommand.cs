﻿using FlyingDonkey_TodoApp.Application.Common.Exceptions;
using FlyingDonkey_TodoApp.Application.Common.Interfaces;
using FlyingDonkey_TodoApp.Domain.Entities;
using FlyingDonkey_TodoApp.Domain.Events;
using MediatR;

namespace FlyingDonkey_TodoApp.Application.TodoItems.Commands.DeleteTodoItem;

public record DeleteTodoItemCommand(int Id) : IRequest;

public class DeleteTodoItemCommandHandler : IRequestHandler<DeleteTodoItemCommand>
{
    private readonly IApplicationDbContext _context;

    public DeleteTodoItemCommandHandler(IApplicationDbContext context)
    {
        _context = context;
    }

    public async Task Handle(DeleteTodoItemCommand request, CancellationToken cancellationToken)
    {
        var entity = await _context.TodoItems
            .FindAsync(new object[] { request.Id }, cancellationToken);

        if (entity == null)
        {
            throw new NotFoundException(nameof(TodoItem), request.Id);
        }

        entity.DeletedAt = DateTime.UtcNow;

        entity.AddDomainEvent(new TodoItemDeletedEvent(entity));

        await _context.SaveChangesAsync(cancellationToken);
    }

}
