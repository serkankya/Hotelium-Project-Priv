using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.EntityLayer.Concrete
{
	public class Room
	{
		public int RoomId { get; set; }
		public string? RoomNumber { get; set; }
		public string? RoomCoverImage { get; set; }
		[Precision(18, 2)]
		public decimal Price { get; set; }
		public string? Title { get; set; }
		public Int16 BedCount { get; set; }
		public Int16 BathCount { get; set; }
		public bool Wifi { get; set; }
		public string? Description { get; set; }
	}
}
