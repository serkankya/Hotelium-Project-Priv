using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Project.BusinessLayer.Abstract;
using Project.DtoLayer.DTOs.RoomDto;
using Project.EntityLayer.Concrete;

namespace Project.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoomController : ControllerBase
    {
        private readonly IRoomService _roomService;
        private readonly IMapper _mapper;

        public RoomController(IRoomService roomService, IMapper mapper)
        {
            _roomService = roomService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult GetAllRooms()
        {
            var values = _roomService.TGetAll();
            return Ok(values);
        }

        [HttpGet("{id}")]
        public IActionResult GetRoomById(int id)
        {
            var values = _roomService.TGetById(id);
            return Ok(values);
        }

        [HttpPost]
        public IActionResult InsertRoom(RoomInsertDto roomInsertDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            var values = _mapper.Map<Room>(roomInsertDto);
            _roomService.TInsert(values);
            return Ok("Başarıyla eklendi.");
        }

        [HttpPut]
        public IActionResult UpdateRoom(RoomUpdateDto roomUpdateDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            var values = _mapper.Map<Room>(roomUpdateDto);
            _roomService.TUpdate(values);
            return Ok("Başarıyla güncellendi.");
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteRoom(int id)
        {
            var values = _roomService.TGetById(id);
            if (values == null)
            {
                return BadRequest("Böyle bir kayıt mevcut değil");
            }
            _roomService.TDelete(values);
            return Ok("Başarıyla silindi.");
        }
    }
}
