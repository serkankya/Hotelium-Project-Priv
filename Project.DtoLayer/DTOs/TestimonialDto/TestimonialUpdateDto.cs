using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.DtoLayer.DTOs.TestimonialDto
{
    public class TestimonialUpdateDto
    {
        public int TestimonialId { get; set; }

        [Required(ErrorMessage = "Lütfen adınızı giriniz.")]
        [MaxLength(100, ErrorMessage = "Ad en fazla 100 karakter olmalıdır.")]
        public string? FullName { get; set; }

        [Required(ErrorMessage = "Lütfen unvanı giriniz.")]
        [MaxLength(100, ErrorMessage = "Unvan en fazla 100 karakter olmalıdır.")]
        public string? Title { get; set; }

        [Required(ErrorMessage = "Lütfen açıklamayı giriniz.")]
        [MaxLength(500, ErrorMessage = "Açıklama en fazla 500 karakter olmalıdır.")]
        public string? Description { get; set; }

        [MaxLength(250, ErrorMessage = "Resim yolu en fazla 250 karakter olmalıdır.")]
        public string? Image { get; set; }
    }
}
