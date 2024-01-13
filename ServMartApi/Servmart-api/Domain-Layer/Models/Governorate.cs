
namespace Domain_Layer.Models
{
	public class Governorate
	{
		public int ID { get; set; }
		public string NameAr { get; set; }
		public string NameEn { get; set; }

		public virtual ICollection<City> Cities { get; set; }
		public virtual ICollection<Request> Request { get; set; }
		public virtual ICollection<Order> Orders { get; set; }
		public virtual ICollection<User> Users { get; set; }
	}
}
