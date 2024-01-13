namespace Domain_Layer.Models
{
    public class ProductCategory
    {
        public Guid ID { get; set; }
        public string Catagory { get; set; }

        public virtual ICollection<Product> Prouducts { get; set; }

    }
}