using System.ComponentModel.DataAnnotations;

namespace Project.UserInterface.DTOs.RegisterDto
{
	public class InsertUserDto
	{
		[Required(ErrorMessage = "İsim alanı boş bırakılamaz!")]
		public string? Name { get; set; }

		[Required(ErrorMessage = "Soyisim alanı boş bırakılamaz!")]
		public string? Surname { get; set; }

		[Required(ErrorMessage = "Kullanıcı adı alanı boş bırakılamaz!")]
		public string? Username { get; set; }

		[Required(ErrorMessage = "Email alanı boş bırakılamaz!")]
		public string? Email { get; set; }

		[Required(ErrorMessage = "Şifre alanı boş bırakılamaz!")]
		public string? Password { get; set; }

		[Required(ErrorMessage = "Şifre onay alanı boş bırakılamaz!")]
		[Compare("Password", ErrorMessage = "Şifreler uyuşmuyor.")]
		public string? ConfirmPassword { get; set; }
	}
}
