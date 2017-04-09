using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Backend.API.Models
{
    public class LegoPartCreateDto
    {
        [Required(ErrorMessage = "Nenurodytas Lego dalies pavadinimas")]
        public string Name { get; set; }
        public string Description { get; set; }
        public string Color { get; set; }
        public string Size { get; set; }
        public string Type { get; set; }
        public string Shape { get; set; }

        [Required(ErrorMessage = "Nenurodytas Lego dalies paveikslėlio URL adresas")]
        public string ImageUrl { get; set; }
    }
}