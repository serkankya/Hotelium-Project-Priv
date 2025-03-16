using AutoMapper;
using Project.UserInterface.DTOs.ServiceDto;
using Project.EntityLayer.Concrete;
using Project.UserInterface.DTOs.RegisterDto;
using Project.UserInterface.DTOs.LoginDto;
using Project.UserInterface.DTOs.AboutDto;

namespace Project.UserInterface.Mapping
{
    public class AutoMapperConfig : Profile
    {
        public AutoMapperConfig()
        {
            //ServiceController
            CreateMap<ServiceResultDto, Service>().ReverseMap();
            CreateMap<ServiceInsertDto, Service>().ReverseMap();
            CreateMap<ServiceUpdateDto, Service>().ReverseMap();

            //RegisterController
            CreateMap<InsertUserDto, AppUser>().ReverseMap();

            //LoginController
            CreateMap<LoginUserDto, AppUser>().ReverseMap();

            //AboutController
            CreateMap<AboutResultDto, About>().ReverseMap();
            CreateMap<AboutInsertDto, About>().ReverseMap();
            CreateMap<AboutUpdateDto, About>().ReverseMap();
        }
    }
}
