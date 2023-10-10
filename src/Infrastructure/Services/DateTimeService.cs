using FlyingDonkey_TodoApp.Application.Common.Interfaces;

namespace FlyingDonkey_TodoApp.Infrastructure.Services;

public class DateTimeService : IDateTime
{
    public DateTime Now => DateTime.Now;
}
