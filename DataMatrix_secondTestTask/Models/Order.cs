namespace DataMatrix_secondTestTask.Models
{
    public class Order : BaseEntity.BaseEntity
    {
        public string Name { get; set; }
        public int Count { get; set; }
        public decimal Price { get; set; }
        public DateTime CreatedDate { get; set; }
        public bool IsDelivery { get; set; }
        public string? Address { get; set; }
        public DateTime? DeliveryDate { get; set; }
    }
}
