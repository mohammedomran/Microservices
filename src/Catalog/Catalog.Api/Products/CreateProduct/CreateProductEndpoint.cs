using Carter;
using Mapster;
using MediatR;

namespace Catalog.Api.Products.CreateProduct;

public class CreateProductEndpoint : ICarterModule
{
    internal record CreateProductRequest(List<string> Category, string Name, string Description, string ImageUrl, decimal Price);
    internal record CreateProductResponse(Guid Id, List<string> Category, string Name, string Description, string ImageUrl, decimal Price);
    public void AddRoutes(IEndpointRouteBuilder app)
    {
        app.MapPost("/products", async (CreateProductRequest request, IMediator mediator) =>
        {
            var command = request.Adapt<CreateProductCommand>();
            var result = await mediator.Send(command);
            var response = result.Adapt<CreateProductResponse>();
            return Results.Created($"/products/{result.Id}", response);
        });
    }
}
