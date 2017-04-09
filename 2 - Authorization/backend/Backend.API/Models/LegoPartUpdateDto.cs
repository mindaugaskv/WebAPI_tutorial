using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Backend.API.Models
{
    public class LegoPartUpdateDto
    {
        [Required(ErrorMessage = "ID privalomas")]
        public int Id { get; set; }

        [Required(ErrorMessage ="Pavadinimas privalomas")]
        public string Name { get; set; }
        public string Description { get; set; }
        public string Color { get; set; }
        public string Size { get; set; }
        public string Type { get; set; }
        public string Shape { get; set; }

        [Required(ErrorMessage = "Paveikslėlis privalomas")]
        public string ImageUrl { get; set; }
    }
}