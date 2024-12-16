using AutoMapper;
using BlueOcean.Data.Models;
using BlueOcean.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlueOcean.Helpers.Mapper
{
    public class BoatProfile : Profile
    {
        public BoatProfile()
        {
            CreateMap<Boat, BoatDTO>()
                .ForMember(dest => dest.BoatCategoryName, opt => opt.MapFrom(src => src.BoatCategory))
                .ForMember(dest => dest.LocationName, opt => opt.MapFrom(src => src.Location.Port))
                .ForMember(dest => dest.OwnerName, opt => opt.MapFrom(src => src.Owner.Firstname + src.Owner.Lastname))
                .ForMember(dest => dest.ImageBase64, opt => opt.MapFrom(src => Convert.ToBase64String(src.Image)));
        }
    }
}
