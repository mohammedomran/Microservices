using Catalog.Api.Models;
using MediatR;
using Shared.CQRS;

namespace Catalog.Api.Products.CreateProduct;

internal record CreateProductCommand(Guid Id, List<string> Category, string Name, string Description, string ImageUrl, decimal Price) : ICommand<CreateProductResult>;
internal record CreateProductResult(Guid Id);
internal class CreateProductHandler : ICommandHandler<CreateProductCommand, CreateProductResult>
{
    public async Task<CreateProductResult> Handle(CreateProductCommand request, CancellationToken cancellationToken)
    {
        //create product 
        var product = new Product
        {
            Category = request.Category,
            Description = request.Description,
            Id = request.Id,
            ImageUrl = request.ImageUrl,
            Name = request.Name,
            Price = request.Price
        };
        // save to db

        //return
        return new CreateProductResult(request.Id);
    }
}
