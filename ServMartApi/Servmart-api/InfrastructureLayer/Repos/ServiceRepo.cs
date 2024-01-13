using Domain_Layer.DTOs.ServiceDTOs;
using Domain_Layer.Models;
using Infrastructure_Layer.IRepos;
using InfrastructureLayer;
using InfrastructureLayer.Interfaces;
using InfrastructureLayer.Repos;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.Data;
using System.Drawing.Printing;

namespace Application_Layer.Repos
{
	public class ServiceRepo : BaseRepos<Service>, IServiceRepo
	{
		private readonly AppDbContext _appDbContext;
		private readonly IPhotoService _photoService;
		private readonly UserManager<User> _userManager;

		public ServiceRepo( AppDbContext appContext, AppDbContext appDbContext, IPhotoService photoService, UserManager<User> userManager ) : base( appContext )
		{
			_appDbContext = appDbContext;
			_photoService = photoService;
			_userManager = userManager;
		}

		public async Task<Service> GetByID( string ID )
		{
			return await _appDbContext.Service.FirstOrDefaultAsync( x => x.ID.ToString() == ID );
		}

		public async Task<IEnumerable<ServiceShowTDO>> GetAll( int page, int pageSize )
		{
			var query = _appDbContext.Service.Select( x => x.ToServiceShowTDO() );
			if ( page > 0 && pageSize > 0 )
			{
				int recordsToSkip = ( page - 1 ) * pageSize;
				query = query.Skip( recordsToSkip ).Take( pageSize );
			}
			var result = await query.ToListAsync();
			return result;
		}

		public async Task<Service> Update( UpdateServiceDTO serviceDTO )
		{
			var service = await _appDbContext.Service.FirstOrDefaultAsync( x => x.ID.ToString() == serviceDTO.Id );
			if ( service != null )
			{
				service.Discription = serviceDTO.Description;
				service.Title = serviceDTO.Title;

				if ( serviceDTO.ServicePic != null )
				{
					service.ServiceMedia.Clear();
					foreach ( var image in serviceDTO.ServicePic )
					{
						var pic = await _photoService.AddPhotoAsync( image );
						service.ServiceMedia.Add( new ServiceMedia() { MediaUrl = pic.Url.ToString(), ServiceID = service.ID } );
					}
				}

				_appDbContext.Service.Update( service );
			}
			return service;
		}

		public async Task<Service> Delete( string ID )
		{
			var serivce = await _appDbContext.Service.FirstOrDefaultAsync( x => x.ID.ToString() == ID );
			if ( serivce != null )
				_appDbContext.Service.Remove( serivce );
			return serivce;
		}

		public async Task<Service> AddService( ServiceDTO serviceDTO )
		{
			var service = new Service()
			{
				Title = serviceDTO.Title,
				Discription = serviceDTO.Description,
				CategoryID = Guid.Parse( serviceDTO.CategoryID ),
				Rate = 0,
				ExpectedSalary = serviceDTO.ExpectedSalary,
				ProviderID = serviceDTO.UserId,
			};

			service.ServiceMedia = new List<ServiceMedia>();
			foreach ( var image in serviceDTO.ServicePic )
			{
				var pic = await _photoService.AddPhotoAsync( image );
				service.ServiceMedia.Add( new ServiceMedia() { MediaUrl = pic.Url.ToString(), ServiceID = service.ID } );
			}

			await _appDbContext.Service.AddAsync( service );
			return service;
		}

		public async Task<IEnumerable<Service>> GetUserServices( string userId )
		{
			return await _appDbContext.Service.Where( x => x.ProviderID == userId ).ToListAsync();
		}

		public async Task<int> GetTotalUserServicesItems( string userId )
		{
			return await _appDbContext.Service.Where( s => s.User.Id == userId ).CountAsync();
		}

		public async Task<IEnumerable<ServiceUser>> GetServicesProviders( int page, int pageSize )
		{
			var role = "ServiceProvider";
			int recordsToSkip = ( page - 1 ) * pageSize;
			var ServiceProvider = _userManager.Users.AsEnumerable()
				.Where( user => _userManager.IsInRoleAsync( user, role ).Result )
				.Select( user => new ServiceUser
				{
					ID = user.Id,
					FName = user.FName,
					LName = user.LName,
					ProfilePic = user.ProfilePic,
					GovernorateAr = user.Governorate != null ? user.Governorate.NameAr : null,
					GovernorateEn = user.Governorate != null ? user.Governorate.NameEn : null,
					CityAr = user.City != null ? user.City.NameAr : null,
					CityEn = user.City != null ? user.City.NameEn : null,
					Rate = user.Services.DefaultIfEmpty().Average( service => service?.Rate ?? 0 ),
					ServiceCount = user.Services.Count(),
				} )
				.Skip( recordsToSkip )
				.Take( pageSize )
				.ToList();
			return ServiceProvider;
		}

		public async Task<int> GetTotalServicesProviders()
		{
			var role = "ServiceProvider";
			var count = await _userManager.GetUsersInRoleAsync( role );
			return count.Count();
		}

		public async Task<IEnumerable<ServiceRate>> GetUserServicesRates( string userId, int page, int pageSize )
		{
			var query = _appDbContext.ServiceRate
				.Include( sr => sr.User )
				.Where( sr => sr.User.Id == userId );
			if ( page > 0 && pageSize > 0 )
			{
				int recordsToSkip = ( page - 1 ) * pageSize;
				query = query.Skip( recordsToSkip ).Take( pageSize );
			}
			var result = await query.ToListAsync();
			return result;
		}

		public async Task<int> GetTotaUserRatesCount( string userId )
		{
			var result = await _appDbContext.ServiceRate
				.Include( s => s.User )
				.Where( s => s.User.Id == userId ).CountAsync();
			return result;
		}

	}
}
