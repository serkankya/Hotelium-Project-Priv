using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Project.BusinessLayer.Abstract;
using Project.EntityLayer.Concrete;

namespace Project.WebApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class TestimonialController : ControllerBase
	{
		ITestimonialService _testimonialService;

		public TestimonialController(ITestimonialService testimonialService)
		{
			_testimonialService = testimonialService;
		}

		[HttpGet]
		public IActionResult GetAllTestimonials()
		{
			var values = _testimonialService.TGetAll();
			return Ok(values);
		}

		[HttpGet("{id}")]
		public IActionResult GetTestimonialById(int id)
		{
			var values = _testimonialService.TGetById(id);
			return Ok(values);
		}

		[HttpPost]
		public IActionResult InsertTestimonial(Testimonial testimonial)
		{
			_testimonialService.TInsert(testimonial);
			return Ok();
		}

		[HttpPut]
		public IActionResult UpdateTestimonial(Testimonial testimonial)
		{
			_testimonialService.TUpdate(testimonial);
			return Ok();
		}

		[HttpDelete]
		public IActionResult DeleteTestimonial(Testimonial testimonial)
		{
			_testimonialService.TDelete(testimonial);
			return Ok();
		}
	}
}
