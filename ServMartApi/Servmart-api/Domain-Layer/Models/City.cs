
namespace Domain_Layer.Models
{
	public class City
	{
		public int ID { get; set; }
		public int GovernorateId { get; set; }
		public string NameAr { get; set; }
		public string NameEn { get; set; }

		public virtual Governorate Governorate { get; set; }
		public virtual ICollection<Request> Request { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
		public virtual ICollection<User> Users { get; set; }
	}
}
