using Domain_Layer.DTOs.AddressDTOs;
using Domain_Layer.DTOs.RequestDTOS;
using Domain_Layer.Models;
using Infrastructure_Layer.IRepos;
using InfrastructureLayer;
using Microsoft.EntityFrameworkCore;

namespace Application_Layer.Repos
{
	public class AddressRepo : IAddressRepo
	{
		private readonly AppDbContext _context;
		public AddressRepo( AppDbContext dbContext ) { _context = dbContext; }

		public async Task AddCity( City entity )
		{
			await _context.Cities.AddAsync( entity );
		}

		public async Task AddGovernorate( Governorate entity )
		{
			await _context.Governorates.AddAsync( entity );
		}

		public async Task<IEnumerable<GovernorateDTO2>> GetAllGovernorates()
		{
			return await _context.Governorates.Select( x => x.ToDTO() ).ToListAsync();
		}

		public async Task<CityDTO2> GetCityById( int id )
		{
			var city = await _context.Cities.FirstOrDefaultAsync( x => x.ID == id );
			return city.ToCityDTO2();
		}

		public async Task<Governorate> GetGovernorateById( int id )
		{
			return await _context.Governorates.FirstOrDefaultAsync( x => x.ID == id );
		}
	}
}
