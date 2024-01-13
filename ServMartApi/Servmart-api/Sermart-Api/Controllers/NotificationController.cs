using Application_Layer.Helpers;
using Domain_Layer.Models;
using Infrastructure_Layer.IRepos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using System.Configuration;
using System.Security.Claims;

namespace Sermart_Api.Controllers
{
	[Route( "api/[controller]" )]
	[ApiController]
	public class NotificationController : ControllerBase
	{
		private readonly IHubContext<NotificationHub> _hubContext;
		private readonly INotificationRepo _notificationRepo;

		public NotificationController(
			IHubContext<NotificationHub> hubContext,
			INotificationRepo notificationRepo
		)
		{
			_hubContext = hubContext;
			_notificationRepo = notificationRepo;
		}

		[HttpPost( "sendNotificationToAll" )]
		public async Task<IActionResult> SendNotificationToAll( [FromBody] string message )
		{
			await _hubContext.Clients.All.SendAsync( "ReceiveNotification", message );
			return Ok();
		}

		[HttpPost( "sendNotificationToUser" )]
		public async Task<IActionResult> SendNotificationToUser( string UserId, string Message )
		{
			await _hubContext.Clients.User( UserId ).SendAsync( "ReceiveNotification", Message );
			return Ok();
		}

		[HttpGet( "GetUserNotifications" )]
		public async Task<IActionResult> GetUserNotifications()
		{
			string userId = User.FindFirstValue( ClaimTypes.NameIdentifier );
			var result = await _notificationRepo.GetUserNotifications( userId );
			return Ok( result );
		}

		[HttpGet( "UpdateUserNotifications" )]
		public async Task<IActionResult> UpdateUserNotifications()
		{
			string userId = User.FindFirstValue( ClaimTypes.NameIdentifier );
			await _notificationRepo.SetAsRead( userId );
			return Ok();
		}


	}
}
