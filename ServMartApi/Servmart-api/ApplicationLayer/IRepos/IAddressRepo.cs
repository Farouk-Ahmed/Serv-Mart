using Domain_Layer.DTOs.AddressDTOs;
using Domain_Layer.DTOs.RequestDTOS;
using Domain_Layer.Models;

namespace Infrastructure_Layer.IRepos
{
	public interface IAddressRepo
	{
		Task AddCity( City entity );
		Task AddGovernorate( Governorate entity );
		Task<CityDTO2> GetCityById( int id );
		Task<Governorate> GetGovernorateById( int id );
		Task<IEnumerable<GovernorateDTO2>> GetAllGovernorates();
	}
}
