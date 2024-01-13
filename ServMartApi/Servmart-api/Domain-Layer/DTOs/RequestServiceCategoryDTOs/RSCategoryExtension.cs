
using Domain_Layer.Models;

namespace Domain_Layer.DTOs.RequestServiceCategoryDTOs
{
	public static class RSCategoryExtension
	{
		public static RSCategoryWithIdDTO toDTO( this ServiceCategory serviceCategory )
		{
			return new RSCategoryWithIdDTO()
			{
				Id = serviceCategory.ID.ToString(),
				NameAr = serviceCategory.NameAr,
				NameEn = serviceCategory.NameEn,
			};
		}
	}
}
