using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Project.BusinessLayer.Abstract;
using Project.EntityLayer.Concrete;

namespace Project.WebApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class SubscriberController : ControllerBase
	{
		ISubscriberService _subscriberService;

		public SubscriberController(ISubscriberService subscriberService)
		{
			_subscriberService = subscriberService;
		}

		[HttpGet]
		public IActionResult GetAllSubscribers()
		{
			var values = _subscriberService.TGetAll();
			return Ok(values);
		}

		[HttpGet("{id}")]
		public IActionResult GetSubscriberById(int id)
		{
			var values = _subscriberService.TGetById(id);
			return Ok(values);
		}

		[HttpPost]
		public IActionResult InsertSubscriber(Subscriber subscriber)
		{
			_subscriberService.TInsert(subscriber);
			return Ok();
		}

		[HttpPut]
		public IActionResult UpdateSubscriber(Subscriber subscriber)
		{
			_subscriberService.TUpdate(subscriber);
			return Ok();
		}

		[HttpDelete]
		public IActionResult DeleteSubscriber(Subscriber subscriber)
		{
			_subscriberService.TDelete(subscriber);
			return Ok();
		}
	}
}
