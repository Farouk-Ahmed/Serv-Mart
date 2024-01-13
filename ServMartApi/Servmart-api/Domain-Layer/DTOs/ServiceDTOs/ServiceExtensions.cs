
using Domain_Layer.Models;

namespace Domain_Layer.DTOs.ServiceDTOs
{
	public static class ServiceExtensions
	{
		public static ServiceShowTDO ToServiceShowTDO( this Service service )
		{
			return new ServiceShowTDO()
			{
				ID = service.ID.ToString(),
				Discription = service.Discription,
				ExpectedSalary = service.ExpectedSalary,
				Rate = service.Rate,
				ServiceCategory = service.ServiceCategory,
				ServiceMedia = service.ServiceMedia,
				Title = service.Title,
				User = new ServiceUser() { ID = service.User.Id, FName = service.User.FName, LName = service.User.LName, ProfilePic = service.User.ProfilePic }
			};
		}
	}
}
