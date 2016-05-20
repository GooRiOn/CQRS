using CQRS.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRS.Domain
{
    public class StaticValidationResult : IStaticValidationResult
    {
        public string ErrorMessage { get; set; }

        public bool HasError => !string.IsNullOrWhiteSpace(ErrorMessage);

        public bool IsOk => !HasError;
    }
}
