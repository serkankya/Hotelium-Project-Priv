﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.UserInterface.DTOs.TestimonialDto
{
    public class TestimonialResultDto
    {
        public int TestimonialId { get; set; }
        public string? FullName { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public string? Image { get; set; }
    }
}
