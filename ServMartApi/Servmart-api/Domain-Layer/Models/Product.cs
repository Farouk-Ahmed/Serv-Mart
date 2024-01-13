
namespace Domain_Layer.Models
{
    public class Product
    {
        public Guid ProductID { get; set; }
        public string ProductName { get; set; }
        public string Description { get; set; }
        public decimal UnitPrice { get; set; }
        public int Stoke { get; set; }
       
        public Guid CategoryID { get; set; }
        public string ProviderId { get; set; }
        public virtual User ProductUser { get; set; }
        public virtual ProductCategory Category { get; set; }
        public virtual ICollection<ProductMedia> ProductMedias { get; set; }
        public virtual ICollection<ProductRate> ProductRates { get; set; }
        public virtual ICollection<OrderItem> OrderItems { get; set; }
    }
}
