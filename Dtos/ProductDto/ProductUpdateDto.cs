using ProductApi.Entities;

namespace ProductApi.Dtos.ProductDto;
public class ProductUpdateDto
{
    public string Name { get; set; } = string.Empty;
    public decimal Price { get; set; }
    public EProductStatus Status { get; set; }
}