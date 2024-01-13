using ApplicationLayer.IRepos;
using Domain_Layer.DTOs.AddressDTOs;
using Domain_Layer.DTOs.RequestDTOS;
using Domain_Layer.DTOs.RequestServiceCategoryDTOs;
using Domain_Layer.Models;
using Infrastructure_Layer.IRepos;
using Microsoft.AspNetCore.Mvc;

namespace Sermart_Api.Controllers
{
	[Route( "api/[controller]" )]
	[ApiController]
	public class RequestServiceCategoryController : ControllerBase
	{
		private readonly IRequestServiceCategory _requestServiceCategory;
		private readonly IUnitOfWork _unitOfWork;
		public RequestServiceCategoryController( IRequestServiceCategory requestServiceCategory, IUnitOfWork unitOfWork )
		{
			_requestServiceCategory = requestServiceCategory;
			_unitOfWork = unitOfWork;
		}

		// api/RequestServiceCategory/AddCategory
		[HttpPost( "AddCategory" )]
		public IActionResult AddCategory( [FromForm] RSCategoryDTO rsCategoryDTO )
		{
			var category = new ServiceCategory()
			{
				NameAr = rsCategoryDTO.NameAr,
				NameEn = rsCategoryDTO.NameEn
			};
			var res = _requestServiceCategory.AddCategory( category );
			_unitOfWork.CommitChanges();
			return Ok();
		}

		// api/RequestServiceCategory/GetCategoryById
		[HttpGet( "GetCategoryById" )]
		public async Task<IActionResult> GetCategoryById( string id )
		{
			var res = await _requestServiceCategory.GetCategoryById( id );
			return Ok( res );
		}

		// api/RequestServiceCategory/GetAllCategories
		[HttpGet( "GetAllCategories" )]
		public async Task<IActionResult> GetAllCategories()
		{
			var res = await _requestServiceCategory.GetAllCategories();
			return Ok( res );
		}

	}
}
