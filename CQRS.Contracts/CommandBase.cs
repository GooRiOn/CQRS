using CQRS.Contracts.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRS.Contracts
{
    public class CommandBase : ICommand
    {
        public Guid Id { get; } = Guid.NewGuid();
    }
}
