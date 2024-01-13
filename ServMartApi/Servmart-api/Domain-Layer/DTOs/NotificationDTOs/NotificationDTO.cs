using Domain_Layer.Enums;
using Domain_Layer.Models;

namespace Domain_Layer.DTOs.NotificationDTOs
{
	public class NotificationDTO
	{
		public string UserId { get; set; }
		public string Message { get; set; }
		public bool IsRead { get; set; }
		public DateTime CreatedAt { get; set; }
		public NotificationType Type { get; set; }
	}
}
