using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.DtoLayer.DTOs.BookingDto
{
	public class BookingInsertDto
	{
		[Required(ErrorMessage = "Lütfen mail adresini giriniz.")]
		[EmailAddress(ErrorMessage = "Geçerli bir mail adresi giriniz.")]
		[MaxLength(100, ErrorMessage = "Mail adresi en fazla 100 karakter olmalıdır.")]
		public string? Mail { get; set; }

		[Required(ErrorMessage = "Lütfen tam adı giriniz.")]
		[MaxLength(100, ErrorMessage = "Tam ad en fazla 100 karakter olmalıdır.")]
		public string? FullName { get; set; }

		[Required(ErrorMessage = "Lütfen giriş tarihini giriniz.")]
		public DateTime CheckIn { get; set; }

		[Required(ErrorMessage = "Lütfen çıkış tarihini giriniz.")]
		public DateTime CheckOut { get; set; }

		[Required(ErrorMessage = "Lütfen yetişkin sayısını giriniz.")]
		[Range(1, 100, ErrorMessage = "Yetişkin sayısı 1 ile 100 arasında olmalıdır.")]
		public Int16 AdultCount { get; set; }

		[Required(ErrorMessage = "Lütfen çocuk sayısını giriniz.")]
		[Range(0, 100, ErrorMessage = "Çocuk sayısı 0 ile 100 arasında olmalıdır.")]
		public Int16 ChildCount { get; set; }

		[Required(ErrorMessage = "Lütfen oda sayısını giriniz.")]
		[Range(1, 100, ErrorMessage = "Oda sayısı 1 ile 100 arasında olmalıdır.")]
		public Int16 RoomCount { get; set; }

		[MaxLength(500, ErrorMessage = "Özel istek en fazla 500 karakter olmalıdır.")]
		public string? SpecialRequest { get; set; }

		public string? Description { get; set; }

		public string? Status { get; set; }
	}
}
