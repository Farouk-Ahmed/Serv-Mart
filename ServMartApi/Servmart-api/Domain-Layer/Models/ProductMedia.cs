namespace Domain_Layer.Models
{
    public class ProductMedia
    {
        public Guid ID { get; set; }
        public string MeadiUrl { get; set; }
        public Guid ProductID { get; set; }

        public virtual Product Product { get; set; }
    }
}