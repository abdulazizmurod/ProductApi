namespace ProductApi.Entities;
public class ProductDetail
{
    public Guid Id { get; set; } = Guid.NewGuid(); 
    public string Description { get; set; } = string.Empty;
    public string Color { get; set; } = string.Empty;
    public string Material { get; set; } = string.Empty;
    public decimal Weight { get; set; }
    public int QuantityInStock { get; set; }
    public DateTime ManufactureDate { get; set; } = DateTime.UtcNow;
    public DateTime ExpiryDate { get; set; } = DateTime.UtcNow;
    public string Size { get; set; } = string.Empty;
    public string Manufacturer { get; set; } = string.Empty;
    public string CountryOfOrigin { get; set; } = string.Empty;

    // Foreign key
    public Guid ProductId { get; set; }

    // faqatgina navigatsiya uchun
    public Product? Product { get; set; }
}
