using MediatR;
using Microsoft.AspNetCore.Mvc;
using ProductManagement.Application.Products.Commands.CreateProduct;
using ProductManagement.Application.Products.Commands.DeleteProduct;
using ProductManagement.Application.Products.Commands.UpdateProduct;
using ProductManagement.Application.Products.Queries.GetAllProducts;
using ProductManagement.Application.Products.Queries.GetProductById;

namespace ProductManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ProductController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> CreateProduct(CreateProductCommand request)
        {
            return Ok(await _mediator.Send(request));
        }

        [HttpGet]
        public async Task<IActionResult> GetAllProducts()
        {
            return Ok(await _mediator.Send(new GetAllProductsQuery()));
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetProductById(Guid id)
        {
            return Ok(await _mediator.Send(new GetProductByIdQuery(id)));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProduct(Guid id)
        {
            return Ok(await _mediator.Send(new DeleteProductCommand(id)));
        }

        [HttpPut]
        public async Task<IActionResult> UpdateProduct(UpdateProductCommand request)
        {
            return Ok(await _mediator.Send(request));
        }
    }
}
