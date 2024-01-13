using ApplicationLayer.IRepos;
using Domain_Layer.DTOs.RequestDTOS;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace Sermart_Api.Controllers
{
	[Route( "api/[controller]" )]
	[ApiController]
	public class Requestcontroller : ControllerBase
	{
		private readonly IRequestRepo _request;
		private readonly IUnitOfWork _unitOfWork;

		public Requestcontroller( IRequestRepo request, IUnitOfWork unitOfWork )
		{
			_request = request;
			_unitOfWork = unitOfWork;
		}

		[HttpPost( "Create" )]
		[Authorize]
		public async Task<IActionResult> Create( [FromForm] RequestDTO requestDTO )
		{
			requestDTO.ClientId = User.FindFirstValue( ClaimTypes.NameIdentifier );
			var request = await _request.AddRequest( requestDTO );
			_unitOfWork.CommitChanges();
			return Ok( request );
		}

		[HttpPost( "Update" )]
		public IActionResult UpDate( string id, [FromForm] RequestUpdateDTO request )
		{
			request.ClientId = id;
			_request.Update( request );
			_unitOfWork.CommitChanges();
			return Ok();
		}

		[HttpPost( "Delete" )]
		public IActionResult Delete( string id )
		{
			_request.Delete( id );
			_unitOfWork.CommitChanges();
			return Ok();

		}

		[HttpGet( "GetAll" )]
		public async Task<IActionResult> Getall( int page, int pageSize )
		{
			var request = await _request.GetAllRequests( page, pageSize );
			return Ok( request );
		}

		[HttpGet( "GetRequestById" )]
		public async Task<IActionResult> GetRequestById( string requestId )
		{
			var request = await _request.GetById( requestId );
			return Ok( request );
		}

		[HttpGet( "FilterRequest" )]
		public IActionResult Filter( string userId, decimal price, decimal? minPrice, decimal? maxPrice )
		{
			var filteredRequests = _request.FilterRequest( userId, price, minPrice, maxPrice );
			return Ok( filteredRequests );
		}

		[HttpGet( "GetRequestCount" )]
		public async Task<IActionResult> GetRequestCount()
		{
			var count = await _request.GetTotalRequestItems();
			return Ok( count );
		}

		[HttpGet( "GetServiceProviderOrders" )]
		public async Task<IActionResult> GetServiceProviderOrders( string providerId, int page, int pageSize )
		{
			var request = await _request.GetProviderRequestsOrders( providerId, page, pageSize );
			return Ok( request );
		}

		//Get Provider Requests Orders Count
		[HttpGet( "GetProviderOrdersCount" )]
		public async Task<IActionResult> GetServiceProviderOrdersCount( string providerId )
		{
			var request = await _request.GetProviderOrdersCount( providerId );
			return Ok( request );
		}

		[HttpGet( "GetUserRequestsById" )]
		public async Task<IActionResult> GetUserRequests( string userId, int status, int page, int pageSize )
		{
			var request = await _request.GetUserRequests( userId, status, page, pageSize );
			return Ok( request );
		}

		[HttpGet( "GetUserRequestsCountById" )]
		public async Task<IActionResult> GetUserRequestsCount( string userId, int status )
		{
			var request = await _request.GetUserRequestCount( userId, status );
			return Ok( request );
		}
	}
}
