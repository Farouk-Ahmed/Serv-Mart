using ApplicationLayer.IRepos;
using Domain_Layer.DTOs.UserDTOs;
using Domain_Layer.Models;
using InfrastructureLayer.Interfaces;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace InfrastructureLayer.Repos
{
	public class AuthRepo : BaseRepos<User>, IAuthRepo
	{
		private readonly AppDbContext _appContext;
		private readonly UserManager<User> _usermanager;
		private readonly RoleManager<IdentityRole> _rolemanager;
		private readonly IConfiguration _config;
		private readonly IPhotoService _photoservice;

		public AuthRepo( AppDbContext appContext, UserManager<User> userManager,
			RoleManager<IdentityRole> rolemanager, IConfiguration config,
			IPhotoService photoservice, IUnitOfWork unitofwork ) : base( appContext )
		{
			_appContext = appContext;
			_usermanager = userManager;
			_rolemanager = rolemanager;
			_config = config;
			_photoservice = photoservice;
		}

		public async Task<AuthModel> LoginAsync( UserLoginDTO loginDTO )
		{
			var authmodel = new AuthModel();

			var user = await _usermanager.FindByEmailAsync( loginDTO.Email );

			if ( user == null || !await _usermanager.CheckPasswordAsync( user, loginDTO.Password ) )
			{
				authmodel.Message = "Email or Password is incorrect";
				return authmodel;
			}

			var roles = await _usermanager.GetRolesAsync( user );
			var token = await CreateToken( user );
			authmodel.IsAuthenticated = true;
			authmodel.Token = new JwtSecurityTokenHandler().WriteToken( token );
			authmodel.UserName = user.UserName;
			authmodel.Email = user.Email;
			authmodel.ProfilePic = user.ProfilePic;
			authmodel.ExpiresOn = token.ValidTo;
			authmodel.Role = roles.ToList();
			authmodel.FName = user.FName;
			authmodel.LName = user.LName;
			authmodel.UserID = user.Id;
			return authmodel;
		}

		public async Task<AuthModel> RegisterAsync( RegisterModel userDTO )
		{
			if ( await _usermanager.FindByEmailAsync( userDTO.Email ) != null )
				return new AuthModel { Message = "This Email Is Already Registerd" };
			if ( await _usermanager.FindByNameAsync( userDTO.Username ) != null )
				return new AuthModel { Message = "This Username Is Already Registerd" };
			foreach ( var role in userDTO.Role )
			{
				if ( !await _rolemanager.RoleExistsAsync( role ) )
				{
					return new AuthModel { Message = "there is no role with this name" };
				}
			}
			var user = new User
			{
				UserName = userDTO.Username,
				Email = userDTO.Email,
				FName = userDTO.FName,
				LName = userDTO.LName,
				SSN = userDTO.SSN,
				Address = "Hello world",
				PhoneNumber = userDTO.phoneNumber,
				ProfilePic = "http://res.cloudinary.com/dc2rdhbgv/image/upload/v1698680178/hxzvksly2rbcwr80rgoi.png",
				Cart = new Cart()
			};
			var result = await _usermanager.CreateAsync( user, userDTO.Password );
			if ( !result.Succeeded )
			{
				var erorr = string.Empty;
				foreach ( var err in result.Errors )
				{
					erorr += $"{err.Description},";
				}
				return new AuthModel { Message = erorr };
			}
			foreach ( var role in userDTO.Role )
			{
				await _usermanager.AddToRoleAsync( user, role );
			}
			var tokens = await CreateToken( user );
			return new AuthModel
			{
				IsAuthenticated = true,
				Token = new JwtSecurityTokenHandler().WriteToken( tokens ),
				Role = userDTO.Role.ToList<string>(),
				UserName = user.UserName,
				ExpiresOn = tokens.ValidTo,
				ProfilePic = user.ProfilePic,
				FName = user.FName,
				LName = user.LName,
				Email = user.Email,
				UserID = user.Id
			};
		}

		private async Task<JwtSecurityToken> CreateToken( User user )
		{
			var userclaims = await _usermanager.GetClaimsAsync( user );
			var roles = await _usermanager.GetRolesAsync( user );
			var roleclaim = new List<Claim>();
			foreach ( var role in roles )
			{
				roleclaim.Add( new Claim("roles", role ) );
			}
			var claims = new[]
			{
				new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
				new Claim(ClaimTypes.NameIdentifier, user.Id)
			}
			.Union( userclaims )
			.Union( roleclaim );
			var symkey = new SymmetricSecurityKey( Encoding.UTF8.GetBytes( _config[ "JWT:Key" ] ) );
			var signingkey = new SigningCredentials( symkey, SecurityAlgorithms.HmacSha256 );
			var jwttoken = new JwtSecurityToken(
				issuer: _config[ "JWT:Issuer" ],
				audience: _config[ "JWT:Audience" ],
				claims: claims,
				expires: DateTime.Now.AddDays( double.Parse( _config[ "JWT:DurationInDays" ] ) ),
				signingCredentials: signingkey );
			return jwttoken;
		}

	}
}
