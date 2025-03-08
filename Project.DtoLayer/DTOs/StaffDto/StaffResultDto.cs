using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.DtoLayer.DTOs.StaffDto
{
    public class StaffResultDto
    {
        public int StaffId { get; set; }
        public string? FullName { get; set; }
        public string? Title { get; set; }
        public string? SocialMediaFirst { get; set; }
        public string? SocialMediaSecond { get; set; }
        public string? SocialMediaThird { get; set; }
    }
}
