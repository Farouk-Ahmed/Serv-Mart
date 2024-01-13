
namespace Domain_Layer.Models
{
	public class ServiceMedia
	{
		public Guid ID { get; set; }
		public string MediaUrl { get; set; }
		public Guid ServiceID { get; set; }

		public virtual Service Service { get; set; }
	}
}
