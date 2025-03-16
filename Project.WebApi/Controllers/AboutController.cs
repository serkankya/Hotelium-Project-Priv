using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Project.BusinessLayer.Abstract;
using Project.DtoLayer.DTOs.AboutDto;
using Project.EntityLayer.Concrete;

namespace Project.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AboutController : ControllerBase
    {
        private readonly IAboutService _aboutService;
        private readonly IMapper _mapper;

        public AboutController(IMapper mapper, IAboutService aboutService)
        {
            _mapper = mapper;
            _aboutService = aboutService;
        }

        [HttpGet]
        public IActionResult GetAllAbouts()
        {
            var values = _aboutService.TGetAll();
            return Ok(values);
        }

        [HttpGet("{id}")]
        public IActionResult GetAboutById(int id)
        {
            var values = _aboutService.TGetById(id);
            return Ok(values);
        }

        [HttpPost]
        public IActionResult InsertAbout(AboutInsertDto aboutInsertDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            var values = _mapper.Map<About>(aboutInsertDto);
            _aboutService.TInsert(values);
            return Ok("Başarıyla eklendi.");
        }

        [HttpPut]
        public IActionResult UpdateAbout(AboutUpdateDto aboutUpdateDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            var values = _mapper.Map<About>(aboutUpdateDto);
            _aboutService.TUpdate(values);
            return Ok("Başarıyla güncellendi.");
        }

        [HttpDelete]
        public IActionResult DeleteAbout(int id)
        {
            var values = _aboutService.TGetById(id);
            if (values == null)
            {
                return BadRequest("Böyle bir kayıt mevcut değil");
            }
            _aboutService.TDelete(values);
            return Ok("Başarıyla silindi.");
        }
    }
}
