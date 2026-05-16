using MediatR;
using ProductManagement.Domain.Interfaces;

namespace ProductManagement.Application.Products.Commands.UpdateProduct
{
    public class UpdateProductCommandHandler : IRequestHandler<UpdateProductCommand, bool>
    {
        private readonly IProductRepository _productRepository;

        public UpdateProductCommandHandler(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task<bool> Handle(UpdateProductCommand request, CancellationToken cancellationToken)
        {
            var product = await _productRepository.GetByIdAsync(request.Id);
            if (product != null)
            {
                product.Name = request.Name;
                product.Description = request.Description;
                product.Price= request.Price;
                await _productRepository.UpdateAsync(product);
                return true;
            }
            return false;
        }
    }
}
