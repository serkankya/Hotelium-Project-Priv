using AutoMapper;
using Project.DtoLayer.DTOs.AboutDto;
using Project.DtoLayer.DTOs.RoomDto;
using Project.DtoLayer.DTOs.ServiceDto;
using Project.EntityLayer.Concrete;

namespace Project.WebApi.Mapping
{
    public class AutoMapperConfig : Profile
    {
        public AutoMapperConfig()
        {
            //ServiceController
            CreateMap<ServiceInsertDto, Service>().ReverseMap();
            CreateMap<ServiceUpdateDto, Service>().ReverseMap();

            //AboutController
            CreateMap<AboutInsertDto, About>().ReverseMap();
            CreateMap<AboutUpdateDto, About>().ReverseMap();

            //RoomController
            CreateMap<RoomInsertDto, Room>().ReverseMap();
            CreateMap<RoomUpdateDto, Room>().ReverseMap();
        }
    }
}
