using Domain_Layer.Models;

namespace Domain_Layer.DTOs.AddressDTOs
{
	public static class GovernorateExtensions
	{
		public static GovernorateDTO2 ToDTO( this Governorate governorate )
		{
			return new GovernorateDTO2
			{
				Id = governorate.ID,
				NameAr = governorate.NameAr,
				NameEn = governorate.NameEn,
				City = governorate.Cities.Select(x=> new RequestDTOS.CityDTO2 { NameAr = x.NameAr, NameEn = x.NameEn, Id = x.ID, GovernorateId = governorate.ID} ).ToList(),
			};
		}
	}
}
