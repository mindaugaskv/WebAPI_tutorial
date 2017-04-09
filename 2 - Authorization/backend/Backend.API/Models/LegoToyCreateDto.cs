using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Backend.API.Models
{
    public class LegoToyCreateDto
    {
        [Required(ErrorMessage = "Nenurodytas pavadinimas")]
        public string Name { get; set; }
        public string Description { get; set; }
        public float Price { get; set; }
        public string ImageUrl { get; set; }
        public virtual List<LegoPartDto> Parts { get; set; }
    }
}