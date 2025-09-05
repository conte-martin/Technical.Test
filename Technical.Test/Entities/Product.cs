namespace Technical.Test.Entities;

public class Product
{
    public int Id { get; set; }
    public int CategoryId { get; set; }
    public required string Name { get; set; }
    public string? Description { get; set; }
    public decimal Price { get; set; }
    public DateTime CreatedAt { get; set; }
    public bool IsDeleted { get; set; }
    public ProductStatus Status { get; set; }
}

public enum ProductStatus
{
    Inactive = 0,
    Active = 1,
    Discontinued = 2
}