using MediatR;

namespace ProductManagement.Application.Products.Commands.UpdateProduct
{
    public class UpdateProductCommand:IRequest<bool>
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
    }
}
