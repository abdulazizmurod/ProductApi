using ProductApi.Entities;

public class ProductCreateDto
{
    public string Name { get; set; } = string.Empty;
    public decimal Price { get; set; }
    public EProductStatus Status { get; set; }
}