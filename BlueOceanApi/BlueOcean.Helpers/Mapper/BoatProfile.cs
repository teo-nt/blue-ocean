using AutoMapper;
using BlueOcean.Data.Models;
using BlueOcean.DTOs;

public class BoatProfile : Profile
{
    public BoatProfile()
    {
        CreateMap<Boat, BoatDTO>()
            .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id.ToString()))
            .ForMember(dest => dest.BoatCategory, opt => opt.MapFrom(src => (int)src.BoatCategory))
            .ForMember(dest => dest.Port, opt => opt.MapFrom(src => src.Location.Port))
            .ForMember(dest => dest.Image, opt => opt.MapFrom(src => src.Image));

        CreateMap<User, OwnerDTO>()
            .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id.ToString()))
            .ForMember(dest => dest.FullName, opt => opt.MapFrom(src => $"{src.Firstname} {src.Lastname}"));
    }
}

