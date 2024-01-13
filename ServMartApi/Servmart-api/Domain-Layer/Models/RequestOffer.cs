namespace Domain_Layer.Models
{
	public class RequestOffer
	{
		public Guid ID { get; set; }
		public Guid RequestID { get; set; }
		public string ProviderID { get; set; }
		public string Details { get; set; }
		public decimal ExpectSalary { get; set; }
		public int Duration { get; set; }
		public int Status { get; set; }
		public DateTime CreatedAt { get; set; }
		public bool IsDirect { get; set; }

		public virtual Request Request { get; set; }
		public virtual User User { get; set; }
	}
}