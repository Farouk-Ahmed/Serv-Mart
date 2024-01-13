using Domain_Layer.Enums;

namespace Domain_Layer.Models
{
	public class Notifications
	{
		public Guid Id { get; set; }
		public string UserId { get; set; }
		public string Message { get; set; }
		public bool IsRead { get; set; }
		public DateTime CreatedAt { get; set; }
		public NotificationType Type { get; set; }

		public virtual User User { get; set; }
	}
}
