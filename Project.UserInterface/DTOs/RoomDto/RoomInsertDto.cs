using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.UserInterface.DTOs.RoomDto
{
    public class RoomInsertDto
    {
        [Required(ErrorMessage = "Lütfen oda numarası giriniz.")]
        [MaxLength(10, ErrorMessage = "Oda numarası en fazla 10 karakter olmalıdır.")]
        public string? RoomNumber { get; set; }

        [Required(ErrorMessage = "Lütfen oda resmini giriniz.")]
        [MaxLength(100, ErrorMessage = "Resim yolu en fazla 100 karakter olmalıdır.")]
        public string? RoomCoverImage { get; set; }

        [Required(ErrorMessage = "Lütfen fiyatı giriniz.")]
        [Precision(18, 2)]
        public decimal Price { get; set; }

        [Required(ErrorMessage = "Lütfen başlığı giriniz.")]
        [MaxLength(100, ErrorMessage = "Başlık en fazla 100 karakter olmalıdır.")]
        public string? Title { get; set; }

        [Required(ErrorMessage = "Lütfen yatak sayısını giriniz.")]
        public Int16 BedCount { get; set; }

        [Required(ErrorMessage = "Lütfen banyo sayısını giriniz.")]
        public Int16 BathCount { get; set; }

        public bool Wifi { get; set; }

        [Required(ErrorMessage = "Lütfen açıklamayı giriniz.")]
        [MaxLength(500, ErrorMessage = "Açıklama en fazla 500 karakter olmalıdır.")]
        public string? Description { get; set; }
    }
}
