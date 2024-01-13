using Domain_Layer.DTOs.RequestDTOS;
using Domain_Layer.Models;

namespace Domain_Layer.DTOs.RequestOfferDTOs
{
	public static class RequestOfferExtensions
	{
		public static RequestOffer ToModel( this AddRequestOfferDTO request )
		{
			return new RequestOffer
			{
				RequestID = Guid.Parse( request.RequestId ),
				ProviderID = request.ProviderId,
				Details = request.Details,
				CreatedAt = DateTime.Now,
				ExpectSalary = request.ExpectedSalary,
				Duration = request.Duration,
				Status = 0,
			};
		}

		public static ViewRequestOfferDTO ToViewModel( this RequestOffer offer )
		{
			return new ViewRequestOfferDTO
			{
				ID = offer.ID.ToString(),
				Request = offer.Request.toShowRequestDTO(),
				Details = offer.Details,
				ExpectSalary = offer.ExpectSalary,
				Duration = offer.Duration,
				Status = offer.Status,
				CreatedAt = offer.CreatedAt,
				User = new User() { Id = offer.User.Id, ProfilePic = offer.User.ProfilePic, FName = offer.User.FName, LName = offer.User.LName }
			};
		}
	}
}
