using Microsoft.AspNetCore.Http;

namespace Domain_Layer.DTOs.RequestDTOS
{
    public class RequestMediaDTO
    {
        public Guid ID { get; set; }
        public IFormFile MeadiUrl { get; set; }
        public Guid RequestID { get; set; }  
    }
}
