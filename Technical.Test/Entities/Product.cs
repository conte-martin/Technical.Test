using Technical.Test.Common.Enums;

namespace Technical.Test.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public required long Code { get; set; }
        public required string Name { get; set; }
        public string? Description { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }
        public int WeightKg { get; set; }
        public int? VolumeM3 { get; set; }
        public int Rating { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? ExpirationDate { get; set; }
        public bool? IsDeleted { get; set; }
        public int Status { get; set; }
    }
}