namespace CQRS.Contracts.AddProduct
{
    public class AddProductCommand : CommandBase
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public decimal InititalQuantity { get; set; }
    }
}
