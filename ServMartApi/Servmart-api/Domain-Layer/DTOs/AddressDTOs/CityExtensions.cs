
using Domain_Layer.DTOs.RequestDTOS;
using Domain_Layer.Models;

namespace Domain_Layer.DTOs.AddressDTOs
{
	public static class CityExtensions
	{
		public static CityDTO2 ToCityDTO2(this City city)
		{
			return new CityDTO2()
			{
				Id = city.ID,
				GovernorateId = city.GovernorateId,
				NameAr = city.NameAr,
				NameEn = city.NameEn,
			};
		}
	}
}
