using Microsoft.AspNetCore.Http;

namespace Domain_Layer.DTOs.UserDTOs
{
    public class UserUpdateDTO
    {
        public string Username { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public string Gender { get; set; }  
        public string Email { get; set; }
        public string SSN { get; set; }
        public string PhoneNo { get; set; }
        public string Address { get; set; }
        public IFormFile ProfilePic { get; set; }
    }
}
