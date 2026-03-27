namespace Catalog.Api.Models;

public class Product
{
    public Guid Id { get; set; }
    public List<string> Category { get; set; } = new();
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string ImageUrl { get; set; } = string.Empty;
    public decimal Price { get; set; }
}
