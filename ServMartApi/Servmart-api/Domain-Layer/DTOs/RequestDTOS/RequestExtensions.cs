using Domain_Layer.Models;

namespace Domain_Layer.DTOs.RequestDTOS
{
	public static class RequestExtensions
	{
		public static RequestShowDTO toShowRequestDTO( this Request request )
		{
			return new RequestShowDTO()
			{
				Id = request.ID.ToString(),
				ClientId = request.UserID,
				Title = request.Title,
				Details = request.Details,
				Category = request.Category,
				CityAr = request.City.NameAr,
				CityEn = request.City.NameEn,
				GovernorateAr = request.Governorate.NameAr,
				GovernorateEn = request.Governorate.NameEn,
				Address = request.Address,
				CreatedAt = request.CreatedAt,
				Duration = request.Duration,
				ExpectedSalary = request.ExpectedSalary,
				Images = request.RequestMedia?.Where( x => x.MediaUrl != null && !x.MediaUrl.Contains( ".mp4" ) ).Select( x => x.MediaUrl ).ToList(),
				Video = request.RequestMedia?.Where( x => x.MediaUrl != null && x.MediaUrl.Contains( ".mp4" ) ).Select( x => x.MediaUrl ).FirstOrDefault()
			};
		}
	}
}
