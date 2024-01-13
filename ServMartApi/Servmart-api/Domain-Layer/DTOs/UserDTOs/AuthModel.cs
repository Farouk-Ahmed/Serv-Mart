
namespace Domain_Layer.DTOs.UserDTOs
{
	public class AuthModel
	{
		public string Message { get; set; }
		public bool IsAuthenticated { get; set; }
		public string UserName { get; set; }
		public string Email { get; set; }
		public List<string> Role { get; set; }
		public string Token { get; set; }
		public DateTime ExpiresOn { get; set; }
		public string ProfilePic { get; set; }
		public string FName { get; set; }
		public string LName { get; set; }
		public string UserID { get; set; }
	}
}
