using MediatR;
using ProductManagement.Application.DTOs.Products;

namespace ProductManagement.Application.Products.Queries.GetAllProducts
{
    public record GetAllProductsQuery():IRequest<List<ProductDto>>;
    
}
