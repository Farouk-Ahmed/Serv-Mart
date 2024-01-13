
namespace Domain_Layer.Models
{
    public class ProductRate
    {
        public Guid ID { get; set; }
        public float Rate { get; set; }
        public string Description { get; set; }
        public Guid ProductId { get; set; }
        public Guid CustomerID { get; set; }
               
        public virtual Product Product { get; set; }
        public virtual User User { get; set; }
    }
}
