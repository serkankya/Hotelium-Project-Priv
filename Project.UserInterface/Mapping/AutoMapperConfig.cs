using AutoMapper;
using Project.UserInterface.DTOs.ServiceDto;
using Project.EntityLayer.Concrete;

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
        }
    }
}
