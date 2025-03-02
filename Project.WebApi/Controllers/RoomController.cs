using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Project.BusinessLayer.Abstract;
using Project.EntityLayer.Concrete;

namespace Project.WebApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class RoomController : ControllerBase
	{
		private readonly IRoomService _roomService;

		public RoomController(IRoomService roomService)
		{
			_roomService = roomService;
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
		public IActionResult InsertRoom(Room room)
		{
			_roomService.TInsert(room);
			return Ok();
		}

		[HttpPut]
		public IActionResult UpdateRoom(Room room)
		{
			_roomService.TUpdate(room);
			return Ok();
		}

		[HttpDelete]
		public IActionResult DeleteRoom(Room room)
		{
			_roomService.TDelete(room);
			return Ok();
		}
	}
}
