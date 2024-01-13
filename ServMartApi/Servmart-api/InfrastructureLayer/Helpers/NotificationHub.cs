using Azure.Core;
using Domain_Layer.Models;
using Microsoft.AspNetCore.SignalR;
using System.Security.Claims;

namespace Application_Layer.Helpers
{
	public class NotificationHub : Hub
	{
		public async Task AddToGroup( string groupName )
		{
			await Groups.AddToGroupAsync( Context.ConnectionId, groupName );
		}

		public async Task RemoveFromGroup( string groupName )
		{
			await Groups.RemoveFromGroupAsync( Context.ConnectionId, groupName );
		}

		public async Task SendOfferNotification( string groupName, object offer )
		{
			await Clients.Group( groupName ).SendAsync( "NewOffer", offer );
		}
	}
}
