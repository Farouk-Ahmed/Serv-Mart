
using Domain_Layer.Models;

namespace Domain_Layer.DTOs.ServiceDTOs
{
	public class ServiceShowTDO
	{
		public string ID { get; set; }
		public string Title { get; set; }
		public string Discription { get; set; }
		public float Rate { get; set; }
		public decimal ExpectedSalary { get; set; }

		public ServiceUser User { get; set; }
		public virtual ServiceCategory ServiceCategory { get; set; }
		public virtual ICollection<ServiceMedia> ServiceMedia { get; set; }
	}
}
