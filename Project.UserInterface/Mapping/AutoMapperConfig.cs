using AutoMapper;
using Project.UserInterface.DTOs.ServiceDto;
using Project.EntityLayer.Concrete;
using Project.UserInterface.DTOs.RegisterDto;
using Project.UserInterface.DTOs.LoginDto;
using Project.UserInterface.DTOs.AboutDto;
using Project.UserInterface.DTOs.RoomDto;
using Project.UserInterface.DTOs.StaffDto;
using Project.UserInterface.DTOs.SubscriberDto;
using Project.UserInterface.DTOs.TestimonialDto;
using Project.UserInterface.DTOs.BookingDto;

namespace Project.UserInterface.Mapping
{
	public class AutoMapperConfig : Profile
	{
		public AutoMapperConfig()
		{
			//ServiceController
			CreateMap<ServiceResultDto, Service>().ReverseMap();
			CreateMap<ServiceInsertDto, Service>().ReverseMap();
			CreateMap<ServiceUpdateDto, Service>().ReverseMap();

			//RegisterController
			CreateMap<InsertUserDto, AppUser>().ReverseMap();

			//LoginController
			CreateMap<LoginUserDto, AppUser>().ReverseMap();

			//AboutController
			CreateMap<AboutResultDto, About>().ReverseMap();
			CreateMap<AboutInsertDto, About>().ReverseMap();
			CreateMap<AboutUpdateDto, About>().ReverseMap();

			//RoomController
			CreateMap<RoomResultDto, Room>().ReverseMap();
			CreateMap<RoomInsertDto, Room>().ReverseMap();
			CreateMap<RoomUpdateDto, Room>().ReverseMap();

			//StaffController
			CreateMap<StaffResultDto, Staff>().ReverseMap();
			CreateMap<StaffInsertDto, Staff>().ReverseMap();
			CreateMap<StaffUpdateDto, Staff>().ReverseMap();

			//SubscriberController
			CreateMap<SubscriberResultDto, Subscriber>().ReverseMap();
			CreateMap<SubscriberInsertDto, Subscriber>().ReverseMap();
			CreateMap<SubscriberUpdateDto, Subscriber>().ReverseMap();

			//TestimonialController
			CreateMap<TestimonialResultDto, Testimonial>().ReverseMap();
			CreateMap<TestimonialInsertDto, Testimonial>().ReverseMap();
			CreateMap<TestimonialUpdateDto, Testimonial>().ReverseMap();

			//BookingController
			CreateMap<BookingResultDto, Booking>().ReverseMap();
			CreateMap<BookingInsertDto, Booking>().ReverseMap();
			CreateMap<BookingUpdateDto, Booking>().ReverseMap();
		}
	}
}
