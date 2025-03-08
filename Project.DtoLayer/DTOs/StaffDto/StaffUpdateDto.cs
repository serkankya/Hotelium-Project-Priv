using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.DtoLayer.DTOs.StaffDto
{
    public class StaffUpdateDto
    {
        public int StaffId { get; set; }

        [Required(ErrorMessage = "Lütfen personelin adını giriniz.")]
        [MaxLength(100, ErrorMessage = "Ad en fazla 100 karakter olmalıdır.")]
        public string? FullName { get; set; }

        [Required(ErrorMessage = "Lütfen unvanı giriniz.")]
        [MaxLength(100, ErrorMessage = "Unvan en fazla 100 karakter olmalıdır.")]
        public string? Title { get; set; }

        [MaxLength(200, ErrorMessage = "Sosyal medya bağlantısı en fazla 200 karakter olmalıdır.")]
        public string? SocialMediaFirst { get; set; }

        [MaxLength(200, ErrorMessage = "Sosyal medya bağlantısı en fazla 200 karakter olmalıdır.")]
        public string? SocialMediaSecond { get; set; }

        [MaxLength(200, ErrorMessage = "Sosyal medya bağlantısı en fazla 200 karakter olmalıdır.")]
        public string? SocialMediaThird { get; set; }
    }
}
