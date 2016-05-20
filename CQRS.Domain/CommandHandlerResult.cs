using CQRS.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRS.Contracts
{
    public class CommandHandlerResult : ICommandHandlerResult
    {
        public string ErrorMessage { get; set; }

        public bool HasError => !string.IsNullOrWhiteSpace(ErrorMessage);

        public bool IsOk => !HasError;
    }
}
