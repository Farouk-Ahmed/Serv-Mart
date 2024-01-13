namespace Domain_Layer.Models
{
	public class RequestMedia
	{
		public Guid ID { get; set; }
		public string MediaUrl { get; set; }
		public Guid RequestID { get; set; }

		public virtual Request Request { get; set; }
	}
}
