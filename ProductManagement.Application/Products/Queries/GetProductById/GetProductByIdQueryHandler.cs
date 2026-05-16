using MediatR;
using ProductManagement.Application.DTOs.Products;
using ProductManagement.Domain.Interfaces;

namespace ProductManagement.Application.Products.Queries.GetProductById
{
    public class GetProductByIdQueryHandler : IRequestHandler<GetProductByIdQuery, ProductDto>
    {
        private readonly IProductRepository _productRepository;

        public GetProductByIdQueryHandler(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task<ProductDto> Handle(GetProductByIdQuery request, CancellationToken cancellationToken)
        {
            var product = await _productRepository.GetByIdAsync(request.Id);
            if (product == null) { return null; }
            var dto= new ProductDto();
            dto.Id = product.Id;
            dto.Name = product.Name;
            dto.Description = product.Description;
            dto.Price=product.Price;
            return dto;
        }
    }
}
