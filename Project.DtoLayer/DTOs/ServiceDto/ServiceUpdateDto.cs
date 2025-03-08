using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.DtoLayer.DTOs.ServiceDto
{
    public class ServiceUpdateDto
    {
        public int ServiceId { get; set; }

        [Required(ErrorMessage = "Lütfen servis ikonunu giriniz.")]
        [MaxLength(100, ErrorMessage = "Servis ikonu en fazla 100 karakter olmalıdır.")]
        public string? ServiceIcon { get; set; }

        [Required(ErrorMessage = "Lütfen başlığı giriniz.")]
        [MaxLength(250, ErrorMessage = "Başlık en fazla 250 karakter olmalıdır.")]
        public string? Title { get; set; }

        [Required(ErrorMessage = "Lütfen açıklamayı giriniz.")]
        [MaxLength(500, ErrorMessage = "Açıklama en fazla 500 karakter olmalıdır.")]
        public string? Description { get; set; }
    }
}
