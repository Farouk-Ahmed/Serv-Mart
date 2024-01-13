namespace Domain_Layer.Models
{
	public class ServiceCategory
	{
		public Guid ID { get; set; }
		public string NameAr { get; set; }
		public string NameEn { get; set; }

		public virtual ICollection<Service> Services { get; set; }
	}

}
