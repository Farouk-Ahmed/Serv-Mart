
namespace Domain_Layer.DTOs.ServiceDTOs
{
	public class ServiceUser
	{
		public string ID { get; set; }
		public string FName { get; set; }
		public string LName { get; set; }
		public string ProfilePic { get; set; }
		public string GovernorateAr { get; set; }
		public string GovernorateEn { get; set; }
		public string CityAr { get; set; }
		public string CityEn { get; set; }
		public float Rate { get; set; }
		public int ServiceCount { get; set; }
	}
}
