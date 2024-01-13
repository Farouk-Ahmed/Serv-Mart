using ApplicationLayer.IRepos;
using Domain_Layer.DTOs.AddressDTOs;
using Domain_Layer.DTOs.RequestDTOS;
using Domain_Layer.Models;
using Infrastructure_Layer.IRepos;
using Microsoft.AspNetCore.Mvc;

namespace Sermart_Api.Controllers
{
	[Route( "api/[controller]" )]
	[ApiController]
	public class AddressController : ControllerBase
	{
		private readonly IAddressRepo _adressRepo;
		private readonly IUnitOfWork _unitOfWork;
		public AddressController( IAddressRepo adressRepo, IUnitOfWork unitOfWork )
		{
			_adressRepo = adressRepo;
			_unitOfWork = unitOfWork;
		}

		#region City

		// api/Address/CreateCity
		[HttpPost( "CreateCity" )]
		public IActionResult AddCity( [FromForm] CityDTO cityDTO )
		{
			var city = new City()
			{
				NameAr = cityDTO.NameAr,
				NameEn = cityDTO.NameEn,
				GovernorateId = cityDTO.GovernorateId,
			};
			var res = _adressRepo.AddCity( city );
			_unitOfWork.CommitChanges();
			return Ok();
		}

		// api/Address/GetCityById
		[HttpGet( "GetCityById" )]
		public async Task<IActionResult> GetCity( int id )
		{
			var res = await _adressRepo.GetCityById( id );
			return Ok( res );
		}

		#endregion

		#region Governorate

		// api/Address/CreateGovernorate
		[HttpPost( "CreateGovernorate" )]
		public IActionResult AddGovernorate( [FromForm] GovernorateDTO governorateDTO )
		{
			var governorate = new Governorate()
			{
				NameAr = governorateDTO.NameAr,
				NameEn = governorateDTO.NameEn
			};
			var res = _adressRepo.AddGovernorate( governorate );
			_unitOfWork.CommitChanges();
			return Ok();
		}

		// api/Address/GetGovernorateById
		[HttpGet( "GetGovernorateById" )]
		public async Task<IActionResult> GetGovernorate( int id )
		{
			var res = await _adressRepo.GetGovernorateById( id );
			return Ok( res );
		}

		// api/Address/GetAllGovernorates
		[HttpGet( "GetAllGovernorates" )]
		public async Task<IActionResult> GetAllGovernorates()
		{
			var res = await _adressRepo.GetAllGovernorates();
			return Ok( res );
		}

		#endregion
	}
}
