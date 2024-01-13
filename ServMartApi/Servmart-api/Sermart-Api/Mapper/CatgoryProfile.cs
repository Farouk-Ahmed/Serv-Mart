using AutoMapper;
using Domain_Layer.DTOs;
using Domain_Layer.Models;

namespace Sermart_Api.Mapper
{
    public class CatgoryProfile:Profile
    {
        public CatgoryProfile()
        {
            CreateMap<ProductCatgoryViewModel, ProductCategory>()
                 .ForMember(item => item.Catagory, opt => opt.MapFrom(item => item.Catagory))
                .ReverseMap();
        }
    }
}
