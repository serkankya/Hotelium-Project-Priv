using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Project.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.DataAccessLayer.Concrete
{
	public class Context : IdentityDbContext<AppUser,AppRole,int>
	{
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer("SERVER=serkankaya; INITIAL CATALOG=HoteliumDbo; INTEGRATED SECURITY=true; TrustServerCertificate=True");
		}

		public DbSet<Room> Rooms { get; set; }
		public DbSet<Service> Services { get; set; }
		public DbSet<Testimonial> Testimonials { get; set; }
		public DbSet<Subscriber> Subscribers { get; set; }
		public DbSet<Staff> Staffs { get; set; }
		public DbSet<About> Abouts { get; set; }
	}
}
