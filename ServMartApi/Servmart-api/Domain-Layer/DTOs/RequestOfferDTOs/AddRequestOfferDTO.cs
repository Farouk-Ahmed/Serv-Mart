
namespace Domain_Layer.DTOs.RequestOfferDTOs
{
	public class AddRequestOfferDTO
	{
		public string RequestId { get; set; }
		public string? ProviderId { get; set; }
		public int? Status { get; set; }
		public string Details { get; set; }
		public decimal ExpectedSalary { get; set; }
		public DateTime? CreatedAt { get; set; }
		public int Duration { get; set; }
	}
}
