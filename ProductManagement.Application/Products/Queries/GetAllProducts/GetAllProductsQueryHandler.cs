using MediatR;
using ProductManagement.Application.DTOs.Products;
using ProductManagement.Domain.Interfaces;

namespace ProductManagement.Application.Products.Queries.GetAllProducts
{
    public class GetAllProductsQueryHandler : IRequestHandler<GetAllProductsQuery, List<ProductDto>>
    {
        private readonly IProductRepository _productRepository;

        public GetAllProductsQueryHandler(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task<List<ProductDto>> Handle(GetAllProductsQuery request, CancellationToken cancellationToken)
        {
            var products = await _productRepository.GetAllAsync();
            var dtos=products.Select(x => new ProductDto { 
              Id= x.Id,
              Name= x.Name,
              Description= x.Description,
              Price= x.Price
            
            }).ToList();
            return dtos;
        }
    }
}
