using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Project.BusinessLayer.Abstract;
using Project.DtoLayer.DTOs.BookingDto;
using Project.EntityLayer.Concrete;

namespace Project.WebApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class BookingController : ControllerBase
	{
		private readonly IBookingService _bookingService;
		private readonly IMapper _mapper;

		public BookingController(IBookingService bookingService, IMapper mapper)
		{
			_bookingService = bookingService;
			_mapper = mapper;
		}

		[HttpGet]
		public IActionResult GetAllBookings()
		{
			var values = _bookingService.TGetAll();
			return Ok(values);
		}

		[HttpGet("{id}")]
		public IActionResult GetBookingById(int id)
		{
			var values = _bookingService.TGetById(id);
			return Ok(values);
		}

		[HttpPost]
		public IActionResult InsertBooking(BookingInsertDto bookingInsertDto)
		{
			if (!ModelState.IsValid)
			{
				return BadRequest();
			}

			var values = _mapper.Map<Booking>(bookingInsertDto);
			_bookingService.TInsert(values);
			return Ok("Rezervasyon başarıyla eklendi.");
		}

		[HttpPut]
		public IActionResult UpdateBooking(BookingUpdateDto bookingUpdateDto)
		{
			if (!ModelState.IsValid)
			{
				return BadRequest();
			}

			var values = _mapper.Map<Booking>(bookingUpdateDto);
			_bookingService.TUpdate(values);
			return Ok("Rezervasyon başarıyla güncellendi.");
		}

		[HttpDelete("{id}")]
		public IActionResult DeleteBooking(int id)
		{
			var values = _bookingService.TGetById(id);
			if (values == null)
			{
				return BadRequest("Böyle bir kayıt mevcut değil");
			}
			_bookingService.TDelete(values);
			return Ok("Rezervasyon başarıyla silindi.");
		}
	}
}
