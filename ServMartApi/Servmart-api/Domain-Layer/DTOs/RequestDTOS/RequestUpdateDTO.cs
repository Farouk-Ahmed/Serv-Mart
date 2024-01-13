
namespace Domain_Layer.DTOs.RequestDTOS
{
	public class RequestUpdateDTO
	{
		public Guid ID { get; set; }
		public string ClientId { get; set; }
		public string Details { get; set; }
		public decimal Price { get; set; }
		public int Status { get; set; } = 0;
		public string picUrl { get; set; } = string.Empty;
		public DateTime CreatedAt { get; set; }
		public int Duration { get; set; }
		public string RateMassage { get; set; }
		public string Titles { get; set; }
	}
}
