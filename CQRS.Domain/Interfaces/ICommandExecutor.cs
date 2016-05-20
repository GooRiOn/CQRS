using CQRS.Contracts.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRS.Domain.Interfaces
{
    public interface ICommandExecutor
    {
        void Execute<TCommand>(TCommand command) where TCommand : class, ICommand;
    }
}
