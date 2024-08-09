using BackEnd.API.Contracts.Products;
using BackEnd.Application.Products.Commands.CreateProduct;
using BackEnd.Application.Products.Commands.DeleteProduct;
using BackEnd.Application.Products.Commands.UpdateProduct;
using BackEnd.Application.Products.Queries.GetAll;
using BackEnd.Application.Products.Queries.GetById;
using BackEnd.Application.Products.Queries.GetByName;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace BackEnd.API.Controllers;

[Route("v1/[Controller]")]
[ApiController]
public sealed class ProductsController(ISender sender) : ControllerBase
{
    [HttpPost]
    public async Task<IActionResult> Create([FromBody] CreateProductRequest request) =>
        Ok(await sender.Send(
            new CreateProductCommand(
                request.Name,
                request.Description,
                request.Price,
                request.Stock)));

    [HttpPut]
    public async Task<IActionResult> Update([FromBody] UpdateProductRequest request) =>
        Ok(await sender.Send(
            new UpdateProductCommand(
                request.ProductId,
                request.Name,
                request.Description,
                request.Price,
                request.Stock)));

    [HttpDelete]
    public async Task<IActionResult> Delete([FromBody] DeleteProductRequest request) =>
        Ok(await sender.Send(new DeleteProductCommand(request.ProductId)));

    [HttpGet]
    public async Task<IActionResult> GetAll() => Ok(await sender.Send(new GetAllProductsQuery()));

    [HttpGet("id:{id}")]
    public async Task<IActionResult> GetById(Guid id) => Ok(await sender.Send(new GetProductByIdQuery(id)));

    [HttpGet("name:{name}")]
    public async Task<IActionResult> GetByName(string name) => Ok(await sender.Send(new GetProductByNameQuery(name)));
}
