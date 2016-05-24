using System;
using CQRS.Infrastructure.Interfaces.Contracts;

namespace CQRS.Contracts
{
    public class CommandBase : ICommand
    {
        public Guid Id { get; } = Guid.NewGuid();
    }
}
