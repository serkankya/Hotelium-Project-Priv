using AutoMapper;
using Project.DtoLayer.DTOs.RoomDto;
using Project.EntityLayer.Concrete;

namespace Project.WebApi.Mapping
{
    public class AutoMapperConfig : Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<RoomInsertDto, Room>();
            CreateMap<Room, RoomInsertDto>();

            CreateMap<RoomUpdateDto, Room>().ReverseMap();
        }
    }
}
