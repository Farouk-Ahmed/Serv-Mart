using ApplicationLayer.IRepos;
using Domain_Layer.DTOs.UserDTOs;
using Microsoft.AspNetCore.Mvc;

namespace Sermart_Api.Controllers
{
    [Route( "api/[controller]" )]
	[ApiController]
	public class AuthController : ControllerBase
	{
		private readonly IAuthRepo _authRepo;
        private readonly IUnitOfWork _unitOfWork;

        public AuthController(IAuthRepo authRepo, IUnitOfWork unitOfWork)
        {
            _authRepo = authRepo;
            _unitOfWork = unitOfWork;
        }

        [HttpPost( "register" )]
		public async Task<IActionResult> Register( [FromBody] RegisterModel model )
		{
			if ( !ModelState.IsValid )
			{
				return BadRequest( "Model state is not valid" );
			}
			var result = await _authRepo.RegisterAsync( model );
			
			if ( !result.IsAuthenticated )
				return BadRequest( "error while registering" + result.Message );
            _unitOfWork.CommitChanges();
            return Ok( new { result.Token, result.ExpiresOn, result.Role, result.UserName, result.ProfilePic, result.Email, result.FName, result.LName, result.UserID } );
		}

		[HttpPost( "login" )]
		public async Task<IActionResult> Login( [FromBody] UserLoginDTO model )
		{
			if ( !ModelState.IsValid )
			{
				return BadRequest( ModelState );
			}
			var result = await _authRepo.LoginAsync( model );
			if ( !result.IsAuthenticated )
				return BadRequest( result.Message );
			return Ok( new { result.Token, result.ExpiresOn, result.Role, result.UserName, result.ProfilePic, result.Email, result.FName, result.LName, result.UserID } );
		}
	}
}
