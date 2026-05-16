using MediatR;

namespace ProductManagement.Application.Products.Commands.CreateProduct
{
    public class CreateProductCommand:IRequest<Guid>
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
    }
}
