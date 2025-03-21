using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.UserInterface.DTOs.BookingDto
{
	public class BookingResultDto
	{
		public int BookingId { get; set; }
		public string? Mail { get; set; }
		public string? FullName { get; set; }
		public DateTime CheckIn { get; set; }
		public DateTime CheckOut { get; set; }
		public Int16 AdultCount { get; set; }
		public Int16 ChildCount { get; set; }
		public Int16 RoomCount { get; set; }
		public string? SpecialRequest { get; set; }
		public string? Description { get; set; }
		public string? Status { get; set; }
	}
}
