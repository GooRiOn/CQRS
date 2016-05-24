using System;

namespace CQRS.Contracts.AddProductQuantity
{
    public class AddProductQuantityCommand : CommandBase
    {
        public Guid ProductId { get; set; }
        public decimal AdditionalQuantity { get; set; }
    }
}
