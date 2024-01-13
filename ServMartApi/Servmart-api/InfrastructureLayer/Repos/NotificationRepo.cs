using Domain_Layer.DTOs.NotificationDTOs;
using Domain_Layer.Models;
using Infrastructure_Layer.IRepos;
using InfrastructureLayer;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace Application_Layer.Repos
{
	public class NotificationRepo : INotificationRepo
	{
		private AppDbContext _appDbContext;

		public NotificationRepo( AppDbContext appDbContext )
		{
			_appDbContext = appDbContext;
		}

		public async Task<NotificationDTO> Create( NotificationDTO notifications )
		{
			var item = new Notifications()
			{
				CreatedAt = notifications.CreatedAt,
				IsRead = notifications.IsRead,
				Message = notifications.Message,
				Type = notifications.Type,
				UserId = notifications.UserId
			};

			var res = await _appDbContext.Notifications.AddAsync( item );
			return notifications;
		}

		public async Task<IEnumerable<Notifications>> GetUserNotifications( string userId )
		{
			return await _appDbContext.Notifications
				.Where( n => n.UserId == userId )
				.OrderByDescending( n => n.CreatedAt )
				.ToListAsync();
		}

		public Task SetAsRead( string userId )
		{
			_appDbContext.Database.ExecuteSqlRaw( "UPDATE Notifications SET IsRead = @newValue WHERE UserId = @userId",
				new SqlParameter( "@newValue", true ),
				new SqlParameter( "@userId", userId ) );
			return Task.CompletedTask;
		}
	}
}
