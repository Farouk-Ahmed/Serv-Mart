using Microsoft.AspNetCore.Http;

namespace Domain_Layer.DTOs.RequestDTOS
{
	public class RequestDTO
	{
		public string ClientId { get; set; }
		public string? ProviderID { get; set; }
		public string Title { get; set; }
		public string Category { get; set; }
		public int GovernorateId { get; set; }
		public int CityId { get; set; }
		public string Address { get; set; }
		public string Details { get; set; }
		public decimal ExpectedSalary { get; set; }
		public ICollection<IFormFile> Images { get; set; }
		public IFormFile Video { get; set; }
		public DateTime CreatedAt { get; set; }
		public bool IsDirect { get; set; } = false;
		public int Duration { get; set; }
	}
}
