using Microsoft.AspNetCore.Http;


namespace Domain_Layer.DTOs.RequestDTOS
{
	public class RequestShowDTO
	{
		public string Id { get; set; }
		public string ClientId { get; set; }
		public string Title { get; set; }
		public string Category { get; set; }
		public string GovernorateAr { get; set; }
		public string GovernorateEn { get; set; }
		public string CityAr { get; set; }
		public string CityEn { get; set; }
		public string Address { get; set; }
		public string Details { get; set; }
		public decimal ExpectedSalary { get; set; }
		public IEnumerable<string> Images { get; set; }
		public string Video { get; set; }
		public DateTime CreatedAt { get; set; }
		public int Duration { get; set; }
	}
}
