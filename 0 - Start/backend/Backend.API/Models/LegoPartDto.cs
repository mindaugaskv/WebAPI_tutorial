using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Backend.API.Models
{
    public class LegoPartDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Color { get; set; }
        public string Size { get; set; }
        public string Type { get; set; }
        public string Shape { get; set; }
        public string ImageUrl { get; set; }
    }
}