using Microsoft.AspNetCore.Http;

namespace Domain_Layer.DTOs.ServiceDTOs
{
	public class ServiceDTO
    {
        public string UserId { get; set; }
        public string Title { get; set; }
        public string CategoryID { get; set; }
        public string Description { get; set; }
        public decimal ExpectedSalary { get; set; }

		public ICollection<IFormFile> ServicePic { get; set; }
    }
}
