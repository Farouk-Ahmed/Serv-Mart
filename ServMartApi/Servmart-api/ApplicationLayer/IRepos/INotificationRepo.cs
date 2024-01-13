using Domain_Layer.DTOs.NotificationDTOs;
using Domain_Layer.Models;

namespace Infrastructure_Layer.IRepos
{
	public interface INotificationRepo
	{
		Task<NotificationDTO> Create( NotificationDTO notifications );
		Task SetAsRead( string userId );
		Task<IEnumerable<Notifications>> GetUserNotifications( string userId );
	}
}
