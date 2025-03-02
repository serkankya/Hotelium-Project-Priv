using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Project.BusinessLayer.Abstract;
using Project.EntityLayer.Concrete;

namespace Project.WebApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class ServiceController : ControllerBase
	{
		IServiceService _serviceService;

		public ServiceController(IServiceService serviceService)
		{
			_serviceService = serviceService;
		}

		[HttpGet]
		public IActionResult GetAllServices()
		{
			var values = _serviceService.TGetAll();
			return Ok(values);
		}

		[HttpGet("{id}")]
		public IActionResult GetServiceById(int id)
		{
			var values = _serviceService.TGetById(id);
			return Ok(values);
		}

		[HttpPost]
		public IActionResult InsertService(Service service)
		{
			_serviceService.TInsert(service);
			return Ok();
		}

		[HttpPut]
		public IActionResult UpdateService(Service service)
		{
			_serviceService.TUpdate(service);
			return Ok();
		}

		[HttpDelete]
		public IActionResult DeleteService(Service service)
		{
			_serviceService.TDelete(service);
			return Ok();
		}
	}
}
