using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Project.BusinessLayer.Abstract;
using Project.EntityLayer.Concrete;

namespace Project.WebApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class StaffController : ControllerBase
	{
		IStaffService _staffService;

		public StaffController(IStaffService staffService)
		{
			_staffService = staffService;
		}

		[HttpGet]
		public IActionResult GetAllStaffs()
		{
			var values = _staffService.TGetAll();
			return Ok(values);
		}

		[HttpGet("{id}")]
		public IActionResult GetStaffById(int id)
		{
			var values = _staffService.TGetById(id);
			return Ok(values);
		}

		[HttpPost]
		public IActionResult InsertStaff(Staff staff)
		{
			_staffService.TInsert(staff);
			return Ok();
		}

		[HttpPut]
		public IActionResult UpdateStaff(Staff staff)
		{
			_staffService.TUpdate(staff);
			return Ok();
		}

		[HttpDelete("{id}")]
		public IActionResult DeleteStaff(int id)
		{
			var values = _staffService.TGetById(id);
			_staffService.TDelete(values);
			return Ok();
		}
	}
}
