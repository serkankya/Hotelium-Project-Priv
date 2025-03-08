using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.DtoLayer.DTOs.SubscriberDto
{
    public class SubscriberUpdateDto
    {
        public int SubscriberId { get; set; }

        [Required(ErrorMessage = "Lütfen e-posta adresini giriniz.")]
        [EmailAddress(ErrorMessage = "Geçerli bir e-posta adresi giriniz.")]
        [MaxLength(150, ErrorMessage = "E-posta adresi en fazla 150 karakter olmalıdır.")]
        public string? Mail { get; set; }
    }
}
