namespace ProductApi.Dtos.ProductDetailDto;
public class ProductDetailCreateDto
{
    public string Description { get; set; } = string.Empty;
    public string Color { get; set; } = string.Empty;
    public string Material { get; set; } = string.Empty;
    public decimal Weight { get; set; }
    public int QuantityInStock { get; set; }
    public DateTime ManufactureDate { get; set; }
    public DateTime ExpiryDate { get; set; }
    public string Size { get; set; } = string.Empty;
    public string Manufacturer { get; set; } = string.Empty;
    public string CountryOfOrigin { get; set; } = string.Empty;
}