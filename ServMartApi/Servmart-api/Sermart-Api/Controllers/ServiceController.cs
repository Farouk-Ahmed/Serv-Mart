using ApplicationLayer.IRepos;
using Domain_Layer.DTOs.ServiceDTOs;
using Infrastructure_Layer.IRepos;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace Sermart_Api.Controllers
{
	[Route( "api/[controller]" )]
	[ApiController]
	public class ServiceController : ControllerBase
	{
		private readonly IUnitOfWork _unitofwork;
		private readonly IServiceRepo _serviceRepo;

		public ServiceController( IServiceRepo serviceRepo, IUnitOfWork unitofwork )
		{
			_serviceRepo = serviceRepo;
			_unitofwork = unitofwork;
		}

		[HttpGet( "GetAllServices" )]
		public async Task<IActionResult> GetAll( int page, int pageSize )
		{
			var result = await _serviceRepo.GetAll( page, pageSize );
			return Ok( result );
		}

		[HttpGet( "GetServiceByID" )]
		public async Task<IActionResult> GetByID( string ID )
		{
			var result = await _serviceRepo.GetByID( ID );
			if ( result == null )
			{
				return BadRequest( result );
			}
			return Ok( result );
		}

		[HttpPost( "AddService" )]
		[Authorize( Roles = "ServiceProvider" )]
		public async Task<IActionResult> AddService( [FromForm] ServiceDTO serviceDTO )
		{

			if ( !ModelState.IsValid )
			{
				return BadRequest( ModelState );
			}

			serviceDTO.UserId = User.FindFirstValue( ClaimTypes.NameIdentifier );
			var service = await _serviceRepo.AddService( serviceDTO );
			_unitofwork.CommitChanges();

			return Ok( service );
		}

		[HttpPut( "UpdateService" )]
		[Authorize( Roles = "ServiceProvider" )]
		public async Task<IActionResult> UpdateService( UpdateServiceDTO serviceDTO )
		{

			var result = await _serviceRepo.Update( serviceDTO );
			if ( result == null )
				return BadRequest( result );
			_unitofwork.CommitChanges();
			return Ok( result );
		}

		[HttpDelete( "Delete" )]
		[Authorize( Roles = "ServiceProvider" )]
		public async Task<IActionResult> Delete( string Id )
		{
			var result = await _serviceRepo.Delete( Id );
			if ( result == null )
				return BadRequest( result );
			_unitofwork.CommitChanges();
			return Ok( result );
		}

		[HttpGet( "GetUserService" )]
		public async Task<IActionResult> GetUserService()
		{
			var userId = User.FindFirstValue( ClaimTypes.NameIdentifier );
			var services = await _serviceRepo.GetUserServices( userId );
			return Ok( services );
		}

		[HttpGet( "GetUserServiceById" )]
		public async Task<IActionResult> GetUserServiceById( string userId )
		{
			var services = await _serviceRepo.GetUserServices( userId );
			return Ok( services );
		}

		[HttpGet( "GetUserServicesCount" )]
		public async Task<IActionResult> GetUserServicesCount( string Id )
		{
			var count = await _serviceRepo.GetTotalUserServicesItems( Id );
			return Ok( count );
		}

		[HttpGet( "GetServicesProviders" )]
		public async Task<IActionResult> GetServicesProviders( int page, int pageSize )
		{
			var result = await _serviceRepo.GetServicesProviders( page, pageSize );
			return Ok( result );
		}

		[HttpGet( "GetTotalServicesProviders" )]
		public async Task<IActionResult> GetTotalServicesProvidersCount()
		{
			var result = await _serviceRepo.GetTotalServicesProviders( );
			return Ok( result );
		}

		[ HttpGet( "GetUserRate" )]
		public async Task<IActionResult> GetUserRate( string userId, int page, int pageSize )
		{
			var result = await _serviceRepo.GetUserServicesRates( userId, page, pageSize );
			return Ok( result );
		}

		[HttpGet( "GetTotaUserRatesCount" )]
		public async Task<IActionResult> GetTotaUserRatesCount( string id )
		{
			var count = await _serviceRepo.GetTotaUserRatesCount( id );
			return Ok( count );
		}



	}
}
