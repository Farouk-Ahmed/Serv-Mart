using Domain_Layer.DTOs.RequestOfferDTOs;
using Domain_Layer.Models;

namespace ApplicationLayer.IRepos
{
	public interface IRequestOfferRepo : IBaseRepo<RequestOffer>
	{
		Task<IEnumerable<RequestOffer>> GetAll( string providerId, int page, int pageSize );
		Task<IEnumerable<ViewRequestOfferDTO>> GetProviderOffersByStatus( string providerId, int status, int page, int pageSize );
		Task<IEnumerable<ViewRequestOfferDTO>> GetUserRequestOffers( string requestId, int page, int pageSize );
		Task<int> GetProviderOffersByStatusCount( string providerId, int status );
		Task<int> GetUserRequestOffersCount( string requestId );
		Task<RequestOffer> AddAsync( AddRequestOfferDTO offer );
		Task<RequestOffer> GetOfferById( string offerId );
		Task<RequestOffer> Update( UpdateRequestOfferDTO updateRequestOfferDTO );
		Task<Request> GetRequest( string requestId );
		Task AcceptOffer( string offerId );
		Task RejectOffer( string offerId );
		Task CompleteOffer( string offerId );
		Task ArchiveOffer( string offerId );
	}
}
