
using Project.BusinessLayer.Abstract;
using Project.BusinessLayer.Concrete;
using Project.DataAccessLayer.Abstract;
using Project.DataAccessLayer.Concrete;
using Project.DataAccessLayer.EntityFramework;

namespace Project.WebApi
{
	public class Program
	{
		public static void Main(string[] args)
		{
			var builder = WebApplication.CreateBuilder(args);

			builder.Services.AddDbContext<Context>();

			builder.Services.AddScoped<IRoomDal, EfRoomDal>();
			builder.Services.AddScoped<IRoomService, RoomManager>();

			builder.Services.AddScoped<ITestimonialDal, EfTestimonialDal>();
			builder.Services.AddScoped<ITestimonialService, TestimonialManager>();

			builder.Services.AddScoped<ISubscriberDal, EfSubscriberDal>();
			builder.Services.AddScoped<ISubscriberService, SubscriberManager>();

			builder.Services.AddScoped<IServiceDal, EfServiceDal>();
			builder.Services.AddScoped<IServiceService, ServiceManager>();

			builder.Services.AddScoped<IStaffDal, EfStaffDal>();
			builder.Services.AddScoped<IStaffService, StaffManager>();

			builder.Services.AddAutoMapper(typeof(Program));

			builder.Services.AddCors(opt =>
			{
				opt.AddPolicy("HoteliumApiCors", opts =>
				{
					opts.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod();
				});
			});

			builder.Services.AddControllers();
			// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
			builder.Services.AddEndpointsApiExplorer();
			builder.Services.AddSwaggerGen();

			var app = builder.Build();

			// Configure the HTTP request pipeline.
			if (app.Environment.IsDevelopment())
			{
				app.UseSwagger();
				app.UseSwaggerUI();
			}

			app.UseCors("HoteliumApiCors");

			app.UseAuthorization();

			app.MapControllers();

			app.Run();
		}
	}
}
