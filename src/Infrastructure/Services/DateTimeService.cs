using DDD_Test.Application.Common.Interfaces;

namespace DDD_Test.Infrastructure.Services;
public class DateTimeService : IDateTime
{
    public DateTime Now => DateTime.Now;
}
