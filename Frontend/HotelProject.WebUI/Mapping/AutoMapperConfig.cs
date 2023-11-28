using AutoMapper;
using HotelProject.EntityLayer.Concrete;
using HotelProject.WebUI.Dtos.LoginDto;
using HotelProject.WebUI.Dtos.RegisterDto;
using HotelProject.WebUI.Dtos.ServiceDto;

namespace HotelProject.WebUI.Mapping
{
    public class AutoMapperConfig:Profile
    {
        public AutoMapperConfig() {
            CreateMap<ResultServiceDto, Service>().ReverseMap(); // Service sınıfı ile ResultServiceDto'nun haberleşmesi
            CreateMap<UpdateServiceDto, Service>().ReverseMap(); // Service sınıfı ile ResultServiceDto'nun haberleşmesi
            CreateMap<CreateServiceDto, Service>().ReverseMap(); // Service sınıfı ile ResultServiceDto'nun haberleşmesi
            CreateMap<CreateNewUserDto,AppUser>().ReverseMap();
            CreateMap<LoginUserDto,AppUser>().ReverseMap();
        }
    }
}
