using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.UserInterface.DTOs.AboutDto
{
    public class AboutInsertDto
    {

        [Required(ErrorMessage = "Başlık 1 zorunludur.")]
        [StringLength(100, ErrorMessage = "Başlık 1 en fazla 100 karakter olmalıdır.")]
        public string? Title1 { get; set; }

        [Required(ErrorMessage = "Başlık 2 zorunludur.")]
        [StringLength(100, ErrorMessage = "Başlık 2 en fazla 100 karakter olmalıdır.")]
        public string? Title2 { get; set; }

        [Required(ErrorMessage = "İçerik zorunludur.")]
        [StringLength(1000, ErrorMessage = "İçerik en fazla 1000 karakter olmalıdır.")]
        public string? Content { get; set; }

        [Range(0, int.MaxValue, ErrorMessage = "Oda sayısı negatif olamaz.")]
        public int RoomCount { get; set; }

        [Range(0, int.MaxValue, ErrorMessage = "Personel sayısı negatif olamaz.")]
        public int StaffCount { get; set; }

        [Range(0, int.MaxValue, ErrorMessage = "Müşteri sayısı negatif olamaz.")]
        public int CustomerCount { get; set; }
    }
}
