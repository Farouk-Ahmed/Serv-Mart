using Domain_Layer.DTOs.RequestDTOS;
using Domain_Layer.Models;

namespace ApplicationLayer.IRepos
{
	public interface IRequestRepo
	{
		Task<Request> AddRequest( RequestDTO requestDTO );
		Task<Request> Update( RequestUpdateDTO requestDTO );
		Task<IEnumerable<RequestShowDTO>> GetAllRequests( int page, int pageSize );
		Request Delete( string id );
		Task<Request> GetById( string id );
		List<Request> FilterRequest( string id, decimal Price, decimal? minPrice, decimal? maxPrice );
		Task<int> GetTotalRequestItems();
		Task<IEnumerable<Request>> GetProviderRequestsOrders( string providerId, int page, int pageSize );
		Task<int> GetProviderOrdersCount( string providerId );
		Task<IEnumerable<RequestShowDTO>> GetUserRequests( string userId, int status, int page, int pageSize );
		Task<int> GetUserRequestCount( string userId, int status );
		Task UpdateStatus( string requestId, int status );
	}
}
