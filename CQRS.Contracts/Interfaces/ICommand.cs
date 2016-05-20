using System;

namespace CQRS.Contracts.Interfaces
{
    public interface ICommand
    {
        Guid Id { get; }
    }
}