using Domain_Layer.Models;

namespace Domain_Layer.DTOs.RequestServiceCategoryDTOs
{
	public class RSCategoryDTO
	{
		public string NameAr { get; set; }
		public string NameEn { get; set; }
	}

	public class RSCategoryWithIdDTO
	{
		public string Id { get; set; }
		public string NameAr { get; set; }
		public string NameEn { get; set; }
	}
}
