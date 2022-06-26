﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Http;

namespace FrontToBack.Models 
{
    public class Slider
    {
        public int Id { get; set; }
        public string  ImageUrl { get; set; }
        
        [NotMapped ]
        [Required]
        public IFormFile Image { get; set; }
    }
}
