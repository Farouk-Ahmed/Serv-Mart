using Microsoft.AspNetCore.Http;

namespace Domain_Layer.DTOs.ServiceDTOs
{
	public class UpdateServiceDTO
	{
		public string Id { get; set; }
		public string Title { get; set; }
		public string CategoryID { get; set; }
		public string Description { get; set; }
		public ICollection<IFormFile> ServicePic { get; set; }
	}
}
