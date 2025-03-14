using System.ComponentModel.DataAnnotations;

namespace Project.UserInterface.DTOs.LoginDto
{
    public class LoginUserDto
    {
        [Required(ErrorMessage = "Kullanıcı adınızı girmek zorundasınız.")]
        public string? Username { get; set; }

        [Required(ErrorMessage = "Şifrenizi girmek zorundasınız.")]
        public string? Password { get; set; }
    }
}
