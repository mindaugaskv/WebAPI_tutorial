using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Backend.API.Models
{
    public class LegoToyDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public float Price { get; set; }
        public string ImageUrl { get; set; }
        public virtual List<LegoPartDto> Parts { get; set; }
    }
}