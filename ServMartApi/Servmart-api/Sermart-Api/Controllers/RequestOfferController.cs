using Application_Layer.Helpers;
using ApplicationLayer.IRepos;
using Domain_Layer.DTOs.NotificationDTOs;
using Domain_Layer.DTOs.RequestOfferDTOs;
using Domain_Layer.Enums;
using Infrastructure_Layer.IRepos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using System.Security.Claims;

namespace Sermart_Api.Controllers
{
	[Route( "api/[controller]" )]
	[ApiController]
	public class RequestOfferController : ControllerBase
	{
		private readonly IRequestOfferRepo _reqOfferRepo;
		private readonly IRequestRepo _requestRepo;
		private readonly IUnitOfWork _unitOfWork;
		private readonly IHubContext<NotificationHub> _hub;
		private readonly INotificationRepo _notificationRepo;

		public RequestOfferController(
			IRequestOfferRepo reqOfferRepo,
			IRequestRepo requestRepo,
			IUnitOfWork unitOfWork,
			IHubContext<NotificationHub> hubContext,
			INotificationRepo notificationRepo
			)
		{
			_reqOfferRepo = reqOfferRepo;
			_requestRepo = requestRepo;
			_unitOfWork = unitOfWork;
			_hub = hubContext ?? throw new ArgumentNullException( nameof( hubContext ) );
			_notificationRepo = notificationRepo;
		}

		[HttpGet( "GetAll" )]
		public async Task<IActionResult> GetAll( string providerId, int page, int pageSize )
		{
			var result = await _reqOfferRepo.GetAll( providerId, page, pageSize );
			return Ok( result );
		}

		[HttpGet( "GetProviderOffersByStatus" )]
		public async Task<IActionResult> GetAllByStatus( int status, int page, int pageSize )
		{
			var providerId = User.FindFirstValue( ClaimTypes.NameIdentifier );
			var result = await _reqOfferRepo.GetProviderOffersByStatus( providerId, status, page, pageSize );
			return Ok( result );
		}

		[HttpGet( "ProviderOffersByStatusCount" )]
		public async Task<IActionResult> ProviderOffersByStatusCount( int status )
		{
			var providerId = User.FindFirstValue( ClaimTypes.NameIdentifier );
			var result = await _reqOfferRepo.GetProviderOffersByStatusCount( providerId, status );
			return Ok( result );
		}

		[HttpPost( "CreateOffer" )]
		public async Task<IActionResult> CreateOffer( [FromBody] AddRequestOfferDTO offerDTO )
		{
			var providerId = User.FindFirstValue( ClaimTypes.NameIdentifier );
			offerDTO.ProviderId = providerId;

			if ( !ModelState.IsValid )
			{
				return BadRequest( "Data is not accureid" );
			}

			var result = await _reqOfferRepo.AddAsync( offerDTO );

			if ( result == null )
			{
				return BadRequest( "Failed to create offer" );
			}

			var request = await _reqOfferRepo.GetRequest( offerDTO.RequestId );

			var notification = new NotificationDTO()
			{
				IsRead = false,
				CreatedAt = DateTime.Now,
				Message = $"لقد تلقيت عرض جديد علي طلبك {request.Title} من {request.User.FName} {request.User.LName}",
				Type = NotificationType.Offer,
				UserId = request.UserID
			};

			var notif = await _notificationRepo.Create( notification );

			int x = _unitOfWork.CommitChanges();

			await _hub.Clients.Group( request.UserID ).SendAsync( "NewOffer", notif );

			return Ok( result );
		}

		[HttpPut( "update" )]
		public async Task<IActionResult> Update( UpdateRequestOfferDTO updateRequestOfferDTO )
		{
			var result = await _reqOfferRepo.Update( updateRequestOfferDTO );
			_unitOfWork.CommitChanges();
			if ( result == null )
			{
				return BadRequest( "Failed to update this request" );
			}
			return Ok( result );
		}

		[HttpGet( "GetUserRequestOffers" )]
		public async Task<IActionResult> GetRequestOffers( string requestId, int page, int pageSize )
		{
			var result = await _reqOfferRepo.GetUserRequestOffers( requestId, page, pageSize );
			return Ok( result );
		}

		[HttpGet( "UserRequestOffersCount" )]
		public async Task<IActionResult> UserRequestOffersCount( string requestId )
		{
			var result = await _reqOfferRepo.GetUserRequestOffersCount( requestId );
			return Ok( result );
		}

		[HttpGet( "AcceptOffer" )]
		public async Task<IActionResult> AcceptOffer( string offerId )
		{
			await _reqOfferRepo.AcceptOffer( offerId );

			var offer = await _reqOfferRepo.GetOfferById( offerId );
			await _requestRepo.UpdateStatus( offer.RequestID.ToString(), (int)OfferStatus.InProgress );

			var notification = new NotificationDTO()
			{
				IsRead = false,
				CreatedAt = DateTime.Now,
				Message = $"لقد تم قبول عرضك على طلب '<b>{offer.Request.Title}</b>' من <b>{offer.Request.User.FName} {offer.Request.User.LName}</b>",
				Type = NotificationType.Offer,
				UserId = offer.ProviderID
			};
			var notif = await _notificationRepo.Create( notification );

			_unitOfWork.CommitChanges();

			await _hub.Clients.Group( offer.ProviderID ).SendAsync( "OfferAccepted", notif );
			
			return Ok();
		}

		[HttpGet( "RejectOffer" )]
		public async Task<IActionResult> RejectOffer( string offerId )
		{
			await _reqOfferRepo.RejectOffer( offerId );

			var offer = await _reqOfferRepo.GetOfferById( offerId );

			var notification = new NotificationDTO()
			{
				IsRead = false,
				CreatedAt = DateTime.Now,
				Message = $"لقد تم رفض عرضك على '<b>{offer.Request.Title}</b>' من '<b>{offer.Request.User.FName} {offer.Request.User.LName}</b>'",
				Type = NotificationType.Offer,
				UserId = offer.ProviderID
			};
			var notif = await _notificationRepo.Create( notification );

			_unitOfWork.CommitChanges();

			await _hub.Clients.Group( offer.ProviderID ).SendAsync( "OfferRejected", notif );

			return Ok();
		}
		
		[HttpGet( "CompleteOffer" )]
		public async Task<IActionResult> CompleteOffer( string offerId )
		{
			await _reqOfferRepo.CompleteOffer( offerId );

			var offer = await _reqOfferRepo.GetOfferById( offerId );
			var request = await _reqOfferRepo.GetRequest( offer.RequestID.ToString() );
			await _requestRepo.UpdateStatus( request.ID.ToString(), (int)OfferStatus.Finished );

			var notification = new NotificationDTO()
			{
				IsRead = false,
				CreatedAt = DateTime.Now,
				//Message = $"لقد تم اكمال طلبك '<b>{offer.Request.Title}</b>', يمكنك الان تقييم '<b>{offer.pro} {offer.Request.User.LName}</b>'",
				Message = $"لقد تم اكمال طلبك '<b>{offer.Request.Title}</b>'",
				Type = NotificationType.Offer,
				UserId = request.UserID
			};
			var notif = await _notificationRepo.Create( notification );

			_unitOfWork.CommitChanges();

			await _hub.Clients.Group( request.UserID ).SendAsync( "OfferCompleted", notif );

			return Ok();
		}
	
		[HttpGet( "ArchiveOffer" )]
		public async Task<IActionResult> ArchiveOffer( string offerId )
		{
			await _reqOfferRepo.ArchiveOffer( offerId );
			_unitOfWork.CommitChanges();
			return Ok();
		}
	
	
	}
}
